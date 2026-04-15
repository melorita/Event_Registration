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
    public partial class EventManagementForm : Form
    {
        private List<EventRegistrationDesktop.Models.Event> _eventsList = new List<EventRegistrationDesktop.Models.Event>();

        public EventManagementForm()
        {
            InitializeComponent();
            StyleDataGridView();
            this.Load += async (s, e) => await LoadEventsAsync();
            dataGridViewEvents.CellContentClick += DataGridViewEvents_CellContentClick;
        }

        private async void DataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure we're not clicking the header
            if (e.RowIndex < 0) return;

            var selectedEvent = _eventsList[e.RowIndex];

            // Edit Button
            if (dataGridViewEvents.Columns[e.ColumnIndex].Name == "colActionEdit")
            {
                var editForm = new AddEventForm(selectedEvent);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadEventsAsync();
                }
            }
            // Delete Button
            else if (dataGridViewEvents.Columns[e.ColumnIndex].Name == "colActionDelete")
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to delete '{selectedEvent.EventName}'?", 
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = await ApiService.DeleteAsync($"events/{selectedEvent.Id}");
                    if (success)
                    {
                        MessageBox.Show("Event deleted successfully.");
                        await LoadEventsAsync();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete event.");
                    }
                }
            }
        }

        private void StyleDataGridView()
        {
            dataGridViewEvents.BorderStyle = BorderStyle.None;
            dataGridViewEvents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewEvents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEvents.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridViewEvents.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewEvents.BackgroundColor = Color.White;
            dataGridViewEvents.RowHeadersVisible = false;

            dataGridViewEvents.EnableHeadersVisualStyles = false;
            dataGridViewEvents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewEvents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewEvents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewEvents.ColumnHeadersHeight = 40;

            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.RowTemplate.Height = 35;
        }

        private async Task LoadEventsAsync()
        {
            _eventsList = await ApiService.GetAsync<List<EventRegistrationDesktop.Models.Event>>("events");
            
            dataGridViewEvents.Rows.Clear();
            
            if (_eventsList != null)
            {
                foreach (var ev in _eventsList)
                {
                    dataGridViewEvents.Rows.Add(ev.EventName, ev.Date.ToShortDateString(), ev.Location, ev.Capacity);
                }
            }
        }
    }
}
