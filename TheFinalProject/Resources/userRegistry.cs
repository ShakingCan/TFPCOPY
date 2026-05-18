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
            if (RegisterUsername.Text != "Username" || RegisterPassword.Text != "Password" || registerpassrepeat.Text != "Re-enter Password")
            {
                Registerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\activeLoginBtn.png");
            }
            else
            {
                Registerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\logoutbtn.png");
                Registerbtn.BackgroundImageLayout = ImageLayout.Stretch;
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
            if (RegisterUsername.Text != "Username" || RegisterPassword.Text != "Password" || registerpassrepeat.Text != "Re-enter Password")
            {
                Registerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\activeLoginBtn.png");
            }
            else
            {
                Registerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\logoutbtn.png");
                Registerbtn.BackgroundImageLayout = ImageLayout.Stretch;
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
            if (RegisterUsername.Text != "Username" || RegisterPassword.Text != "Password" || registerpassrepeat.Text != "Re-enter Password")
            {
                Registerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\activeLoginBtn.png");
            }
            else
            {
                Registerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\logoutbtn.png");
                Registerbtn.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void showpassbtn_MouseDown(object sender, MouseEventArgs e)
        {
            RegisterPassword.PasswordChar = '\0';
            registerpassrepeat.PasswordChar = '\0';
        }

        private void showpassbtn_MouseUp(object sender, MouseEventArgs e)
        {
            RegisterPassword.PasswordChar = '*';
            registerpassrepeat.PasswordChar = '*';
        }

        private void RegisterUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegisterUsername.Text) || string.IsNullOrWhiteSpace(RegisterUsername.Text) || RegisterUsername.Text == "Username")
            {
                RegisterUsername.Text = "Username";
                RegisterUsername.ForeColor = Color.DarkGray;
            }
        }

        private void RegisterUsername_Enter(object sender, EventArgs e)
        {
            RegisterUsername.SelectAll();
            RegisterUsername.ForeColor = Color.Black;
        }

        private void RegisterPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegisterPassword.Text) || string.IsNullOrWhiteSpace(RegisterPassword.Text) || RegisterPassword.Text == "Password")
            {
                RegisterPassword.PasswordChar = '\0';
                RegisterPassword.Text = "Password";
                RegisterPassword.ForeColor = Color.DarkGray;


            }
        }

        private void RegisterPassword_Enter(object sender, EventArgs e)
        {
            RegisterPassword.SelectAll();
            RegisterPassword.ForeColor = Color.Black;
        }


        private void registerpassrepeat_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(registerpassrepeat.Text) || string.IsNullOrWhiteSpace(registerpassrepeat.Text) || registerpassrepeat.Text == "Re-enter Password")
            {
                registerpassrepeat.PasswordChar = '\0';
                registerpassrepeat.Text = "Re-enter Password";
                registerpassrepeat.ForeColor = Color.DarkGray;

            }
        }

        private void userRegistry_Load(object sender, EventArgs e)
        {
            RegisterUsername.Text = "Username";
            RegisterPassword.Text = "Password";
            registerpassrepeat.Text = "Re-enter Password";
            RegisterPassword.PasswordChar = '\0';
            registerpassrepeat.PasswordChar = '\0';
            RegisterUsername.ForeColor = SystemColors.ControlDark;
            RegisterPassword.ForeColor = SystemColors.ControlDark;
            registerpassrepeat.ForeColor = SystemColors.ControlDark;
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
