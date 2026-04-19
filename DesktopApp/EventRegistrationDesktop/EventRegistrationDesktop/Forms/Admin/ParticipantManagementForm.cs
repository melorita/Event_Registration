using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventRegistrationDesktop.Models;
using EventRegistrationDesktop.Services;

namespace EventRegistrationDesktop.Forms.Admin
{
    public partial class ParticipantManagementForm : Form
    {
        private List<RegistrationDto> _allRegistrations = new List<RegistrationDto>();
        private int currentSelectedRowIndex = -1;
        private string initialStatusFilter = "All";

        public ParticipantManagementForm(string statusFilter = "All")
        {
            InitializeComponent();
            initialStatusFilter = statusFilter;
            cmbStatusFilter.SelectedIndexChanged += (s, e) => FilterGrid();
            
            // Add 'View Receipt' to context menu
            var viewReceiptItem = new ToolStripMenuItem("View Receipt", null, viewReceiptToolStripMenuItem_Click);
            contextMenuStrip1.Items.Insert(0, viewReceiptItem);

            // Wire up direct status editing
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;

            StyleDataGridView();
        }

        private void StyleDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 244, 244);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
        }

        private async void ParticipantManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatusFilter.Items.Contains(initialStatusFilter))
                    cmbStatusFilter.SelectedItem = initialStatusFilter;
                else if (cmbStatusFilter.Items.Count > 0)
                    cmbStatusFilter.SelectedIndex = 0;

                await LoadRegistrationsAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Load Error: " + ex.Message);
            }
        }

        private async Task LoadRegistrationsAsync()
        {
            try
            {
                _allRegistrations = await ApiService.GetAsync<List<RegistrationDto>>("registrations");
                FilterGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching registrations: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void FilterGrid()
        {
            if (_allRegistrations == null || dataGridView1 == null) return;
            
            // Safeguard: If columns were somehow lost or not initialized yet
            if (dataGridView1.Columns.Count == 0)
            {
                return; 
            }

            string statusFilter = cmbStatusFilter.SelectedItem?.ToString().Trim() ?? "All";
            string nameFilter = txtSearchName.Text.Trim().ToLower();
            string eventFilter = txtSearchEvent.Text.Trim().ToLower();
            
            dataGridView1.Rows.Clear();
            foreach (var reg in _allRegistrations)
            {
                bool matchesStatus = statusFilter == "All" || reg.Status == statusFilter;
                bool matchesName = string.IsNullOrEmpty(nameFilter) || reg.FullName.ToLower().Contains(nameFilter);
                bool matchesEvent = string.IsNullOrEmpty(eventFilter) || (reg.EventName?.ToLower().Contains(eventFilter) ?? false);

                if (matchesStatus && matchesName && matchesEvent)
                {
                    dataGridView1.Rows.Add(
                        reg.Id,
                        reg.FullName,
                        reg.Email,
                        reg.RegisteredAt.ToShortDateString(),
                        reg.EventName,
                        reg.Status
                    );
                }
            }
        }

        private async void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await UpdateStatusAsync("Approved");
        }

        private async void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await UpdateStatusAsync("Rejected");
        }

        private async Task UpdateStatusAsync(string newStatus)
        {
            if (currentSelectedRowIndex >= 0 && currentSelectedRowIndex < dataGridView1.Rows.Count)
            {
                try
                {
                    var cellValue = dataGridView1.Rows[currentSelectedRowIndex].Cells[0].Value;
                    if (cellValue == null) return;

                    int regId = Convert.ToInt32(cellValue);
                    bool success = await ApiService.PutAsync($"registrations/{regId}/status", newStatus);
                    if (success)
                    {
                        MessageBox.Show($"Registration {newStatus.ToLower()} successfully.");
                        await LoadRegistrationsAsync();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update status: " + ApiService.LastErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message);
                }
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentSelectedRowIndex >= 0 && currentSelectedRowIndex < dataGridView1.Rows.Count)
            {
                int regId = Convert.ToInt32(dataGridView1.Rows[currentSelectedRowIndex].Cells[0].Value);
                var result = MessageBox.Show("Are you sure you want to delete this registration?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    bool success = await ApiService.DeleteAsync($"registrations/{regId}");
                    if (success)
                    {
                        MessageBox.Show("Registration deleted successfully.");
                        await LoadRegistrationsAsync();
                    }
                }
            }
        }

        private void viewReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentSelectedRowIndex >= 0)
            {
                int regId = Convert.ToInt32(dataGridView1.Rows[currentSelectedRowIndex].Cells[0].Value);
                var reg = _allRegistrations.FirstOrDefault(r => r.Id == regId);
                
                // We need to fetch the Full Registration details or rely on reg mapping
                // For now, let's check if the current DTO has the Image. 
                // Wait, registration/my returns DTO without image. 
                // I should fetch a single registration to get the image or update the DTO.
                
                ShowReceiptPopup(regId);
            }
        }

        private void ShowReceiptPopup(int regId)
        {
            var reg = _allRegistrations.FirstOrDefault(r => r.Id == regId);
            
            if (reg == null || string.IsNullOrEmpty(reg.PaymentReceiptImage))
            {
                MessageBox.Show("No payment receipt image found for this registration.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                byte[] imageBytes = Convert.FromBase64String(reg.PaymentReceiptImage);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    Image receiptImage = Image.FromStream(ms);
                    
                    Form receiptForm = new Form();
                    receiptForm.Text = $"Payment Receipt - {reg.FullName}";
                    receiptForm.Size = new Size(600, 800);
                    receiptForm.StartPosition = FormStartPosition.CenterScreen;

                    PictureBox pb = new PictureBox();
                    pb.Dock = DockStyle.Fill;
                    pb.Image = receiptImage;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    
                    receiptForm.Controls.Add(pb);
                    receiptForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                currentSelectedRowIndex = e.RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                var regIdValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (regIdValue == null) return;

                int regId = Convert.ToInt32(regIdValue);
                var result = MessageBox.Show("Are you sure you want to delete this registration?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool success = await ApiService.DeleteAsync($"registrations/{regId}");
                    if (success)
                    {
                        MessageBox.Show("Registration deleted successfully.");
                        await LoadRegistrationsAsync();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete registration: " + ApiService.LastErrorMessage);
                    }
                }
            }
        }

        private async void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Colum index 5 is 'Status' in the designer
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrEmpty(newValue))
                {
                    // Temporarily set currentSelectedRowIndex for the helper method
                    int oldIndex = currentSelectedRowIndex;
                    currentSelectedRowIndex = e.RowIndex;
                    await UpdateStatusAsync(newValue);
                    currentSelectedRowIndex = oldIndex;
                }
            }
        }

        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty && dataGridView1.CurrentCell is DataGridViewComboBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

