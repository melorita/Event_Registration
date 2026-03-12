using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Forms.Admin
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            btnEvents.Click += BtnEvents_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void BtnEvents_Click(object sender, EventArgs e)
        {
            EventManagementForm eventForm = new EventManagementForm();
            eventForm.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.LoginForm login = new EventRegistrationDesktop.Forms.LoginForm();
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
    }
}
