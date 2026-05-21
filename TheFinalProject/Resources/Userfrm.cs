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

namespace TheFinalProject.Resources
{
    public partial class Userfrm : Form
    {
        private int selectedPrimaryKey = -1;
        string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
        private string currentAccountName = "Loading...";
        public string AccountNameVar
        {
            get { return currentAccountName; }
            set { currentAccountName = value; }
        }

        private int upcomingcount;
        private int processingcount;
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
        private int CurrentUserID;

        List<string> allUsernames = new List<string>();
        public Userfrm(int userId)
        {
            InitializeComponent();
            CurrentUserID = userId;
            // 1. Force the label to sit INSIDE the picture box layer
            this.accountname.Parent = this.pictureBox1;

            // 2. Now 'Transparent' will look directly at the gym banner image pixels
            this.accountname.BackColor = Color.Transparent;
            this.accountname.ForeColor = Color.White;

            this.Reminderbtn.Paint += new PaintEventHandler(Reminderbtn_Paint);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";


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
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            coachguide.Visible = false;
            string input = searchbox.Text.ToLower();

            searchbox.Items.Clear();

            foreach (var name in allUsernames)
            {
                if (name.ToLower().Contains(input))
                {
                    searchbox.Items.Add(name);
                }
            }

            searchbox.SelectionStart = searchbox.Text.Length;
            searchbox.DroppedDown = true;


        }

        private void Userfrm_Load(object sender, EventArgs e)
        {



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


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            searchbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchbox.DropDownStyle = ComboBoxStyle.DropDown;
            searchbox.Items.AddRange(allUsernames.ToArray());
            MessageBox.Show(allUsernames.Count.ToString());


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
                    
                    WHERE br.USERID = @CurrentUserID
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
                    if (dataGridView2.Columns.Contains("RequestID"))
                    {
                        dataGridView2.Columns["RequestID"].Visible = false;
                    }

                }
                //notif queries
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\nAND (UserApproved IS NULL OR UserApproved <> 'Approved')";

                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show(result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);


                }
                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= CAST(GETDATE() AS DATE);";

