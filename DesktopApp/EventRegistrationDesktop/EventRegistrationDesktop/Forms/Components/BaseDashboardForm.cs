using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Forms.Components
{
    public class BaseDashboardForm : Form
    {
        protected Form activeForm = null;
        protected Button currentButton = null;
        protected Color defaultBtnColor = Color.Transparent;
        protected Color hoverBtnColor = Color.FromArgb(50, 255, 255, 255); // Semi-transparent white
        protected Color activeBtnColor = Color.FromArgb(80, 255, 255, 255); // More opaque white overlay

        protected void SetupSidebarButtons(Control sidebarPanel)
        {
            foreach (Control ctrl in sidebarPanel.Controls)
            {
                if (ctrl is Button btn && btn.Name != "btnLogout")
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = defaultBtnColor;
                    Color originalForeColor = btn.ForeColor;

                    btn.MouseEnter += (s, e) => {
                        if (currentButton != btn)
                        {
                            btn.BackColor = hoverBtnColor;
                            btn.ForeColor = Color.White;
                        }
                    };

                    btn.MouseLeave += (s, e) => {
                        if (currentButton != btn)
                        {
                            btn.BackColor = defaultBtnColor;
                            btn.ForeColor = originalForeColor;
                        }
                    };
                }
            }
        }

        protected void ActivateButton(Button btn)
        {
            if (btn == null) return;

            // Reset previous button
            if (currentButton != null)
            {
                currentButton.BackColor = defaultBtnColor;
                currentButton.ForeColor = Color.White; 
            }

            // Set new active button
            currentButton = btn;
            currentButton.BackColor = activeBtnColor;
            currentButton.ForeColor = Color.White;
        }

        protected void openChildForm(Form childForm, Panel mainPanel, Label titleLabel = null)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            if (titleLabel != null)
                titleLabel.Text = "Event Registration System - " + childForm.Text;
        }
    }
}
