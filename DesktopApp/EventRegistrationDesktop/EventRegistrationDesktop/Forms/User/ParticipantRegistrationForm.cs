using System;
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
    public partial class ParticipantRegistrationForm : Form
    {
        private List<Participant> participants = new List<Participant>();
        private string currentEventName;

        public ParticipantRegistrationForm()
        {
            InitializeComponent();
        }

        public ParticipantRegistrationForm(EventListForm.EventItem ev)
        {
            InitializeComponent();
            this.currentEventName = ev.Title;
            lblEventTitleSummary.Text = ev.Title;
            lblSummaryTitle.Text = $"Event Summary: {ev.Date} @ {ev.Location}";
            
            // For demo: auto-fill some user data if session was available
            // txtFullName.Text = "Current User"; 
            // txtEmail.Text = "user@example.com";
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AddCurrentParticipant();
                ClearInputs();
                MessageBox.Show("Participant added. Please enter details for the next person.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                if (ValidateInput())
                {
                    AddCurrentParticipant();
                }
                else
                {
                    return;
                }
            }

            if (participants.Count == 0)
            {
                MessageBox.Show("Please add at least one participant.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Here you would typically call your ApiService to save registration
            string summary = $"Successfully registered {participants.Count} participant(s) for {currentEventName}:\n";
            foreach (var p in participants)
            {
                summary += $"- {p.Name} ({p.Email})\n";
            }

            MessageBox.Show(summary, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Full Name and Email are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddCurrentParticipant()
        {
            participants.Add(new Participant
            {
                Name = txtFullName.Text,
                Email = txtEmail.Text
            });
            UpdateParticipantList();
        }

        private void ClearInputs()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtFullName.Focus();
        }

        private void UpdateParticipantList()
        {
            // Update a simple display or status
            lblParticipantCount.Text = $"Participants added: {participants.Count}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            participants.Clear();
            UpdateParticipantList();
        }

        public class Participant
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}
