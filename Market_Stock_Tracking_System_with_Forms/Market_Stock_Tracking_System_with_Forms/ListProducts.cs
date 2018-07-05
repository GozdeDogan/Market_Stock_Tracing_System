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
        private StatusBar sb;
        private DataTable table;
        private List<Product> products;

        public ListProducts()
        {
            InitializeComponent();

            table = GetTable();

            Text = "ListView";
            //Size = new Size(350, 250);

            ColumnHeader id = new ColumnHeader();
            id.Text = "Product ID";
            id.Width = -1;
            ColumnHeader name = new ColumnHeader();
            name.Text = "Product Name";
            id.Width = -1;
            ColumnHeader unit = new ColumnHeader();
            unit.Text = "Product Unit";
            name.Width = -1;
            ColumnHeader quantity = new ColumnHeader();
            quantity.Text = "Product Quantity";

            SuspendLayout();

            ListView listView = new ListView();
            listView.Bounds = new Rectangle(new Point(80, 80), new Size(350, 250));
            listView.Parent = this;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            listView.Columns.AddRange(new ColumnHeader[] { id, name, unit, quantity });
            listView.ColumnClick += new ColumnClickEventHandler(ColumnClick);

            string[] strArr = new string[5];
            int i = 0;
            foreach (DataRow row in table.Rows) { 
                strArr[0] = table.Rows[i].Field<int>(0).ToString();
                strArr[1] = table.Rows[i].Field<string>(1);
                strArr[2] = table.Rows[i].Field<string>(2);
                strArr[3] = table.Rows[i].Field<int>(3).ToString();
                Console.WriteLine(">>>>>>>>>>>>>>>Product:" + strArr);
                ListViewItem item = new ListViewItem(strArr);
                Console.WriteLine(">>>>>>>>>>>>>>>ITEM:" + item.ToString());
                listView.Items.Add(item);
                i++;
            }
            int pageColumnSize = i;

            listView.Dock = DockStyle.Fill;
            listView.Click += new EventHandler(OnChanged);

            sb = new StatusBar();
            sb.Parent = this;
            listView.View = View.Details;

            ResumeLayout();

            CenterToScreen();

           /* Button btn = new Button();

            btn.Text = "Turn Back";

            btn.BackColor = SystemColors.ButtonFace;

            //btn.Click += new EventHandler(btn_Click);

            Point p = listView.Items[2].Position;

            p.X += pageColumnSize;
            p.Y += 30 * pageColumnSize;

            btn.Location = p;

            btn.Size = listView.Items[2].Bounds.Size;

            listView.Controls.Add(btn);*/

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

        private bool IsElementArr(List<Product> p, int id)
        {
            foreach(Product temp in p)
            {
                if (temp.getID() == id)
                    return true;
            }

            return false;
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {

        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
