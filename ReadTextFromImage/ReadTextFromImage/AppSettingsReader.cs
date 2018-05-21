using System.Configuration;

namespace ReadTextFromImage
{
    public static class AppSettingsReader
    {
        public static string TessDataPath = ConfigurationManager.AppSettings["TessDataPath"].ToString();
        public static string ImagePath = ConfigurationManager.AppSettings["ImagePath"].ToString();
    }
}
