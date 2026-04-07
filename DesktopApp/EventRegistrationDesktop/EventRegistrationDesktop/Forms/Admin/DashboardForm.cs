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

            btnparticipants.Click += (s, e) => ActivateButton(btnparticipants);
            btnReports.Click += (s, e) =>
            {
                ActivateButton(btnReports);
                openChildForm(new ReportsForm());
            };

            SetupSidebarButtons(panelsidebar);

            ActivateButton(btndashboard);
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            // Adding sample data to chart
            chart1.Series["series 1"].Points.Clear();
            int p1 = chart1.Series["series 1"].Points.AddXY("Tech", 150);
            int p2 = chart1.Series["series 1"].Points.AddXY("Music", 200);
            int p3 = chart1.Series["series 1"].Points.AddXY("Business", 120);
            int p4 = chart1.Series["series 1"].Points.AddXY("Sports", 80);

            // Set colors for a premium look
            chart1.Series["series 1"].Points[p1].Color = Color.FromArgb(46, 204, 113); // Green
            chart1.Series["series 1"].Points[p2].Color = Color.FromArgb(52, 152, 219); // Blue
            chart1.Series["series 1"].Points[p3].Color = Color.FromArgb(155, 89, 182); // Purple
            chart1.Series["series 1"].Points[p4].Color = Color.FromArgb(230, 126, 34); // Orange

            chart1.Series["series 1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["series 1"]["PointWidth"] = "0.6";

            // Chart Styling
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 10);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 10);
            chart1.ChartAreas[0].BorderColor = Color.Transparent;

            // Set labels
            labNoOfevents.Text = "10";
            labelNoOfparticipant.Text = "550";
            labelNoOfPending.Text = "25";
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
            lblTitle.Text = "Event Registration System - Admin Dashboard";
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
