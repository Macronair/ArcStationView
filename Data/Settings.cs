using System.Configuration;

namespace Arc_Station_View.Data
{
    class Settings
    {

        public static string sqlServer;
        public static string sqlUser;
        public static string sqlPassword;
        public static string sqlDatabase;

        public static bool mainShowEntriesOnStartup;

        public static void LoadSettings()
        {
            sqlServer = ConfigurationManager.AppSettings["sql-server"];
            sqlUser = ConfigurationManager.AppSettings["sql-user"];
            sqlPassword = ConfigurationManager.AppSettings["sql-password"];
            sqlDatabase = ConfigurationManager.AppSettings["sql-database"];

            if (ConfigurationManager.AppSettings["showEntriesOnStart"] == "1")
            {
                mainShowEntriesOnStartup = true;
            }
            else
            {
                mainShowEntriesOnStartup = false;
            }
        }

        public static void SaveSettings()
        {

        }
    }
}
