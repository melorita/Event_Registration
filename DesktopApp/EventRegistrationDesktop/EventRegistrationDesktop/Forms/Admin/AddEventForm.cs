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
    public partial class AddEventForm : Form
    {
        List<Event> events = new List<Event>();
        string imagePath = "";
        public AddEventForm()
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

            // 2. Validate Capacity (must be a number)
            if (!int.TryParse(textBox2.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Date Validation (must not be in the past)
            if (dtEventDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The event date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Image Validation (Optional but recommended)
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please upload an event image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If all validation passes
            MessageBox.Show("Event Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Here you would typically save to database/list
            // For now, we just clear the form or close
            this.Close();
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
