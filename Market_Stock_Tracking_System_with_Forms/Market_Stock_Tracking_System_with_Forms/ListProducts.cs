using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Stock_Tracking_System_with_Forms
{
    public partial class ListProducts : Form
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;

            connetionString = "Data Source=SQLEXPRESS;Initial Catalog=STOCK_CARD;User ID=GozdeDogan;Password=26062016";
            sql = "Your SQL Statemnt Here";

            connection = new SqlConnection(connetionString);
            try
            {
                MessageBox.Show("0");
                // connection acilamiyor incele!
                connection.Open();
                MessageBox.Show("1");
                command = new SqlCommand(sql, connection);
                MessageBox.Show("2");
                command.ExecuteNonQuery();
                MessageBox.Show("3");
                command.Dispose();
                connection.Close();
                MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            
            
            /*string connectionString = "Data Source=.; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr[0].ToString());
                        }
                    }
                }
            }
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable databases = con.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                    String databaseName = database.Field<String>("database_name");
                    short dbID = database.Field<short>("dbid");
                    DateTime creationDate = database.Field<DateTime>("create_date");
                    Console.WriteLine("DatabaseName : " + databaseName + ", DatabaseID : " + dbID + ", CreationDate : " + creationDate);
                }
            }*/
        }

        private void ProductID_Click(object sender, EventArgs e)
        {

        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void ProductQuantity_Click(object sender, EventArgs e)
        {

        }

        private void ProductUnit_Click(object sender, EventArgs e)
        {

        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
