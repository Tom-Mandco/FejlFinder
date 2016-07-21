namespace FejlFinder.Grænseflader
{
    public interface IEmailForfatter
    {
        void SendeEmail(string frå, string til, string emne, string legme, string vedhæftetSti = "");
    }
}
