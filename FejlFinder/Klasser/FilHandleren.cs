namespace FejlFinder.Klasser
{
    using Grænseflader;

    class FilHandleren : IFilHandleren
    {
        ILog logger;
        IFilLæser filLæser;
        IFilPlacering filPlacering;

        public FilHandleren(ILog logger, IFilLæser filLæser, IFilPlacering filPlacering)
        {
            this.logger = logger;
            this.filLæser = filLæser;
            this.filPlacering = filPlacering;
        }

        public void LøbFilfinder(string filSti)
        {
            logger.Info("Løb Fil Finder.");

            

            logger.Info("Fil Finder Sluttede.");
        }
    }
}
