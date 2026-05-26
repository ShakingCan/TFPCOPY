using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.UI.Widget;
using System.Windows.Forms;
using TheFinalProject.Resources;
using Tulpep.NotificationWindow;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using YourProjectName;

namespace TheFinalProject
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
          

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            
            username.ForeColor = Color.Black;
            if(username.Text != "Username" ||password.Text != "Password")
            {
                loginBtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\activeLoginBtn.png");

            }
            else
            {
                loginBtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\logoutbtn.png");
                loginBtn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void username_MouseClick(object sender, MouseEventArgs e)
        {
            username.SelectAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password.ForeColor = Color.Black;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            password.SelectAll();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            userRegistry registerform = new userRegistry();
            registerform.Visible = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String loginuser = username.Text.Trim();
            String loginpass = password.Text.Trim();
            
            bool passnullchecker = string.IsNullOrWhiteSpace(loginpass);
            bool usernullchecker = string.IsNullOrWhiteSpace(loginuser);

            if (usernullchecker)
            {
                userguidelogin.Visible = true;
                userguidelogin.ForeColor = Color.Red;
                userguidelogin.Text = "Username cannot be empty!";
            }

             if (passnullchecker)
            {
                passguidelogin.Visible = true;
                passguidelogin.ForeColor = Color.Red;
                passguidelogin.Text = "Password cannot be empty!";
            }
            String role;
                string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
               
                //fix this shit tomorrow


                    String query = @"SELECT ID, role
                            FROM UsersNew
                            WHERE username = @username AND password = @password";


                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", loginuser);
                        cmd.Parameters.AddWithValue("@password", loginpass);

                        object result = cmd.ExecuteScalar();
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            int userID = Convert.ToInt32(result);
                            role = reader["role"].ToString();
                            if (result != null && role == "User")
                            {
                                //the goal is to find a notification pop up that suits


                                MessageBox.Show("Login Successful!"+"\r\nWelcome User: "+username.Text, "Authentication Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                               
                                Userfrm userForm = new Userfrm(userID);
                                userForm.Dock = DockStyle.Fill;
                                
                                loginPanel.Controls.Add(userForm);
                                userForm.Show();
                                userForm.BringToFront();
                                userForm.Visible = true;
                                username.Text = "Username";
                                password.Text = "Password";

                            }
                            else if (result != null && role == "Coach")
                            {

                                MessageBox.Show("Login Successful!" + "\r\nWelcome Coach: " + username.Text, "Authentication Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                coachfrm cfrom = new coachfrm(userID);
                                cfrom.Dock = DockStyle.Fill;

                                loginPanel.Controls.Add(cfrom);
                                cfrom.Show();
                                cfrom.BringToFront();
                                cfrom.Visible = true;
                                username.Text = "Username";
                                password.Text = "Password";

                            }
                            else if (result != null && role == "Admin") {
                                MessageBox.Show("Login Successful!" + "\r\nWelcome Admin: " + username.Text, "Authentication Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                adminwindow aw = new adminwindow(userID);
                                aw.Dock = DockStyle.Fill;

                                loginPanel.Controls.Add(aw);
                                aw.Show();
                                aw.BringToFront();
                                aw.Visible = true;
                                username.Text = "Username";
                                password.Text = "Password";x
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                  
                    }




                }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        { 
            
            loginPanel.Visible = true;
            loginPanel.BringToFront();
            username.Text = "Username";
            username.ForeColor = SystemColors.ControlDark;
            password.Text = "Password";
            password.ForeColor = SystemColors.ControlDark;
            password.PasswordChar = '\0';
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            adminwindow adminwindow = new adminwindow();
            adminwindow.Show();
        }

        private void showpassbtn_MouseDown(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '\0';
           
        }

        private void showpassbtn_MouseUp(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '*';
            
        }

        private void showpassbtn_Click(object sender, EventArgs e)
        {

        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrWhiteSpace(username.Text)|| username.Text == "Username")
            {
                username.Text = "Username";
                username.ForeColor = Color.DarkGray;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            username.SelectAll();
            username.ForeColor = Color.Black;
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text) || string.IsNullOrWhiteSpace(password.Text)|| password.Text == "Password")
            {
                password.Text = "Password";
                password.ForeColor = Color.DarkGray;
                password.PasswordChar = '\0';
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.SelectAll();
            password.ForeColor = Color.Black;
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            if (username.Text != "Username" || password.Text != "Password")
            {
                loginBtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\activeLoginBtn.png");
            }
            else
            {
                loginBtn.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\logoutbtn.png");
                loginBtn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adminwindow a = new adminwindow();
            a.Visible = true;
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                e.SuppressKeyPress = true;

             
                loginBtn.PerformClick();
            }
        }
    }
}
