namespace TheFinalProject
{
    partial class adminwindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminwindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetStatus = new System.Windows.Forms.Button();
            this.reject = new System.Windows.Forms.Button();
            this.reassign = new System.Windows.Forms.Button();
            this.approve = new System.Windows.Forms.Button();
            this.AllSessions = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeaccbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.useraccountslist = new System.Windows.Forms.DataGridView();
            this.accountname = new System.Windows.Forms.Label();
            this.viewprofilebutton = new System.Windows.Forms.Button();
            this.Reminderbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSessions)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountslist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(140, 40);
            this.tabControl1.Location = new System.Drawing.Point(-7, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 399);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.resetStatus);
            this.tabPage1.Controls.Add(this.reject);
            this.tabPage1.Controls.Add(this.reassign);
            this.tabPage1.Controls.Add(this.approve);
            this.tabPage1.Controls.Add(this.AllSessions);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessions list";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmbtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(255, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 203);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmbtn.BackgroundImage")));
            this.confirmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmbtn.FlatAppearance.BorderSize = 0;
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.confirmbtn.Location = new System.Drawing.Point(211, 131);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(96, 37);
            this.confirmbtn.TabIndex = 2;
            this.confirmbtn.Text = "confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(196, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a coach";
            // 
            // resetStatus
            // 
            this.resetStatus.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.resetStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetStatus.FlatAppearance.BorderSize = 0;
            this.resetStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.resetStatus.ForeColor = System.Drawing.Color.White;
            this.resetStatus.Location = new System.Drawing.Point(367, 307);
            this.resetStatus.Name = "resetStatus";
            this.resetStatus.Size = new System.Drawing.Size(130, 37);
            this.resetStatus.TabIndex = 11;
            this.resetStatus.Text = "reset status";
            this.resetStatus.UseVisualStyleBackColor = true;
            this.resetStatus.Click += new System.EventHandler(this.resetStatus_Click);
            // 
            // reject
            // 
            this.reject.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.reject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reject.FlatAppearance.BorderSize = 0;
            this.reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.reject.ForeColor = System.Drawing.Color.White;
            this.reject.Location = new System.Drawing.Point(121, 307);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(96, 37);
            this.reject.TabIndex = 10;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = true;
            this.reject.Click += new System.EventHandler(this.reject_Click);
            // 
            // reassign
            // 
            this.reassign.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.reassign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reassign.FlatAppearance.BorderSize = 0;
            this.reassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reassign.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.reassign.ForeColor = System.Drawing.Color.White;
            this.reassign.Location = new System.Drawing.Point(222, 307);
            this.reassign.Name = "reassign";
            this.reassign.Size = new System.Drawing.Size(130, 37);
            this.reassign.TabIndex = 9;
            this.reassign.Text = "Reassign coach";
            this.reassign.UseVisualStyleBackColor = true;
            this.reassign.Click += new System.EventHandler(this.reassign_Click);
            // 
            // approve
            // 
            this.approve.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.approve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.approve.FlatAppearance.BorderSize = 0;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.approve.ForeColor = System.Drawing.Color.White;
            this.approve.Location = new System.Drawing.Point(21, 307);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(96, 37);
            this.approve.TabIndex = 8;
            this.approve.Text = "Approve";
            this.approve.UseVisualStyleBackColor = true;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // AllSessions
            // 
            this.AllSessions.AllowUserToAddRows = false;
            this.AllSessions.AllowUserToDeleteRows = false;
            this.AllSessions.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.AllSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllSessions.EnableHeadersVisualStyles = false;
            this.AllSessions.Location = new System.Drawing.Point(1, 0);
            this.AllSessions.Name = "AllSessions";
            this.AllSessions.RowTemplate.Height = 44;
            this.AllSessions.Size = new System.Drawing.Size(982, 273);
            this.AllSessions.TabIndex = 7;
            this.AllSessions.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllSessions_RowHeaderMouseClick);
            this.AllSessions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.AllSessions_RowPostPaint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.removeaccbtn);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.useraccountslist);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accounts list";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TheFinalProject.Properties.Resources.receptiondesk60;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(482, 345);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(673, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Accounts list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // removeaccbtn
            // 
            this.removeaccbtn.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.removeaccbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeaccbtn.FlatAppearance.BorderSize = 0;
            this.removeaccbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeaccbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.removeaccbtn.ForeColor = System.Drawing.Color.White;
            this.removeaccbtn.Location = new System.Drawing.Point(795, 274);
            this.removeaccbtn.Name = "removeaccbtn";
            this.removeaccbtn.Size = new System.Drawing.Size(130, 37);
            this.removeaccbtn.TabIndex = 15;
            this.removeaccbtn.Text = "Remove account";
            this.removeaccbtn.UseVisualStyleBackColor = true;
            this.removeaccbtn.Click += new System.EventHandler(this.removeaccbtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(567, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // useraccountslist
            // 
            this.useraccountslist.AllowUserToAddRows = false;
            this.useraccountslist.AllowUserToDeleteRows = false;
            this.useraccountslist.AllowUserToResizeColumns = false;
            this.useraccountslist.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.useraccountslist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.useraccountslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.useraccountslist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.useraccountslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useraccountslist.EnableHeadersVisualStyles = false;
            this.useraccountslist.Location = new System.Drawing.Point(514, 52);
            this.useraccountslist.Name = "useraccountslist";
            this.useraccountslist.Size = new System.Drawing.Size(440, 216);
            this.useraccountslist.TabIndex = 8;
            this.useraccountslist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserAccountList_RowHeaderMouseClick);
            this.useraccountslist.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.UserAccountList_RowPostPaint);
            // 
            // accountname
            // 
            this.accountname.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.accountname.Location = new System.Drawing.Point(603, 17);
            this.accountname.Name = "accountname";
            this.accountname.Size = new System.Drawing.Size(242, 35);
            this.accountname.TabIndex = 41;
            this.accountname.Text = "label2";
            this.accountname.Paint += new System.Windows.Forms.PaintEventHandler(this.yourBackgroundContainer_Paint);
            // 
            // viewprofilebutton
            // 
            this.viewprofilebutton.BackColor = System.Drawing.Color.Transparent;
            this.viewprofilebutton.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.viewprofilebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewprofilebutton.FlatAppearance.BorderSize = 0;
            this.viewprofilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewprofilebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.viewprofilebutton.ForeColor = System.Drawing.Color.White;
            this.viewprofilebutton.Location = new System.Drawing.Point(599, 55);
            this.viewprofilebutton.Margin = new System.Windows.Forms.Padding(2);
            this.viewprofilebutton.Name = "viewprofilebutton";
            this.viewprofilebutton.Size = new System.Drawing.Size(120, 33);
            this.viewprofilebutton.TabIndex = 40;
            this.viewprofilebutton.Text = "logout";
            this.viewprofilebutton.UseVisualStyleBackColor = false;
            this.viewprofilebutton.Click += new System.EventHandler(this.viewprofilebutton_Click);
            // 
            // Reminderbtn
            // 
            this.Reminderbtn.BackColor = System.Drawing.Color.Transparent;
            this.Reminderbtn.BackgroundImage = global::TheFinalProject.Properties.Resources.roundedactivebntn_removebg_preview;
            this.Reminderbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reminderbtn.FlatAppearance.BorderSize = 0;
            this.Reminderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reminderbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Reminderbtn.ForeColor = System.Drawing.Color.White;
            this.Reminderbtn.Location = new System.Drawing.Point(725, 55);
            this.Reminderbtn.Name = "Reminderbtn";
            this.Reminderbtn.Size = new System.Drawing.Size(120, 33);
            this.Reminderbtn.TabIndex = 39;
            this.Reminderbtn.Text = "  Reminders";
            this.Reminderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reminderbtn.UseVisualStyleBackColor = false;
            this.Reminderbtn.Click += new System.EventHandler(this.Reminderbtn_Click_1);
            this.Reminderbtn.Paint += new System.Windows.Forms.PaintEventHandler(this.Reminderbtn_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(861, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 62);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 138);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // adminwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.accountname);
            this.Controls.Add(this.viewprofilebutton);
            this.Controls.Add(this.Reminderbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminwindow";
            this.Text = "adminwindow";
            this.Load += new System.EventHandler(this.adminwindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSessions)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountslist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button resetStatus;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button reassign;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.DataGridView AllSessions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView useraccountslist;
        private System.Windows.Forms.Button removeaccbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Reminderbtn;
        private System.Windows.Forms.Button viewprofilebutton;
        private System.Windows.Forms.Label accountname;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}