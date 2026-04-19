using System;
using System.Drawing;
using System.Windows.Forms;
using EventRegistrationDesktop.Services;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 60);

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(15, 15);
            this.lblHeader.Text = "Change Password";

            // btnExit (X button)
            this.btnExit.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnExit.ForeColor = Color.White;
            this.btnExit.Location = new Point(350, 10);
            this.btnExit.Size = new Size(40, 40);
            this.btnExit.Text = "X";
            this.btnExit.Click += (s, e) => this.Close();

            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new Point(50, 90);
            this.label6.Text = "Current Password:";
            this.label6.Font = new Font("Segoe UI", 10F);

            // txtCurrentPassword
            this.txtCurrentPassword.Location = new Point(50, 120);
            this.txtCurrentPassword.Size = new Size(300, 30);
            this.txtCurrentPassword.PasswordChar = '●';

            // label7
            this.label7.AutoSize = true;
            this.label7.Location = new Point(50, 170);
            this.label7.Text = "New Password:";
            this.label7.Font = new Font("Segoe UI", 10F);

            // txtNewPassword
            this.txtNewPassword.Location = new Point(50, 200);
            this.txtNewPassword.Size = new Size(300, 30);
            this.txtNewPassword.PasswordChar = '●';

            // btnUpdate
            this.btnUpdate.BackColor = Color.SeaGreen;
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnUpdate.Location = new Point(50, 260);
            this.btnUpdate.Size = new Size(300, 45);
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.Click += btnUpdate_Click;

            // Form
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string currentPwd = txtCurrentPassword.Text.Trim();
            string newPwd = txtNewPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(currentPwd) || string.IsNullOrWhiteSpace(newPwd))
            {
                MessageBox.Show("Please fill in both current and new password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentPwd == newPwd)
            {
                MessageBox.Show("New password must be different from the current password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var changeDto = new
            {
                CurrentPassword = currentPwd,
                NewPassword = newPwd
            };

            bool success = await ApiService.PostAsync("account/change-password", changeDto);

            if (success)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                string error = ApiService.LastErrorMessage;
                if (string.IsNullOrEmpty(error)) error = "Invalid current password or server error.";
                // The error might be a JSON object if returned from ASP.NET Core
                if (error.Contains("message"))
                {
                    try {
                        // Simple check to see if it's JSON
                        var start = error.IndexOf(":") + 1;
                        var end = error.LastIndexOf("\"");
                        if (start > 0 && end > start)
                            error = error.Substring(start, end - start).Replace("\"", "").Trim();
                    } catch { }
                }
                MessageBox.Show("Failed to update password: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel panelHeader;
        private Label lblHeader;
        private Button btnExit;
        private Label label6;
        private TextBox txtCurrentPassword;
        private Label label7;
        private TextBox txtNewPassword;
        private Button btnUpdate;
    }
}
