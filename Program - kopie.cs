using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcLogger_v2
{
    class Program
    {

        public static List<string> GetTables()
        {
            string connectionString = "Server=10.10.0.21;Database=Arc_DB_Test;User Id=sa;Password=TechTDJG99!;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                List<string> TableNames = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    TableNames.Add(row[2].ToString());
                }
                return TableNames;
            }
        }

        static void Main(string[] args)
        {
            var list = new List<string>(GetTables());

            foreach(string dt in list)
            {
                Console.WriteLine(dt);
            }
            Console.ReadKey();
        }
    }
}
