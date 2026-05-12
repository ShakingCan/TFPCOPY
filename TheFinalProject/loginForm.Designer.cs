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
            this.loginBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.passguidelogin = new System.Windows.Forms.Label();
            this.userguidelogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerbtn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(87, 209);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(91, 39);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.username.Location = new System.Drawing.Point(56, 102);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 29);
            this.username.TabIndex = 3;
            this.username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_MouseClick);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Controls.Add(this.panel5);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.panel4);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(800, 450);
            this.loginPanel.TabIndex = 5;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.passguidelogin);
            this.panel5.Controls.Add(this.userguidelogin);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.username);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.loginBtn);
            this.panel5.Controls.Add(this.registerbtn);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.password);
            this.panel5.Location = new System.Drawing.Point(286, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(335, 315);
            this.panel5.TabIndex = 12;
            // 
            // passguidelogin
            // 
            this.passguidelogin.Location = new System.Drawing.Point(186, 158);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TheFinalProject.Properties.Resources.user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(11, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 30);
            this.panel2.TabIndex = 5;
            // 
            // registerbtn
            // 
            this.registerbtn.AutoSize = true;
            this.registerbtn.Location = new System.Drawing.Point(145, 257);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(73, 13);
            this.registerbtn.TabIndex = 9;
            this.registerbtn.Text = "Register here.";
            this.registerbtn.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::TheFinalProject.Properties.Resources._lock;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(11, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 30);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "No account yet?";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.password.Location = new System.Drawing.Point(56, 174);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(200, 29);
            this.password.TabIndex = 7;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "app name";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::TheFinalProject.Properties.Resources.tambay_mambo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 100);
            this.panel4.TabIndex = 10;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPanel);
            this.Name = "loginform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label registerbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userguidelogin;
        private System.Windows.Forms.Label passguidelogin;
        private System.Windows.Forms.Button button1;
    }
}

