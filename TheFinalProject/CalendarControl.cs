
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace TheFinalProject
{

    public partial class CalendarControl : UserControl
    {
        private DateTime currentDate = DateTime.Today;
        private HashSet<DateTime> loggedInDays = new HashSet<DateTime>();

        private TableLayoutPanel table;
        public Label monthLabel;
        public Button btnPrev, btnNext;

        public CalendarControl()
        {
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            this.BackColor = Color.White;
            this.Padding = new Padding(10);

            // Header
            Panel header = new Panel { Height = 75, Dock = DockStyle.Top };
            btnPrev = new Button { Text = "◀", Width = 40, Height = 35, Left = 10, Top = 22 };
            btnNext = new Button { Text = "▶", Width = 40, Height = 35, Left = 700, Top = 22     };

            monthLabel = new Label
            {
                Text = currentDate.ToString("MMMM yyyy"),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40,
                
            };

            header.Controls.Add(btnPrev);
            header.Controls.Add(btnNext);
            header.Controls.Add(monthLabel);

            // Calendar Grid
            table = new TableLayoutPanel
            {
                RowCount = 7,
                ColumnCount = 7,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            // Day headers
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < 7; i++)
            {
                Label lbl = new Label
                {
                    Text = days[i].Substring(0, 3),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    BackColor = Color.FromArgb(45, 55, 70),
                    ForeColor = Color.White,
                    Height = 30
                };
                table.Controls.Add(lbl, i, 0);
            }

            this.Controls.Add(table);
            this.Controls.Add(header);

            btnPrev.Click += (s, e) => { currentDate = currentDate.AddMonths(-1); RefreshCalendar(); };
            btnNext.Click += (s, e) => { currentDate = currentDate.AddMonths(1); RefreshCalendar(); };

            RefreshCalendar();
        }

        public void SetLoggedInDays(List<DateTime> dates)
        {
            loggedInDays.Clear();
            foreach (var date in dates)
            {
                loggedInDays.Add(date.Date);
            }
            RefreshCalendar();
        }

        private void RefreshCalendar()
        {
            monthLabel.Text = currentDate.ToString("MMMM yyyy");

            // Clear previous days
            for (int i = table.Controls.Count - 1; i >= 7; i--) // keep headers
            {
                table.Controls.RemoveAt(i);
            }

            DateTime firstDay = new DateTime(currentDate.Year, currentDate.Month, 1);
            int startDay = (int)firstDay.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            int row = 1;
            int col = startDay;

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDay = new DateTime(currentDate.Year, currentDate.Month, day);

                Label dayLabel = new Label
                {
                    Text = day.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10),
                    Height = 50,
                    Margin = new Padding(2),
                    BackColor = loggedInDays.Contains(currentDay) ? Color.FromArgb(0, 180, 100) : Color.White,
                    ForeColor = loggedInDays.Contains(currentDay) ? Color.White : Color.Black,
                    BorderStyle = BorderStyle.FixedSingle
                };

                table.Controls.Add(dayLabel, col, row);

                col++;
                if (col >= 7)
                {
                    col = 0;
                    row++;
                }
            }
        }

        // Optional: Public property to change current month
        public DateTime CurrentDate
        {
            get => currentDate;
            set
            {
                currentDate = value;
                RefreshCalendar();
            }
        }
    }
}