using System;
using System.Drawing;
using System.Windows.Forms;
using EventRegistrationDesktop.Services;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private async void LoadUserData()
        {
            var profile = await ApiService.GetAsync<Models.UserProfileResult>("profiles/me");
            if (profile != null)
            {
                txtName.Text = profile.User.FullName;
                txtEmail.Text = profile.User.Email;
                txtRole.Text = profile.User.Role;
                txtPhone.Text = profile.PhoneNumber;
                cmbGender.Text = profile.Gender;
                txtAddress.Text = profile.Address;

                // Sync Session
                SessionService.UserName = profile.User.FullName;
            }
            else
            {
                txtName.Text = SessionService.UserName;
                txtEmail.Text = SessionService.UserEmail;
                txtRole.Text = SessionService.UserRole;
            }

            // Update Avatar Initial
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                lblProfileAvatar.Text = txtName.Text.Substring(0, 1).ToUpper();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var updateDto = new Models.ProfileUpdateDto
            {
                FullName = txtName.Text,
                PhoneNumber = txtPhone.Text,
                Gender = cmbGender.Text,
                Address = txtAddress.Text,
                ProfilePictureUrl = ""
            };

            bool success = await ApiService.PutAsync("profiles", updateDto);

            if (success)
            {
                SessionService.UserName = txtName.Text;
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    lblProfileAvatar.Text = txtName.Text.Substring(0, 1).ToUpper();
                }
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnChangePasswordPop = new System.Windows.Forms.Button();
            this.btnLogoutForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 70);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Text = "User Profile";
            
            // Profile Avatar (Circular with Intitial)
            this.profileAvatarContainer = new System.Windows.Forms.Panel();
            this.lblProfileAvatar = new System.Windows.Forms.Label();
            this.profileAvatarContainer.Controls.Add(this.lblProfileAvatar);
            this.profileAvatarContainer.Location = new System.Drawing.Point(230, 2);
            this.profileAvatarContainer.Size = new System.Drawing.Size(65, 65);
            this.lblProfileAvatar.Size = new System.Drawing.Size(50, 50);
            this.lblProfileAvatar.Location = new System.Drawing.Point(8, 8);
            this.lblProfileAvatar.Text = "U";
            UIHelper.StyleAvatar(this.lblProfileAvatar, this.profileAvatarContainer);
            this.panel1.Controls.Add(this.profileAvatarContainer);

            // Labels and TextBoxes (Centered vertically in the middle, horizontally aligned)
            int labelLeft = 200;
            int textLeft = 320;
            int startTop = 100;
            int verticalGap = 45;

            // Full Name
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(labelLeft, startTop);
            this.label1.Text = "Full Name:";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(textLeft, startTop - 3);
            this.txtName.Size = new System.Drawing.Size(350, 34);

            // Email
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(labelLeft, startTop + verticalGap);
            this.label2.Text = "Email:";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(textLeft, startTop + verticalGap - 3);
            this.txtEmail.Size = new System.Drawing.Size(350, 34);
            this.txtEmail.ReadOnly = true;

            // Role
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(labelLeft, startTop + verticalGap * 2);
            this.label3.Text = "Role:";
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRole.Location = new System.Drawing.Point(textLeft, startTop + verticalGap * 2 - 3);
            this.txtRole.Size = new System.Drawing.Size(350, 34);
            this.txtRole.ReadOnly = true;

            // Phone
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(labelLeft, startTop + verticalGap * 3);
            this.label4.Text = "Phone:";
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(textLeft, startTop + verticalGap * 3 - 3);
            this.txtPhone.Size = new System.Drawing.Size(350, 34);

            // Address
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(labelLeft, startTop + verticalGap * 5);
            this.label5.Text = "Address:";
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(textLeft, startTop + verticalGap * 5 - 3);
            this.txtAddress.Size = new System.Drawing.Size(350, 60);
            this.txtAddress.Multiline = true;

            // Gender
            this.labelGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGender.Location = new System.Drawing.Point(labelLeft, startTop + verticalGap * 4);
            this.labelGender.Text = "Gender:";
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.Location = new System.Drawing.Point(textLeft, startTop + verticalGap * 4 - 3);
            this.cmbGender.Size = new System.Drawing.Size(350, 34);
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;

            // Buttons (Centered)
            int buttonTop = 440;
            int buttonWidth = 160;
            int buttonGap = 15;
            int totalButtonsWidth = (buttonWidth * 4) + (buttonGap * 3);
            int buttonsStartLeft = (900 - totalButtonsWidth) / 2;

            // Save Details
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(buttonsStartLeft, buttonTop);
            this.btnSave.Size = new System.Drawing.Size(buttonWidth, 45);
            this.btnSave.Text = "Save Details";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Change Password
            this.btnChangePasswordPop.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChangePasswordPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePasswordPop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangePasswordPop.ForeColor = System.Drawing.Color.White;
            this.btnChangePasswordPop.Location = new System.Drawing.Point(buttonsStartLeft + buttonWidth + buttonGap, buttonTop);
            this.btnChangePasswordPop.Size = new System.Drawing.Size(buttonWidth, 45);
            this.btnChangePasswordPop.Text = "Change Password";
            this.btnChangePasswordPop.Click += new System.EventHandler(this.btnChangePasswordPop_Click);

            // Logout
            this.btnLogoutForm.BackColor = System.Drawing.Color.Crimson;
            this.btnLogoutForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogoutForm.ForeColor = System.Drawing.Color.White;
            this.btnLogoutForm.Location = new System.Drawing.Point(buttonsStartLeft + (buttonWidth + buttonGap) * 2, buttonTop);
            this.btnLogoutForm.Size = new System.Drawing.Size(buttonWidth, 45);
            this.btnLogoutForm.Text = "Logout Now";
            this.btnLogoutForm.Click += new System.EventHandler(this.btnLogoutForm_Click);

            // Close
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(buttonsStartLeft + (buttonWidth + buttonGap) * 3, buttonTop);
            this.btnClose.Size = new System.Drawing.Size(buttonWidth, 45);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ProfileForm
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangePasswordPop);
            this.Controls.Add(this.btnLogoutForm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1); this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2); this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3); this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label4); this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5); this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelGender); this.Controls.Add(this.cmbGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelGender;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtRole;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private Button btnSave;
        private Button btnClose;
        private Panel panel1;
        private Label lblHeader;
        private Button btnLogoutForm;
        private Button btnChangePasswordPop;
        private Panel profileAvatarContainer;
        private Label lblProfileAvatar;

        private void btnChangePasswordPop_Click(object sender, EventArgs e)
        {
            using (var form = new ChangePasswordForm())
            {
                form.ShowDialog();
            }
        }

        private void btnLogoutForm_Click(object sender, EventArgs e)
        {
            SessionService.Logout();
            Application.Restart();
        }
    }
}

