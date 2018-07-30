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
    public partial class MovePage : Form
    {
        SqlConnection connection;
        string byID;
        string name;
        string unit;
        int quantity;
        int money;
        string moneyunit;
        string product;
        int SizeMoves = 0;
        MainPage mainpage;

        public MovePage(SqlConnection connection, int id, string product, MainPage mainpage, string name, string unit, int quantity, int money, string moneyunit)
        {
            InitializeComponent();

            this.FormClosed += new FormClosedEventHandler(MovePage_Closed);
            this.FormClosing += new FormClosingEventHandler(MovePage_Closing);

            this.connection = connection;
            byID = id.ToString();
            this.name = name;
            this.unit = unit;
            this.quantity = quantity;
            this.money = money;
            this.moneyunit = moneyunit;
            this.product = product;
            this.mainpage = mainpage;

            InsertPanel.Visible = false;
            GridPanel.Visible = true;
        }

        private void MovePage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stockManagementSystemDatabaseDataSet1.Move_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.move_TableTableAdapter.Fill(this.stockManagementSystemDatabaseDataSet1.Move_Table);
            // TODO: Bu kod satırı 'stockManagementSystemDatabaseDataSet.Move_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.move_TableTableAdapter.Fill(this.stockManagementSystemDatabaseDataSet.Move_Table);
            ProductTextBox.Text = product;
            ProductTextBox.Enabled = false;
            
            InsertPanel.Visible = false;
            GridPanel.Visible = true;

            string sql = "SELECT * FROM StockManagementSystemDatabase.dbo.Move_Table WHERE MoveProductID='" + byID +"';";

            DBUtils.OpenConnection(connection);

            SqlCommand sCommand = new SqlCommand(sql, connection);
            SqlDataAdapter sAdapter = new SqlDataAdapter(sCommand);
            SqlCommandBuilder sBuilder = new SqlCommandBuilder(sAdapter);
            DataSet cardSet = new DataSet();
            sAdapter.Fill(cardSet, "StockManagementSystemDatabase.dbo.Move_Table");
            DataTable cardTable = cardSet.Tables["StockManagementSystemDatabase.dbo.Move_Table"];

            DBUtils.CloseConnection(connection);

            DataGridView_ByID.DataSource = cardSet.Tables["StockManagementSystemDatabase.dbo.Move_Table"];
            DataGridView_ByID.ReadOnly = true;
            DataGridView_ByID.ReadOnly = true;
            DataGridView_ByID.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FillDataGridView()
        {
            string sqlstring = "Select * From StockManagementSystemDatabase.dbo.Move_Table WHERE MoveProductID='" + byID + "';";
            SqlDataAdapter da;
            DataSet ds;
            da = new SqlDataAdapter(sqlstring, connection);
            ds = new DataSet();
            DBUtils.OpenConnection(connection);
            da.Fill(ds, "StockManagementSystemDatabase.dbo.Move_Table");
            DataGridView_ByID.DataSource = ds.Tables["StockManagementSystemDatabase.dbo.Move_Table"];
            DBUtils.CloseConnection(connection);
            SizeMoves = DataGridView_ByID.RowCount;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView_ByID.SelectedCells.Count > 0)
                {
                    int selectedrowindex = DataGridView_ByID.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = DataGridView_ByID.Rows[selectedrowindex];

                    MoveProduct temp = new MoveProduct(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[1].Value.ToString(), 
                        Convert.ToDateTime(selectedRow.Cells[2].Value), Convert.ToInt32(selectedRow.Cells[3].Value), selectedRow.Cells[4].Value.ToString());

                    string sql = "DELETE FROM StockManagementSystemDatabase.dbo.Move_Table WHERE MoveProductID=@MoveProductID and MoveDate=@MoveDate and MoveQuantity=@MoveQuantity";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MoveProductID", temp.getMoveProductID());
                    command.Parameters.AddWithValue("@MoveDate", temp.getMoveDate());
                    command.Parameters.AddWithValue("@MoveQuantity", temp.getMoveQuantity());
                    DBUtils.OpenConnection(connection);
                    command.ExecuteNonQuery();
                    DBUtils.CloseConnection(connection);
                    MessageBox.Show("Product Move deleted!", "SUCCESS DELETED");

                }
                else
                    MessageBox.Show("Please, select the element to delete!", "SELECT DELETE ELEMENT");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            finally
            {
                DBUtils.CloseConnection(connection);
                FillDataGridView();
            }
        }


        private void turnbackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            mainpage.Visible = true;
        }

        private void ınsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GridPanel.Visible = false;
                InsertPanel.Visible = true;
                InformationTextBox.Text = "Insert element!";
                InformationTextBox.Enabled = false;
                MoveProductIDTextBox.Text = byID;
                MoveProductIDTextBox.Enabled = false;
                MoveDateTimePicker.Text = "";
                UnitComboBox.Text = this.unit;
                UnitComboBox.Enabled = false;

                turnbackButton.Visible = false;
                TurnBackPictureBox.Visible = false;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            finally
            {
                FillDataGridView();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int state = 2;
            try
            {
                if(MoveTypeComboBox.Text.ToString().CompareTo("out")==0 & Convert.ToInt32(MoveQuantityTextBox.Text) > this.quantity)
                {
                    MessageBox.Show("Product in stock is not enough!", "INVALID QUANTITY");
                    state = 1;
                }
                else
                {
                    string sql = "INSERT into StockManagementSystemDatabase.dbo.Move_Table(MoveProductID, MoveType, MoveDate, MoveQuantity, MoveQuantityUnit)"
                    + "values('" + MoveProductIDTextBox.Text + "','" + MoveTypeComboBox.Text + "','" + MoveDateTimePicker.Value.ToString("yyyy-MM-dd")
                    + "','" + MoveQuantityTextBox.Text + "','" + UnitComboBox.Text + "');";
                    SqlCommand command = new SqlCommand(sql, connection);
                    DBUtils.OpenConnection(connection);
                    command.ExecuteNonQuery();
                    DBUtils.CloseConnection(connection);

                    int newquantity = 0;
                    if (MoveTypeComboBox.Text.ToString().CompareTo("entry") == 0)
                    {
                        newquantity = this.quantity + Convert.ToInt32(MoveQuantityTextBox.Text);
                    }
                    else if (MoveTypeComboBox.Text.ToString().CompareTo("out") == 0)
                    {
                        newquantity = this.quantity - Convert.ToInt32(MoveQuantityTextBox.Text);
                    }

                    string Query = "update StockManagementSystemDatabase.dbo.Product_Cards_Table set ProductID='" + byID
                            + "',ProductName='" + this.name + "',ProductUnit='" + this.unit + "',ProductQuantity='" + newquantity
                            + "',ProductMoney='" + this.money + "',ProductMoneyUnit='" + this.moneyunit + "' WHERE ProductID=@ProductID;";

                    SqlCommand MyCommand = new SqlCommand(Query, connection);

                    MyCommand.Parameters.AddWithValue("@ProductID", byID);

                    DBUtils.OpenConnection(connection);
                    MyCommand.ExecuteNonQuery();
                    DBUtils.CloseConnection(connection);

                    mainpage.FillDataGridView();

                    MessageBox.Show("Product Move added!", "SUCCESS INSERTED");
                    state = 2;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            finally
            {
                DBUtils.CloseConnection(connection);
                FillDataGridView();

                if(state == 2) {
                    InsertPanel.Visible = false;
                    GridPanel.Visible = true;
                    TurnBackPictureBox.Visible = true;
                    turnbackButton.Visible = true;
                    MoveTypeComboBox.Text = "";
                    MoveQuantityTextBox.Clear();
                    UnitComboBox.Text = "";
                    MoveDateTimePicker.Text = "";
                }
                else if(state == 1){
                    InsertPanel.Visible = true;
                    GridPanel.Visible = false;
                    TurnBackPictureBox.Visible = false;
                    turnbackButton.Visible = false;
                    MoveQuantityTextBox.Clear();

                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InsertPanel.Visible = false;
            GridPanel.Visible = true;
            turnbackButton.Visible = true;
            TurnBackPictureBox.Visible = true;
        }

        private void MovePage_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult answer;
            string caption = "EXIT?";

            answer = MessageBox.Show("Are you sure?", caption, buttons);

            if (answer == DialogResult.No)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Normal;
                Console.WriteLine("\nclosing\n");
            }
        }

        private void MovePage_Closed(object sender, FormClosedEventArgs e)
        {
            DBUtils.CloseConnection(mainpage.getlogin().getConnection()); //giris sayfasina doner
            mainpage.getlogin().Visible = true;
            mainpage.getlogin().getPasswordTextBox().Clear();

            this.Dispose();
            this.Close();

            DBUtils.CloseConnection(mainpage.getConnection());
            mainpage.Dispose();
            mainpage.Close();

            /*DBUtils.CloseConnection(mainpage.getlogin().getConnection()); //toptan ciksin diye, ust 3 satiri sil bunu yorumdan cikar
            mainpage.getlogin().Dispose();
            mainpage.getlogin().Close();*/

        }

        private void TurnBackPictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            mainpage.Visible = true;
        }
    }
}
