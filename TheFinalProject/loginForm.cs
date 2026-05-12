using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheFinalProject.Resources;

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
                            if (result != null && role =="User")
                            {
                               
                                MessageBox.Show("Login successful!");

                                Userfrm userForm = new Userfrm(userID);
                                userForm.Show();
                                this.Hide();
                            }
                            else if (result != null && role == "Coach")
                            {
                               
                                MessageBox.Show("Login successful!");

                                coachfrm cform = new coachfrm(userID);
                                cform.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!");
                            }

                        }
                    
                    }

                  
                    }




                }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        { 
            
            loginPanel.Visible = true;
            loginPanel.BringToFront();
           
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            adminwindow adminwindow = new adminwindow();
            adminwindow.Show();
        }
    }
}
