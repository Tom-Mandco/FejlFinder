namespace FejlFinder.Klasser
{
    using Grænseflader;
    using System;

    class App : IApp
    {
        private readonly ILog logger;
        private readonly IEmailHandleren emailHandleren;
        private readonly IFilHandleren filHandleren;

        public App(ILog logger, IEmailHandleren emailHandleren, IFilHandleren filHandleren)
        {
            this.logger = logger;
            this.emailHandleren = emailHandleren;
            this.filHandleren = filHandleren;
        }

        public void whatever()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }
    }
}
