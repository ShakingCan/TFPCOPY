using System;
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
    public partial class adminwindow : UserControl
    {
        private int processingcount;
        private int selectedPrimaryKey = -1;
        public int ProcessingCount
        {
            get { return processingcount; }
            set { processingcount = value; }
        }
        private string currentAccountName = "Loading...";
        public string AccountNameVar
        {
            get { return currentAccountName; }
            set { currentAccountName = value; }
        }
        private int CurrentUserID;
        List<string> allUsernames = new List<string>();
        string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";

        public adminwindow()
        {
            InitializeComponent();
            
        }
        public adminwindow(int currentId)
        {
            InitializeComponent();
            CurrentUserID = currentId;
            this.Reminderbtn.Paint += new PaintEventHandler(Reminderbtn_Paint);
            this.accountname.Parent = this.pictureBox1;

            // 2. Now 'Transparent' will look directly at the gym banner image pixels
            this.accountname.BackColor = Color.Transparent;
            this.accountname.ForeColor = Color.White;
        }
        private void viewprofilebutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            refreshnotif();
        }
        private void yourBackgroundContainer_Paint(object sender, PaintEventArgs e)
        {

            // 1. Forces the text edges to blend perfectly into the gritty gym photo
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 2. Set your white font styling to match the brand mockup
            using (Font font = new Font("Segoe UI", 14, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.White))
            {
                // 3. CRITICAL: Draw at (0, 0) so it paints cleanly inside the label boundaries,
                // instead of flying off-screen into the void!
                e.Graphics.DrawString(AccountNameVar, font, brush, 0, 0);
            }
        }

        private void AllSessions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clickedRow = AllSessions.Rows[e.RowIndex];

                if (clickedRow.Cells["RequestID"].Value != null)
                {
                    int clickedKey = Convert.ToInt32(clickedRow.Cells["RequestID"].Value);

                    // OPTIONAL "TOGGLE" LOGIC: 
                    // If they click the already checked row, uncheck it. Otherwise, check the new one.
                    if (selectedPrimaryKey == clickedKey)
                    {
                        selectedPrimaryKey = -1; // Clear selection
                    }
                    else
                    {
                        selectedPrimaryKey = clickedKey; // Set new selection
                    }

                    // Force the grid to redraw and display the checkbox immediately
                    AllSessions.Invalidate();

                    // Optional: Test to see if it works!
                    if (selectedPrimaryKey != -1)
                    {
                        
                    }
                }
            }
        }
        private void UserAccountList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clickedRow = useraccountslist.Rows[e.RowIndex];

                if (clickedRow.Cells["ID"].Value != null)
                {
                    int clickedKey = Convert.ToInt32(clickedRow.Cells["ID"].Value);

                    // OPTIONAL "TOGGLE" LOGIC: 
                    // If they click the already checked row, uncheck it. Otherwise, check the new one.
                    if (selectedPrimaryKey == clickedKey)
                    {
                        selectedPrimaryKey = -1; // Clear selection
                    }
                    else
                    {
                        selectedPrimaryKey = clickedKey; // Set new selection
                    }

                    // Force the grid to redraw and display the checkbox immediately
                    useraccountslist.Invalidate();

                    // Optional: Test to see if it works!
                    if (selectedPrimaryKey != -1)
                    {
                         
                    }
                }
            }
        }
        private void UserAccountList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                var row = grid.Rows[e.RowIndex];
                if (row.IsNewRow) return;

                if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int currentRowsKey))
                {
                    bool isSelected = (currentRowsKey == selectedPrimaryKey);

                    int glyphSize = 14; // Checkboxes look slightly cleaner a tiny bit smaller (14x14)
                    int x = e.RowBounds.Left + (grid.RowHeadersWidth - glyphSize) / 2;
                    int y = e.RowBounds.Top + (row.Height - glyphSize) / 2;

                    // Swapped to DrawCheckBox
                    ButtonState state = isSelected ? ButtonState.Checked : ButtonState.Normal;
                    ControlPaint.DrawCheckBox(e.Graphics, x, y, glyphSize, glyphSize, state);
                }
            }
        }
        private void AllSessions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                var row = grid.Rows[e.RowIndex];
                if (row.IsNewRow) return;

                if (row.Cells["RequestID"].Value != null && int.TryParse(row.Cells["RequestID"].Value.ToString(), out int currentRowsKey))
                {
                    bool isSelected = (currentRowsKey == selectedPrimaryKey);

                    int glyphSize = 14; // Checkboxes look slightly cleaner a tiny bit smaller (14x14)
                    int x = e.RowBounds.Left + (grid.RowHeadersWidth - glyphSize) / 2;
                    int y = e.RowBounds.Top + (row.Height - glyphSize) / 2;

                    // Swapped to DrawCheckBox
                    ButtonState state = isSelected ? ButtonState.Checked : ButtonState.Normal;
                    ControlPaint.DrawCheckBox(e.Graphics, x, y, glyphSize, glyphSize, state);
                }
            }
        }

        private void Reminderbtn_Paint(object sender, PaintEventArgs e)
        {
            refreshnotif();
            int totalCount = ProcessingCount;

            // Only draw the red badge if there are actually pending/upcoming notifications!
            if (totalCount > 0)
            {
                // Smooth out the circle edges so it looks clean and modern
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 1. Define the size and position of the red circle
                int circleRadius = 18;
                int x = this.Reminderbtn.Width - circleRadius - 5; // 6 pixels off the right edge
                int y = 8;                                        // 4 pixels down from the top edge

                // 2. Draw the solid red circle
                using (Brush redBrush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillEllipse(redBrush, x, y, circleRadius, circleRadius);
                }

                // 3. Draw the count number right inside the circle
                string countText = ProcessingCount.ToString();
                using (Font font = new Font("Segoe UI", 9, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    // Measure the text size so we can center it perfectly inside the circle
                    SizeF textSize = e.Graphics.MeasureString(countText, font);
                    float textX = x + (circleRadius - textSize.Width) / 2;
                    float textY = y + (circleRadius - textSize.Height) / 2;

                    e.Graphics.DrawString(countText, font, textBrush, textX, textY);
                }
            }
        }

        public void refreshnotif()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string notifquery = @"SELECT COUNT(*) FROM BookingRequests WHERE (Status = 'Pending' OR Status IS NULL) AND RequestDateTime >= GETDATE()";

                using (SqlCommand cmd = new SqlCommand(notifquery, conn))
                {

                    object result = cmd.ExecuteScalar();

                   

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    
                }

            }
        }

        private void adminwindow_Load(object sender, EventArgs e)
        {
            Reminderbtn.Text = "  Reminders";
            refreshnotif();
            //this query needs adjustment
            using (SqlConnection conn = new SqlConnection(connectionString)) {
               conn.Open();
                string notifquery = @"SELECT COUNT(*) FROM BookingRequests WHERE (Status = 'Pending' OR Status IS NULL) AND RequestDateTime >= GETDATE()";

                using (SqlCommand cmd = new SqlCommand(notifquery, conn))
                {

                    object result = cmd.ExecuteScalar();

                   

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);


                }

                string usernamequery = "SELECT username FROM UsersNew WHERE ID = @userid";
                using (SqlCommand command = new SqlCommand(usernamequery, conn))
                {
                    command.Parameters.AddWithValue("userid", CurrentUserID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = reader["username"].ToString();
                            accountname.Text = username;
                            AccountNameVar = username;
                        }
                    }

                }
                this.accountname.Invalidate();

                string query = @"
