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
    public partial class ParticipantManagementForm : Form
    {
        public ParticipantManagementForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.Admin.DashboardForm dashboardForm = new EventRegistrationDesktop.Forms.Admin.DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }
    }
    }

