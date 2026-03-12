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
    public partial class DashboardForm : Form
    {
        private Form activeForm = null;
        private Button currentButton = null;
        private Color defaultBtnColor = SystemColors.Control;
        private Color hoverBtnColor = Color.LightSkyBlue;
        private Color activeBtnColor = Color.DeepSkyBlue;

        public DashboardForm()
        {
            InitializeComponent();
            btnEvents.Click += BtnEvents_Click;
            btndashboard.Click += Btndashboard_Click;
            btnLogout.Click += BtnLogout_Click;

            btnparticipants.Click += (s, e) => ActivateButton(btnparticipants);
            btnReports.Click += (s, e) => ActivateButton(btnReports);

            SetupSidebarButtons();

            // Set dashboard active at first
            ActivateButton(btndashboard);
        }

        private void SetupSidebarButtons()
        {
            foreach (Control ctrl in panelsidebar.Controls)
            {
                if (ctrl is Button btn && btn.Name != "btnLogout")
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = defaultBtnColor;

                    btn.MouseEnter += (s, e) => {
                        if (currentButton != btn)
                            btn.BackColor = hoverBtnColor;
                    };

                    btn.MouseLeave += (s, e) => {
                        if (currentButton != btn)
                            btn.BackColor = defaultBtnColor;
                    };
                }
            }
        }

        private void ActivateButton(Button btn)
        {
            if (btn == null) return;

            // Reset previous button
            if (currentButton != null)
            {
                currentButton.BackColor = defaultBtnColor;
            }

            // Set new active button
            currentButton = btn;
            currentButton.BackColor = activeBtnColor;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            panelmain.Controls.Add(childForm);
            panelmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            lblTitle.Text = "Event Registration System - " + childForm.Text;
        }

        private void Btndashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btndashboard);
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            lblTitle.Text = "Event Registration System - Admin Dashboard";
        }

        private void BtnEvents_Click(object sender, EventArgs e)
        {
            ActivateButton(btnEvents);
            openChildForm(new EventManagementForm());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            EventRegistrationDesktop.Forms.LoginForm login = new EventRegistrationDesktop.Forms.LoginForm();
            login.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNoOfPending_Click(object sender, EventArgs e)
        {

        }

        private void btnEvents_Click_1(object sender, EventArgs e)
        {

        }

        private void labNoOfevents_Click(object sender, EventArgs e)
        {

        }

        private void btnparticipants_Click(object sender, EventArgs e)
        {
            ActivateButton(btnEvents);
            openChildForm(new ParticipantManagementForm());
        }
    }
}
