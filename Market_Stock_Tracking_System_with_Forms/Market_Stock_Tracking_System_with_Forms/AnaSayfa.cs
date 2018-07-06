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
    public partial class AnaSayfa : Form
    {
        private StatusBar sb;
        private DataTable table;
        private List<Product> products;

        public AnaSayfa()
        {
            InitializeComponent();
            table = GetTable();
        }

        public DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("unit", typeof(string));
            table.Columns.Add("quantity", typeof(int));


            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DBConnection();
            OpenConnection(conn);

            ///Console.Read();

            string cmd = "Select * from STOCK_CARDS_TABLE";
            SqlCommand command = new SqlCommand(cmd, conn);
            SqlDataReader dataReader = command.ExecuteReader();

            products = new List<Product>();
            Product temp = new Product();
            while (dataReader.Read())
            {
                temp.setID((int)dataReader.GetValue(0));
                temp.setName(dataReader.GetValue(1).ToString());
                temp.setUnit(dataReader.GetValue(2).ToString());
                temp.setQuantity((int)dataReader.GetValue(3));

                table.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity());

            }

            /*int i = 0;
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(table.Rows[i].Field<int>(0) + "\t" + table.Rows[i].Field<string>(1) + "\t"
                    + table.Rows[i].Field<string>(2) + "\t" + table.Rows[i].Field<int>(3));
                i++;
            }*/

            dataReader.Close();
            command.Dispose();
            CloseConnection(conn);



            return table;
        }

        public static SqlConnection DBConnection()
        {
            string datasource = @"DESKTOP-4HHEDN5\SQLEXPRESS";

            string database = "STOCK_CARD";
            string username = "GozdeDogan";
            string password = "26062016";

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }

        private static void OpenConnection(SqlConnection conn)
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

        private static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }


        private void OnChanged(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            string name = listView.SelectedItems[0].SubItems[0].Text;
            string born = listView.SelectedItems[0].SubItems[1].Text;
            sb.Text = name + ", " + born;
        }

        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView listView = (ListView)sender;

            if (listView.Sorting == System.Windows.Forms.SortOrder.Ascending)
            {
                listView.Sorting = System.Windows.Forms.SortOrder.Descending;
            }
            else
            {
                listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
        }



        /// <summary>
        /// 
        /// Listeleme butonu, urunleri listeler
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form listProducts = new ListProducts();
            listProducts.ShowDialog();
            this.Hide();
        }


        /// <summary>
        /// 
        /// yeni ürün eklenir (Yeni ürün girisi)
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form addNewProduct = new AddNewProduct();
            addNewProduct.ShowDialog();
        }

        /// <summary>
        /// 
        /// urun cikarilir (urun cikisi)
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //Form deleteProduct = new DeleteProduct();
            //deleteProduct.ShowDialog();
        }

        /// <summary>
        /// 
        /// urun arar
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //Form searchProduct = new SearchProduct();
            //searchProduct.ShowDialog();
        }

        /// <summary>
        /// 
        /// sistemden cikilir
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exited!");
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
