namespace TheFinalProject.Resources
{
    partial class coachfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usermainpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.upcomingseshcount = new System.Windows.Forms.Label();
            this.toprocesscount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reminderbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.viewprofilebutton = new System.Windows.Forms.Button();
            this.accountname = new System.Windows.Forms.Label();
            this.profilepanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mybookingstab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Pendingsessionspanel = new System.Windows.Forms.Panel();
            this.upcomingsessionsdata = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.sessionstoapprovetab = new System.Windows.Forms.TabPage();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.declinebtn = new System.Windows.Forms.Button();
            this.approvebtn = new System.Windows.Forms.Button();
            this.sessionstoapprove = new System.Windows.Forms.DataGridView();
            this.usermainpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mybookingstab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Pendingsessionspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingsessionsdata)).BeginInit();
            this.sessionstoapprovetab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionstoapprove)).BeginInit();
            this.SuspendLayout();
            // 
            // usermainpanel
            // 
            this.usermainpanel.Controls.Add(this.panel2);
            this.usermainpanel.Controls.Add(this.Reminderbtn);
            this.usermainpanel.Controls.Add(this.panel4);
            this.usermainpanel.Controls.Add(this.label2);
            this.usermainpanel.Controls.Add(this.viewprofilebutton);
            this.usermainpanel.Controls.Add(this.accountname);
            this.usermainpanel.Controls.Add(this.profilepanel);
            this.usermainpanel.Controls.Add(this.tabControl1);
            this.usermainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usermainpanel.Location = new System.Drawing.Point(0, 0);
            this.usermainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.usermainpanel.Name = "usermainpanel";
            this.usermainpanel.Size = new System.Drawing.Size(800, 450);
            this.usermainpanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.upcomingseshcount);
            this.panel2.Controls.Add(this.toprocesscount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(264, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 75);
            this.panel2.TabIndex = 20;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // upcomingseshcount
            // 
            this.upcomingseshcount.AutoSize = true;
            this.upcomingseshcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingseshcount.Location = new System.Drawing.Point(223, 42);
            this.upcomingseshcount.Name = "upcomingseshcount";
            this.upcomingseshcount.Size = new System.Drawing.Size(0, 20);
            this.upcomingseshcount.TabIndex = 24;
            // 
            // toprocesscount
            // 
            this.toprocesscount.AutoSize = true;
            this.toprocesscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toprocesscount.Location = new System.Drawing.Point(106, 2);
            this.toprocesscount.Name = "toprocesscount";
            this.toprocesscount.Size = new System.Drawing.Size(0, 20);
            this.toprocesscount.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "upcoming sessions today: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "To process: ";
            // 
            // Reminderbtn
            // 
            this.Reminderbtn.Location = new System.Drawing.Point(457, 17);
            this.Reminderbtn.Name = "Reminderbtn";
            this.Reminderbtn.Size = new System.Drawing.Size(85, 23);
            this.Reminderbtn.TabIndex = 19;
            this.Reminderbtn.Text = "reminder";
            this.Reminderbtn.UseVisualStyleBackColor = true;
            this.Reminderbtn.Click += new System.EventHandler(this.Reminderbtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::TheFinalProject.Properties.Resources.tambay_mambo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(16, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 69);
            this.panel4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "app name";
            // 
            // viewprofilebutton
            // 
            this.viewprofilebutton.Location = new System.Drawing.Point(645, 70);
            this.viewprofilebutton.Margin = new System.Windows.Forms.Padding(2);
            this.viewprofilebutton.Name = "viewprofilebutton";
            this.viewprofilebutton.Size = new System.Drawing.Size(56, 28);
            this.viewprofilebutton.TabIndex = 16;
            this.viewprofilebutton.Text = "logout";
            this.viewprofilebutton.UseVisualStyleBackColor = true;
            this.viewprofilebutton.Click += new System.EventHandler(this.viewprofilebutton_Click);
            // 
            // accountname
            // 
            this.accountname.Location = new System.Drawing.Point(643, 17);
            this.accountname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountname.Name = "accountname";
            this.accountname.Size = new System.Drawing.Size(137, 29);
            this.accountname.TabIndex = 15;
            this.accountname.Text = "label1";
            // 
            // profilepanel
            // 
            this.profilepanel.BackgroundImage = global::TheFinalProject.Properties.Resources.user;
            this.profilepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilepanel.Location = new System.Drawing.Point(547, 17);
            this.profilepanel.Margin = new System.Windows.Forms.Padding(2);
            this.profilepanel.Name = "profilepanel";
            this.profilepanel.Size = new System.Drawing.Size(82, 81);
            this.profilepanel.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.mybookingstab);
            this.tabControl1.Controls.Add(this.sessionstoapprovetab);
            this.tabControl1.Location = new System.Drawing.Point(27, 125);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // mybookingstab
            // 
            this.mybookingstab.Controls.Add(this.panel1);
            this.mybookingstab.Controls.Add(this.Pendingsessionspanel);
            this.mybookingstab.Location = new System.Drawing.Point(4, 25);
            this.mybookingstab.Margin = new System.Windows.Forms.Padding(2);
            this.mybookingstab.Name = "mybookingstab";
            this.mybookingstab.Padding = new System.Windows.Forms.Padding(2);
            this.mybookingstab.Size = new System.Drawing.Size(691, 255);
            this.mybookingstab.TabIndex = 0;
            this.mybookingstab.Text = "My bookings";
            this.mybookingstab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(368, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 215);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(299, 186);
            this.dataGridView2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Past Sessions";
            // 
            // Pendingsessionspanel
            // 
            this.Pendingsessionspanel.Controls.Add(this.upcomingsessionsdata);
            this.Pendingsessionspanel.Controls.Add(this.label3);
            this.Pendingsessionspanel.Location = new System.Drawing.Point(4, 5);
            this.Pendingsessionspanel.Margin = new System.Windows.Forms.Padding(2);
            this.Pendingsessionspanel.Name = "Pendingsessionspanel";
            this.Pendingsessionspanel.Size = new System.Drawing.Size(359, 213);
            this.Pendingsessionspanel.TabIndex = 11;
            // 
            // upcomingsessionsdata
            // 
            this.upcomingsessionsdata.AllowUserToAddRows = false;
            this.upcomingsessionsdata.AllowUserToDeleteRows = false;
            this.upcomingsessionsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingsessionsdata.Location = new System.Drawing.Point(5, 24);
            this.upcomingsessionsdata.Name = "upcomingsessionsdata";
            this.upcomingsessionsdata.Size = new System.Drawing.Size(351, 186);
            this.upcomingsessionsdata.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upcoming Sessions";
            // 
            // sessionstoapprovetab
            // 
            this.sessionstoapprovetab.Controls.Add(this.refreshbtn);
            this.sessionstoapprovetab.Controls.Add(this.declinebtn);
            this.sessionstoapprovetab.Controls.Add(this.approvebtn);
            this.sessionstoapprovetab.Controls.Add(this.sessionstoapprove);
            this.sessionstoapprovetab.Location = new System.Drawing.Point(4, 25);
            this.sessionstoapprovetab.Name = "sessionstoapprovetab";
            this.sessionstoapprovetab.Padding = new System.Windows.Forms.Padding(3);
            this.sessionstoapprovetab.Size = new System.Drawing.Size(691, 255);
            this.sessionstoapprovetab.TabIndex = 2;
            this.sessionstoapprovetab.Text = "Sessions to approve";
            this.sessionstoapprovetab.UseVisualStyleBackColor = true;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(233, 204);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(56, 19);
            this.refreshbtn.TabIndex = 19;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // declinebtn
            // 
            this.declinebtn.Location = new System.Drawing.Point(132, 204);
            this.declinebtn.Margin = new System.Windows.Forms.Padding(2);
            this.declinebtn.Name = "declinebtn";
            this.declinebtn.Size = new System.Drawing.Size(56, 19);
            this.declinebtn.TabIndex = 18;
            this.declinebtn.Text = "Decline";
            this.declinebtn.UseVisualStyleBackColor = true;
            this.declinebtn.Click += new System.EventHandler(this.declinebtn_Click);
            // 
            // approvebtn
            // 
            this.approvebtn.Location = new System.Drawing.Point(29, 204);
            this.approvebtn.Margin = new System.Windows.Forms.Padding(2);
            this.approvebtn.Name = "approvebtn";
            this.approvebtn.Size = new System.Drawing.Size(56, 19);
            this.approvebtn.TabIndex = 17;
            this.approvebtn.Text = "Approve";
            this.approvebtn.UseVisualStyleBackColor = true;
            this.approvebtn.Click += new System.EventHandler(this.approvebtn_Click);
            // 
            // sessionstoapprove
            // 
            this.sessionstoapprove.AllowUserToAddRows = false;
            this.sessionstoapprove.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionstoapprove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sessionstoapprove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sessionstoapprove.DefaultCellStyle = dataGridViewCellStyle2;
            this.sessionstoapprove.Location = new System.Drawing.Point(-4, 0);
            this.sessionstoapprove.MultiSelect = false;
            this.sessionstoapprove.Name = "sessionstoapprove";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionstoapprove.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sessionstoapprove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionstoapprove.Size = new System.Drawing.Size(371, 169);
            this.sessionstoapprove.TabIndex = 0;
            // 
            // coachfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usermainpanel);
            this.Name = "coachfrm";
            this.Text = "coachfrm";
            this.Load += new System.EventHandler(this.coachfrm_Load);
            this.usermainpanel.ResumeLayout(false);
            this.usermainpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.mybookingstab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Pendingsessionspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upcomingsessionsdata)).EndInit();
            this.sessionstoapprovetab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionstoapprove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel usermainpanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewprofilebutton;
        private System.Windows.Forms.Label accountname;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mybookingstab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pendingsessionspanel;
        private System.Windows.Forms.DataGridView upcomingsessionsdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage sessionstoapprovetab;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button declinebtn;
        private System.Windows.Forms.Button approvebtn;
        private System.Windows.Forms.DataGridView sessionstoapprove;
        private System.Windows.Forms.Panel profilepanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label upcomingseshcount;
        private System.Windows.Forms.Label toprocesscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reminderbtn;
    }
}