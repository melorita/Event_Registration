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
            LoadSampleRegistrations();
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
        }

        private void LoadSampleRegistrations()
        {
            dataGridView1.Rows.Add("Future Tech Summit", "Aug 20, 2026", "Addis Ababa", "Mar 10, 2026", "Approved");
            dataGridView1.Rows.Add("Melodic Beats Festival", "Sep 05, 2026", "Bahir Dar", "Mar 12, 2026", "Pending");
        }
    }
}
