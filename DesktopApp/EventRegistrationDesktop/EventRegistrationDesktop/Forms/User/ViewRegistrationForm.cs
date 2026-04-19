using System;
using EventRegistrationDesktop.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class ViewRegistrationForm : Form
    {
        public ViewRegistrationForm()
        {
            InitializeComponent();
            StyleModernUI();
            this.Load += async (s, e) => await LoadMyRegistrations();
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void StyleModernUI()
        {
            this.BackColor = Color.FromArgb(236, 240, 241);
            panelViewreg.BackColor = Color.SteelBlue;
            lbviewReg.ForeColor = Color.White;
            lbviewReg.Font = new Font("Segoe UI", 20, FontStyle.Bold);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 45;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Rename columns to fit our data
            if (dataGridView1.Columns.Count >= 5)
            {
                dataGridView1.Columns[3].HeaderText = "Participant";
            }
        }

        private async Task LoadMyRegistrations()
        {
            try
            {
                var regs = await ApiService.GetAsync<List<EventRegistrationDesktop.Models.RegistrationDto>>("registrations/my");
                dataGridView1.Rows.Clear();

                if (regs != null)
                {
                    foreach (var reg in regs)
                    {
                        int rowIndex = dataGridView1.Rows.Add(
                            reg.EventName,
                            reg.EventDate,
                            reg.EventLocation,
                            reg.FullName,
                            reg.Status
                        );

                        // Remindation Logic: Highlight if event is within 2 days
                        if (DateTime.TryParse(reg.EventDate, out DateTime eventDate))
                        {
                            TimeSpan timeLeft = eventDate - DateTime.Now;
                            if (timeLeft.TotalDays >= 0 && timeLeft.TotalDays <= 2)
                            {
                                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                                dataGridView1.Rows[rowIndex].Cells[1].Value = "⚠️ " + reg.EventDate + " (Near!)";
                            }
                        }

                        // Color Status
                        var statusCell = dataGridView1.Rows[rowIndex].Cells[4];
                        if (reg.Status == "Approved") statusCell.Style.ForeColor = Color.Green;
                        else if (reg.Status == "Rejected") statusCell.Style.ForeColor = Color.Red;
                        else statusCell.Style.ForeColor = Color.Orange;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load registrations: " + ex.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string eventName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string personName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string status = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            string detail = $"Event: {eventName}\n" +
                            $"Participant: {personName}\n" +
                            $"Status: {status}\n\n" +
                            $"Please contact support if you have questions regarding your registration status.";

            MessageBox.Show(detail, "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
