using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Forms.Components
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.Admin.DashboardForm dashboardForm = new EventRegistrationDesktop.Forms.Admin.DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.User.UserRegistrationForm regForm = new EventRegistrationDesktop.Forms.User.UserRegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.User.UserRegistrationForm regForm = new EventRegistrationDesktop.Forms.User.UserRegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            // 1. Check if empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Entry is empty! Please fill all fields.";
                lblError.ForeColor = Color.Red;
                return;
            }

            // 2. Check password length
            if (password.Length < 8)
            {
                lblError.Text = "Password must be at least 8 characters.";
                lblError.ForeColor = Color.Red;
                return;
            }

            if (email == "admin@admin.com" && password == "admin123")
            {
                EventRegistrationDesktop.Forms.Admin.DashboardForm dashForm = new EventRegistrationDesktop.Forms.Admin.DashboardForm();
                dashForm.Show();
                this.Hide();
            }
            else
            {
                // In a real app, you'd verify against a database here
                EventRegistrationDesktop.Forms.User.HomePage homeForm = new EventRegistrationDesktop.Forms.User.HomePage(true);
                homeForm.Show();
                this.Hide();
            }
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.User.HomePage homeForm = new EventRegistrationDesktop.Forms.User.HomePage(true);
            homeForm.Show();
            this.Hide();
        }
    }
}
