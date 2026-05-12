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

namespace TheFinalProject.Resources
{
    public partial class userRegistry : Form
    {
        public userRegistry()
        {
            InitializeComponent();
        }




        private void Registerbtn_Click(object sender, EventArgs e)
        {
            String username = RegisterUsername.Text.Trim();
            String password = RegisterPassword.Text.Trim();
            String passwordrepeat = registerpassrepeat.Text.Trim();
            bool passnullchecker = string.IsNullOrWhiteSpace(password);
            bool usernullchecker = string.IsNullOrWhiteSpace(username);
            bool passrepeatnullchecker = string.IsNullOrWhiteSpace(passwordrepeat);



          
            if (usernullchecker)
            {
                userguide.Visible = true;
                userguide.ForeColor = Color.Red;
                userguide.Text = "Username cannot be empty!";
            }

            if (passnullchecker)
            {
                passguide.Visible = true;
                passguide.ForeColor = Color.Red;
                passguide.Text = "Password cannot be empty!";
            }
            if (passrepeatnullchecker)
            {
                passrepeatguide.Visible = true;
                passrepeatguide.ForeColor = Color.Red;
                passrepeatguide.Text = "Password confirmation cannot be empty!";
            }
            else if (passwordrepeat != password)
            {
                MessageBox.Show("Please match the password confirmation to the password");
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        String query = "INSERT INTO UsersNew (username, password,role) VALUES (@username, @password,@role)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            String role = "User";
                            cmd.Parameters.AddWithValue("@username", RegisterUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", RegisterPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@role",role );
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
        }

        private void RegisterUsername_Click(object sender, EventArgs e)
        {
            RegisterUsername.SelectAll();
        }

        private void RegisterPassword_Click(object sender, EventArgs e)
        {
            RegisterPassword.SelectAll();
        }

        private void registerpassrepeat_Click(object sender, EventArgs e)
        {
            registerpassrepeat.SelectAll();
        }

        private void RegisterUsername_TextChanged(object sender, EventArgs e)
        {
            RegisterUsername.ForeColor = Color.Black;
            if (!string.IsNullOrWhiteSpace(RegisterUsername.Text))
            {
                clearGuide();
            }
        }

        private void RegisterPassword_TextChanged(object sender, EventArgs e)
        {
            RegisterPassword.ForeColor = Color.Black;
            comparePass();
            if (!string.IsNullOrWhiteSpace(RegisterPassword.Text))
            {
                clearGuide();
            }
        }

        private void registerpassrepeat_TextChanged(object sender, EventArgs e)
        {
            registerpassrepeat.ForeColor = Color.Black;
            comparePass();
            if (!string.IsNullOrWhiteSpace(registerpassrepeat.Text))
            {
                clearGuide();
            }
        }
        void comparePass()
        {
            String password = RegisterPassword.Text;
            String passwordrepeat = registerpassrepeat.Text;
            if (passwordrepeat != password)
            {
                passrepeatguide.Visible = true;
                passrepeatguide.Text = "Passwords do not match!";
                passrepeatguide.ForeColor = Color.Red;
            }
            else
            {
                passrepeatguide.Visible = true;
                passrepeatguide.Text = "Passwords matches!";
                passrepeatguide.ForeColor = Color.Green;
            }
        }

        void clearGuide()
        {
            userguide.Visible = false;
            passguide.Visible = false;
            passrepeatguide.Visible = false;
        }




        /* 
         private void RegisterUsername_TextChanged(object sender, EventArgs e)
        {
            RegisterUsername.ForeColor = Color.Black;
                if(!string.IsNullOrWhiteSpace(RegisterUsername.Text))
                {
                    clearGuide();
            }
               
        }

        private void RegisterUsername_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterUsername.SelectAll();
        }

        private void RegisterPassword_TextChanged(object sender, EventArgs e)
        {
            RegisterPassword.ForeColor = Color.Black;
            comparePass();
            if (!string.IsNullOrWhiteSpace(RegisterPassword.Text))
            {
                clearGuide();
            }

        }

        private void registerpassrepeat_TextChanged(object sender, EventArgs e)
        {
            registerpassrepeat.ForeColor = Color.Black;
            comparePass();
            if (!string.IsNullOrWhiteSpace(registerpassrepeat.Text))
            {
                clearGuide();
            }

        }

        private void RegisterPassword_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterPassword.SelectAll();
        }

        private void registerpassrepeat_MouseClick(object sender, MouseEventArgs e)
        {
            registerpassrepeat.SelectAll();
        }
        */









    }
}
