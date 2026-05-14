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

namespace TheFinalProject.Resources
{
    public partial class Userfrm : Form
    {
        string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";

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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";


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
                    using (SqlCommand command  = new SqlCommand(usernamequery, conn))
                    {
                        command.Parameters.AddWithValue("userid", CurrentUserID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string username = reader["username"].ToString();
                               accountname.Text = username;
                            }
                        }

                    }

                   
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

                }
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\nAND (UserApproved IS NULL OR UserApproved <> 'Approved')";

                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show(result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    toprocesscount.Text = ProcessingCount.ToString();
                }
                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= CAST(GETDATE() AS DATE);";

                using (SqlCommand cmd = new SqlCommand(upcomingreminderquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    UpcomingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    upcomingseshcount.Text = UpcomingCount.ToString();
                }
                int totalcount = UpcomingCount + ProcessingCount;
                Reminderbtn.Text = "Reminders(" + totalcount + ")";
                


            }

            loadSessions();

            //implement data tables for upcoming sessions grid and past sessions
            

        }
        public void refreshnotif()
        { 
        using(SqlConnection conn = new SqlConnection(connectionString))
            { 
                conn.Open(); 
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\nAND (UserApproved IS NULL OR UserApproved <> 'Approved')";

                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show(result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    toprocesscount.Text = ProcessingCount.ToString();
                }
                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE USERID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= CAST(GETDATE() AS DATE);";

                using (SqlCommand cmd = new SqlCommand(upcomingreminderquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    UpcomingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    upcomingseshcount.Text = UpcomingCount.ToString();
                }
                int totalcount = UpcomingCount + ProcessingCount;
                Reminderbtn.Text = "Reminders(" + totalcount + ")";
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
            var selected = dataGridView1.CurrentRow.Cells["RequestID"].Value;
            if (selected == null)
            {
                MessageBox.Show("Please select a row with values");
            }
            requestID = Convert.ToInt32(selected);
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString)) {
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
            var selected = dataGridView1.CurrentRow.Cells["RequestID"].Value;
            if (selected == null)
            {
                MessageBox.Show("Please select a row with values");
            }
            requestID = Convert.ToInt32(selected);
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string approvingquery = "UPDATE BookingRequests SET UserApprovedx = 'Declined' WHERE RequestID = @requestID";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshnotif();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString)) { 
            conn.Open ();
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
            TogglePanel(panel2);
            refreshnotif();
        }
        private void TogglePanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
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