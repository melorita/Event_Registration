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
        public HomePage()
        {
            InitializeComponent();

            btnHome3.Click += (s, e) => ActivateButton(btnHome3);  
            btnHome2.Click += (s, e) => ActivateButton(btnHome2);  
            btnHome.Click  += (s, e) => ActivateButton(btnHome);   

            
            SetupSidebarButtons(homeheaderpanel);

           
            ActivateButton(btnHome3);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
