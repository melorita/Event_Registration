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
        private string _selectedReceiptBase64 = "";
        private string currentEventName;
        private int _eventId;

        public ParticipantRegistrationForm()
        {
            InitializeComponent();
        }

        public ParticipantRegistrationForm(EventListForm.EventItem ev)
        {
            InitializeComponent();
            this._eventId = ev.Id;
            this.currentEventName = ev.Title;
            lblEventTitleSummary.Text = ev.Title;
            lblSummaryTitle.Text = $"Event Summary: {ev.Date} @ {ev.Location}";
            
            SetupReceiptLogic();
        }

        private void SetupReceiptLogic()
        {
            btnBrowseReceipt.Click += (s, e) => {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(ofd.FileName);
                        _selectedReceiptBase64 = Convert.ToBase64String(imageArray);
                        lblParticipantCount.Text = "Receipt: " + System.IO.Path.GetFileName(ofd.FileName);
                        pbReceiptPreview.Image = Image.FromFile(ofd.FileName);
                    }
                }
            };
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

        private async void btnRegister_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(_selectedReceiptBase64))
            {
                MessageBox.Show("Please upload a payment receipt screenshot.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnRegister.Enabled = false;
            btnRegister.Text = "Processing...";

            int successCount = 0;
            foreach (var p in participants)
            {
                var dto = new {
                    EventId = _eventId,
                    FullName = p.Name,
                    Email = p.Email,
                    PaymentReceiptImage = _selectedReceiptBase64
                };

                bool success = await Services.ApiService.PostAsync("registrations", dto);
                if (success) successCount++;
            }

            if (successCount > 0)
            {
                MessageBox.Show($"Successfully registered {successCount} participant(s) for {currentEventName}! Status is 'Pending' until approved by admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. " + Services.ApiService.LastErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRegister.Enabled = true;
                btnRegister.Text = "Final Register";
            }
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
