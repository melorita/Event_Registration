using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class EventListForm : Form
    {
        public Action<EventItem> OnRegisterClicked { get; set; }

        public EventListForm()
        {
            InitializeComponent();
            LoadSampleEvents();
            SetupFilterButtons();
        }

        private void SetupFilterButtons()
        {
            var filterBtns = new List<Button> { btnAll, btnTech, btnMusic, btnBusiness };
            foreach (var btn in filterBtns)
            {
                btn.MouseEnter += (s, e) => {
                    btn.BackColor = Color.SteelBlue;
                    btn.ForeColor = Color.White;
                };
                btn.MouseLeave += (s, e) => {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                };
            }
        }

        private Panel CreateEventCard(EventItem ev)
        {
            Panel card = new Panel();
            card.Width = 320;
            card.Height = 480;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.None;
            card.Margin = new Padding(15);
            card.Padding = new Padding(0);

            // Add drop shadow effect using a larger panel or just better borders
            // For WinForms, we'll use a neat border
            Panel borderPanel = new Panel();
            borderPanel.Dock = DockStyle.Fill;
            borderPanel.Padding = new Padding(1);
            borderPanel.BackColor = Color.LightGray;
            card.Controls.Add(borderPanel);

            Panel innerContent = new Panel();
            innerContent.Dock = DockStyle.Fill;
            innerContent.BackColor = Color.White;
            borderPanel.Controls.Add(innerContent);

            // 1. Event Image
            PictureBox pic = new PictureBox();
            pic.Height = 180;
            pic.Dock = DockStyle.Top;
            pic.SizeMode = PictureBoxSizeMode.Zoom; // Use zoom for cleaner look
            pic.BackColor = Color.FromArgb(240, 240, 240);
            try { 
                if (!string.IsNullOrEmpty(ev.ImagePath) && System.IO.File.Exists(ev.ImagePath))
                    pic.Image = Image.FromFile(ev.ImagePath);
                else
                    pic.Image = null; // Placeholder logic
            } catch { }
            innerContent.Controls.Add(pic);

            // Container for text to add padding
            Panel textDetails = new Panel();
            textDetails.Dock = DockStyle.Fill;
            textDetails.Padding = new Padding(15, 10, 15, 10);
            innerContent.Controls.Add(textDetails);
            textDetails.BringToFront();

            // 2. Category Badge
            Label lblCat = new Label();
            lblCat.Text = ev.Category.ToUpper();
            lblCat.AutoSize = true;
            lblCat.BackColor = Color.DeepSkyBlue;
            lblCat.ForeColor = Color.White;
            lblCat.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lblCat.Padding = new Padding(5, 2, 5, 2);
            lblCat.Top = 10;
            lblCat.Left = 15;
            textDetails.Controls.Add(lblCat);

            // 3. Title
            Label lblTitle = new Label();
            lblTitle.Text = ev.Title;
            lblTitle.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 45, 45);
            lblTitle.Top = 40;
            lblTitle.Left = 15;
            lblTitle.Width = 280;
            lblTitle.AutoEllipsis = true;
            textDetails.Controls.Add(lblTitle);

            // 4. Description (Short)
            Label lblDesc = new Label();
            lblDesc.Text = ev.Description;
            lblDesc.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Top = 80;
            lblDesc.Left = 15;
            lblDesc.Width = 280;
            lblDesc.Height = 45;
            lblDesc.AutoEllipsis = true;
            textDetails.Controls.Add(lblDesc);

            // 5. Details (Icon + Text style simulation)
            int currentTop = 135;
            Label lblLoc = CreateDetailLabel("📍 " + ev.Location, currentTop, textDetails);
            currentTop += 25;
            Label lblDate = CreateDetailLabel("📅 " + ev.Date, currentTop, textDetails);
            currentTop += 25;
            Label lblOrg = CreateDetailLabel("👤 Org: " + ev.Organizer, currentTop, textDetails);
            currentTop += 25;
            Label lblCap = CreateDetailLabel("👥 Cap: " + ev.Capacity, currentTop, textDetails);

            // 6. Action Button
            Button btnRegister = new Button();
            btnRegister.Text = "Register Now";
            btnRegister.Dock = DockStyle.Bottom;
            btnRegister.Height = 50;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.BackColor = Color.RoyalBlue;
            btnRegister.ForeColor = Color.White;
            btnRegister.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnRegister.Cursor = Cursors.Hand;

            btnRegister.Click += (s, e) => OnRegisterClicked?.Invoke(ev);
            innerContent.Controls.Add(btnRegister);
            btnRegister.BringToFront();

            return card;
        }

        private Label CreateDetailLabel(string text, int top, Panel parent)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lbl.ForeColor = Color.DarkSlateGray;
            lbl.AutoSize = true;
            lbl.Top = top;
            lbl.Left = 15;
            parent.Controls.Add(lbl);
            return lbl;
        }
        private void LoadSampleEvents()
        {
            events.Add(new EventItem
            {
                Title = "Future Tech Summit 2026",
                Date = "Aug 20, 2026",
                Location = "Skyline Hall, Addis Ababa",
                Category = "Technology",
                Description = "Explore the next generation of AI and sustainable software engineering with global leaders.",
                Capacity = "500 Attendees",
                Organizer = "TechHub Ethiopia",
                ImagePath = "" // Can be set later
            });

            events.Add(new EventItem
            {
                Title = "Melodic Beats Festival",
                Date = "Sep 05, 2026",
                Location = "Lakeside Arena, Bahir Dar",
                Category = "Music",
                Description = "A vibrant celebration of Ethiopian jazz and contemporary pop featuring top-tier artists.",
                Capacity = "2000 Fans",
                Organizer = "Star Events",
                ImagePath = ""
            });

            events.Add(new EventItem
            {
                Title = "Green Growth Meetup",
                Date = "Jul 12, 2026",
                Location = "Innovation Center, Adama",
                Category = "Business",
                Description = "Networking event for green tech startups and established sustainability investors.",
                Capacity = "150 Experts",
                Organizer = "Adama Chambers",
                ImagePath = ""
            });

            DisplayEvents(events);
        }
        public class EventItem
        {
            public string Title { get; set; }
            public string Date { get; set; }
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public string Capacity { get; set; }
            public string Organizer { get; set; }
            public string ImagePath { get; set; }
        }

        private List<EventItem> events = new List<EventItem>();

        private void DisplayEvents(List<EventItem> eventList)
        {
            flowEvents.Controls.Clear();

            foreach (var ev in eventList)
            {
                flowEvents.Controls.Add(CreateEventCard(ev));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var filteredEvents = events
                .Where(ev => ev.Title.ToLower().Contains(keyword))
                .ToList();

            DisplayEvents(filteredEvents);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DisplayEvents(events);
        }

        private void btnTech_Click(object sender, EventArgs e)
        {
            var filtered = events
                .Where(ev => ev.Category == "Technology")
                .ToList();

            DisplayEvents(filtered);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            var filtered = events
        .Where(ev => ev.Category == "Music")
        .ToList();

            DisplayEvents(filtered);
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            var filtered = events
        .Where(ev => ev.Category == "Business")
        .ToList();

            DisplayEvents(filtered);
        }
    }
}