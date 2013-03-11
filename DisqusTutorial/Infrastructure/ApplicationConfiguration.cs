using System.Configuration;

namespace DisqusTutorial.Infrastructure
{
    public static class ApplicationConfiguration
    {
        public static string DisqusShortName
        {
            get { return ConfigurationManager.AppSettings["DisqusShortName"]; }
        }
    }
}