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
    public partial class coachfrm : Form
    {
        
        private int CurrentUserID;
        private int processingcount;
        private int upcomingcount;
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
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\nAND (CoachApproved IS NULL OR CoachApproved <> 'Approved')";

                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show(result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    toprocesscount.Text = ProcessingCount.ToString();
                }

                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= CAST(GETDATE() AS DATE);";

                using (SqlCommand cmd = new SqlCommand(upcomingreminderquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    UpcomingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    upcomingseshcount.Text = UpcomingCount.ToString();
                }
                int totalcount = UpcomingCount + ProcessingCount;
                Reminderbtn.Text = "Reminders(" + totalcount + ")";
                string sessionstoapprovequery = @"SELECT 
                     br.RequestID AS RequestID,
                     u.username AS UserName,
                     c.username AS CoachName,
                     br.RequestDateTime
                     FROM BookingRequests br
                    JOIN UsersNew u ON br.UserID = u.ID
                    JOIN UsersNew c ON br.CoachID = c.ID
                    WHERE br.CoachID = @CurrentUserID
                    AND br.CoachApproved IS NULL;";
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

        public void refreshnotif()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\nAND (CoachApproved IS NULL OR CoachApproved <> 'Approved')";

                using (SqlCommand cmd = new SqlCommand(processingquery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserID", CurrentUserID);

                    object result = cmd.ExecuteScalar();

                    MessageBox.Show(result.ToString());

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    toprocesscount.Text = ProcessingCount.ToString();
                }

                string upcomingreminderquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE COACHID = @currentUserID\r\n  AND Status = 'Approved'\r\n  AND UserApproved = 'Approved'\r\n  AND CoachApproved = 'Approved'\r\n  AND RequestDateTime >= CAST(GETDATE() AS DATE);";

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
            TogglePanel(panel2);
            refreshnotif();
        }
        private void TogglePanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }
        private void approvebtn_Click(object sender, EventArgs e)
        {
            int requestID;
            var selected = sessionstoapprove.CurrentRow.Cells["RequestID"].Value;
            if (selected == null)
            {
                MessageBox.Show("Please select a row with values");
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
            refreshnotif();
        }

        private void declinebtn_Click(object sender, EventArgs e)
        {
            int requestID;
            var selected = sessionstoapprove.CurrentRow.Cells["RequestID"].Value;
            if (selected == null)
            {
                MessageBox.Show("Please select a row with values");
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
            refreshnotif();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
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
                    AND br.CoachApproved IS NULL;";
            using (SqlConnection conn = new SqlConnection(connectionString)) { conn.Open();

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
            refreshnotif();

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