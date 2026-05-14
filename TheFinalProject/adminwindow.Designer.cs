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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.upcomingseshcount = new System.Windows.Forms.Label();
            this.toprocesscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reminderbtn = new System.Windows.Forms.Button();
            this.addaccount = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.removeaccbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.useraccountslist = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSessions)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountslist)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 438);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.Reminderbtn);
            this.tabPage1.Controls.Add(this.addaccount);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.resetStatus);
            this.tabPage1.Controls.Add(this.reject);
            this.tabPage1.Controls.Add(this.reassign);
            this.tabPage1.Controls.Add(this.approve);
            this.tabPage1.Controls.Add(this.AllSessions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.upcomingseshcount);
            this.panel2.Controls.Add(this.toprocesscount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(436, 312);
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
            this.Reminderbtn.Location = new System.Drawing.Point(629, 283);
            this.Reminderbtn.Name = "Reminderbtn";
            this.Reminderbtn.Size = new System.Drawing.Size(85, 23);
            this.Reminderbtn.TabIndex = 20;
            this.Reminderbtn.UseVisualStyleBackColor = true;
            this.Reminderbtn.Click += new System.EventHandler(this.Reminderbtn_Click_1);
            // 
            // addaccount
            // 
            this.addaccount.Location = new System.Drawing.Point(491, 283);
            this.addaccount.Name = "addaccount";
            this.addaccount.Size = new System.Drawing.Size(121, 23);
            this.addaccount.TabIndex = 13;
            this.addaccount.Text = "Add account";
            this.addaccount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmbtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(269, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(60, 61);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.confirmbtn.TabIndex = 2;
            this.confirmbtn.Text = "confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter coach name";
            // 
            // resetStatus
            // 
            this.resetStatus.Location = new System.Drawing.Point(368, 283);
            this.resetStatus.Name = "resetStatus";
            this.resetStatus.Size = new System.Drawing.Size(101, 23);
            this.resetStatus.TabIndex = 11;
            this.resetStatus.Text = "reset status";
            this.resetStatus.UseVisualStyleBackColor = true;
            this.resetStatus.Click += new System.EventHandler(this.resetStatus_Click);
            // 
            // reject
            // 
            this.reject.Location = new System.Drawing.Point(146, 283);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(95, 23);
            this.reject.TabIndex = 10;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = true;
            this.reject.Click += new System.EventHandler(this.reject_Click);
            // 
            // reassign
            // 
            this.reassign.Location = new System.Drawing.Point(247, 283);
            this.reassign.Name = "reassign";
            this.reassign.Size = new System.Drawing.Size(97, 23);
            this.reassign.TabIndex = 9;
            this.reassign.Text = "Reassign coach";
            this.reassign.UseVisualStyleBackColor = true;
            this.reassign.Click += new System.EventHandler(this.reassign_Click);
            // 
            // approve
            // 
            this.approve.Location = new System.Drawing.Point(46, 283);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(98, 23);
            this.approve.TabIndex = 8;
            this.approve.Text = "Approve";
            this.approve.UseVisualStyleBackColor = true;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // AllSessions
            // 
            this.AllSessions.AllowUserToAddRows = false;
            this.AllSessions.AllowUserToDeleteRows = false;
            this.AllSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllSessions.Location = new System.Drawing.Point(23, 24);
            this.AllSessions.Name = "AllSessions";
            this.AllSessions.Size = new System.Drawing.Size(744, 216);
            this.AllSessions.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.removeaccbtn);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.useraccountslist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Accounts list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // removeaccbtn
            // 
            this.removeaccbtn.Location = new System.Drawing.Point(416, 357);
            this.removeaccbtn.Name = "removeaccbtn";
            this.removeaccbtn.Size = new System.Drawing.Size(137, 23);
            this.removeaccbtn.TabIndex = 15;
            this.removeaccbtn.Text = "Remove account";
            this.removeaccbtn.UseVisualStyleBackColor = true;
            this.removeaccbtn.Click += new System.EventHandler(this.removeaccbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // useraccountslist
            // 
            this.useraccountslist.AllowUserToAddRows = false;
            this.useraccountslist.AllowUserToDeleteRows = false;
            this.useraccountslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useraccountslist.Location = new System.Drawing.Point(220, 110);
            this.useraccountslist.Name = "useraccountslist";
            this.useraccountslist.Size = new System.Drawing.Size(348, 216);
            this.useraccountslist.TabIndex = 8;
            // 
            // adminwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminwindow";
            this.Text = "adminwindow";
            this.Load += new System.EventHandler(this.adminwindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSessions)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountslist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addaccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
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
    }
}