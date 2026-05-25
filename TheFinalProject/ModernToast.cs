using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YourProjectName
{
    public class ModernToast : Form
    {
        // Smoothly rounds the corners of the window
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private Label lblMessage;
        private Timer fadeTimer;
        private Timer displayTimer;
        private bool fadingOut = false;

        public ModernToast(Form parent, string message, Color bgColor, Color textColor)
        {
            // Form Setup
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = bgColor;
            this.Opacity = 0; // Start invisible for fade-in
            this.Size = new Size(320, 55);

            // Apply rounded corners (15px radius)
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // Label Setup
            lblMessage = new Label
            {
                Text = message,
                ForeColor = textColor,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblMessage);

            // Position perfectly in the center of your main window/panel
            int centerX = parent.Location.X + (parent.Width - this.Width) / 2;
            int centerY = parent.Location.Y + (parent.Height - this.Height) / 2;
            this.Location = new Point(centerX, centerY);

            // Fade-in Animation Timer
            fadeTimer = new Timer { Interval = 15 };
            fadeTimer.Tick += FadeTimer_Tick;

            // Display Duration Timer
            displayTimer = new Timer { Interval = 2000 }; // Stay for 2 seconds
            displayTimer.Tick += (s, e) => { fadingOut = true; displayTimer.Stop(); fadeTimer.Start(); };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (!fadingOut)
            {
                if (this.Opacity < 0.95) this.Opacity += 0.08; // Fade In
                else { fadeTimer.Stop(); displayTimer.Start(); }
            }
            else
            {
                if (this.Opacity > 0) this.Opacity -= 0.08; // Fade Out
                else { fadeTimer.Stop(); this.Close(); } // Close and free memory
            }
        }

        // Prevent the toast from taking focus away from your textboxes/navigation panels
        protected override bool ShowWithoutActivation => true;
    }
}