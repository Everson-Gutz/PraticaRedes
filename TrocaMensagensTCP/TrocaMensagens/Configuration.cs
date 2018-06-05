namespace TrocaMensagens
{
    public class Configuration
    {
        public const string SERVER = "larc.inf.furb.br";

        public static string UserId { get; set; }
        public static string Password { get; set; }

        public static string UserIdentification
        {
            get { return $"{UserId}:{Password}"; }
        }
    }
}
