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
