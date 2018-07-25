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
        string product;
        int SizeMoves = 0;
        MainPage mainpage;

        public MovePage(SqlConnection connection, int id, string product, MainPage mainpage)
        {
            InitializeComponent();

            this.FormClosed += new FormClosedEventHandler(MovePage_Closed);
            this.FormClosing += new FormClosingEventHandler(MovePage_Closing);

            this.connection = connection;
            byID = id.ToString();
            this.product = product;
            this.mainpage = mainpage;

            InsertPanel.Visible = false;
            GridPanel.Visible = true;
        }

        private void MovePage_Load(object sender, EventArgs e)
        {
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

        /*private void FillDataGridView()
        {
            SqlDataAdapter da;
            DataSet ds;
            da = new SqlDataAdapter("Select * From StockManagementSystemDatabase.dbo.Move_Table", connection);
            ds = new DataSet();
            DBUtils.OpenConnection(connection);
            da.Fill(ds, "StockManagementSystemDatabase.dbo.Move_Table");
            DataGridView_ByID.DataSource = ds.Tables["StockManagementSystemDatabase.dbo.Move_Table"];
            DBUtils.CloseConnection(connection);
        }*/

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

                if (DataGridView_ByID.SelectedCells.Count >= 0)
                {
                    int selectedrowindex = DataGridView_ByID.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = DataGridView_ByID.Rows[selectedrowindex];

                    MoveProduct temp = new MoveProduct(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[1].Value.ToString(), 
                        Convert.ToDateTime(selectedRow.Cells[2].Value), Convert.ToInt32(selectedRow.Cells[3].Value));

                    string sql = "DELETE FROM StockManagementSystemDatabase.dbo.Move_Table WHERE MoveDate=@MoveDate";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MoveDate", temp.getMoveDate());
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


        private void pictureBox1_Click(object sender, EventArgs e)
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

                turnbackButton.Visible = false;
                pictureBox1.Visible = false;
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
            try
            {
                string sql = "INSERT into StockManagementSystemDatabase.dbo.Move_Table(MoveProductID, MoveType, MoveDate, MoveQuantity)" 
                    + "values('" + MoveProductIDTextBox.Text + "','" + MoveTypeTextBox.Text + "','" + MoveDateTimePicker.Text + "','" + MoveQuantityTextBox.Text + "');";
                SqlCommand command = new SqlCommand(sql, connection);
                DBUtils.OpenConnection(connection);
                command.ExecuteNonQuery();
                DBUtils.CloseConnection(connection);
                MessageBox.Show("Product Move added!", "SUCCESS INSERTED");
                
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            finally
            {
                DBUtils.CloseConnection(connection);
                FillDataGridView();
                InsertPanel.Visible = false;
                GridPanel.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InsertPanel.Visible = false;
            GridPanel.Visible = true;
            turnbackButton.Visible = true;
            pictureBox1.Visible = true;
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
            DBUtils.CloseConnection(mainpage.getlogin().getConnection());
            mainpage.getlogin().Visible = true;
            mainpage.getlogin().getPasswordTextBox().Clear();

            this.Dispose();
            this.Close();

            DBUtils.CloseConnection(mainpage.getConnection());
            mainpage.Dispose();
            mainpage.Close();

            /*DBUtils.CloseConnection(mainpage.getlogin().getConnection());
            mainpage.getlogin().Dispose();
            mainpage.getlogin().Close();*/

        }

    }
}
