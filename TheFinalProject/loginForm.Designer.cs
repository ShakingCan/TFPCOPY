namespace TheFinalProject
{
    partial class loginform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showpassbtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.passguidelogin = new System.Windows.Forms.Label();
            this.userguidelogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.pictureBox3);
            this.loginPanel.Controls.Add(this.panel5);
            this.loginPanel.Controls.Add(this.pictureBox2);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(984, 511);
            this.loginPanel.TabIndex = 5;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TheFinalProject.Properties.Resources.loginIMG;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(491, 508);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::TheFinalProject.Properties.Resources.white_rect;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.showpassbtn);
            this.panel5.Controls.Add(this.password);
            this.panel5.Controls.Add(this.passguidelogin);
            this.panel5.Controls.Add(this.userguidelogin);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.username);
            this.panel5.Controls.Add(this.loginBtn);
            this.panel5.Controls.Add(this.registerbtn);
            this.panel5.Location = new System.Drawing.Point(572, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 315);
            this.panel5.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "info@betacellwellness.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Contact us:";
            // 
            // showpassbtn
            // 
            this.showpassbtn.BackgroundImage = global::TheFinalProject.Properties.Resources.show_pass_icon;
            this.showpassbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showpassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpassbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showpassbtn.Location = new System.Drawing.Point(259, 152);
            this.showpassbtn.Margin = new System.Windows.Forms.Padding(0);
            this.showpassbtn.Name = "showpassbtn";
            this.showpassbtn.Size = new System.Drawing.Size(31, 29);
            this.showpassbtn.TabIndex = 19;
            this.showpassbtn.UseVisualStyleBackColor = true;
            this.showpassbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showpassbtn_MouseDown);
            this.showpassbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showpassbtn_MouseUp);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.password.Location = new System.Drawing.Point(56, 154);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(200, 24);
            this.password.TabIndex = 7;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // passguidelogin
            // 
            this.passguidelogin.Location = new System.Drawing.Point(196, 138);
            this.passguidelogin.Name = "passguidelogin";
            this.passguidelogin.Size = new System.Drawing.Size(149, 13);
            this.passguidelogin.TabIndex = 18;
            this.passguidelogin.Text = "passguide";
            this.passguidelogin.Visible = false;
            // 
            // userguidelogin
            // 
            this.userguidelogin.Location = new System.Drawing.Point(185, 86);
            this.userguidelogin.Name = "userguidelogin";
            this.userguidelogin.Size = new System.Drawing.Size(147, 13);
            this.userguidelogin.TabIndex = 17;
            this.userguidelogin.Text = "userguidelogin";
            this.userguidelogin.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(168, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.username.Location = new System.Drawing.Point(56, 102);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 24);
            this.username.TabIndex = 3;
            this.username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_MouseClick);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkGray;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(56, 209);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(200, 39);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.AutoSize = true;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.Gray;
            this.registerbtn.Location = new System.Drawing.Point(85, 36);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(93, 24);
            this.registerbtn.TabIndex = 9;
            this.registerbtn.Text = "Register ";
            this.registerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerbtn.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TheFinalProject.Properties.Resources.white_rect;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(490, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(494, 505);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheFinalProject.Properties.Resources.grey_rect;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 505);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.loginPanel);
            this.Name = "loginform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userguidelogin;
        private System.Windows.Forms.Label passguidelogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button showpassbtn;
        private System.Windows.Forms.Label registerbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}

