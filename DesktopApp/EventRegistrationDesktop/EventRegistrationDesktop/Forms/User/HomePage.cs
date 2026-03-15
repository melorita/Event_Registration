using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventRegistrationDesktop.Forms.Components;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class HomePage : BaseDashboardForm
    {
        public HomePage(bool isLoggedIn = false)
        {
            InitializeComponent();

            btnHome3.Click += (s, e) => ActivateButton(btnHome3);  
            btnHome2.Click += (s, e) => ActivateButton(btnHome2);  
            btnHome.Click  += (s, e) => ActivateButton(btnHome);   

            SetupSidebarButtons(homeheaderpanel);

            ActivateButton(btnHome3);
            
            if (isLoggedIn)
            {
                btnHome.Text = "Logout";
                btnMyRegistration.Visible = true;
            }
            else
            {
                btnHome.Text = "Login";
                btnMyRegistration.Visible = false;
            }
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnMyRegistration_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewRegistrationForm(), homeMainPanel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (btnHome.Text == "Logout")
            {
                HomePage form = new HomePage(false);
                form.Show();
                this.Hide();
            }
            else
            {
                LoginForm form = new LoginForm();
                form.Show();
                this.Hide();
            }
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            openChildForm(new EventListForm(), homeMainPanel);
        }
    }
}
