using EventRegistrationDesktop.Forms.Components;
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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Go back to login
            EventRegistrationDesktop.Forms.Components.LoginForm login = new EventRegistrationDesktop.Forms.Components.LoginForm();
            login.Show();
            this.Close();
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
             LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
