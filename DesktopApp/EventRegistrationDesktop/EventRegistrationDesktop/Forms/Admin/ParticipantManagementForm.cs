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
        private int currentSelectedRowIndex = -1;

        private string initialStatusFilter = "All";

        public ParticipantManagementForm(string statusFilter = "All")
        {
            InitializeComponent();
            initialStatusFilter = statusFilter;
            cmbStatusFilter.SelectedIndexChanged += CmbStatusFilter_SelectedIndexChanged;
        }

        private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void FilterGrid()
        {
            if (cmbStatusFilter.SelectedItem == null) return;
            string filter = cmbStatusFilter.SelectedItem.ToString();
            
            // Note: DataGridView row visibility can only be changed when it's not the 'new' row buffer.
            dataGridView1.CurrentCell = null; // Important to remove focus before hiding rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (filter == "All")
                        row.Visible = true;
                    else
                    {
                        var statusCell = row.Cells["Status"].Value?.ToString();
                        row.Visible = (statusCell == filter);
                    }
                }
            }
        }

        private void ParticipantManagementForm_Load(object sender, EventArgs e)
        {
            // Adding mock data to simulate "Pending" registrations initially
            dataGridView1.Rows.Add("101", "Emma Watson", "emma@example.com", "2026-03-15", "Tech Conference", "Pending");
            dataGridView1.Rows.Add("102", "John Doe", "john@example.com", "2026-03-15", "Art Workshop", "Pending");
            dataGridView1.Rows.Add("103", "Alice Smith", "alice@example.com", "2026-03-14", "Seminar", "Pending");

            if (cmbStatusFilter.Items.Contains(initialStatusFilter))
            {
                cmbStatusFilter.SelectedItem = initialStatusFilter;
            }
            else
            {
                cmbStatusFilter.SelectedIndex = 0;
            }
            FilterGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.Admin.DashboardForm dashboardForm = new EventRegistrationDesktop.Forms.Admin.DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Detect right click
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                currentSelectedRowIndex = e.RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delete button column is index 6
            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                var result = MessageBox.Show("Are you sure you want to delete this registration?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentSelectedRowIndex >= 0 && currentSelectedRowIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[currentSelectedRowIndex].Cells["Status"].Value = "Approved";
                FilterGrid();
            }
        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentSelectedRowIndex >= 0 && currentSelectedRowIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[currentSelectedRowIndex].Cells["Status"].Value = "Rejected";
                FilterGrid();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentSelectedRowIndex >= 0 && currentSelectedRowIndex < dataGridView1.Rows.Count && !dataGridView1.Rows[currentSelectedRowIndex].IsNewRow)
            {
                var result = MessageBox.Show("Are you sure you want to delete this registration?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(currentSelectedRowIndex);
                }
            }
        }
    }
    }

