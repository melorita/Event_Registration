using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EventRegistrationDesktop.Services;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class EventListForm : Form
    {
        public Action<EventItem> OnRegisterClicked { get; set; }

        public EventListForm()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadEventsAsync();
            cmbFilterCategory.SelectedIndex = 0;
        }



        private Panel CreateEventCard(EventItem ev)
        {
            Panel card = new Panel();
            card.Width = 360;
            card.Height = 460;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.None;
            card.Margin = new Padding(15, 15, 15, 15);
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
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BackColor = Color.FromArgb(240, 240, 240);
            try { 
                if (!string.IsNullOrEmpty(ev.ImagePath))
                {
                    // Handle Base64 from database
                    byte[] imageBytes = Convert.FromBase64String(ev.ImagePath);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pic.Image = null; 
                }
            } catch { 
                // Fallback or placeholder
                pic.Image = null;
            }
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
            lblTitle.Width = 330;
            lblTitle.AutoEllipsis = true;
            textDetails.Controls.Add(lblTitle);

            // 4. Description (Short)
            Label lblDesc = new Label();
            lblDesc.Text = ev.Description;
            lblDesc.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Top = 80;
            lblDesc.Left = 15;
            lblDesc.Width = 330;
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
        private async System.Threading.Tasks.Task LoadEventsAsync()
        {
            try
            {
                var apiEvents = await ApiService.GetAsync<List<EventRegistrationDesktop.Models.Event>>("events");
                if (apiEvents != null)
                {
                    events.Clear();
                    foreach (var ev in apiEvents)
                    {
                        events.Add(new EventItem
                        {
                            Id = ev.Id,
                            Title = ev.EventName,
                            Date = ev.Date.ToShortDateString(),
                            Location = ev.Location,
                            Category = ev.Category,
                            Description = ev.Description,
                            Capacity = ev.Capacity.ToString(),
                            Organizer = ev.Organizer,
                            ImagePath = ev.EventImage
                        });
                    }
                    DisplayEvents(events);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }
        public class EventItem
        {
            public int Id { get; set; }
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

            if (eventList.Count == 0)
            {
                lblNoEvents.Visible = true;
                flowEvents.Controls.Add(lblNoEvents);
            }
            else
            {
                lblNoEvents.Visible = false;
                foreach (var ev in eventList)
                {
                    flowEvents.Controls.Add(CreateEventCard(ev));
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterEvents();
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEvents();
        }

        private void FilterEvents()
        {
            string keyword = txtSearch.Text.ToLower();
            string category = cmbFilterCategory.SelectedItem?.ToString();

            var filteredEvents = events.Where(ev => 
                ev.Title.ToLower().Contains(keyword) && 
                (category == "All Categories" || ev.Category == category)
            ).ToList();

            DisplayEvents(filteredEvents);
        }
    }
}