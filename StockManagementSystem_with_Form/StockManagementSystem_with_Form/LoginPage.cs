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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4HHEDN5; Initial Catalog=StockManagementSystemDatabase; User Id=GozdeDogan; password=26062016;");

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(username_textbox.Text))
            {
                MessageBox.Show("Username can't be blank!!!", "Username Blank",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(password_textbox.Text))
            {
                MessageBox.Show("Password can't be blank!!!", "Password Blank",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                // Sql bağlantı cümlemiz.

                connection.Open(); // Bağlantıyı aç.
                               // Sorgumuz.
                string sql = "SELECT * FROM StockManagementSystemDatabase.dbo.User_Password_Table WHERE username=@username AND password=@password";
                SqlParameter prms1 = new SqlParameter("@username", username_textbox.Text);
                SqlParameter prms2 = new SqlParameter("@password", password_textbox.Text);
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add(prms1);
                cmd.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //    Giriş gerçekleşti yaptırmak istediğiniz kodu burdan gerçekleştirebilirsiniz.
                    //    Altta yeni form açma işlemi gerçekleştirilmiştir.
                    this.Hide();
                    Form mainpage = new MainPage();
                    mainpage.Show();
                }
                else
                {
                    MessageBox.Show("User not found in database");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                Application.Exit();
            }
        }

        private void exit_picturebox_likebutton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult answer;
            string caption = "EXIT?";

            // Displays the MessageBox.

            answer = MessageBox.Show("Are you sure?", caption, buttons);

            if (answer == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
