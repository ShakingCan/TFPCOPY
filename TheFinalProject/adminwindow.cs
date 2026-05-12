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
    public partial class adminwindow : Form
    {
        private int processingcount;
        public int ProcessingCount
        {
            get { return processingcount; }
            set { processingcount = value; }
        }
        List<string> allUsernames = new List<string>();
        string connectionString = @"Data Source=DESKTOP-MOE35KS;Initial Catalog=finalprojectDB;Integrated Security=True;";
        public adminwindow()
        {
            InitializeComponent();
        }

        private void adminwindow_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(connectionString)) {
               conn.Open();
                string query = @"
SELECT 
    br.RequestID,
    u.username AS UserName,
    c.username AS CoachName,
    br.USERID,
    br.COACHID,
    br.RequestDateTime,
    br.Status,
    br.UserApproved,
    br.CoachApproved
FROM BookingRequests br
JOIN UsersNew u ON br.USERID = u.ID
JOIN UsersNew c ON br.COACHID = c.ID
WHERE Status LIKE '%e%'
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
                string alluserquery = "SELECT ID,username,role FROM UsersNew ORDER BY role";

                using (SqlCommand cmd = new SqlCommand(alluserquery, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    useraccountslist.DataSource = dt;


                }



            }
              string processingquery = "SELECT COUNT(*)\r\nFROM BookingRequests\r\nWHERE (UserApproved = 'Approved') AND (CoachApproved = 'Approved') AND Status = 'Pending'";
            using (SqlConnection con = new SqlConnection(connectionString))
            {con.Open();
                using (SqlCommand cmd = new SqlCommand(processingquery, con))
                {
                    

                    object result = cmd.ExecuteScalar();

                    

                    ProcessingCount = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                    toprocesscount.Text = ProcessingCount.ToString();
                }
            }
            int totalcount = ProcessingCount;
            Reminderbtn.Text = "Reminders(" + totalcount + ")";



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
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
SELECT 
    br.RequestID,
    u.username AS UserName,
    c.username AS CoachName,
    br.USERID,
    br.COACHID,
    br.RequestDateTime,
    br.Status,
    br.UserApproved,
    br.CoachApproved
FROM BookingRequests br
JOIN UsersNew u ON br.USERID = u.ID
JOIN UsersNew c ON br.COACHID = c.ID
WHERE Status LIKE '%e%'
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
                    MessageBox.Show("Session view refreshed");
                }



            }
        }

        private void reassign_Click(object sender, EventArgs e)
        {
           
            if (AllSessions.CurrentRow != null)
            { panel1.Visible = true; }
               
                
            }
           


        

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = comboBox1.Text.ToLower();

            comboBox1.Items.Clear();

            foreach (var name in allUsernames)
            {
                if (name.ToLower().Contains(input))
                {
                    comboBox1.Items.Add(name);
                }
            }

            comboBox1.SelectionStart = comboBox1.Text.Length;
            comboBox1.DroppedDown = true;
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
            panel1.Visible = false;
            loadSessions();

        }

        private void addaccount_Click(object sender, EventArgs e)
        {
           registerform rf = new registerform();
            rf.Visible = true;
            this.Hide();
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
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with that ID.");
                    }
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reminderbtn_Click(object sender, EventArgs e)
        {

        }

        private void Reminderbtn_Click_1(object sender, EventArgs e)
        {
            TogglePanel(panel2);
        }
        private void TogglePanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

       
    }

       
    }
