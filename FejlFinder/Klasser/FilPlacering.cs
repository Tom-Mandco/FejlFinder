namespace FejlFinder.Klasser
{
    using Grænseflader;
    using System.Configuration;
    using System.IO;

    class FilPlacering : IFilPlacering
    {
        public void getFiles()
        {
            string logBasePlacering = ConfigurationManager.AppSettings["FilSti"];

            Directory.GetFiles(logBasePlacering);
        }
    }
}
