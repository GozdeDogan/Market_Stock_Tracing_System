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
        DataSet cardSet;

        SqlConnection conn;

        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;

        LoginPage login;

        public MainPage()
        {
            InitializeComponent();
            conn = DBUtils.DBConnection();

            InformationTextBox.Visible = false;
            InformationTextBox.Enabled = false;

            this.FormClosed += new FormClosedEventHandler(MainPage_Closed);
            this.FormClosing += new FormClosingEventHandler(MainPage_Closing);

            string sql = "SELECT * FROM StockManagementSystemDatabase.dbo.Product_Cards_Table";

            DBUtils.OpenConnection(conn);

            sCommand = new SqlCommand(sql, conn);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            cardSet = new DataSet();
            sAdapter.Fill(cardSet, "StockManagementSystemDatabase.dbo.Product_Cards_Table");
            cardTable = cardSet.Tables["StockManagementSystemDatabase.dbo.Product_Cards_Table"];

            DBUtils.CloseConnection(conn);

            DataGridView_Products.DataSource = cardSet.Tables["StockManagementSystemDatabase.dbo.Product_Cards_Table"];
            DataGridView_Products.ReadOnly = true;
            DataGridView_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public MainPage(LoginPage login)
        {
            InitializeComponent();
            
            InformationTextBox.Visible = false;
            InformationTextBox.Enabled = false;

            conn = DBUtils.DBConnection();

            this.login = login;

            this.FormClosed += new FormClosedEventHandler(MainPage_Closed);
            this.FormClosing += new FormClosingEventHandler(MainPage_Closing);

            string sql = "SELECT * FROM StockManagementSystemDatabase.dbo.Product_Cards_Table";

            DBUtils.OpenConnection(conn);

            sCommand = new SqlCommand(sql, conn);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            cardSet = new DataSet();
            sAdapter.Fill(cardSet, "StockManagementSystemDatabase.dbo.Product_Cards_Table");
            cardTable = cardSet.Tables["StockManagementSystemDatabase.dbo.Product_Cards_Table"];

            DBUtils.CloseConnection(conn);

            DataGridView_Products.DataSource = cardSet.Tables["StockManagementSystemDatabase.dbo.Product_Cards_Table"];
            DataGridView_Products.ReadOnly = true;
            DataGridView_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public SqlConnection getConnection()
        {
            return conn;
        }

        public LoginPage getlogin() { return login; }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
                MessageBox.Show("ID can't be blank!!!", "Blank ID");
            else if (NameTextBox.Text == "")
                MessageBox.Show("Name can't be blank!!!", "Blank Name");
            else if (UnitListComboBox.Text == "")
                MessageBox.Show("Unit can't be blank!!!", "Blank Quantity");
            else if (QuantityTextBox.Text == "")
                MessageBox.Show("Quantity can't be blank!!!", "Blank Quantity");
            else if (MoneyTextBox.Text == "")
                MessageBox.Show("Money can't be blank!!!", "Blank Quantity");
            else if (MoneyUnitComboBox.Text == "")
                MessageBox.Show("Money Unit can't be blank!!!", "Blank Quantity");
            else
            {
                int size = -1;
                int result = 2;
                try
                {
                    int parsedint = int.Parse(IDTextBox.Text);
                    Console.WriteLine(parsedint);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("id", typeof(int));
                    dt.Columns.Add("name", typeof(string));
                    dt.Columns.Add("unit", typeof(string));
                    dt.Columns.Add("quantity", typeof(int));
                    dt.Columns.Add("money", typeof(int));
                    dt.Columns.Add("moneyunit", typeof(string));
                    size = 0;

                    DBUtils.OpenConnection(conn);
                    string cmd = "Select * from StockManagementSystemDatabase.dbo.Product_Cards_Table where ProductID=" + IDTextBox.Text + ";";

                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    Product temp = new Product();
                    while (dataReader.Read())
                    {
                        temp.setID((int)dataReader.GetValue(0));
                        temp.setName(dataReader.GetValue(1).ToString());
                        temp.setUnit(dataReader.GetValue(2).ToString());
                        temp.setQuantity((int)dataReader.GetValue(3));
                        temp.setMoney((int)dataReader.GetValue(4));
                        temp.setMoneyunit(dataReader.GetValue(5).ToString());

                        if (temp.getID() == Int32.Parse(SearchElementTextBox.Text))
                        {
                            dt.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity());
                            Console.WriteLine(dt.Rows[size].Field<int>(0) + "\t" + dt.Rows[size].Field<string>(1) + "\t"
                                + dt.Rows[size].Field<string>(2) + "\t" + dt.Rows[size].Field<int>(3) + "\t" 
                                + dt.Rows[size].Field<int>(4) + "\t" + dt.Rows[size].Field<string>(5));
                            Console.WriteLine("size:" + size);
                            size++;
                        }
                        }
                        dataReader.Close();
                        DBUtils.CloseConnection(conn);

                    if (size==0)
                    {
                        string Query = "insert into StockManagementSystemDatabase.dbo.Product_Cards_Table(ProductID,ProductName,ProductUnit,ProductQuantity, ProductMoney, ProductMoneyUnit) " +
                            "values('" + this.IDTextBox.Text + "','" + this.NameTextBox.Text + "','" + this.UnitListComboBox.Text + "','" + this.QuantityTextBox.Text +
                            "','" + this.MoneyTextBox.Text + "','" + this.MoneyUnitComboBox.Text + "');";

                        SqlCommand MyCommand = new SqlCommand(Query, conn);
                        DBUtils.OpenConnection(conn);

                        MyCommand.ExecuteNonQuery();
                        MessageBox.Show("Save product", "SUCCESS INSERT");


                        cardTable.Rows.Add(this.IDTextBox.Text, this.NameTextBox.Text, this.UnitListComboBox.Text, this.QuantityTextBox.Text, this.MoneyTextBox.Text, this.MoneyUnitComboBox.Text);
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

                    DataGridView_Products.DataSource = cardTable;
                    DataGridView_Products.Refresh();

                    if (result != 2)
                    {

                        IDTextBox.Clear();
                        NameTextBox.Clear();
                        UnitListComboBox.Text = "";
                        QuantityTextBox.Clear();
                        MoneyTextBox.Clear();
                        MoneyUnitComboBox.Text = "";
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
            dt.Columns.Add("money", typeof(int));
            dt.Columns.Add("moneyunit", typeof(string));

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
                        cmd = "Select * from StockManagementSystemDatabase.dbo.Product_Cards_Table where ProductID=" + SearchElementTextBox.Text + ";";
                    }
                    else /*if (ByNameRadioButton.Checked == true)*/
                    {
                        cmd = "Select * from StockManagementSystemDatabase.dbo.Product_Cards_Table where ProductName='" + SearchElementTextBox.Text + "';";
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
                        temp.setMoney((int)dataReader.GetValue(4));
                        temp.setMoneyunit(dataReader.GetValue(5).ToString());

                        if (ByIDRadioButton.Checked == true && temp.getID() == Int32.Parse(SearchElementTextBox.Text))
                        {
                            dt.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity(), temp.getMoney(), temp.getMoneyunit());
                            Console.WriteLine(dt.Rows[size].Field<int>(0) + "\t" + dt.Rows[size].Field<string>(1) + "\t"
                                + dt.Rows[size].Field<string>(2) + "\t" + dt.Rows[size].Field<int>(3) + "\t"
                                + dt.Rows[size].Field<int>(4) + "\t" + dt.Rows[size].Field<string>(5));
                            size++;
                        }
                        else if (ByNameRadioButton.Checked == true && temp.getName() == SearchElementTextBox.Text.ToString())
                        {
                            dt.Rows.Add(temp.getID(), temp.getName(), temp.getUnit(), temp.getQuantity(), temp.getMoney(), temp.getMoneyunit());
                            Console.WriteLine(dt.Rows[size].Field<int>(0) + "\t" + dt.Rows[size].Field<string>(1) + "\t"
                                + dt.Rows[size].Field<string>(2) + "\t" + dt.Rows[size].Field<int>(3) + "\t"
                                + dt.Rows[size].Field<int>(4) + "\t" + dt.Rows[size].Field<string>(5));
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
                        MessageBox.Show("Product not found!", "Not Found");
                    else
                    {
                        string message = "";
                        int i = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            message = message + dt.Rows[i].Field<int>(0).ToString() + " - " + dt.Rows[i].Field<string>(1) + " " 
                                +  dt.Rows[i].Field<int>(3).ToString() + " " + dt.Rows[i].Field<string>(2) + " and unit price is " 
                                + dt.Rows[i].Field<int>(4).ToString() + dt.Rows[i].Field<string>(5) + "\n";
                            i++;
                        }
                        
                        MovePage movepage = new MovePage(conn, Convert.ToInt32(SearchElementTextBox.Text), message, this);

                        DataGridView_Products.DataSource = cardTable;
                        SearchElementTextBox.Clear();

                        movepage.Show();
                        this.Visible = false;
                    }
                }
                FillDataGridView();
            }
        }


        private void MainPage_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult answer;
            string caption = "TURN BACK?";
            
            answer = MessageBox.Show("Are you sure?", caption, buttons);

            if (answer == DialogResult.No)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Normal;
                Console.WriteLine("\nclosing\n");
            }
        }

        private void MainPage_Closed(object sender, FormClosedEventArgs e)
        {
            DBUtils.CloseConnection(login.getConnection());
            login.Visible = true;
            login.getPasswordTextBox().Clear();

            this.Dispose();
            this.Close();

            /*this.Dispose();
            this.Close();

            DBUtils.CloseConnection(login.getConnection());
            login.Dispose();
            login.Close();*/
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stockManagementSystemDatabaseDataSet.Product_Cards_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.product_Cards_TableTableAdapter.Fill(this.stockManagementSystemDatabaseDataSet.Product_Cards_Table);
            FillDataGridView();
            UnitListComboBox.SelectedIndex = 0;
            MoneyUnitComboBox.SelectedIndex = 0;

            UnitListComboBox.Text = "";
            MoneyUnitComboBox.Text = "";

            InformationTextBox.Visible = false;
            InformationTextBox.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataGridView_Products.SelectedCells.Count > 0)
                {
                    int selectedrowindex = DataGridView_Products.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = DataGridView_Products.Rows[selectedrowindex];

                    Product temp = new Product(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[1].Value.ToString(), 
                            selectedRow.Cells[2].Value.ToString(), Convert.ToInt32(selectedRow.Cells[3].Value), 
                            Convert.ToInt32(selectedRow.Cells[4].Value), selectedRow.Cells[5].Value.ToString());
                    Console.WriteLine("delete, temp->\n" + temp.ToString());
                    string sql = "DELETE FROM StockManagementSystemDatabase.dbo.Product_Cards_Table WHERE ProductID=@ProductID";
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
            da = new SqlDataAdapter("Select * From StockManagementSystemDatabase.dbo.Product_Cards_Table", conn);
            ds = new DataSet();
            DBUtils.OpenConnection(conn);
            da.Fill(ds, "StockManagementSystemDatabase.dbo.Product_Cards_Table");
            DataGridView_Products.DataSource = ds.Tables["StockManagementSystemDatabase.dbo.Product_Cards_Table"];
            DBUtils.CloseConnection(conn);
        }

        private void UpdateDataGridView_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void UpdateThisButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "update StockManagementSystemDatabase.dbo.Product_Cards_Table set ProductID='" + IDTextBox.Text
                    + "',ProductName='" + NameTextBox.Text + "',ProductUnit='" + UnitListComboBox.Text + "',ProductQuantity='" + QuantityTextBox.Text
                    + "',ProductMoney='" + this.MoneyTextBox.Text + "',ProductMoneyUnit='" + this.MoneyUnitComboBox.Text + "' WHERE ProductID=@ProductID;";

                SqlCommand MyCommand = new SqlCommand(Query, conn);

                MyCommand.Parameters.AddWithValue("@ProductID", IDTextBox.Text.ToString());

                DBUtils.OpenConnection(conn);
                MyCommand.ExecuteNonQuery();
                MessageBox.Show("Update product", "SUCCESS UPDATE");
      
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            finally
            {
                DBUtils.CloseConnection(conn);
                FillDataGridView();

                InformationTextBox.Visible = false;
                AddNewProduct.Visible = true;
                
                IDTextBox.Enabled = true;
                NameTextBox.Enabled = true;

                IDTextBox.Clear();
                NameTextBox.Clear();
                UnitListComboBox.Text = "";
                QuantityTextBox.Clear();
                MoneyTextBox.Clear();
                MoneyUnitComboBox.Text = "";
            }
        }

        private void UpdateSelectButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataGridView_Products.SelectedCells.Count >= 0)
                {
                    int selectedrowindex = DataGridView_Products.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = DataGridView_Products.Rows[selectedrowindex];

                    IDTextBox.Text = selectedRow.Cells[0].Value.ToString();
                    IDTextBox.Enabled = false;
                    NameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                    NameTextBox.Enabled = false;
                    UnitListComboBox.Text = selectedRow.Cells[2].Value.ToString();
                    QuantityTextBox.Text = selectedRow.Cells[3].Value.ToString();
                    MoneyTextBox.Text = selectedRow.Cells[4].Value.ToString();
                    MoneyUnitComboBox.Text = selectedRow.Cells[5].Value.ToString();
                }
                else
                    MessageBox.Show("Please, select the element to edit!", "SELECT EDIT ELEMENT");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            finally
            {
                AddNewProduct.Visible = false;

                InformationTextBox.Visible = true;
                InformationTextBox.Text = "Edit product!";

                FillDataGridView();
            }
        }

        private void TurnBackButton_Click(object sender, EventArgs e)
        {
            DBUtils.CloseConnection(login.getConnection());
            login.Visible = true;
            login.getPasswordTextBox().Clear();
            
            this.Dispose();
            this.Close();
        }
    }
}