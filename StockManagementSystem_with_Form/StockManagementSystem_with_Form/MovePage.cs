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

        public MovePage(SqlConnection connection, int id, string product)
        {
            InitializeComponent();
            this.connection = connection;
            byID = id.ToString();
            this.product = product;

        }

        private void MovePage_Load(object sender, EventArgs e)
        {
            ProductTextBox.Text = product;
            ProductTextBox.Enabled = false;

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
                        Convert.ToDateTime(selectedRow.Cells[2].Value), Convert.ToInt32(selectedRow.Cells[3].Value));

                    string sql = "DELETE FROM StockManagementSystemDatabase.dbo.Move_Table WHERE MoveProductID=@MoveProductID";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MoveProductID", temp.getMoveProductID());
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataGridView_ByID.SelectedCells.Count > 0)
                {
                    int selectedrowindex = DataGridView_ByID.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = DataGridView_ByID.Rows[selectedrowindex];

                    MoveProduct temp = new MoveProduct(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[1].Value.ToString(),
                        Convert.ToDateTime(selectedRow.Cells[2].Value), Convert.ToInt32(selectedRow.Cells[3].Value));

                    string Query = "update StockManagementSystemDatabase.dbo.Product_Cards_Table set MoveType='" + selectedRow.Cells[1].Value.ToString() 
                        + "',MoveDate='" + selectedRow.Cells[2].Value.ToString() + "',MoveQuantity='" + selectedRow.Cells[3].Value
                        + "' WHERE MoveProductID=@MoveProductID;";

                    SqlCommand MyCommand = new SqlCommand(Query, connection);


                    MyCommand.Parameters.AddWithValue("@MoveProductID", selectedRow.Cells[0].Value.ToString());

                    DBUtils.OpenConnection(connection);
                    MyCommand.ExecuteNonQuery();
                    DBUtils.CloseConnection(connection);
                    MessageBox.Show("Product move updated!", "SUCCESS UPDATED");

                }
                else
                    MessageBox.Show("Please, select the element to update!", "SELECT UPDATE ELEMENT");
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
