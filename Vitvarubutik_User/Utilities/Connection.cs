using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvarubutik_User.Utilities
{
    public static class Connection
    {
        // Database connection properties
        private static string Host = "195.178.235.60";
        private static string Database = "ae6945";
        private static string Username = "ae6945";
        private static string Password = "TomatSallad";

        private static MySqlConnection conn;

        public static MySqlDataReader RunQuery(string query)
        {
            conn = null;
            MySqlDataReader reader = null;
            try
            {
                // Connection
                conn = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                conn.Open();

                // Query
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }

            Console.Read();

            return reader;
        }

        public static void CloseConnection()
        {
            if (conn != null)
                conn.Close();
        }
    }
}
