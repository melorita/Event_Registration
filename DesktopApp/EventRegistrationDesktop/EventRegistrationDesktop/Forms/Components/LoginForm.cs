using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventRegistrationDesktop.Services;
using EventRegistrationDesktop.Models;

namespace EventRegistrationDesktop.Forms.Components
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblError.BringToFront();
            StyleModernUI();
        }

        private void StyleModernUI()
        {
            this.BackColor = Color.FromArgb(24, 30, 54);
            rtblogin.BackColor = Color.FromArgb(37, 42, 64);
            rtblogin.BorderStyle = BorderStyle.None;
            UIHelper.ApplyRoundedCorners(rtblogin, 30);

            lblogin1.BackColor = Color.Transparent;
            lblogin1.ForeColor = Color.White;
            lblogin1.Font = new Font("Segoe UI", 24, FontStyle.Bold);

            lbemail.BackColor = Color.Transparent;
            lbemail.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            UIHelper.StyleTextBox(textBox1);
            UIHelper.StyleTextBox(textBox2);

            UIHelper.BeautifyButton(button1, Color.FromArgb(0, 126, 249));
            UIHelper.BeautifyButton(btnRegister, Color.FromArgb(46, 51, 73));
            UIHelper.BeautifyButton(btnback1, Color.Gray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.User.UserRegistrationForm regForm = new EventRegistrationDesktop.Forms.User.UserRegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            // 1. Check if empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Visible = true;
                lblError.BringToFront();
                lblError.Text = "Please enter email and password!";
                lblError.ForeColor = Color.Red;
                return;
            }

            // 2. Check email format
            if (!email.Contains("@"))
            {
                lblError.Visible = true;
                lblError.BringToFront();
                lblError.Text = "Please enter a valid email address!";
                lblError.ForeColor = Color.Red;
                return;
            }

            // 3. Check password length
            if (password.Length < 8)
            {
                lblError.Visible = true;
                lblError.BringToFront();
                lblError.Text = "Password must be at least 8 characters!";
                lblError.ForeColor = Color.Red;
                return;
            }

            var loginData = new Models.LoginDto { Email = email, Password = password };
            var result = await ApiService.PostWithResultAsync<Models.LoginDto, Models.UserDto>("account/login", loginData);

            if (result != null)
            {
                SessionService.Login(result.FullName, result.Email, result.Role, result.Token);

                if (result.Role == "Admin")
                {
                    EventRegistrationDesktop.Forms.Admin.DashboardForm dashForm = new EventRegistrationDesktop.Forms.Admin.DashboardForm();
                    dashForm.Show();
                    this.Hide();
                }
                else
                {
                    EventRegistrationDesktop.Forms.User.HomePage homeForm = new EventRegistrationDesktop.Forms.User.HomePage(true);
                    homeForm.Show();
                    this.Hide();
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.BringToFront();
                lblError.Text = "Invalid email or password!";
                lblError.ForeColor = Color.Red;
            }
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.User.HomePage homeForm = new EventRegistrationDesktop.Forms.User.HomePage(false);
            homeForm.Show();
            this.Close();
        }
    }
}
