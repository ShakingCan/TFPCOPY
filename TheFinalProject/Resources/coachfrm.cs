using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFinalProject.Resources
{
    public partial class coachfrm : Form
    {
        private int selectedPrimaryKey = -1;
       
        private int CurrentUserID;
        private int processingcount;
        private int upcomingcount;
        private string currentAccountName = "Loading...";
        public string AccountNameVar
        {
            get { return currentAccountName; }
            set { currentAccountName = value; }
        }
        public int ProcessingCount
        {
            get { return processingcount; }
            set { processingcount = value; }
        }
        public int UpcomingCount
        {
            get { return upcomingcount; }
            set { upcomingcount = value; }
        }
        string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
        public coachfrm()
        {
            InitializeComponent();
        }
        public coachfrm(int userid)
        {
            CurrentUserID = userid;
            InitializeComponent();
            // 1. Force the label to sit INSIDE the picture box layer
            this.accountname.Parent = this.pictureBox1;

            // 2. Now 'Transparent' will look directly at the gym banner image pixels
            this.accountname.BackColor = Color.Transparent;
            this.accountname.ForeColor = Color.White;
            this.Reminderbtn.Paint += new PaintEventHandler(Reminderbtn_Paint); 
        }

        private void sessionstoapprove_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clickedRow = sessionstoapprove.Rows[e.RowIndex];

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
                    sessionstoapprove.Invalidate();

                    // Optional: Test to see if it works!
                    if (selectedPrimaryKey != -1)
                    {
                        MessageBox.Show($"Selected Primary Key: {selectedPrimaryKey}");
                    }
                }
            }
        }
        private void sessionstoapprove_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
            int totalCount = UpcomingCount + ProcessingCount;

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
                string countText = totalCount.ToString();
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
        private void coachfrm_Load(object sender, EventArgs e)
        {
          
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
              
                conn.Open();

                
                string query = @"SELECT
                     br.RequestID AS RequestID,
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.USERID = u.ID
                    JOIN UsersNew c ON br.COACHID = c.ID
                    
                    WHERE br.COACHID = @CurrentUserID
                    AND br.UserApproved = 'Approved' 
                    AND br.CoachApproved = 'Approved'
                    And br.RequestDateTime >= GETDATE()
                    ORDER BY br.RequestDateTime ASC;       ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable upcomingSessionstable = new DataTable();

                    adapter.Fill(upcomingSessionstable);

                    upcomingsessionsdata.DataSource = upcomingSessionstable;
                    if (upcomingsessionsdata.Columns.Contains("RequestID"))
                    {
                        upcomingsessionsdata.Columns["RequestID"].Visible = false;
                    }

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
                string pastquery = @"SELECT
                     br.RequestID AS RequestID,
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.USERID = u.ID
                    JOIN UsersNew c ON br.COACHID = c.ID
                    
                    WHERE br.USERID = @CurrentUserID
                    AND br.UserApproved = 'Approved' 
                    AND br.CoachApproved = 'Approved'
                    And br.RequestDateTime < GETDATE()
                    ORDER BY br.RequestDateTime ASC;       ";

                using (SqlCommand cmd = new SqlCommand(pastquery, conn))
                {
                    cmd.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable pastSessionstable = new DataTable();
                    
                    adapter.Fill(pastSessionstable);

                    dataGridView2.DataSource = pastSessionstable;

                }
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\nAND (CoachApproved IS NULL OR CoachApproved = 'Pending') AND RequestDateTime >= GETDATE()";

                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show("Processing"+result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

           
                }

                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= GETDATE();";
                using (SqlCommand cmd = new SqlCommand(upcomingreminderquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();
                    MessageBox.Show("Upcominmg" + result.ToString());
                    UpcomingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                   
                }
                int totalcount = UpcomingCount + ProcessingCount;
                Reminderbtn.Text = "  Reminders";

                
                string sessionstoapprovequery = @"SELECT 
                     br.RequestID AS RequestID,
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.UserID = u.ID
                    JOIN UsersNew c ON br.CoachID = c.ID
                    WHERE br.CoachID = @CurrentUserID
                    AND (br.CoachApproved IS NULL OR br.CoachApproved = 'Pending')
                    AND RequestDateTime >= GETDATE();";
                using (SqlCommand cmd = new SqlCommand(sessionstoapprovequery, conn))
                {
                    cmd.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable Sessionstable = new DataTable();

                    adapter.Fill(Sessionstable);

                    sessionstoapprove.DataSource = Sessionstable;
                    MessageBox.Show("Session view refreshed");
                }

            }//the value isnt getting passed so its the damn curly braces

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
        public void refreshnotif()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //needs fixing
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\nAND (CoachApproved IS NULL OR CoachApproved = 'Pending') AND RequestDateTime >= GETDATE()";


                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show(result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                   
                }
                //needs fixing
                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= GETDATE();";

                using (SqlCommand cmd = new SqlCommand(upcomingreminderquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    UpcomingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    
                }
                int totalcount = UpcomingCount + ProcessingCount;
                Reminderbtn.Text = "  Reminders";


            }
        }
        private void RecordAttendance(int userID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
            SELECT COUNT(*)
            FROM Attendance
            WHERE UserID = @id
            AND LoginDate = @date";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", userID);
                checkCmd.Parameters.AddWithValue("@date", DateTime.Today);

                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string insertQuery = @"
                INSERT INTO Attendance (UserID, LoginDate)
                VALUES (@id, @date)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@id", userID);
                    insertCmd.Parameters.AddWithValue("@date", DateTime.Today);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        private void Reminderbtn_Click(object sender, EventArgs e)
        {
          
            refreshnotif();
        }
        private void TogglePanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }
        private void approvebtn_Click(object sender, EventArgs e)
        {
            int requestID;
           
            if (sessionstoapprove.CurrentRow == null)
            {
                MessageBox.Show("There are no sessions available to select.");
                return;
            }
            var selected = sessionstoapprove.CurrentRow.Cells["RequestID"].Value;
            if (selected == null || selected == DBNull.Value)
            {
                MessageBox.Show("Please select a row with values");
                return;
            }
            requestID = Convert.ToInt32(selected);
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string approvingquery = "UPDATE BookingRequests SET CoachApproved = 'Approved' WHERE RequestID = @requestID";
                using (SqlCommand cmd = new SqlCommand(approvingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.ExecuteNonQuery();

                    //debug shit
                    MessageBox.Show("Session approved");
                }



            }
            reloadSessions();
            refreshnotif();
        }

        private void declinebtn_Click(object sender, EventArgs e)
        {
            int requestID;
            if (sessionstoapprove.CurrentRow == null)
            {
                MessageBox.Show("There are no sessions available to select.");
                return;
            }
            var selected = sessionstoapprove.CurrentRow.Cells["RequestID"].Value;
            if (selected == null || selected == DBNull.Value)
            {
                MessageBox.Show("Please select a row with values");
                return;
            }
            requestID = Convert.ToInt32(selected);
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string approvingquery = "UPDATE BookingRequests SET CoachApproved = 'Rejected' WHERE RequestID = @requestID";
                using (SqlCommand cmd = new SqlCommand(approvingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.ExecuteNonQuery();

                    //debug shit
                    MessageBox.Show("Session rejected");
                }



            }
            reloadSessions();
            refreshnotif();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            reloadSessions();
            refreshnotif();

        }
        public void reloadSessions()
        {
            string sessionstoapprovequery = @"SELECT 
                     br.RequestID AS RequestID,
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.UserID = u.ID
                    JOIN UsersNew c ON br.CoachID = c.ID
                    WHERE br.CoachID = @CurrentUserID
                    AND (br.CoachApproved IS NULL OR br.CoachApproved = 'Pending')
                    AND RequestDateTime >= GETDATE();";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sessionstoapprovequery, conn))
                {
                    cmd.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable Sessionstable = new DataTable();

                    adapter.Fill(Sessionstable);

                    sessionstoapprove.DataSource = Sessionstable;
                    MessageBox.Show("Session view refreshed");
                }
            }
        }

        private void viewprofilebutton_Click(object sender, EventArgs e)
        {
            loginform lg = new loginform();
            lg.Show();
            this.Hide();
            refreshnotif();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}