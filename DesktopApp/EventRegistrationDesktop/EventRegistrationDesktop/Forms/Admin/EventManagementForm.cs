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
    public partial class EventManagementForm : Form
    {
        public EventManagementForm()
        {
            InitializeComponent();
            StyleDataGridView();
            LoadSampleEvents();
        }

        private void StyleDataGridView()
        {
            dataGridViewEvents.BorderStyle = BorderStyle.None;
            dataGridViewEvents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewEvents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEvents.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridViewEvents.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewEvents.BackgroundColor = Color.White;

            dataGridViewEvents.EnableHeadersVisualStyles = false;
            dataGridViewEvents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewEvents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewEvents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewEvents.ColumnHeadersHeight = 40;

            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.RowTemplate.Height = 35;
        }

        private void LoadSampleEvents()
        {
            dataGridViewEvents.Rows.Add("Future Tech Summit", "2026-08-20", "Addis Ababa", "500");
            dataGridViewEvents.Rows.Add("Melodic Beats Festival", "2026-09-05", "Bahir Dar", "1000");
        }
    }
}
