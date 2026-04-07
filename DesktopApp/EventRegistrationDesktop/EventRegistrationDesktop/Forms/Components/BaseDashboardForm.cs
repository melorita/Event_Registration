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
        protected void ApplyRoundedCorners(Control ctrl, int radius)
        {
            if (ctrl == null) return;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            ctrl.Region = new Region(gp);
        }

        protected void BeautifyButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            // Dynamic Hover
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(backColor);
            btn.MouseLeave += (s, e) => btn.BackColor = backColor;
        }
    }
}