SELECT 
    br.RequestID,
    u.username AS Client,
    c.username AS Coach,
    br.RequestDateTime AS Schedule,
    br.Status,
    br.Duration,
    br.UserApproved AS 'User Confirmation',
    br.CoachApproved AS 'Coach Approval'
FROM BookingRequests br
LEFT JOIN UsersNew u ON br.USERID = u.ID
LEFT JOIN UsersNew c ON br.COACHID = c.ID
WHERE RequestDateTime >= GETDATE()

ORDER BY 
    CASE Status
        WHEN 'Pending' THEN 1
        WHEN 'Approved' THEN 2
        WHEN 'Rejected' THEN 3
        ELSE 4
    END";

                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    AllSessions.DataSource = dt;

                    if (AllSessions.Columns.Contains("RequestID"))
                    {
                        AllSessions.Columns["RequestID"].Visible = false;
                    }
                }




            }
            /*
              string query = @"SELECT 
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.UserID = u.ID
                    JOIN UsersNew c ON br.CoachID = c.ID
                    
                    WHERE br.UserID = @CurrentUserID
                    AND br.UserApproved = 'Approved' 
                    AND br.CoachApproved = 'Approved'
                    And br.RequestDateTime >= GETDATE()
                    ORDER BY br.RequestDateTime ASC;       ";
             */


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT username FROM UsersNew WHERE role = 'coach'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allUsernames.Add(reader["username"].ToString());
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.Items.AddRange(allUsernames.ToArray());
            MessageBox.Show(allUsernames.Count.ToString());



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string alluserquery = "SELECT ID,username,role FROM UsersNew WHERE role <> 'Admin' ORDER BY role";

                using (SqlCommand cmd = new SqlCommand(alluserquery, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    useraccountslist.DataSource = dt;
                    if (useraccountslist.Columns.Contains("RequestID"))
                    {
                        useraccountslist.Columns["RequestID"].Visible = false;
                    }

                }



            }
            //adjust this one 
              string processingquery = @"SELECT COUNT(*) FROM BookingRequests WHERE (Status = 'Pending' OR Status IS NULL) AND RequestDateTime >= GETDATE()";
            using (SqlConnection con = new SqlConnection(connectionString))
            {con.Open();
                using (SqlCommand cmd = new SqlCommand(processingquery, con))
                {
                    

                    object result = cmd.ExecuteScalar();

                    

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                  
                }
            }
            int totalcount = ProcessingCount;
            Reminderbtn.Text = "  Reminders";



        }

        private void approve_Click(object sender, EventArgs e)
        {
          


            if (AllSessions.CurrentRow != null)
            {

                int requestID = Convert.ToInt32(
                     AllSessions.CurrentRow.Cells["RequestID"].Value);

             
                

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE BookingRequests SET Status = 'Approved' WHERE RequestID = @requestID; ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@requestID", requestID);
                        cmd.ExecuteNonQuery();

                    }
                MessageBox.Show("Session approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSessions();
                }
            }
            else
            {
                MessageBox.Show("Please select a row first");
                return;
            }



        }

        private void reject_Click(object sender, EventArgs e)
        {
            if (AllSessions.CurrentRow != null)
            {

                int requestID = Convert.ToInt32(
                     AllSessions.CurrentRow.Cells["RequestID"].Value);


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE BookingRequests SET Status = 'Rejected' WHERE RequestID = @requestID; ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@requestID", requestID);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Session rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSessions();

                }
            }
            else
            {
                MessageBox.Show("Please select a row first");
                return;
            }
        }

        private void resetStatus_Click(object sender, EventArgs e)
        {
           
            if (AllSessions.CurrentRow != null)
            {

                int requestID = Convert.ToInt32(
                     AllSessions.CurrentRow.Cells["RequestID"].Value);


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE BookingRequests SET Status = 'Pending' WHERE RequestID = @requestID; ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@requestID", requestID);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Status reset successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSessions();


                }
            }
            else
            {
                MessageBox.Show("Please select a row first");
                return;
            }
        
    }
        public void loadSessions()
        {
             refreshnotif();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
SELECT 
     br.RequestID,
    u.username AS Client,
    c.username AS Coach,
    br.RequestDateTime AS Schedule,
    br.Status,
    br.Duration,
    br.UserApproved AS 'User Confirmation',
    br.CoachApproved AS 'Coach Approval'
FROM BookingRequests br
LEFT JOIN UsersNew u ON br.USERID = u.ID
LEFT   JOIN UsersNew c ON br.COACHID = c.ID
WHERE RequestDateTime >= GETDATE()
ORDER BY 
    CASE Status
        WHEN 'Pending' THEN 1
        WHEN 'Approved' THEN 2
        WHEN 'Rejected' THEN 3
        ELSE 4
    END";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable Sessionstable = new DataTable();

                    adapter.Fill(Sessionstable);

                    AllSessions.DataSource = Sessionstable;
                    if (AllSessions.Columns.Contains("RequestID"))
                    {
                        AllSessions.Columns["RequestID"].Visible = false;
                    }
                    MessageBox.Show("Session view refreshed");
                }



            }
        }

        private void reassign_Click(object sender, EventArgs e)
        {

            if (AllSessions.CurrentRow != null)
            { panel2.Visible = true; }
            else { MessageBox.Show("Please select a row first"); }
               
                
            }
       
           


        

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {

            int requestID = Convert.ToInt32(AllSessions.CurrentRow.Cells["RequestID"].Value);


            string coachname = comboBox1.GetItemText(comboBox1.SelectedItem);
            int COACHID;
            string retrieveCOACHID = "SELECT ID FROM UsersNew WHERE username = @coachname";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String query = "UPDATE BookingRequests SET CoachID = @COACHID WHERE RequestID = @requestID";
                conn.Open();
              
                using (SqlCommand retriever = new SqlCommand(retrieveCOACHID, conn))
                {
                    retriever.Parameters.AddWithValue("@coachname", coachname);
                    
                    retriever.ExecuteNonQuery();
                    object result = retriever.ExecuteScalar();
                    COACHID = Convert.ToInt32(result);
                    
                }


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@COACHID", COACHID);
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.ExecuteNonQuery();


                }


            }
            MessageBox.Show("Reassignment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel2.Visible = false;
            loadSessions();

        }

        private void addaccount_Click(object sender, EventArgs e)
        {
            
            registerform rf = new registerform();
            rf.Dock = DockStyle.Fill;

            panel1.Controls.Add(rf);
            rf.Visible = true;
            rf.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerform rf = new registerform();
            rf.Visible = true;
            this.Hide();
        }

        private void removeaccbtn_Click(object sender, EventArgs e)
        { var selected = useraccountslist.CurrentRow.Cells["ID"].Value;
            if (selected == null) {
                MessageBox.Show("Please select a row first");
                return;
            }
            int IDvalue = Convert.ToInt32(selected);
            String query = "DELETE FROM UsersNew WHERE ID = @ID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@ID", IDvalue);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Optionally, remove the row from the DataGridView to reflect the change
                        useraccountslist.Rows.RemoveAt(useraccountslist.CurrentRow.Index);
                        MessageBox.Show("Account successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No accounts selectedd.");
                    }
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reminderbtn_Click_1(object sender, EventArgs e)
        {
            refreshnotif();
            MessageBox.Show("You have "+processingcount + " session to process", "Reminders", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void TogglePanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            // Colors from your mockup
            Color activeColor = Color.FromArgb(100, 100, 100); // Dark Gray
            Color inactiveColor = Color.FromArgb(220, 220, 220); // Light Gray
            Color textColor = Color.White;

            TabPage page = tabControl1.TabPages[e.Index];
            Rectangle tabBounds = tabControl1.GetTabRect(e.Index);

            // Check if the tab is selected
            if (e.State == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(activeColor), tabBounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(inactiveColor), tabBounds);
                textColor = Color.Black; // Inactive tabs usually have dark text
            }

            // Draw the text in the middle
            TextRenderer.DrawText(e.Graphics, page.Text, page.Font, tabBounds, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {   
                con.Open();
                string alluserquery = "SELECT ID,username,role FROM UsersNew WHERE role <> 'Admin' ORDER BY role";

                using (SqlCommand cmd = new SqlCommand(alluserquery, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    useraccountslist.DataSource = dt;
                    if (useraccountslist.Columns.Contains("RequestID"))
                    {
                        useraccountslist.Columns["RequestID"].Visible = false;
                    }

                }



            }
        }
    }

       
    }
