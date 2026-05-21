namespace TheFinalProject.Resources
{
    partial class Userfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usermainpanel = new System.Windows.Forms.Panel();
            this.accountname = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mybookingstab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Pendingsessionspanel = new System.Windows.Forms.Panel();
            this.upcomingsessionsdata = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.sessionbookingstab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.durationguide = new System.Windows.Forms.Label();
            this.durationbox = new System.Windows.Forms.ComboBox();
            this.requestdateguide = new System.Windows.Forms.Label();
            this.coachguide = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sessionstoapprovetab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Reminderbtn = new System.Windows.Forms.Button();
            this.viewprofilebutton = new System.Windows.Forms.Button();
            this.Confirmbook = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.declinebtn = new System.Windows.Forms.Button();
            this.approvebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usermainpanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mybookingstab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Pendingsessionspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingsessionsdata)).BeginInit();
            this.sessionbookingstab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sessionstoapprovetab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usermainpanel
            // 
            this.usermainpanel.Controls.Add(this.pictureBox2);
            this.usermainpanel.Controls.Add(this.accountname);
            this.usermainpanel.Controls.Add(this.Reminderbtn);
            this.usermainpanel.Controls.Add(this.viewprofilebutton);
            this.usermainpanel.Controls.Add(this.tabControl1);
            this.usermainpanel.Controls.Add(this.pictureBox1);
            this.usermainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usermainpanel.Location = new System.Drawing.Point(0, 0);
            this.usermainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.usermainpanel.Name = "usermainpanel";
            this.usermainpanel.Size = new System.Drawing.Size(984, 511);
            this.usermainpanel.TabIndex = 0;
            // 
            // accountname
            // 
            this.accountname.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.accountname.Location = new System.Drawing.Point(603, 17);
            this.accountname.Name = "accountname";
            this.accountname.Size = new System.Drawing.Size(242, 35);
            this.accountname.TabIndex = 33;
            this.accountname.Text = "label2";
            this.accountname.Paint += new System.Windows.Forms.PaintEventHandler(this.yourBackgroundContainer_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.mybookingstab);
            this.tabControl1.Controls.Add(this.sessionbookingstab);
            this.tabControl1.Controls.Add(this.sessionstoapprovetab);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(140, 40);
            this.tabControl1.Location = new System.Drawing.Point(-7, 122);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 399);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem_1);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // mybookingstab
            // 
            this.mybookingstab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mybookingstab.Controls.Add(this.panel1);
            this.mybookingstab.Controls.Add(this.Pendingsessionspanel);
            this.mybookingstab.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.mybookingstab.Location = new System.Drawing.Point(4, 44);
            this.mybookingstab.Margin = new System.Windows.Forms.Padding(2);
            this.mybookingstab.Name = "mybookingstab";
            this.mybookingstab.Padding = new System.Windows.Forms.Padding(2);
            this.mybookingstab.Size = new System.Drawing.Size(992, 351);
            this.mybookingstab.TabIndex = 0;
            this.mybookingstab.Text = "My bookings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(492, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 347);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 44;
            this.dataGridView2.Size = new System.Drawing.Size(481, 310);
            this.dataGridView2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
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
            this.Pendingsessionspanel.Size = new System.Drawing.Size(473, 340);
            this.Pendingsessionspanel.TabIndex = 11;
            // 
            // upcomingsessionsdata
            // 
            this.upcomingsessionsdata.AllowUserToAddRows = false;
            this.upcomingsessionsdata.AllowUserToDeleteRows = false;
            this.upcomingsessionsdata.AllowUserToResizeColumns = false;
            this.upcomingsessionsdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.upcomingsessionsdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.upcomingsessionsdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.upcomingsessionsdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.upcomingsessionsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.upcomingsessionsdata.DefaultCellStyle = dataGridViewCellStyle24;
            this.upcomingsessionsdata.EnableHeadersVisualStyles = false;
            this.upcomingsessionsdata.Location = new System.Drawing.Point(-1, 32);
            this.upcomingsessionsdata.Name = "upcomingsessionsdata";
            this.upcomingsessionsdata.RowHeadersVisible = false;
            this.upcomingsessionsdata.RowTemplate.Height = 44;
            this.upcomingsessionsdata.Size = new System.Drawing.Size(474, 308);
            this.upcomingsessionsdata.TabIndex = 8;
            this.upcomingsessionsdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upcomingsessionsdata_CellContentClick);
            this.upcomingsessionsdata.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.upcomingsessionsdata_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upcoming Sessions";
            // 
            // sessionbookingstab
            // 
            this.sessionbookingstab.Controls.Add(this.panel3);
            this.sessionbookingstab.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.sessionbookingstab.Location = new System.Drawing.Point(4, 44);
            this.sessionbookingstab.Margin = new System.Windows.Forms.Padding(2);
            this.sessionbookingstab.Name = "sessionbookingstab";
            this.sessionbookingstab.Padding = new System.Windows.Forms.Padding(2);
            this.sessionbookingstab.Size = new System.Drawing.Size(935, 300);
            this.sessionbookingstab.TabIndex = 1;
            this.sessionbookingstab.Text = "Session booking";
            this.sessionbookingstab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.durationguide);
            this.panel3.Controls.Add(this.durationbox);
            this.panel3.Controls.Add(this.requestdateguide);
            this.panel3.Controls.Add(this.coachguide);
            this.panel3.Controls.Add(this.searchbox);
            this.panel3.Controls.Add(this.Confirmbook);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(308, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 273);
            this.panel3.TabIndex = 28;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // durationguide
            // 
            this.durationguide.AutoSize = true;
            this.durationguide.Location = new System.Drawing.Point(126, 215);
            this.durationguide.Name = "durationguide";
            this.durationguide.Size = new System.Drawing.Size(50, 20);
            this.durationguide.TabIndex = 25;
            this.durationguide.Text = "label6";
            this.durationguide.Visible = false;
            // 
            // durationbox
            // 
            this.durationbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.durationbox.FormattingEnabled = true;
            this.durationbox.Items.AddRange(new object[] {
            "30 mins",
            "1 hr",
            "1 hr 30 mins",
            "2 hrs",
            "2 hr 30 mins",
            "3 hr"});
            this.durationbox.Location = new System.Drawing.Point(74, 189);
            this.durationbox.Name = "durationbox";
            this.durationbox.Size = new System.Drawing.Size(147, 25);
            this.durationbox.TabIndex = 24;
            // 
            // requestdateguide
            // 
            this.requestdateguide.AutoSize = true;
            this.requestdateguide.Location = new System.Drawing.Point(125, 157);
            this.requestdateguide.Name = "requestdateguide";
            this.requestdateguide.Size = new System.Drawing.Size(50, 20);
            this.requestdateguide.TabIndex = 23;
            this.requestdateguide.Text = "label6";
            this.requestdateguide.Visible = false;
            // 
            // coachguide
            // 
            this.coachguide.AutoSize = true;
            this.coachguide.Location = new System.Drawing.Point(125, 98);
            this.coachguide.Name = "coachguide";
            this.coachguide.Size = new System.Drawing.Size(50, 20);
            this.coachguide.TabIndex = 22;
            this.coachguide.Text = "label6";
            this.coachguide.Visible = false;
            // 
            // searchbox
            // 
            this.searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchbox.BackColor = System.Drawing.SystemColors.Control;
            this.searchbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchbox.FormattingEnabled = true;
            this.searchbox.Location = new System.Drawing.Point(74, 71);
            this.searchbox.Margin = new System.Windows.Forms.Padding(2);
            this.searchbox.MaxLength = 10;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(147, 25);
            this.searchbox.TabIndex = 2;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Session booking";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(102, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select coach";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(109, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Select date";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(95, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Select duration";
            // 
            // sessionstoapprovetab
            // 
            this.sessionstoapprovetab.Controls.Add(this.refreshbtn);
            this.sessionstoapprovetab.Controls.Add(this.declinebtn);
            this.sessionstoapprovetab.Controls.Add(this.approvebtn);
            this.sessionstoapprovetab.Controls.Add(this.dataGridView1);
            this.sessionstoapprovetab.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.sessionstoapprovetab.Location = new System.Drawing.Point(4, 44);
            this.sessionstoapprovetab.Name = "sessionstoapprovetab";
            this.sessionstoapprovetab.Padding = new System.Windows.Forms.Padding(3);
            this.sessionstoapprovetab.Size = new System.Drawing.Size(935, 300);
            this.sessionstoapprovetab.TabIndex = 2;
            this.sessionstoapprovetab.Text = "Sessions to approve";
            this.sessionstoapprovetab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pictureBox2.BackgroundImage = global::TheFinalProject.Properties.Resources.white_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(861, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 62);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // Reminderbtn
            // 
            this.Reminderbtn.BackgroundImage = global::TheFinalProject.Properties.Resources.logoutbtn;
            this.Reminderbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reminderbtn.FlatAppearance.BorderSize = 0;
            this.Reminderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reminderbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Reminderbtn.ForeColor = System.Drawing.Color.White;
            this.Reminderbtn.Location = new System.Drawing.Point(725, 55);
            this.Reminderbtn.Name = "Reminderbtn";
            this.Reminderbtn.Size = new System.Drawing.Size(120, 33);
            this.Reminderbtn.TabIndex = 21;
            this.Reminderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reminderbtn.UseVisualStyleBackColor = true;
            this.Reminderbtn.Click += new System.EventHandler(this.Reminderbtn_Click);
            // 
            // viewprofilebutton
            // 
            this.viewprofilebutton.BackgroundImage = global::TheFinalProject.Properties.Resources.logoutbtn;
            this.viewprofilebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewprofilebutton.FlatAppearance.BorderSize = 0;
            this.viewprofilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewprofilebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.viewprofilebutton.ForeColor = System.Drawing.Color.White;
            this.viewprofilebutton.Location = new System.Drawing.Point(599, 55);
            this.viewprofilebutton.Margin = new System.Windows.Forms.Padding(2);
            this.viewprofilebutton.Name = "viewprofilebutton";
            this.viewprofilebutton.Size = new System.Drawing.Size(120, 33);
            this.viewprofilebutton.TabIndex = 16;
            this.viewprofilebutton.Text = "logout";
            this.viewprofilebutton.UseVisualStyleBackColor = true;
            this.viewprofilebutton.Click += new System.EventHandler(this.viewprofilebutton_Click);
            // 
            // Confirmbook
            // 
            this.Confirmbook.BackgroundImage = global::TheFinalProject.Properties.Resources.confirmbook;
            this.Confirmbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirmbook.FlatAppearance.BorderSize = 0;
            this.Confirmbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmbook.Location = new System.Drawing.Point(42, 234);
            this.Confirmbook.Margin = new System.Windows.Forms.Padding(2);
            this.Confirmbook.Name = "Confirmbook";
            this.Confirmbook.Size = new System.Drawing.Size(207, 33);
            this.Confirmbook.TabIndex = 3;
            this.Confirmbook.UseVisualStyleBackColor = true;
            this.Confirmbook.Click += new System.EventHandler(this.Confirmbook_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.White;
            this.refreshbtn.BackgroundImage = global::TheFinalProject.Properties.Resources.approvebtn;
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.Location = new System.Drawing.Point(222, 257);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(96, 37);
            this.refreshbtn.TabIndex = 19;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // declinebtn
            // 
            this.declinebtn.BackColor = System.Drawing.Color.White;
            this.declinebtn.BackgroundImage = global::TheFinalProject.Properties.Resources.approvebtn;
            this.declinebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.declinebtn.FlatAppearance.BorderSize = 0;
            this.declinebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declinebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.declinebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.declinebtn.Location = new System.Drawing.Point(121, 257);
            this.declinebtn.Margin = new System.Windows.Forms.Padding(2);
            this.declinebtn.Name = "declinebtn";
            this.declinebtn.Size = new System.Drawing.Size(97, 37);
            this.declinebtn.TabIndex = 18;
            this.declinebtn.Text = "Decline";
            this.declinebtn.UseVisualStyleBackColor = false;
            this.declinebtn.Click += new System.EventHandler(this.declinebtn_Click);
            // 
            // approvebtn
            // 
            this.approvebtn.BackgroundImage = global::TheFinalProject.Properties.Resources.approvebtn;
            this.approvebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.approvebtn.FlatAppearance.BorderSize = 0;
            this.approvebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approvebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvebtn.ForeColor = System.Drawing.Color.White;
            this.approvebtn.Location = new System.Drawing.Point(18, 257);
            this.approvebtn.Margin = new System.Windows.Forms.Padding(2);
            this.approvebtn.Name = "approvebtn";
            this.approvebtn.Size = new System.Drawing.Size(99, 37);
            this.approvebtn.TabIndex = 17;
            this.approvebtn.Text = "Approve";
            this.approvebtn.UseVisualStyleBackColor = true;
            this.approvebtn.Click += new System.EventHandler(this.approvebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheFinalProject.Properties.Resources.banner;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 138);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Userfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.usermainpanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Userfrm";
            this.Text = "Userfrm";
            this.Load += new System.EventHandler(this.Userfrm_Load);
            this.usermainpanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mybookingstab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Pendingsessionspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upcomingsessionsdata)).EndInit();
            this.sessionbookingstab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sessionstoapprovetab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel usermainpanel;
        private System.Windows.Forms.Button Reminderbtn;
        private System.Windows.Forms.Button viewprofilebutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mybookingstab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pendingsessionspanel;
        private System.Windows.Forms.DataGridView upcomingsessionsdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage sessionbookingstab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label durationguide;
        private System.Windows.Forms.ComboBox durationbox;
        private System.Windows.Forms.Label requestdateguide;
        private System.Windows.Forms.Label coachguide;
        private System.Windows.Forms.ComboBox searchbox;
        private System.Windows.Forms.Button Confirmbook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage sessionstoapprovetab;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button declinebtn;
        private System.Windows.Forms.Button approvebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label accountname;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}