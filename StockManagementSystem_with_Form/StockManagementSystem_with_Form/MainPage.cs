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

namespace StockManagementSystem_with_Form
{
    public partial class MainPage : Form
    {
        private DataTable cardTable;
        //DataGridView dataGridView = new DataGridView();
        SqlConnection conn;

        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet cardSet;

        public MainPage()
        {
            InitializeComponent();
            conn = DBUtils.DBConnection();

            //DatabaseTable.GetTable(conn, cardTable, cardTableSize);

            string sql = "SELECT * FROM Product_Card_Table";

            DBUtils.OpenConnection(conn);

            sCommand = new SqlCommand(sql, conn);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            cardSet = new DataSet();
            sAdapter.Fill(cardSet, "Product_Card_Table");
            cardTable = cardSet.Tables["Product_Card_Table"];

            DBUtils.CloseConnection(conn);

            DataGridView_ListElement.DataSource = cardSet.Tables["Product_Card_Table"];
            DataGridView_ListElement.ReadOnly = true;
            DataGridView_ListElement.ReadOnly = true;
            DataGridView_ListElement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // kullanmiyorum ?
        private bool IsElementArr(int id, DataTable table)
        {
            string SearchByColumn = "ProductID=" + id;
            DataRow[] hasRows = cardTable.Select(SearchByColumn);
            Console.WriteLine("hasRows select");
            if (hasRows.Length == 0)
            {
                Console.WriteLine("OKEY");
                return true;
            }
            else
            {
                Console.WriteLine("NOT OKEY");
                return false;
            }

        }


        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
                MessageBox.Show("ID can't be blank!!!", "Blank ID");
            else if (NameTextBox.Text == "")
                MessageBox.Show("Name can't be blank!!!", "Blank Name");
            else if (QuantityTextBox.Text == "")
                MessageBox.Show("Quantity can't be blank!!!", "Blank Quantity");
            else
            {
                int size = -1;
                int result = 2;
                try
                {
                    int parsedint = int.Parse(IDTextBox.Text);
                    Console.WriteLine(parsedint);
                    /*string SearchByColumn = "ProductID=" + parsedint;
                    DataRow[] hasRows = cardTable.Select(SearchByColumn);
                    if (hasRows.Length == 0)
                    {
                        Console.WriteLine("OKEY");
                    }
                    else
                    {
                        Console.WriteLine("NOT OKEY");
                    }*/

                     DataTable dt = new DataTable();
                     dt.Columns.Add("id", typeof(int));
                     dt.Columns.Add("name", typeof(string));
                     dt.Columns.Add("unit", typeof(string));
                     dt.Columns.Add("quantity", typeof(int));
                     size = 0;

                     DBUtils.OpenConnection(conn);
                     string cmd = "Select * from Product_Card_Table where ProductID=" + IDTextBox.Text + ";";

                     SqlCommand command = new SqlCommand(cmd, conn);
                     SqlDataReader dataReader = command.ExecuteReader();

                     Product temp = new Product();
                     while (dataReader.Read())
                     {
                         temp.setID((int)dataReader.GetValue(0));
                         temp.setName(dataReader.GetValue(1).ToString());
                         temp.setUnit(dataReader.GetValue(2).ToString());
                         temp.setQuantity((int)dataReader.GetValue(3));

                         if (temp.getID() == Int32.Parse(SearchElementTextBox.Text))
                         {
                             dt.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity());
                             Console.WriteLine(dt.Rows[size].Field<int>(0) + "\t" + dt.Rows[size].Field<string>(1) + "\t"
                                 + dt.Rows[size].Field<string>(2) + "\t" + dt.Rows[size].Field<int>(3));
                             Console.WriteLine("size:" + size);
                             size++;
                         }
                     }
                     dataReader.Close();
                     DBUtils.CloseConnection(conn);

                    if (size==0)
                    {
                        //This is my insert query in which i am taking input from the user through windows forms  
                        string Query = "insert into Product_Card_Table(ProductID,ProductName,ProductUnit,ProductQuantity) values('" + this.IDTextBox.Text + "','" + this.NameTextBox.Text + "','" + this.UnitListComboBox.Text + "','" + this.QuantityTextBox.Text + "');";
                        //This is command class which will handle the query and connection object.  
                        SqlCommand MyCommand = new SqlCommand(Query, conn);
                        DBUtils.OpenConnection(conn);

                        MyCommand.ExecuteNonQuery();
                        MessageBox.Show("Save product", "SUCCESS INSERT");
                        cardTable.Rows.Add(this.IDTextBox.Text, this.NameTextBox.Text, this.UnitListComboBox.Text, this.QuantityTextBox.Text);
                        result = 1;
                    }
                    else
                    {
                        result = 2;
                    }
                }
                catch
                {
                    if(result == 2)
                        MessageBox.Show("Same ID", "WARNING");
                }
                finally
                {
                    DBUtils.CloseConnection(conn);
                    FillDataGridView();
                    //datagridview e ekleme
                    DataGridView_ListElement.DataSource = cardTable;
                    DataGridView_ListElement.Refresh();

                    if (result != 2)
                    {
                        IDTextBox.Clear();
                        NameTextBox.Clear();
                        QuantityTextBox.Clear();
                    }
                }
            }
        }


