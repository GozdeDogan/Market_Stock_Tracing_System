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
        Form mainpage;
        LoginPage login;

        public LoginPage()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(LoginPage_Closed);
            this.FormClosing += new FormClosingEventHandler(LoginPage_Closing);
        }

        public LoginPage(LoginPage login)
        {
            
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(LoginPage_Closed);
            this.FormClosing += new FormClosingEventHandler(LoginPage_Closing);
            this.login = login;
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
                connection.Open(); 

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
                    this.Hide();
                    mainpage = new MainPage(this);
                    mainpage.Show();
                }
                else
                {
                    MessageBox.Show("User not found in database");
                    username_textbox.Clear();
                    password_textbox.Clear();
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
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult answer;
            string caption = "EXIT?";
            
            answer = MessageBox.Show("Are you sure?", caption, buttons);

            if (answer == DialogResult.Yes)
            {
                if (login != null)
                {
                    login.Dispose();
                    login.Close();


                    Console.WriteLine("\nclosed\n");

                    this.Dispose();
                    this.Close();

                    Application.Exit();
                }
                else
                {
                    Console.WriteLine("\nclosed\n");
                    Application.Exit();

                    this.Dispose();
                    this.Close();
                }

            }
        }

        private void LoginPage_Closing(object sender, FormClosingEventArgs e)
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

        private void LoginPage_Closed(object sender, FormClosedEventArgs e)
        {
            if (login != null)
            {
                login.Dispose();
                login.Close();


                Console.WriteLine("\nclosed\n");

                this.Dispose();
                this.Close();

                Application.Exit();
            }
            else
            {
                Console.WriteLine("\nclosed\n");
                Application.Exit();

                this.Dispose();
                this.Close();
            }

        }

       /* private void exit_picturebox_likebutton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult answer;
            string caption = "EXIT?";

            // Displays the MessageBox.

            answer = MessageBox.Show("Are you sure?", caption, buttons);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }*/
    }
}
