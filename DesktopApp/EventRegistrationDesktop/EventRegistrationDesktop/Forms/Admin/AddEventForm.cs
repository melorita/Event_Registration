using EventRegistrationDesktop.Models;
using EventRegistrationDesktop.Services;
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
    public partial class AddEventForm : Form
    {
        private bool _isEditMode = false;
        private int _eventId = 0;
        private string _existingImageBase64 = "";
        private string imagePath = "";

        public AddEventForm()
        {
            InitializeComponent();
        }

        public AddEventForm(Event ev)
        {
            InitializeComponent();
            _isEditMode = true;
            _eventId = ev.Id;
            
            // Populate fields
            txtEventName.Text = ev.EventName;
            txtDescription.Text = ev.Description;
            dtEventDate.Value = ev.Date;
            txtLocation.Text = ev.Location;
            textBox2.Text = ev.Capacity.ToString();
            cmbCategory.Text = ev.Category;
            txtOrganizer.Text = ev.Organizer;
            _existingImageBase64 = ev.EventImage;

            if (!string.IsNullOrEmpty(ev.EventImage))
            {
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(ev.EventImage);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBoxEvent.Image = Image.FromStream(ms);
                        pictureBoxEvent.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch { /* Ignore image loading errors */ }
            }

            btnAdd.Text = "Update Event";
            this.Text = "Edit Event";
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Check for empty fields
            if (string.IsNullOrWhiteSpace(txtEventName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) || // Capacity
                string.IsNullOrWhiteSpace(txtOrganizer.Text) ||
                cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Validate Capacity
            if (!int.TryParse(textBox2.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Date Validation
            if (dtEventDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The event date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prepare event data
            string imageBase64 = _existingImageBase64;
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(imagePath);
                    imageBase64 = Convert.ToBase64String(imageArray);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing image: " + ex.Message);
                }
            }

            var eventData = new Event
            {
                Id = _eventId,
                EventName = txtEventName.Text,
                Description = txtDescription.Text,
                Date = dtEventDate.Value,
                Location = txtLocation.Text,
                Capacity = capacity,
                Category = cmbCategory.Text,
                Organizer = txtOrganizer.Text,
                EventImage = imageBase64
            };

            bool success;
            if (_isEditMode)
            {
                success = await ApiService.PutAsync($"events/{_eventId}", eventData);
            }
            else
            {
                success = await ApiService.PostAsync("events", eventData);
            }

            if (success)
            {
                string message = _isEditMode ? "Event Updated Successfully!" : "Event Added Successfully!";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                string error = ApiService.LastErrorMessage;
                if (string.IsNullOrEmpty(error)) error = "Please check your connection or if the server is running.";
                
                string message = _isEditMode ? "Failed to update event: " : "Failed to add event: ";
                MessageBox.Show(message + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            // Allow only image files
            op.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

            // Title of the dialog
            op.Title = "Select Event Image";

            if (op.ShowDialog() == DialogResult.OK)
            {
                // Save image path
                imagePath = op.FileName;

                // Display image in PictureBox
                pictureBoxEvent.Image = Image.FromFile(imagePath);
                pictureBoxEvent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtCapacity_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
