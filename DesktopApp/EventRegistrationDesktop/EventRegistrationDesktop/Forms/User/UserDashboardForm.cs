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
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
            OpenForm(new EventListForm());
        }
        public void OpenForm(Form form)
        {
            userdashboardmainPanel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            userdashboardmainPanel.Controls.Add(form);
            form.Show();
        }
    }

}
