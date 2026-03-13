using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class EventListForm : Form
    {
        public EventListForm()
        {
            InitializeComponent();
            LoadSampleEvents();
        }

        private Panel CreateEventCard(EventItem ev)
        {
            Panel card = new Panel();
            card.Width = 250;
            card.Height = 150;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);

            Label lblTitle = new Label();
            lblTitle.Text = ev.Title;
            lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitle.Top = 10;
            lblTitle.Left = 10;
            lblTitle.Width = 200;

            Label lblDate = new Label();
            lblDate.Text = "Date: " + ev.Date;
            lblDate.Top = 50;
            lblDate.Left = 10;

            Label lblLocation = new Label();
            lblLocation.Text = "Location: " + ev.Location;
            lblLocation.Top = 75;
            lblLocation.Left = 10;

            Button btnRegister = new Button();
            btnRegister.Text = "Register";
            btnRegister.Top = 110;
            btnRegister.Left = 10;

            // Register button action
            btnRegister.Click += (s, e) =>
            {
                MessageBox.Show("You registered for " + ev.Title);
            };

            // Event details popup when card clicked
            card.Click += (s, e) =>
            {
                MessageBox.Show(
                    "Title: " + ev.Title +
                    "\nDate: " + ev.Date +
                    "\nLocation: " + ev.Location +
                    "\nCategory: " + ev.Category +
                    "\n\nDescription:\n" + ev.Description,
                    "Event Details"
                );
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDate);
            card.Controls.Add(lblLocation);
            card.Controls.Add(btnRegister);

            return card;
        }
        private void LoadSampleEvents()
        {
            events.Add(new EventItem
            {
                Title = "Tech Conference",
                Date = "Aug 20 2026",
                Location = "Addis Ababa",
                Category = "Technology",
                Description = "AI and software innovation conference"
            });

            events.Add(new EventItem
            {
                Title = "Music Festival",
                Date = "Sep 5 2026",
                Location = "Bahir Dar",
                Category = "Music",
                Description = "Live music event with Ethiopian artists"
            });

            events.Add(new EventItem
            {
                Title = "Startup Meetup",
                Date = "Jul 12 2026",
                Location = "Adama",
                Category = "Business",
                Description = "Networking event for startup founders"
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