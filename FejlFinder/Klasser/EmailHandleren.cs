namespace FejlFinder.Klasser
{
    using Grænseflader;
    using System;
    using System.Configuration;

    class EmailHandleren : IEmailHandleren
    {
        private readonly ILog logger;
        private readonly IEmailForfatter emailForfatter;

        public EmailHandleren(ILog logger, IEmailForfatter emailForfatter)
        {
            logger = logger;
            emailForfatter = emailForfatter;
        }


        public void SendeMislykketLog_TilEmail(string mislykketFilNavn, string mislykketFilPath)
        {
            var modtagere = ConfigurationManager.AppSettings["SendeTilListe"];
            var fråAdresse = "tsmith@mackays.co.uk";
            var lageme = LagemeSkaberen_ToString(); 

            logger.Debug("Programme mislykket. Sende email ....");

            emailForfatter.SendeEmail(modtagere, fråAdresse, mislykketFilNavn, lageme, mislykketFilPath);
        }

        private string LagemeSkaberen_ToString()
        {
            return string.Format("Hej,\n\nJeg har fundet en error!");
        }
    }
}
