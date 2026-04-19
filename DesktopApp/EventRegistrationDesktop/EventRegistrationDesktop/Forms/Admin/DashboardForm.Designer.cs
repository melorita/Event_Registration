namespace EventRegistrationDesktop.Forms.Admin
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbprofilename = new System.Windows.Forms.Label();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelsidebar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnparticipants = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnAddEvents = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panelmain = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNoOfPending = new System.Windows.Forms.Label();
            this.labelpending = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNoOfparticipant = new System.Windows.Forms.Label();
            this.labelTotalPartcipant = new System.Windows.Forms.Label();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.labNoOfevents = new System.Windows.Forms.Label();
            this.labelTotalevents = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelsidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lbprofilename);
            this.panelHeader.Controls.Add(this.lbwelcome);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(260, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1500, 85);
            this.panelHeader.TabIndex = 0;
            // 
            // lbprofilename
            // 
            this.lbprofilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbprofilename.AutoSize = true;
            this.lbprofilename.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbprofilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lbprofilename.Location = new System.Drawing.Point(1350, 28);
            this.lbprofilename.Name = "lbprofilename";
            this.lbprofilename.Size = new System.Drawing.Size(83, 28);
            this.lbprofilename.TabIndex = 3;
            this.lbprofilename.Text = "Admin1";
            // 
            // lbwelcome
            // 
            this.lbwelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbwelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbwelcome.Location = new System.Drawing.Point(1240, 28);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(104, 28);
            this.lbwelcome.TabIndex = 2;
            this.lbwelcome.Text = "Welcome, ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pictureBox1.Location = new System.Drawing.Point(1440, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelsidebar.Controls.Add(this.btnLogout);
            this.panelsidebar.Controls.Add(this.btnReports);
            this.panelsidebar.Controls.Add(this.btnparticipants);
            this.panelsidebar.Controls.Add(this.btnEvents);
            this.panelsidebar.Controls.Add(this.btnAddEvents);
            this.panelsidebar.Controls.Add(this.btndashboard);
            this.panelsidebar.Controls.Add(this.panelLogo);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 0);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(260, 680);
            this.panelsidebar.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 85);
            this.panelLogo.TabIndex = 6;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(217, 45);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "EVENT HUB";
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(260, 60);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "  🚪 Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 325);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(260, 60);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "  📊 Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnparticipants
            // 
            this.btnparticipants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnparticipants.FlatAppearance.BorderSize = 0;
            this.btnparticipants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnparticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparticipants.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnparticipants.ForeColor = System.Drawing.Color.White;
            this.btnparticipants.Location = new System.Drawing.Point(0, 265);
            this.btnparticipants.Name = "btnparticipants";
            this.btnparticipants.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnparticipants.Size = new System.Drawing.Size(260, 60);
            this.btnparticipants.TabIndex = 2;
            this.btnparticipants.Text = "  👥 Participants";
            this.btnparticipants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnparticipants.UseVisualStyleBackColor = true;
            this.btnparticipants.Click += new System.EventHandler(this.btnparticipants_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Location = new System.Drawing.Point(0, 205);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEvents.Size = new System.Drawing.Size(260, 60);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "  📅 Manage Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnAddEvents
            // 
            this.btnAddEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEvents.FlatAppearance.BorderSize = 0;
            this.btnAddEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddEvents.ForeColor = System.Drawing.Color.White;
            this.btnAddEvents.Location = new System.Drawing.Point(0, 145);
            this.btnAddEvents.Name = "btnAddEvents";
            this.btnAddEvents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEvents.Size = new System.Drawing.Size(260, 60);
            this.btnAddEvents.TabIndex = 5;
            this.btnAddEvents.Text = "  ➕ Add Events";
            this.btnAddEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEvents.UseVisualStyleBackColor = true;
            // 
            // btndashboard
            // 
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(0, 85);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btndashboard.Size = new System.Drawing.Size(260, 60);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "  🏠 Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.UseVisualStyleBackColor = true;
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelmain.Controls.Add(this.chart1);
            this.panelmain.Controls.Add(this.statusStrip1);
            this.panelmain.Controls.Add(this.panel3);
            this.panelmain.Controls.Add(this.panel2);
            this.panelmain.Controls.Add(this.panelEvents);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(260, 85);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1500, 595);
            this.panelmain.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(40, 220);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "series 1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1420, 320);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1500, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 25);
            this.toolStripStatusLabel1.Text = "status=ready";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelNoOfPending);
            this.panel3.Controls.Add(this.labelpending);
            this.panel3.Location = new System.Drawing.Point(740, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 140);
            this.panel3.TabIndex = 2;
            // 
            // labelNoOfPending
            // 
            this.labelNoOfPending.AutoSize = true;
            this.labelNoOfPending.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelNoOfPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.labelNoOfPending.Location = new System.Drawing.Point(20, 60);
            this.labelNoOfPending.Name = "labelNoOfPending";
            this.labelNoOfPending.Size = new System.Drawing.Size(55, 65);
            this.labelNoOfPending.TabIndex = 1;
            this.labelNoOfPending.Text = "5";
            // 
            // labelpending
            // 
            this.labelpending.AutoSize = true;
            this.labelpending.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelpending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.labelpending.Location = new System.Drawing.Point(20, 20);
            this.labelpending.Name = "labelpending";
            this.labelpending.Size = new System.Drawing.Size(206, 28);
            this.labelpending.TabIndex = 0;
            this.labelpending.Text = "Pending Registration";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelNoOfparticipant);
            this.panel2.Controls.Add(this.labelTotalPartcipant);
            this.panel2.Location = new System.Drawing.Point(390, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 140);
            this.panel2.TabIndex = 1;
            // 
            // labelNoOfparticipant
            // 
            this.labelNoOfparticipant.AutoSize = true;
            this.labelNoOfparticipant.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelNoOfparticipant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelNoOfparticipant.Location = new System.Drawing.Point(20, 60);
            this.labelNoOfparticipant.Name = "labelNoOfparticipant";
            this.labelNoOfparticipant.Size = new System.Drawing.Size(84, 65);
            this.labelNoOfparticipant.TabIndex = 1;
            this.labelNoOfparticipant.Text = "30";
            // 
            // labelTotalPartcipant
            // 
            this.labelTotalPartcipant.AutoSize = true;
            this.labelTotalPartcipant.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalPartcipant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.labelTotalPartcipant.Location = new System.Drawing.Point(20, 20);
            this.labelTotalPartcipant.Name = "labelTotalPartcipant";
            this.labelTotalPartcipant.Size = new System.Drawing.Size(167, 28);
            this.labelTotalPartcipant.TabIndex = 0;
            this.labelTotalPartcipant.Text = "Total Participants";
            // 
            // panelEvents
            // 
            this.panelEvents.BackColor = System.Drawing.Color.White;
            this.panelEvents.Controls.Add(this.labNoOfevents);
            this.panelEvents.Controls.Add(this.labelTotalevents);
            this.panelEvents.Location = new System.Drawing.Point(40, 40);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(320, 140);
            this.panelEvents.TabIndex = 0;
            // 
            // labNoOfevents
            // 
            this.labNoOfevents.AutoSize = true;
            this.labNoOfevents.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labNoOfevents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.labNoOfevents.Location = new System.Drawing.Point(20, 60);
            this.labNoOfevents.Name = "labNoOfevents";
            this.labNoOfevents.Size = new System.Drawing.Size(84, 65);
            this.labNoOfevents.TabIndex = 1;
            this.labNoOfevents.Text = "10";
            // 
            // labelTotalevents
            // 
            this.labelTotalevents.AutoSize = true;
            this.labelTotalevents.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalevents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.labelTotalevents.Location = new System.Drawing.Point(20, 20);
            this.labelTotalevents.Name = "labelTotalevents";
            this.labelTotalevents.Size = new System.Drawing.Size(120, 28);
            this.labelTotalevents.TabIndex = 0;
            this.labelTotalevents.Text = "Total Events";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1760, 680);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelsidebar);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelsidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnparticipants;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.Label labelTotalevents;
        private System.Windows.Forms.Label labelNoOfparticipant;
        private System.Windows.Forms.Label labelTotalPartcipant;
        private System.Windows.Forms.Label labNoOfevents;
        private System.Windows.Forms.Label labelNoOfPending;
        private System.Windows.Forms.Label labelpending;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddEvents;
        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.Label lbprofilename;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
    }
}