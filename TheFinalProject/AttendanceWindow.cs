using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFinalProject
{
    public partial class AttendanceWindow : Form
    {
        public AttendanceWindow()
        {
            InitializeComponent();
        }

        private void AttendanceWindow_Load(object sender, EventArgs e)
        {
            calendarControl1.btnNext.Click += (s, ev) => UpdateLabelText();
            calendarControl1.btnPrev.Click += (s, ev) => UpdateLabelText();
            calendarControl1.btnNext.Click += (s, ev) => pictureBox1.Invalidate();
            calendarControl1.btnPrev.Click += (s, ev) => pictureBox1.Invalidate();
            calendarControl1.btnNext.Parent = pictureBox1;
            calendarControl1.btnPrev.Parent = pictureBox1;
            //calendarControl1.monthLabel.Parent = pictureBox1;
            //calendarControl1.monthLabel.BringToFront();
            calendarControl1.btnPrev.BringToFront();
            calendarControl1.btnNext.BringToFront();
            calendarControl1.btnNext.Location = new Point(900, 90);
            calendarControl1.btnPrev.Location = new Point(260, 90);
            //calendarControl1.monthLabel.Location = new Point(580, 90);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
   
            using (Font myFont = new Font("Segoe UI", 14, FontStyle.Bold))
            using (SolidBrush myBrush = new SolidBrush(Color.White))
            {
               
                e.Graphics.DrawString(calendarControl1.monthLabel.Text, myFont, myBrush, new PointF(580, 90));
            }
        
        }

       
        public string CurrentMonthText
        {
            get { return calendarControl1.monthLabel.Text; }
            set { calendarControl1.monthLabel.Text = value; } 
        }
        private void UpdateLabelText()
        {
            
            calendarControl1.monthLabel.Text = CurrentMonthText;
        }
    }
}
