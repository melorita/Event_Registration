using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EventRegistrationDesktop.Services;
using EventRegistrationDesktop.Models;

namespace EventRegistrationDesktop.Forms.Admin
{
    public partial class ReportsForm : Form
    {
        private List<Event> _events = new List<Event>();
        private List<RegistrationDto> _registrations = new List<RegistrationDto>();

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void chartReports_Click(object sender, EventArgs e)
        {

        }
        private async void ReportsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var eventsData = await ApiService.GetAsync<List<Event>>("events");
                if (this.IsDisposed) return;
                _events = eventsData ?? new List<Event>();

                var regsData = await ApiService.GetAsync<List<RegistrationDto>>("registrations");
                if (this.IsDisposed) return;
                _registrations = regsData ?? new List<RegistrationDto>();

                int totalEvents = _events.Count;
                int totalParticipants = _registrations.Count;
                int totalApproved = _registrations.Count(r => r != null && r.Status == "Approved");
                int totalRejected = _registrations.Count(r => r != null && r.Status == "Rejected");
                int totalPending = _registrations.Count(r => r != null && r.Status == "Pending");

                if (lblTotalEvents != null) lblTotalEvents.Text = totalEvents.ToString();
                if (lblTotalParticipants != null) lblTotalParticipants.Text = totalParticipants.ToString();
                if (lblTotalApproved != null) lblTotalApproved.Text = totalApproved.ToString();
                if (lblTotalRejected != null) lblTotalRejected.Text = totalRejected.ToString();

                var chart = this.chartReports;
                if (chart != null && !chart.IsDisposed)
                {
                    try 
                    {
                        var seriesCollection = chart.Series;
                        if (seriesCollection != null && seriesCollection.Count > 0)
                        {
                            System.Windows.Forms.DataVisualization.Charting.Series series = null;
                            
                            series = seriesCollection.FindByName("EventStatistics") ?? seriesCollection[0];

                            if (series != null && series.Points != null)
                            {
                                series.Points.Clear();
                                int p1 = series.Points.AddXY("Approved", totalApproved);
                                int p2 = series.Points.AddXY("Pending", totalPending);
                                int p3 = series.Points.AddXY("Rejected", totalRejected);

                                series.Points[p1].Color = Color.FromArgb(46, 204, 113); // Green
                                series.Points[p2].Color = Color.FromArgb(241, 196, 15); // Yellow
                                series.Points[p3].Color = Color.FromArgb(231, 76, 60);  // Red
                                
                                series["PieLabelStyle"] = "Outside";
                                series.BorderColor = Color.White;
                                series.BorderWidth = 2;
                            }
                        }
                    }
                    catch (Exception chartEx)
                    {
                        System.Diagnostics.Debug.WriteLine("Chart Update Error: " + chartEx.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Report Load Error: " + ex.Message);
            }
        }

        private void lblTotalEvents_Click(object sender, EventArgs e)
        {

        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (_registrations == null)
            {
                MessageBox.Show("No data available to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = "EventRegistrationReport_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();
                    csv.AppendLine("Event Registration System Report");
                    csv.AppendLine("Generated on: " + DateTime.Now.ToString());
                    csv.AppendLine("");
                    csv.AppendLine("SUMMARY");
                    csv.AppendLine($"Total Events,{lblTotalEvents?.Text ?? "0"}");
                    csv.AppendLine($"Total Registrations,{lblTotalParticipants?.Text ?? "0"}");
                    csv.AppendLine($"Approved,{lblTotalApproved?.Text ?? "0"}");
                    csv.AppendLine($"Rejected,{lblTotalRejected?.Text ?? "0"}");
                    csv.AppendLine("");
                    csv.AppendLine("PARTICIPANT LIST");
                    csv.AppendLine("Name,Email,Event,Status,Date");

                    foreach (var reg in _registrations)
                    {
                        if (reg == null) continue;
                        csv.AppendLine($"{reg.FullName},{reg.Email},{reg.EventName},{reg.Status},{reg.RegisteredAt}");
                    }

                    System.IO.File.WriteAllText(sfd.FileName, csv.ToString());
                    MessageBox.Show("Report exported successfully to CSV!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
