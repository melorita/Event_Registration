namespace EventRegistrationDesktop.Forms.User
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeheaderpanel = new System.Windows.Forms.Panel();
            this.lbhome1 = new System.Windows.Forms.Label();
            this.btnHome3 = new System.Windows.Forms.Button();
            this.btnMyRegistration = new System.Windows.Forms.Button();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.profileContainer = new System.Windows.Forms.Panel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.homeMainPanel = new System.Windows.Forms.Panel();
            this.lbhome2 = new System.Windows.Forms.Label();
            this.lbhome = new System.Windows.Forms.Label();
            this.homeheaderpanel.SuspendLayout();
            this.profileContainer.SuspendLayout();
            this.homeMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeheaderpanel
            // 
            this.homeheaderpanel.BackColor = System.Drawing.Color.SteelBlue;
            this.homeheaderpanel.Controls.Add(this.lbhome1);
            this.homeheaderpanel.Controls.Add(this.btnHome3);
            this.homeheaderpanel.Controls.Add(this.btnMyRegistration);
            this.homeheaderpanel.Controls.Add(this.btnHome2);
            this.homeheaderpanel.Controls.Add(this.btnHome);
            this.homeheaderpanel.Controls.Add(this.profileContainer);
            this.homeheaderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeheaderpanel.Location = new System.Drawing.Point(0, 0);
            this.homeheaderpanel.Name = "homeheaderpanel";
            this.homeheaderpanel.Size = new System.Drawing.Size(1274, 100);
            this.homeheaderpanel.TabIndex = 0;
            // 
            // lbhome1
            // 
            this.lbhome1.AutoSize = true;
            this.lbhome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhome1.ForeColor = System.Drawing.Color.White;
            this.lbhome1.Location = new System.Drawing.Point(39, 34);
            this.lbhome1.Name = "lbhome1";
            this.lbhome1.Size = new System.Drawing.Size(85, 53);
            this.lbhome1.TabIndex = 3;
            this.lbhome1.Text = "EE";
            // btnHome3 (Home Button)
            this.btnHome3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome3.ForeColor = System.Drawing.Color.White;
            this.btnHome3.Location = new System.Drawing.Point(580, 26);
            this.btnHome3.Name = "btnHome3";
            this.btnHome3.Size = new System.Drawing.Size(120, 45);
            this.btnHome3.TabIndex = 2;
            this.btnHome3.Text = "Home";
            this.btnHome3.UseVisualStyleBackColor = true;
            this.btnHome3.Click += new System.EventHandler(this.btnHome3_Click);
            // 
            // btnMyRegistration (My Registrations)
            this.btnMyRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyRegistration.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnMyRegistration.ForeColor = System.Drawing.Color.White;
            this.btnMyRegistration.Location = new System.Drawing.Point(710, 28);
            this.btnMyRegistration.Name = "btnMyRegistration";
            this.btnMyRegistration.Size = new System.Drawing.Size(180, 45);
            this.btnMyRegistration.TabIndex = 4;
            this.btnMyRegistration.Text = "My Registrations";
            this.btnMyRegistration.UseVisualStyleBackColor = true;
            this.btnMyRegistration.Visible = false;
            this.btnMyRegistration.Click += new System.EventHandler(this.btnMyRegistration_Click);
            // 
            // btnHome2 (Events Button)
            this.btnHome2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome2.ForeColor = System.Drawing.Color.White;
            this.btnHome2.Location = new System.Drawing.Point(900, 29);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(120, 45);
            this.btnHome2.TabIndex = 1;
            this.btnHome2.Text = "Events";
            this.btnHome2.UseVisualStyleBackColor = false;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // btnHome (Login/Logout Button)
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(1030, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Login";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // profileContainer (Avatar Container)
            this.profileContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profileContainer.Controls.Add(this.lblAvatar);
            this.profileContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileContainer.Location = new System.Drawing.Point(1170, 15);
            this.profileContainer.Name = "profileContainer";
            this.profileContainer.Size = new System.Drawing.Size(70, 70);

            this.profileContainer.TabIndex = 5;
            this.profileContainer.Visible = false;
            this.profileContainer.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblAvatar
            // 
            this.lblAvatar.BackColor = System.Drawing.Color.Gold;
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAvatar.Location = new System.Drawing.Point(10, 10);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(50, 50);
            this.lblAvatar.TabIndex = 0;
            this.lblAvatar.Text = "U";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvatar.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // homeMainPanel
            // 
            this.homeMainPanel.Controls.Add(this.lbhome2);
            this.homeMainPanel.Controls.Add(this.lbhome);
            this.homeMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeMainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMainPanel.Location = new System.Drawing.Point(0, 100);
            this.homeMainPanel.Name = "homeMainPanel";
            this.homeMainPanel.Size = new System.Drawing.Size(1274, 578);
            this.homeMainPanel.TabIndex = 1;
            // 
            // lbhome2
            // 
            this.lbhome2.AutoSize = true;
            this.lbhome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhome2.Location = new System.Drawing.Point(175, 253);
            this.lbhome2.Name = "lbhome2";
            this.lbhome2.Size = new System.Drawing.Size(933, 69);
            this.lbhome2.TabIndex = 1;
            this.lbhome2.Text = "Register For Your Favorite Event";
            // 
            // lbhome
            // 
            this.lbhome.AutoSize = true;
            this.lbhome.BackColor = System.Drawing.Color.Transparent;
            this.lbhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbhome.Location = new System.Drawing.Point(220, 66);
            this.lbhome.Name = "lbhome";
            this.lbhome.Size = new System.Drawing.Size(901, 159);
            this.lbhome.TabIndex = 0;
            this.lbhome.Text = "Ethio Events ";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 678);
            this.Controls.Add(this.homeMainPanel);
            this.Controls.Add(this.homeheaderpanel);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.homeheaderpanel.ResumeLayout(false);
            this.homeheaderpanel.PerformLayout();
            this.profileContainer.ResumeLayout(false);
            this.homeMainPanel.ResumeLayout(false);
            this.homeMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homeheaderpanel;
        private System.Windows.Forms.Panel homeMainPanel;
        private System.Windows.Forms.Label lbhome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbhome2;
        private System.Windows.Forms.Button btnHome2;
        private System.Windows.Forms.Button btnHome3;
        private System.Windows.Forms.Button btnMyRegistration;
        private System.Windows.Forms.Label lbhome1;
        private System.Windows.Forms.Panel profileContainer;
        private System.Windows.Forms.Label lblAvatar;
    }
}