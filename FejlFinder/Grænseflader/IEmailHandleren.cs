namespace FejlFinder.Grænseflader
{
    public interface IEmailHandleren
    {
        void SendeMislykketLog_TilEmail(string mislykketFilNavn, string mislykketFilPath);
    }
}
