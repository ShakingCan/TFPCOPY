using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace TheFinalProject.Resources
{
    public partial class registerform : Form   
    {
        public registerform()
        {
            InitializeComponent();
            
        }

        private void RegisterUsername_TextChanged(object sender, EventArgs e)
        {
            RegisterUsername.ForeColor = Color.Black;
                if(!string.IsNullOrWhiteSpace(RegisterUsername.Text))
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
        

        private void RegisterUsername_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterUsername.SelectAll();
        }

        private void RegisterPassword_TextChanged(object sender, EventArgs e)
        {
            RegisterPassword.PasswordChar = '*';
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
            registerpassrepeat.PasswordChar = '*';
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
       
        private void RegisterPassword_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterPassword.SelectAll();
        }

        private void registerpassrepeat_MouseClick(object sender, MouseEventArgs e)
        {
            registerpassrepeat.SelectAll();
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

        private void Registerbtn_Click_1(object sender, EventArgs e)
        {

            
            String username = RegisterUsername.Text.Trim();
            String password = RegisterPassword.Text.Trim();
            String passwordrepeat = registerpassrepeat.Text.Trim();
            bool passnullchecker = string.IsNullOrWhiteSpace(password);
            bool usernullchecker = string.IsNullOrWhiteSpace(username);
            bool passrepeatnullchecker = string.IsNullOrWhiteSpace(passwordrepeat);



            if (!Coachtoggle.Checked && !Usertoggle.Checked)
            {
                MessageBox.Show("Please select account type!");
            }
            else if (usernullchecker)
            {
                userguide.Visible = true;
                userguide.ForeColor = Color.Red;
                userguide.Text = "Username cannot be empty!";
            }

            else if (passnullchecker)
            {
                passguide.Visible = true;
                passguide.ForeColor = Color.Red;
                passguide.Text = "Password cannot be empty!";
            }
            else if (passrepeatnullchecker)
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
                            cmd.Parameters.AddWithValue("@username", RegisterUsername.Text.Trim()); 
                            cmd.Parameters.AddWithValue("@password", RegisterPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", Coachtoggle.Checked ? "Coach" : "User");
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

        private void userguide_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
        private void registerform_Load(object sender, EventArgs e)
        {
            coach.FlatStyle = FlatStyle.Flat;
            userrr.FlatStyle = FlatStyle.Flat;

            coach.Paint += CustomRadioButton_Paint;
            userrr.Paint += CustomRadioButton_Paint;
            RegisterUsername.Text = "Username";
            RegisterUsername.ForeColor = SystemColors.ControlDark;

            RegisterPassword.Text = "Password";
            RegisterPassword.ForeColor = SystemColors.ControlDark;
            RegisterPassword.PasswordChar = '\0';

            registerpassrepeat.Text = "Re-enter Password";
            registerpassrepeat.ForeColor = SystemColors.ControlDark;
            registerpassrepeat.PasswordChar = '\0';
            

        }
      private void CustomRadioButton_Paint(object sender, PaintEventArgs e)
{
    RadioButton rb = sender as RadioButton;

    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

    int size = 14;
    int x = 2;
    int y = (rb.Height - size) / 2;

    Rectangle rect = new Rectangle(x, y, size, size);

    // Always draw clean base (no system colors)
    using (SolidBrush bg = new SolidBrush(Color.White))
    {
        e.Graphics.FillEllipse(bg, rect);
    }

    // Fill state
    if (rb.Checked)
    {
        e.Graphics.FillEllipse(Brushes.Gray, rect);
    }

    // Outline
    using (Pen pen = new Pen(Color.Black, 2f))
    {
        e.Graphics.DrawEllipse(pen, rect);
    }
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
        private void registerpassrepeat_Enter(object sender, EventArgs e)
        {
            registerpassrepeat.SelectAll();
            registerpassrepeat.ForeColor = Color.Black;
        }

        private void coach_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\Coachpic.png");
           
        }

        private void userrr_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile("C:\\Users\\Allan\\Desktop\\New folder\\userpic.png");
        }

        private void RadioButton_Paint(object sender, PaintEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Hide default radio button
            RadioButtonRenderer.DrawParentBackground(g, rb.ClientRectangle, rb);

            float size = 18f;

            RectangleF rect = new RectangleF(
                1,
                (rb.Height - size) / 2,
                size,
                size
            );

            using (Pen pen = new Pen(Color.Black, 1.5f))
            using (SolidBrush whiteBrush = new SolidBrush(Color.White))
            using (SolidBrush grayBrush = new SolidBrush(Color.Gray))
            using (SolidBrush textBrush = new SolidBrush(rb.ForeColor))
            {
                // Draw custom circle
                g.FillEllipse(rb.Checked ? grayBrush : whiteBrush, rect);
                g.DrawEllipse(pen, rect);

                // Draw text manually
                g.DrawString(
                    rb.Text,
                    rb.Font,
                    textBrush,
                    size + 8,
                    (rb.Height - rb.Font.Height) / 2
                );
            }
        }
    }
    }