                using (SqlCommand cmd = new SqlCommand(upcomingreminderquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();
                    MessageBox.Show(result.ToString());

                    UpcomingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);


                }
                int totalcount = UpcomingCount + ProcessingCount;
                Reminderbtn.Text = "  Reminders";



            }

            loadSessions();

            //implement data tables for upcoming sessions grid and past sessions


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
        public void refreshnotif()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\nAND (UserApproved IS NULL OR UserApproved <> 'Approved') AND RequestDateTime = GETDATE()";

                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show(result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);


                }
                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= GETDATE();";

                using (SqlCommand cmd = new SqlCommand(upcomingreminderquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();
                    MessageBox.Show(result.ToString());

                    UpcomingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);


                }
                int totalcount = UpcomingCount + ProcessingCount;
                Reminderbtn.Text = "  Reminders";
            }
        }
        private void searchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmbook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchbox.Text))
            {
                coachguide.Visible = true;
                coachguide.Text = "Please enter a coach name!";
                coachguide.ForeColor = Color.Red;
                return;
            }
            if (dateTimePicker1.Value < DateTime.Now.AddHours(1))
            {
                requestdateguide.Visible = true;
                requestdateguide.Text = "Please select a future date or at least 1 hour from now!";
                requestdateguide.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(durationbox.Text) || string.IsNullOrWhiteSpace(durationbox.Text))
            {

                durationguide.Visible = true;
                durationguide.Text = "Please select a session duration!";
                durationguide.ForeColor = Color.Red;
                return;

            }


            if (!string.IsNullOrWhiteSpace(searchbox.Text) && dateTimePicker1.Value >= DateTime.Now.AddHours(1))
            {
                int coachId;

                string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        String identificationQuery = "SELECT ID FROM UsersNew WHERE username = @username";

                        using (SqlCommand cmd = new SqlCommand(identificationQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", searchbox.Text.Trim());
                            object result = cmd.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show("Coach not found!");
                                return;
                            }
                            else
                            {
                                coachId = Convert.ToInt32(result);
                            }


                        }
                        string checkQuery = @"SELECT COUNT(*) FROM BookingRequests WHERE COACHID = @coachId AND (@newTime BETWEEN RequestDateTime AND DATEADD(HOUR, 3, RequestDateTime) OR DATEADD(HOUR, 3, @newTime) BETWEEN RequestDateTime AND DATEADD(HOUR, 3, RequestDateTime))";
                        using (SqlCommand command = new SqlCommand(checkQuery, conn))
                        {
                            command.Parameters.AddWithValue("@CoachID", coachId);
                            command.Parameters.AddWithValue("@RequestDate", dateTimePicker1.Value);
                            command.Parameters.AddWithValue("@newTime", dateTimePicker1.Value);
                            int result = (int)command.ExecuteScalar();
                            if (result > 0)
                            {
                                MessageBox.Show("Please set the time to be 3 hours ahead from now");
                                return;
                            }
                        }
                        String query = "INSERT INTO BookingRequests(USERID, COACHID,RequestDateTime, Duration) VALUES (@UserID, @CoachID, @RequestDate,@Duration)";
                        using (SqlCommand cmd2 = new SqlCommand(query, conn))
                        {
                            cmd2.Parameters.AddWithValue("@Duration", durationbox.Text.ToString());
                            cmd2.Parameters.AddWithValue("@UserID", CurrentUserID);
                            cmd2.Parameters.AddWithValue("@CoachID", coachId);
                            cmd2.Parameters.AddWithValue("@RequestDate", dateTimePicker1.Value);
                            cmd2.ExecuteNonQuery();

                            //debug shit
                            MessageBox.Show("Booking request sent successfully!");


                        }

                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }


            refreshnotif();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            requestdateguide.Visible = false;


        }
        private void sessionstoapprove_Load(object sender, EventArgs e)
        {

        }
        //this will also be used in the coach feature
        private void approvebtn_Click(object sender, EventArgs e)
        {
            int requestID;
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("There are no sessions available to select.");
                return;
            }
            var selected = dataGridView1.CurrentRow.Cells["RequestID"].Value;
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
                string approvingquery = "UPDATE BookingRequests SET UserApproved = 'Approved' WHERE RequestID = @requestID";
                using (SqlCommand cmd = new SqlCommand(approvingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.ExecuteNonQuery();

                    //debug shit
                    MessageBox.Show("Session approved");
                }



            }
            refreshnotif();


        }

        private void declinebtn_Click(object sender, EventArgs e)
        {
            int requestID;
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("There are no sessions available to select.");
                return;
            }
            var selected = dataGridView1.CurrentRow.Cells["RequestID"].Value;
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
                string approvingquery = "UPDATE BookingRequests SET UserApproved = 'Declined' WHERE RequestID = @requestID";
                using (SqlCommand cmd = new SqlCommand(approvingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.ExecuteNonQuery();

                    //debug shit
                    MessageBox.Show("Session declined");
                }



            }
            refreshnotif();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {

            loadSessions();
            refreshnotif();
        }



        public void loadSessions()
        {
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                     br.RequestID AS RequestID,
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.UserID = u.ID
                    JOIN UsersNew c ON br.CoachID = c.ID
                    WHERE br.UserID = @CurrentUserID
                    AND br.UserApproved IS NULL;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CurrentUserID", CurrentUserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable Sessionstable = new DataTable();

                    adapter.Fill(Sessionstable);

                    dataGridView1.DataSource = Sessionstable;
                    MessageBox.Show("Session view refreshed");
                }



            }
        }
        public void loadUpcomingSessions()
        {

        }
        private void ExecuteUserAction(int requestID, string actionName, string sqlQuery)
        {
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.ExecuteNonQuery();

                    // Your debug alert showing exactly what row did what
                    MessageBox.Show($"Session {actionName.ToLower()} successfully!");
                }
            }

            // Refresh notifications and reload the grid data immediately so the approved/declined row disappears/updates
            refreshnotif();
            loadSessions();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ignore clicks on the header row (-1)
            if (e.RowIndex < 0) return;

            // 2. Safely extract the RequestID from the row where the button was clicked
            var selectedValue = dataGridView1.Rows[e.RowIndex].Cells["RequestID"].Value;
            if (selectedValue == null || selectedValue == DBNull.Value)
            {
                MessageBox.Show("Please select a valid row with session values.");
                return;
            }
            int requestID = Convert.ToInt32(selectedValue);

            // 3. Check if they clicked the APPROVE (Check ✔️) column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ApproveAction")
            {
                ExecuteUserAction(requestID, "Approved", "UPDATE BookingRequests SET UserApproved = 'Approved' WHERE RequestID = @requestID");
            }

            // 4. Check if they clicked the DECLINE (X ❌) column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "RejectAction")
            {
                // Note: Using 'UserApproved' here instead of 'UserApprovedx' just in case that 'x' was a typo in your database column name!
                ExecuteUserAction(requestID, "Declined", "UPDATE BookingRequests SET UserApproved = 'Declined' WHERE RequestID = @requestID");
            }
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                     br.RequestID AS RequestID,
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.UserID = u.ID
                    JOIN UsersNew c ON br.CoachID = c.ID
                    WHERE br.UserID = @CurrentUserID
                    AND br.UserApproved IS NULL;   ";

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchbox.Text))
            {
                coachguide.Visible = true;
                coachguide.Text = "Please enter a coach name!";
                coachguide.ForeColor = Color.Red;
                return;
            }
            if (dateTimePicker1.Value < DateTime.Now.AddHours(1))
            {
                requestdateguide.Visible = true;
                requestdateguide.Text = "Please select a future date or at least 1 hour from now!";
                requestdateguide.ForeColor = Color.Red;
                return;
            }

            if (!string.IsNullOrWhiteSpace(searchbox.Text) && dateTimePicker1.Value >= DateTime.Now.AddHours(1))
            {
                int coachId;
                string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        //FIX THIS SHIT 



                        String identificationQuery = "SELECT ID FROM UsersNew WHERE username = @username";


                        using (SqlCommand cmd = new SqlCommand(identificationQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", searchbox.Text.Trim());
                            object result = cmd.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show("Coach not found!");
                                return;
                            }
                            else
                            {
                                coachId = Convert.ToInt32(result);
                            }


                        }
                        String query = "INSERT INTO BookingRequests(USERID, COACHID,RequestDateTime) VALUES (@UserID, @CoachID, @RequestDate)";
                        using (SqlCommand cmd2 = new SqlCommand(query, conn))
                        {
                            cmd2.Parameters.AddWithValue("@UserID", CurrentUserID);
                            cmd2.Parameters.AddWithValue("@CoachID", coachId);
                            cmd2.Parameters.AddWithValue("@RequestDate", dateTimePicker1.Value);
                            cmd2.ExecuteNonQuery();

                            //debug shit
                            MessageBox.Show("Booking request sent successfully!");


                        }

                    }

                    refreshnotif();


                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("This coach already had a schedule for this time. Please choose another time or another coach.");
                        return;
                    }
                    else
                    {
                        return;
                    }

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

        private void upcomingsessionsdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void Reminderbtn_Click(object sender, EventArgs e)
        {

            refreshnotif();
        }
        private void TogglePanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        private void upcomingsessionsdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                approvebtn.Visible = true;
                refreshbtn.Visible = true;
                declinebtn.Visible = true;
            }
            else
            {
                approvebtn.Visible = false;
                refreshbtn.Visible = false;
                declinebtn.Visible = false;
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }
        //to implement on coach
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        // To implement on coach
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clickedRow = dataGridView1.Rows[e.RowIndex];

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
                    dataGridView1.Invalidate();

                    // Optional: Test to see if it works!
                    if (selectedPrimaryKey != -1)
                    {
                        MessageBox.Show($"Selected Primary Key: {selectedPrimaryKey}");
                    }
                }
            }
        }
        private void searchbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCalendarDays(searchbox.Text);
        }
        private void LoadCalendarDays(string coachName)
        {
            // 1. Clear out any bolded dates from the previous coach selection
            monthCalendar1.RemoveAllBoldedDates();

            List<DateTime> bookedDates = new List<DateTime>();

            // 2. Your exact beautiful JOIN query
            string query = "SELECT BookingRequests.RequestDateTime, UsersNew.username AS COACHNAME " +
                           "FROM BookingRequests " +
                           "JOIN UsersNew ON BookingRequests.COACHID = UsersNew.ID " +
                           "WHERE UsersNew.username = @coachname";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@coachname", coachName);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                if (dataReader["RequestDateTime"] != DBNull.Value)
                                {
                                    bookedDates.Add(Convert.ToDateTime(dataReader["RequestDateTime"]));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching coach schedule: " + ex.Message);
                    }
                }
            }

            // 3. Pass the dates to the native calendar so they stand out
            foreach (DateTime bookedDate in bookedDates)
            {
                monthCalendar1.AddBoldedDate(bookedDate.Date);
            }

            // 4. CRITICAL: Tell Windows to repaint the calendar so the changes show up
            monthCalendar1.UpdateBoldedDates();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start.Date;

            // Check if the date they clicked is in the calendar's bolded list
            if (monthCalendar1.BoldedDates.Contains(selectedDate))
            {
                MessageBox.Show("This coach is already booked on this day! Please select a regular date.",
                                "Slot Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Optional: Reset selection back to today's date
                monthCalendar1.SetDate(DateTime.Now);
            }
        }

       
    }
}
/*EVERYTHING IN CELL DESIGNING THAT I MAY NEED
 
 
 
 private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
{
    if (e.RowIndex < 0) return;

    e.Handled = true;
    e.PaintBackground(e.CellBounds, true);

    bool selected = dataGridView1.Rows[e.RowIndex].Selected;

    Graphics g = e.Graphics;
    g.SmoothingMode = SmoothingMode.AntiAlias;

    Rectangle rowRect = dataGridView1.GetRowDisplayRectangle(e.RowIndex, true);

    // CARD BACKGROUND
    using (SolidBrush bg = new SolidBrush(Color.FromArgb(40, 40, 40)))
    {
        g.FillRectangle(bg, rowRect);
    }

    // BLUE BORDER IF SELECTED
    if (selected)
    {
        using (Pen p = new Pen(Color.DodgerBlue, 2))
        {
            Rectangle borderRect = new Rectangle(
                rowRect.X + 2,
                rowRect.Y + 2,
                rowRect.Width - 4,
                rowRect.Height - 4
            );

            g.DrawRectangle(p, borderRect);
        }
    }

    // TEXT DRAWING
    TextRenderer.DrawText(
        g,
        e.FormattedValue?.ToString(),
        e.CellStyle.Font,
        e.CellBounds,
        Color.Gainsboro,
        TextFormatFlags.VerticalCenter | TextFormatFlags.Left
    );
}
 
 
 
 dataGridView1.EnableHeadersVisualStyles = false;
dataGridView1.BorderStyle = BorderStyle.None;
dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
dataGridView1.RowHeadersVisible = false;

dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Transparent;
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */