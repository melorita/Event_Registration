namespace EventRegistrationDesktop.Forms.User
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.homeMainPanel = new System.Windows.Forms.Panel();
            this.lbhome1 = new System.Windows.Forms.Label();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.btnNavLogin = new System.Windows.Forms.Button();
            this.lbhome2 = new System.Windows.Forms.Label();
            this.lbhome = new System.Windows.Forms.Label();
            this.btnHeroGetStarted = new System.Windows.Forms.Button();
            this.homeMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeMainPanel
            // 
            this.homeMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.homeMainPanel.Controls.Add(this.lbhome1);
            this.homeMainPanel.Controls.Add(this.btnHome2);
            this.homeMainPanel.Controls.Add(this.btnNavLogin);
            this.homeMainPanel.Controls.Add(this.lbhome2);
            this.homeMainPanel.Controls.Add(this.lbhome);
            this.homeMainPanel.Controls.Add(this.btnHeroGetStarted);
            this.homeMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMainPanel.Location = new System.Drawing.Point(0, 0);
            this.homeMainPanel.Name = "homeMainPanel";
            this.homeMainPanel.Size = new System.Drawing.Size(1274, 678);
            this.homeMainPanel.TabIndex = 1;
            // 
            // lbhome1
            // 
            this.lbhome1.AutoSize = true;
            this.lbhome1.Font = new System.Drawing.Font("Constantia", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbhome1.ForeColor = System.Drawing.Color.White;
            this.lbhome1.Location = new System.Drawing.Point(580, 50);
            this.lbhome1.Name = "lbhome1";
            this.lbhome1.Size = new System.Drawing.Size(114, 78);
            this.lbhome1.TabIndex = 3;
            this.lbhome1.Text = "e.e";
            // 
            // btnHome2
            // 
            this.btnHome2.Location = new System.Drawing.Point(430, 500);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(180, 45);
            this.btnHome2.TabIndex = 6;
            this.btnHome2.Text = "Browse Event";
            this.btnHome2.UseVisualStyleBackColor = true;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // btnNavLogin
            // 
            this.btnNavLogin.Location = new System.Drawing.Point(630, 500);
            this.btnNavLogin.Name = "btnNavLogin";
            this.btnNavLogin.Size = new System.Drawing.Size(180, 45);
            this.btnNavLogin.TabIndex = 7;
            this.btnNavLogin.Text = "Login";
            this.btnNavLogin.UseVisualStyleBackColor = true;
            this.btnNavLogin.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbhome2
            // 
            this.lbhome2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbhome2.ForeColor = System.Drawing.Color.White;
            this.lbhome2.Location = new System.Drawing.Point(0, 350);
            this.lbhome2.Name = "lbhome2";
            this.lbhome2.Size = new System.Drawing.Size(1274, 80);
            this.lbhome2.TabIndex = 1;
            this.lbhome2.Text = "Subtitle";
            this.lbhome2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbhome
            // 
            this.lbhome.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lbhome.ForeColor = System.Drawing.Color.White;
            this.lbhome.Location = new System.Drawing.Point(0, 150);
            this.lbhome.Name = "lbhome";
            this.lbhome.Size = new System.Drawing.Size(1274, 180);
            this.lbhome.TabIndex = 0;
            this.lbhome.Text = "Title";
            this.lbhome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnHeroGetStarted
            // 
            this.btnHeroGetStarted.Location = new System.Drawing.Point(100, 350);
            this.btnHeroGetStarted.Name = "btnHeroGetStarted";
            this.btnHeroGetStarted.Size = new System.Drawing.Size(200, 50);
            this.btnHeroGetStarted.TabIndex = 2;
            this.btnHeroGetStarted.Text = "log in";
            this.btnHeroGetStarted.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 678);
            this.Controls.Add(this.homeMainPanel);
            this.Name = "HomePage";
            this.Text = "Ethio Events";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.homeMainPanel.ResumeLayout(false);
            this.homeMainPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel homeMainPanel;
        private System.Windows.Forms.Label lbhome;
        private System.Windows.Forms.Label lbhome2;
        private System.Windows.Forms.Button btnHeroGetStarted;
        private System.Windows.Forms.Button btnHome2; 
        private System.Windows.Forms.Button btnNavLogin;
        private System.Windows.Forms.Label lbhome1;
    }
}