        private void SearchProduct_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("unit", typeof(string));
            dt.Columns.Add("quantity", typeof(int));
            int size = 0;
            int noChecked = 1;
            try
            {
                DBUtils.OpenConnection(conn);
                string cmd;
                if (ByIDRadioButton.Checked == false && ByNameRadioButton.Checked == false)
                {
                    noChecked = 0;
                }
                else
                {
                    if (ByIDRadioButton.Checked == true)
                    {
                        cmd = "Select * from Product_Card_Table where ProductID=" + SearchElementTextBox.Text + ";";
                    }
                    else /*if (ByNameRadioButton.Checked == true)*/
                    {
                        cmd = "Select * from Product_Card_Table where ProductName=" + SearchElementTextBox.Text + ";";
                    }

                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    Product temp = new Product();
                    while (dataReader.Read())
                    {
                        temp.setID((int)dataReader.GetValue(0));
                        temp.setName(dataReader.GetValue(1).ToString());
                        temp.setUnit(dataReader.GetValue(2).ToString());
                        temp.setQuantity((int)dataReader.GetValue(3));

                        if (temp.getID() == Int32.Parse(SearchElementTextBox.Text))
                        {
                            dt.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity());
                            Console.WriteLine(dt.Rows[size].Field<int>(0) + "\t" + dt.Rows[size].Field<string>(1) + "\t"
                                + dt.Rows[size].Field<string>(2) + "\t" + dt.Rows[size].Field<int>(3));
                            size++;
                        }
                    }
                    dataReader.Close();
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            finally
            {
                DBUtils.CloseConnection(conn);
                if (noChecked == 0)
                {
                    MessageBox.Show("Choose Searching Method!", "Search Method");
                    SearchElementTextBox.Clear();
                }
                else
                {
                    if (size == 0)
                        MessageBox.Show("Product not found!", "Warning");
                    else
                    {
                        string message = "";
                        int i = 0;
                        foreach (DataRow row in dt.Rows)
                        {

                            message = message + dt.Rows[i].Field<int>(0).ToString() + "\t" + dt.Rows[i].Field<string>(1) + "\t"
                                + dt.Rows[i].Field<string>(2) + "\t" + dt.Rows[i].Field<int>(3).ToString() + "\n";
                            i++;
                        }

                        MessageBox.Show(message, "Found Products");
                        DataGridView_ListElement.DataSource = cardTable;
                        SearchElementTextBox.Clear();
                    }
                }
                FillDataGridView();
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult answer;
            string caption = "EXIT?";

            // Displays the MessageBox.

            answer = MessageBox.Show("Are you sure?", caption, buttons);

            if (answer == System.Windows.Forms.DialogResult.Yes)
            {
                Form LoginPageForm = new LoginPage();
                this.Close();
                LoginPageForm.Show();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            UnitListComboBox.SelectedIndex = 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataGridView_ListElement.SelectedCells.Count > 0)
                {
                    //MessageBox.Show(DataGridView_ListElement.Rows[DataGridView_ListElement.CurrentRow.Index].ToString());
                    int selectedrowindex = DataGridView_ListElement.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = DataGridView_ListElement.Rows[selectedrowindex];

                    Product temp = new Product(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[1].Value.ToString(), 
                            selectedRow.Cells[2].Value.ToString(), Convert.ToInt32(selectedRow.Cells[3].Value));
                        Console.WriteLine("delete, temp->\n" + temp.ToString());
                        string sql = "DELETE FROM Product_Card_Table WHERE ProductID=@ProductID";
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@ProductID", temp.getID());
                        DBUtils.OpenConnection(conn);
                        command.ExecuteNonQuery();
                        DBUtils.CloseConnection(conn);
                        MessageBox.Show("Product deleted!", "SUCCESS DELETED");

                }
                else
                    MessageBox.Show("Please, select the element to delete!", "SELECT DELETE ELEMENT");
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            finally
            {
                DBUtils.CloseConnection(conn);
                FillDataGridView();
            }
        }

        private void FillDataGridView()
        {
            SqlDataAdapter da;
            DataSet ds;
            da = new SqlDataAdapter("Select * From Product_Card_Table", conn);
            ds = new DataSet();
            DBUtils.OpenConnection(conn);
            da.Fill(ds, "Product_Card_Table");
            DataGridView_ListElement.DataSource = ds.Tables["Product_Card_Table"];
            DBUtils.CloseConnection(conn);
        }

        private void UpdateDataGridView_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult answer;
                string caption = "Same Product";

                // Displays the MessageBox.

                answer = MessageBox.Show("Same Product, Same ID, Do you want to update this product?", caption, buttons);

                if (answer == System.Windows.Forms.DialogResult.Yes)
                {
                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "update Product_Card_Table set ProductID='" + IDTextBox.Text
                       + "',ProductName='" + NameTextBox.Text + "',ProductUnit='" + UnitListComboBox.Text
                       + "',ProductQuantity='" + QuantityTextBox.Text + "' WHERE ProductID='" + IDTextBox.Text + "';";

                    //This is command class which will handle the query and connection object.  
                    SqlCommand MyCommand = new SqlCommand(Query, conn);
                    DBUtils.OpenConnection(conn);

                    MyCommand.ExecuteNonQuery();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Update product", "SUCCESS UPDATE");
                } 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            finally
            {
                DBUtils.CloseConnection(conn);
                FillDataGridView();
            }
        }
    }
}