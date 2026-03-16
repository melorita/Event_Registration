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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void chartReports_Click(object sender, EventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            int totalEvents = 10;
            int totalParticipants = 60;
            int totalApproved = 30;

            lblTotalEvents.Text = totalEvents.ToString();
            lblTotalParticipants.Text = totalParticipants.ToString();
            lblTotalApproved.Text = totalApproved.ToString();

            chartReports.Series["EventStatistics"].Points.Clear();

            chartReports.Series["EventStatistics"].Points.AddXY("Events", totalEvents);
            chartReports.Series["EventStatistics"].Points.AddXY("Participants", totalParticipants);
            chartReports.Series["EventStatistics"].Points.AddXY("Approved", totalApproved);
        }

        private void lblTotalEvents_Click(object sender, EventArgs e)
        {

        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
