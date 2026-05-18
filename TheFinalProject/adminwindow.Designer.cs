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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.upcomingseshcount = new System.Windows.Forms.Label();
            this.toprocesscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reminderbtn = new System.Windows.Forms.Button();
            this.resetStatus = new System.Windows.Forms.Button();
            this.reject = new System.Windows.Forms.Button();
            this.reassign = new System.Windows.Forms.Button();
            this.AllSessions = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.removeaccbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.useraccountslist = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.approve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSessions)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountslist)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 479);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.Reminderbtn);
            this.tabPage1.Controls.Add(this.resetStatus);
            this.tabPage1.Controls.Add(this.reject);
            this.tabPage1.Controls.Add(this.reassign);
            this.tabPage1.Controls.Add(this.approve);
            this.tabPage1.Controls.Add(this.AllSessions);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessions list";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.upcomingseshcount);
            this.panel2.Controls.Add(this.toprocesscount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(431, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 32);
            this.panel2.TabIndex = 21;
            this.panel2.Visible = false;
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
            this.Reminderbtn.Location = new System.Drawing.Point(604, 307);
            this.Reminderbtn.Name = "Reminderbtn";
            this.Reminderbtn.Size = new System.Drawing.Size(85, 23);
            this.Reminderbtn.TabIndex = 20;
            this.Reminderbtn.UseVisualStyleBackColor = true;
            this.Reminderbtn.Click += new System.EventHandler(this.Reminderbtn_Click_1);
            // 
            // resetStatus
            // 
            this.resetStatus.BackgroundImage = global::TheFinalProject.Properties.Resources.adminbtns;
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
            this.reject.BackgroundImage = global::TheFinalProject.Properties.Resources.adminbtns;
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
            this.reassign.BackgroundImage = global::TheFinalProject.Properties.Resources.adminbtns;
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
            // AllSessions
            // 
            this.AllSessions.AllowUserToAddRows = false;
            this.AllSessions.AllowUserToDeleteRows = false;
            this.AllSessions.AllowUserToResizeColumns = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.AllSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.AllSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AllSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllSessions.EnableHeadersVisualStyles = false;
            this.AllSessions.Location = new System.Drawing.Point(1, 15);
            this.AllSessions.Name = "AllSessions";
            this.AllSessions.RowHeadersVisible = false;
            this.AllSessions.RowTemplate.Height = 44;
            this.AllSessions.Size = new System.Drawing.Size(951, 273);
            this.AllSessions.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.removeaccbtn);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.useraccountslist);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accounts list";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(412, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Accounts list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // removeaccbtn
            // 
            this.removeaccbtn.BackgroundImage = global::TheFinalProject.Properties.Resources.adminbtns;
            this.removeaccbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeaccbtn.FlatAppearance.BorderSize = 0;
            this.removeaccbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeaccbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.removeaccbtn.ForeColor = System.Drawing.Color.White;
            this.removeaccbtn.Location = new System.Drawing.Point(526, 301);
            this.removeaccbtn.Name = "removeaccbtn";
            this.removeaccbtn.Size = new System.Drawing.Size(130, 37);
            this.removeaccbtn.TabIndex = 15;
            this.removeaccbtn.Text = "Remove account";
            this.removeaccbtn.UseVisualStyleBackColor = true;
            this.removeaccbtn.Click += new System.EventHandler(this.removeaccbtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TheFinalProject.Properties.Resources.adminbtns;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(306, 301);
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.useraccountslist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.useraccountslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.useraccountslist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.useraccountslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useraccountslist.EnableHeadersVisualStyles = false;
            this.useraccountslist.Location = new System.Drawing.Point(254, 79);
            this.useraccountslist.Name = "useraccountslist";
            this.useraccountslist.RowHeadersVisible = false;
            this.useraccountslist.Size = new System.Drawing.Size(440, 216);
            this.useraccountslist.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmbtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(222, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 203);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackgroundImage = global::TheFinalProject.Properties.Resources.adminbtns;
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
            // approve
            // 
            this.approve.BackgroundImage = global::TheFinalProject.Properties.Resources.adminbtns;
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 33);
            this.label3.TabIndex = 29;
            this.label3.Tag = "";
            this.label3.Text = "Betacell Wellness";
            // 
            // adminwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminwindow";
            this.Text = "adminwindow";
            this.Load += new System.EventHandler(this.adminwindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSessions)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountslist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button Reminderbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label upcomingseshcount;
        private System.Windows.Forms.Label toprocesscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}