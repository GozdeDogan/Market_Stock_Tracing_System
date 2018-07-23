using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem_with_Form
{
    class DBUtils
    {
        public static SqlConnection DBConnection()
        {
            string datasource = @"DESKTOP-JB2BDAR\SQLEXPRESS";

            string database = "StockManagementSystemDatabase";
            string username = "sa";
            string password = "1234";

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }

        public static void OpenConnection(SqlConnection conn)
        {
            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }
    }
}
