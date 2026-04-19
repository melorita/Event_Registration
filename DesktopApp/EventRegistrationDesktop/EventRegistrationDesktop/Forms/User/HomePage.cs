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
using EventRegistrationDesktop.Services;

namespace EventRegistrationDesktop.Forms.User
{
    public partial class HomePage : BaseDashboardForm
    {
        private bool _isLoggedIn = false;

        public HomePage(bool isLoggedIn = false)
        {
            InitializeComponent();
            this._isLoggedIn = isLoggedIn;

            btnHome3.Click += (s, e) => ActivateButton(btnHome3);  
            btnHome2.Click += (s, e) => ActivateButton(btnHome2);  
            btnHome.Click  += (s, e) => ActivateButton(btnHome);   

            SetupSidebarButtons(homeheaderpanel);

            ActivateButton(btnHome3);

            // Set Background Image
            try
            {
                string assetPath = System.IO.Path.Combine(Application.StartupPath, "Assets", "hero-bg.jpg");
                // If not in bin, check project root (for design time/debug)
                if (!System.IO.File.Exists(assetPath))
                    assetPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "hero-bg.jpg");

                if (System.IO.File.Exists(assetPath))
                {
                    homeMainPanel.BackgroundImage = Image.FromFile(assetPath);
                    homeMainPanel.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch { }

            lbhome.BackColor = Color.Transparent;
            lbhome2.BackColor = Color.Transparent;
            lbhome2.ForeColor = Color.White; 
            lbhome.ForeColor = Color.White;
            
            if (isLoggedIn)
            {
                btnHome.Text = "Logout";
                btnMyRegistration.Visible = true;
                btnHome3.Visible = false; 
                profileContainer.Visible = true;

                // Set initial in avatar
                if (!string.IsNullOrEmpty(SessionService.UserName))
                {
                    lblAvatar.Text = SessionService.UserName.Substring(0, 1).ToUpper();
                }
                UIHelper.StyleAvatar(lblAvatar, profileContainer);
                
                btnHome2_Click(null, null);
                ActivateButton(btnHome2);
            }
            else
            {
                btnHome.Text = "Login";
                btnMyRegistration.Visible = false;
                btnHome3.Visible = true;
                profileContainer.Visible = false;
            }
            
            CenterHeroText();
        }

        private void CenterHeroText()
        {
            // Center lbhome (Main Title)
            lbhome.Left = (homeMainPanel.Width - lbhome.Width) / 2;
            lbhome.Top = (homeMainPanel.Height / 2) - 100;
            lbhome.Anchor = AnchorStyles.None;

            // Center lbhome2 (Subtitle)
            lbhome2.Left = (homeMainPanel.Width - lbhome2.Width) / 2;
            lbhome2.Top = lbhome.Bottom + 20;
            lbhome2.Anchor = AnchorStyles.None;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm(), homeMainPanel);
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
                if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SessionService.Logout();
                    HomePage form = new HomePage(false);
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        if (SessionService.UserRole == "Admin")
                        {
                            EventRegistrationDesktop.Forms.Admin.DashboardForm dash = new EventRegistrationDesktop.Forms.Admin.DashboardForm();
                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Refresh home page with logged in state
                            HomePage form = new HomePage(true);
                            form.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            var eventList = new EventListForm();
            eventList.OnRegisterClicked = (ev) =>
            {
                if (!_isLoggedIn)
                {
                    MessageBox.Show("Please login first to register for an event.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    using (LoginForm loginForm = new LoginForm())
                    {
                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            if (SessionService.UserRole == "Admin")
                            {
                                EventRegistrationDesktop.Forms.Admin.DashboardForm dash = new EventRegistrationDesktop.Forms.Admin.DashboardForm();
                                dash.Show();
                                this.Hide();
                            }
                            else
                            {
                                HomePage form = new HomePage(true);
                                form.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {
                    openChildForm(new ParticipantRegistrationForm(ev), homeMainPanel);
                }
            };
            openChildForm(eventList, homeMainPanel);
        }
    }
}
