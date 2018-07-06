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
        private int DataTableSize;
        DataGridView dataGridView = new DataGridView();
        SqlConnection conn;

        public AnaSayfa()
        {
            InitializeComponent();

            Console.WriteLine("Getting Connection ...");
            conn = DBConnection();

            GetTable();
        }

        public void GetTable()
        {
            // Here we create a DataTable with four columns.
            table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("unit", typeof(string));
            table.Columns.Add("quantity", typeof(int));

            OpenConnection(conn);

            ///Console.Read();

            string cmd = "Select * from STOCK_CARDS_TABLE";
            SqlCommand command = new SqlCommand(cmd, conn);
            SqlDataReader dataReader = command.ExecuteReader();

            products = new List<Product>();
            Product temp = new Product();
            int size = 0;
            while (dataReader.Read())
            {
                temp.setID((int)dataReader.GetValue(0));
                temp.setName(dataReader.GetValue(1).ToString());
                temp.setUnit(dataReader.GetValue(2).ToString());
                temp.setQuantity((int)dataReader.GetValue(3));

                table.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity());
                size++;

            }

            DataTableSize = size;
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

        private bool IsElementArr(int id)
        {
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                if (table.Rows[i].Field<int>(0) == id)
                    return true;
                i++;
            }

            return false;
        }


        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
                MessageBox.Show("ID can't be blank!!!");
            else if (NameTextBox.Text == "")
                MessageBox.Show("Name can't be blank!!!");
            else if (QuantityTextBox.Text == "")
                MessageBox.Show("Quantity can't be blank!!!");
            else
            {
                try
                {
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into STOCK_CARDS_TABLE(STOCK_ID, STOCK_NAME, STOCK_UNIT, STOCK_QUANTITY) values('" + this.IDTextBox.Text + "','" + this.NameTextBox.Text + "','" + this.UnitTypesListBox.Text + "','" + this.QuantityTextBox.Text + "');";

                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand = new SqlCommand(Query, conn);
                    SqlDataReader MyReader;
                    OpenConnection(conn);
                    if (!IsElementArr(Int32.Parse(IDTextBox.Text)))
                    {
                        MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Save product");
                        while (MyReader.Read())
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Same ID");
                    }
                    CloseConnection(conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            // TODO: Bu kod satırı 'sTOCK_CARDDataSet.STOCK_CARDS_TABLE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sTOCK_CARDS_TABLETableAdapter.Fill(this.sTOCK_CARDDataSet.STOCK_CARDS_TABLE);

            //dataGridView.DataSource = table;

            /*this.AutoScroll = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Form f = new Form();
            f.AutoScroll = true;
            f.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            f.VerticalScroll = */
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from STOCK_CARDS_TABLE where STOCK_ID='15';";
                
                SqlCommand MyCommand2 = new SqlCommand(Query, conn);
                SqlDataReader MyReader2;
                OpenConnection(conn);
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Product deleted");
                while (MyReader2.Read())
                {
                }
                CloseConnection(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sTOCK_CARDS_TABLETableAdapter.FillBy(this.sTOCK_CARDDataSet.STOCK_CARDS_TABLE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("unit", typeof(string));
            dt.Columns.Add("quantity", typeof(int));
            int size = 0;
            try
            {
                OpenConnection(conn);

                string cmd = "Select * from STOCK_CARDS_TABLE where STOCK_ID=" + SearchProductIDBox.Text + ";";
                SqlCommand command = new SqlCommand(cmd, conn);
                SqlDataReader dataReader = command.ExecuteReader();

                Product temp = new Product();
                while (dataReader.Read())
                {
                    temp.setID((int)dataReader.GetValue(0));
                    temp.setName(dataReader.GetValue(1).ToString());
                    temp.setUnit(dataReader.GetValue(2).ToString());
                    temp.setQuantity((int)dataReader.GetValue(3));

                    if (temp.getID() == Int32.Parse(SearchProductIDBox.Text))
                    {
                        dt.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity());
                        Console.WriteLine(dt.Rows[size].Field<int>(0) + "\t" + dt.Rows[size].Field<string>(1) + "\t"
                            + dt.Rows[size].Field<string>(2) + "\t" + dt.Rows[size].Field<int>(3));
                        size++;
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            finally
            {
                CloseConnection(conn);
                if(size == 0)
                    MessageBox.Show("Product not found!");
                else
                {
                    string message = "Product:\n";
                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        
                        message = message + "id: " + dt.Rows[i].Field<int>(0).ToString() + "\nname: " + dt.Rows[i].Field<string>(1) + "\nunit: "
                            + dt.Rows[i].Field<string>(2) + "\nquantity: " + dt.Rows[i].Field<int>(3).ToString() + "\n";
                        i++;
                    }

                    MessageBox.Show(message);
                }
            }
            /* try
             {
                 string Query = "select from STOCK_CARDS_TABLE where STOCK_ID="+ SearchProductID.Text + ";";

                 SqlCommand MyCommand2 = new SqlCommand(Query, conn);
                 SqlDataReader MyReader2;
                 OpenConnection(conn);
                 MessageBox.Show("NOLUYO0");
                 MyReader2 = MyCommand2.ExecuteReader();

                 MessageBox.Show("NOLUYO1");
                 string message = "\0";
                 if (MyReader2.HasRows)
                 {
                     while (MyReader2.Read())
                     {
                         message = MyReader2.ToString();

                         MessageBox.Show("NOLUYO2");
                         if (message != "\0")
                             MessageBox.Show(message);
                         else
                             MessageBox.Show("Product not found!");
                     }
                 }
                 else
                     MessageBox.Show("Product not found!");
                 CloseConnection(conn);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("NOLUYO");
             }*/
        }
    }
}
