using EventRegistrationDesktop.Models;
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
        List<Event> events = new List<Event>();

        public EventManagementForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                Event ev = new Event();

                ev.EventName = txtEventName.Text;
                ev.EventDate = dtEventDate.Value;
                ev.Location = txtLocation.Text;

                events.Add(ev);

                dgvEvents.DataSource = null;
                dgvEvents.DataSource = events;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEvents.CurrentRow != null)
            {
                events.RemoveAt(dgvEvents.CurrentRow.Index);

                dgvEvents.DataSource = null;
                dgvEvents.DataSource = events;
            }
        }

        private void EventManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
