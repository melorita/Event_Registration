using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EventRegistrationDesktop.Forms.Components;
using EventRegistrationDesktop.Services;
using EventRegistrationDesktop.Models;

namespace EventRegistrationDesktop.Forms.Admin
{
    public partial class DashboardForm : BaseDashboardForm
    {

        public DashboardForm()
        {
            InitializeComponent();
            btnEvents.Click += BtnEvents_Click;
            btndashboard.Click += Btndashboard_Click;
            btnLogout.Click += BtnLogout_Click;
            btnAddEvents.Click += BtnAddEvents_Click;
            btnparticipants.Click += btnparticipants_Click;
            btnReports.Click += btnReports_Click;

            SetupSidebarButtons(panelsidebar);

            ActivateButton(btndashboard);
            LoadDashboardData();
        }

        private async void LoadDashboardData()
        {
            try
            {
                // 1. Fetch real data from API
                var events = await ApiService.GetAsync<List<Event>>("events");
                var registrations = await ApiService.GetAsync<List<RegistrationDto>>("registrations");

                int totalEvents = events?.Count ?? 0;
                int totalParticipants = registrations?.Count ?? 0;
                int pendingRegistrations = registrations?.Count(r => r.Status == "Pending") ?? 0;

                // 2. Update UI Cards
                if (labNoOfevents != null) labNoOfevents.Text = totalEvents.ToString();
                if (labelNoOfparticipant != null) labelNoOfparticipant.Text = totalParticipants.ToString();
                if (labelNoOfPending != null) labelNoOfPending.Text = pendingRegistrations.ToString();

                // 3. Update Chart with real data (Events by Category)
                if (chart1 != null && chart1.Series.Count > 0)
                {
                    var series = chart1.Series[0];
                    series.Points.Clear();

                    if (events != null && events.Count > 0)
                    {
                        var categoryGroups = events.GroupBy(e => e.Category)
                                                 .Select(g => new { Category = g.Key, Count = g.Count() });

                        foreach (var group in categoryGroups)
                        {
                            series.Points.AddXY(group.Category ?? "Other", group.Count);
                        }
                    }
                    else
                    {
                        series.Points.AddXY("No Data", 0);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Dashboard Load Error: " + ex.Message);
            }
        }

        private void openChildForm(Form childForm)
        {
            base.openChildForm(childForm, panelmain, lblTitle);
        }

        private void Btndashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btndashboard);
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            lblTitle.Text = "Admin Dashboard";
        }

        private void BtnEvents_Click(object sender, EventArgs e)
        {
            ActivateButton(btnEvents);
            openChildForm(new EventManagementForm());
        }

        private void BtnAddEvents_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAddEvents);
            openChildForm(new AddEventForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (EventRegistrationDesktop.Forms.User.UserRegistrationForm regForm = new EventRegistrationDesktop.Forms.User.UserRegistrationForm())
            {
                regForm.ShowDialog();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.Components.LoginForm login = new EventRegistrationDesktop.Forms.Components.LoginForm();
            login.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNoOfPending_Click(object sender, EventArgs e)
        {

        }

        private void btnEvents_Click_1(object sender, EventArgs e)
        {

        }

        private void labNoOfevents_Click(object sender, EventArgs e)
        {

        }

        private void btnparticipants_Click(object sender, EventArgs e)
        {
            ActivateButton(btnparticipants);
            openChildForm(new ParticipantManagementForm("Pending"));
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReports);
            openChildForm(new ReportsForm());
        }

    }
}
