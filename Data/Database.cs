using System.Data.SqlClient;

namespace Arc_Station_View.Data
{
    class Database
    {

        // Nodige SQL server info
        public static string hostname = Settings.sqlServer;
        public static string database = Settings.sqlDatabase;
        public static string username = Settings.sqlUser;
        public static string password = Settings.sqlPassword;
        //

        static string con = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3}", hostname, database, username, password);
        public static SqlConnection cn;

        // Het openen van de connectie
        public static void OpenConnection()
        {
            cn = new SqlConnection(con);
            cn.Open();
        }

        // En dan ook weer alles netjes afsluiten
        public static void CloseConnection()
        {
            cn = new SqlConnection(con);
            cn.Close();
        }
    }
}

