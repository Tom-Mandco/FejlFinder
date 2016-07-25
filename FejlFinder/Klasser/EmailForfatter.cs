namespace FejlFinder.Klasser
{
    using Grænseflader;
    using System;
    using System.IO;
    using System.Net.Mail;

    class EmailForfatter : IEmailForfatter
    {
        private readonly int ClientPort;
        private readonly string ClientHost;
        private readonly ILog logger;

        public EmailForfatter(ILog log, int clientPort, string clientHost)
        {
            logger = log;
            ClientPort = clientPort;
            ClientHost = clientHost;
        }

        public void SendeEmail(string frå, string til, string emne, string legme, string vedhæftetSti = "")
        {
            var mail = new MailMessage(frå, til);
            var klient = new SmtpClient
            {
                Port = ClientPort,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = ClientHost
            };

            mail.Subject = emne;
            mail.Body = legme;

            if (vedhæftetSti != "")
            {
                TilføjeVedhæftetFil(mail, vedhæftetSti);
            }

            try
            {
                klient.Send(mail);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }

        }

        private void TilføjeVedhæftetFil(MailMessage mail, string vedhæftetSti)
        {            
            using (var inputFil = new FileStream(
                     vedhæftetSti,
                     FileMode.Open,
                     FileAccess.Read,
                     FileShare.ReadWrite))
            {
                var filNavn = Path.GetFileName(vedhæftetSti);

                if (File.Exists(filNavn))
                {
                    File.Delete(filNavn);
                }

                File.Copy(vedhæftetSti, filNavn);

                var vedhæftetFil = new Attachment(filNavn);
                                
                mail.Attachments.Add(vedhæftetFil);                
            }                                
        }
    }
}
