using EventRegistrationDesktop.Forms.Components;
using EventRegistrationDesktop.Services;
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

namespace EventRegistrationDesktop.Forms.User
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
            StyleModernUI();
        }

        private void StyleModernUI()
        {
            this.BackColor = Color.FromArgb(24, 30, 54);
            panel1.BackColor = Color.FromArgb(37, 42, 64);
            UIHelper.ApplyRoundedCorners(panel1, 40);

            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);

            // Style Labels
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Label lbl && lbl != lblTitle)
                {
                    lbl.ForeColor = Color.LightGray;
                    lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                if (ctrl is TextBox txt)
                {
                    UIHelper.StyleTextBox(txt);
                }
            }

            UIHelper.BeautifyButton(btnRegister, Color.FromArgb(0, 126, 249));
            UIHelper.BeautifyButton(btnlogin, Color.FromArgb(46, 51, 73));
            UIHelper.BeautifyButton(backButton, Color.Gray);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(txtphonenumber.Text) || 
                string.IsNullOrWhiteSpace(txtpassword.Text) ||
                string.IsNullOrWhiteSpace(txtconfirmpassword.Text))
            {
                MessageBox.Show("Entry is empty! Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if gender is selected
            if (!rbMale.Checked && !Female.Checked)
            {
                MessageBox.Show("Please select your gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if phone number is a number
            if (!long.TryParse(txtphonenumber.Text, out _))
            {
                MessageBox.Show("Phone number must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check email format
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtpassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var registerData = new Models.RegisterDto
            {
                FullName = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtphonenumber.Text,
                Gender = rbMale.Checked ? "Male" : "Female",
                Password = txtpassword.Text,
                Address = "" // Optional for now
            };

            var result = await ApiService.PostWithResultAsync<Models.RegisterDto, Models.UserDto>("account/register", registerData);

            if (result != null)
            {
                MessageBox.Show("Registration Successful! Please login to continue.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                string error = ApiService.LastErrorMessage;
                if (string.IsNullOrEmpty(error)) error = "Unknown error occurred. Please check your internet connection or if the server is running.";
                
                // If it's a validation error from ASP.NET, it might be JSON. 
                // We'll keep it simple for the user but provide the full text if available.
                MessageBox.Show(error, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.Components.LoginForm login = new EventRegistrationDesktop.Forms.Components.LoginForm();
            login.Show();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
