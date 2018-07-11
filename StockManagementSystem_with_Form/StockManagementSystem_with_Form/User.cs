using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem_with_Form
{
    class User
    {
        private string username;
        private string password;

        public string getUsername()
        {
            return username;
        }

        public void setUsername(string username)
        {
            if (username != null)
                this.username = username;
            else
                this.username = "invalid";
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            if (password != null)
                this.password = password;
            else
                this.password = "invalid";
        }

        public string ToString()
        {
            return "User:\nusername: " + username + "\npassword: " + password;
        }
    }
}
