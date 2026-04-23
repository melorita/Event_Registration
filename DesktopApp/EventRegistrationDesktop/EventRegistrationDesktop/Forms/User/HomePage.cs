using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private List<FloatingShape> _shapes;
        private Timer _animationTimer;
        private Color _creamColor = Color.FromArgb(249, 237, 204);

        public HomePage(bool isLoggedIn = false)
        {
            InitializeComponent();
            this._isLoggedIn = isLoggedIn;

            // Remove existing background image
            homeMainPanel.BackgroundImage = null;

            // Add Paint event for gradient
            homeMainPanel.Paint += HomeMainPanel_Paint;
            
            // Create shapes
            InitializeShapes();

            // Set up transparent labels
            lbhome.BackColor = Color.Transparent;
            lbhome2.BackColor = Color.Transparent;
            lbhome2.ForeColor = Color.FromArgb(220, 255, 255, 255); // Light opacity white
            lbhome.ForeColor = Color.White;
            lbhome1.ForeColor = Color.White; // White for Logo visibility
            
            // Set texts
            lbhome.Text = "ethio events\r\nRegister for your favourite events";
            lbhome2.Text = "Join thousands of people discovering and attending local events.\r\nIt's fast, secure, and built for you.";

            // Style buttons
            StyleHeroButton(btnHome2);
            StyleHeroButton(btnNavLogin);
            
            // Add Hover Effects
            AddHoverEffect(btnHome2, Color.FromArgb(0, 122, 183));
            AddHoverEffect(btnNavLogin, Color.FromArgb(0, 122, 183));

            if (isLoggedIn)
            {
                btnNavLogin.Text = "Logout";
            }
            else
            {
                btnNavLogin.Text = "Login";
            }
            
            // Fix positioning
            homeMainPanel.Resize += (s, e) => { PositionElements(); };
            PositionElements();
        }

        private void InitializeShapes()
        {
            _shapes = new List<FloatingShape>();
            Random rand = new Random();
            for (int i = 0; i < 8; i++) // Added more shapes for movement feeling
            {
                _shapes.Add(new FloatingShape
                {
                    X = rand.Next(600, 1200),
                    Y = rand.Next(100, 600),
                    Size = rand.Next(30, 120),
                    SpeedY = (float)(rand.NextDouble() * 1.5 - 0.75),
                    IsCircle = rand.Next(2) == 0,
                    Opacity = rand.Next(40, 120)
                });
            }
        }

        private void HomeMainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Gradient Background
            using (LinearGradientBrush brush = new LinearGradientBrush(
                homeMainPanel.ClientRectangle, 
                Color.FromArgb(253, 246, 227), // Cream
                Color.FromArgb(0, 170, 204), // Cyan
                45F))
            {
                ColorBlend blend = new ColorBlend();
                blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };
                blend.Colors = new Color[] { 
                    Color.FromArgb(255, 253, 230), // Lighter Cream
                    Color.FromArgb(32, 178, 170), // Teal
                    Color.FromArgb(0, 102, 128) // Deep Blue/Cyan
                };
                brush.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush, homeMainPanel.ClientRectangle);
            }

            // Draw Shapes
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (var shape in _shapes)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(shape.Opacity, 255, 255, 255)))
                {
                    if (shape.IsCircle)
                        e.Graphics.FillEllipse(brush, shape.X, shape.Y, shape.Size, shape.Size);
                    else
                        e.Graphics.FillRectangle(brush, shape.X, shape.Y, shape.Size, shape.Size);
                }
            }
        }

        private void StyleHeroButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(0, 102, 153); // Teal/Blue
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Paint += (s, e) => {
                GraphicsPath path = new GraphicsPath();
                int r = 25; // More rounded
                path.AddArc(0, 0, r, r, 180, 90);
                path.AddArc(btn.Width - r, 0, r, r, 270, 90);
                path.AddArc(btn.Width - r, btn.Height - r, r, r, 0, 90);
                path.AddArc(0, btn.Height - r, r, r, 90, 90);
                btn.Region = new Region(path);
            };
        }

        private void StyleNavButton(Button btn, bool outlined)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            if (outlined)
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.FlatAppearance.BorderSize = 2;
                btn.Paint += (s, e) => {
                    GraphicsPath path = new GraphicsPath();
                    int r = 15;
                    path.AddArc(0, 0, r, r, 180, 90);
                    path.AddArc(btn.Width - r, 0, r, r, 270, 90);
                    path.AddArc(btn.Width - r, btn.Height - r, r, r, 0, 90);
                    path.AddArc(0, btn.Height - r, r, r, 90, 90);
                    btn.Region = new Region(path);
                };
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = _creamColor;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void StyleNavLink(Button btn, Color color)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = color;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
        }

        private void AddHoverEffect(Button btn, Color hoverColor, Color? textHoverColor = null)
        {
            Color originalBase = btn.BackColor;
            Color originalText = btn.ForeColor;

            btn.MouseEnter += (s, e) => {
                btn.BackColor = hoverColor;
                if (textHoverColor.HasValue) btn.ForeColor = textHoverColor.Value;
            };

            btn.MouseLeave += (s, e) => {
                btn.BackColor = originalBase;
                btn.ForeColor = originalText;
            };
        }

        private void PositionElements()
        {
            // Center Logo at the top
            lbhome1.Left = (homeMainPanel.Width - lbhome1.Width) / 2;
            lbhome1.Top = 60;

            // Center Title
            lbhome.Left = 0;
            lbhome.Width = homeMainPanel.Width;
            lbhome.Top = (homeMainPanel.Height / 2) - 160;
            
            // Center Subtitle
            lbhome2.Left = 0;
            lbhome2.Width = homeMainPanel.Width;
            lbhome2.Top = lbhome.Bottom + 10;
            
            // Center Buttons side by side
            int gap = 30;
            int totalWidth = btnHome2.Width + btnNavLogin.Width + gap;
            int startX = (homeMainPanel.Width - totalWidth) / 2;
            
            btnHome2.Left = startX;
            btnHome2.Top = lbhome2.Bottom + 60;
            
            btnNavLogin.Left = btnHome2.Right + gap;
            btnNavLogin.Top = btnHome2.Top;
        }

        private void btnHome3_Click(object sender, EventArgs e) 
        { 
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
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
                    btnHome_Click(null, null);
                }
                else
                {
                    openChildForm(new ParticipantRegistrationForm(ev), homeMainPanel);
                }
            };
            openChildForm(eventList, homeMainPanel);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm(), homeMainPanel);
        }

        private void btnMyRegistration_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewRegistrationForm(), homeMainPanel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (btnNavLogin.Text == "Logout")
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
                            HomePage form = new HomePage(true);
                            form.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
        private class FloatingShape
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Size { get; set; }
            public float SpeedY { get; set; }
            public bool IsCircle { get; set; }
            public int Opacity { get; set; }
            
            public void Update() { /* Static */ }
        }
    }
}
