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
            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.LoginForm login = new EventRegistrationDesktop.Forms.LoginForm();
            login.Show();
            this.Close();
        }
    }
}
