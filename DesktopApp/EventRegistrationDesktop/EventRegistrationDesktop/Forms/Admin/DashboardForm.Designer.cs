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
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelHeader.Controls.Add(this.lbprofilename);
            this.panelHeader.Controls.Add(this.lbwelcome);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1760, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // lbprofilename
            // 
            this.lbprofilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbprofilename.AutoSize = true;
            this.lbprofilename.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprofilename.ForeColor = System.Drawing.Color.Yellow;
            this.lbprofilename.Location = new System.Drawing.Point(1440, 30);
            this.lbprofilename.Name = "lbprofilename";
            this.lbprofilename.Size = new System.Drawing.Size(94, 30);
            this.lbprofilename.TabIndex = 3;
            this.lbprofilename.Text = "Admin1";
            // 
            // lbwelcome
            // 
            this.lbwelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwelcome.ForeColor = System.Drawing.Color.White;
            this.lbwelcome.Location = new System.Drawing.Point(1320, 30);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(114, 30);
            this.lbwelcome.TabIndex = 2;
            this.lbwelcome.Text = "Welcome,";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 90);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Event Registration System - Admin Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1550, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
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
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 90);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(250, 590);
            this.panelsidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(20, 480);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 60);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.Location = new System.Drawing.Point(20, 400);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(210, 60);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnparticipants
            // 
            this.btnparticipants.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnparticipants.Location = new System.Drawing.Point(20, 320);
            this.btnparticipants.Name = "btnparticipants";
            this.btnparticipants.Size = new System.Drawing.Size(210, 60);
            this.btnparticipants.TabIndex = 2;
            this.btnparticipants.Text = "Participants";
            this.btnparticipants.UseVisualStyleBackColor = true;
            this.btnparticipants.Click += new System.EventHandler(this.btnparticipants_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEvents.Location = new System.Drawing.Point(20, 240);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(210, 60);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Manage Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnAddEvents
            // 
            this.btnAddEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddEvents.Location = new System.Drawing.Point(20, 160);
            this.btnAddEvents.Name = "btnAddEvents";
            this.btnAddEvents.Size = new System.Drawing.Size(210, 60);
            this.btnAddEvents.TabIndex = 5;
            this.btnAddEvents.Text = "Add Events";
            this.btnAddEvents.UseVisualStyleBackColor = true;
            // 
            // btndashboard
            // 
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(20, 80);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(210, 60);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = true;
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.chart1);
            this.panelmain.Controls.Add(this.statusStrip1);
            this.panelmain.Controls.Add(this.panel3);
            this.panelmain.Controls.Add(this.panel2);
            this.panelmain.Controls.Add(this.panelEvents);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(250, 90);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1510, 590);
            this.panelmain.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(373, 272);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "series 1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 450);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1510, 32);
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
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.labelNoOfPending);
            this.panel3.Controls.Add(this.labelpending);
            this.panel3.Location = new System.Drawing.Point(1073, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 131);
            this.panel3.TabIndex = 2;
            // 
            // labelNoOfPending
            // 
            this.labelNoOfPending.AutoSize = true;
            this.labelNoOfPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfPending.ForeColor = System.Drawing.Color.White;
            this.labelNoOfPending.Location = new System.Drawing.Point(135, 68);
            this.labelNoOfPending.Name = "labelNoOfPending";
            this.labelNoOfPending.Size = new System.Drawing.Size(26, 29);
            this.labelNoOfPending.TabIndex = 1;
            this.labelNoOfPending.Text = "5";
            this.labelNoOfPending.Click += new System.EventHandler(this.labelNoOfPending_Click);
            // 
            // labelpending
            // 
            this.labelpending.AutoSize = true;
            this.labelpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpending.ForeColor = System.Drawing.Color.White;
            this.labelpending.Location = new System.Drawing.Point(19, 19);
            this.labelpending.Name = "labelpending";
            this.labelpending.Size = new System.Drawing.Size(256, 29);
            this.labelpending.TabIndex = 0;
            this.labelpending.Text = "pending Registration";
            this.labelpending.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.labelNoOfparticipant);
            this.panel2.Controls.Add(this.labelTotalPartcipant);
            this.panel2.Location = new System.Drawing.Point(641, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 131);
            this.panel2.TabIndex = 1;
            // 
            // labelNoOfparticipant
            // 
            this.labelNoOfparticipant.AutoSize = true;
            this.labelNoOfparticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfparticipant.ForeColor = System.Drawing.Color.White;
            this.labelNoOfparticipant.Location = new System.Drawing.Point(102, 59);
            this.labelNoOfparticipant.Name = "labelNoOfparticipant";
            this.labelNoOfparticipant.Size = new System.Drawing.Size(39, 29);
            this.labelNoOfparticipant.TabIndex = 1;
            this.labelNoOfparticipant.Text = "30";
            this.labelNoOfparticipant.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTotalPartcipant
            // 
            this.labelTotalPartcipant.AutoSize = true;
            this.labelTotalPartcipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPartcipant.ForeColor = System.Drawing.Color.White;
            this.labelTotalPartcipant.Location = new System.Drawing.Point(20, 19);
            this.labelTotalPartcipant.Name = "labelTotalPartcipant";
            this.labelTotalPartcipant.Size = new System.Drawing.Size(204, 29);
            this.labelTotalPartcipant.TabIndex = 0;
            this.labelTotalPartcipant.Text = "Total Participant";
            // 
            // panelEvents
            // 
            this.panelEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelEvents.Controls.Add(this.labNoOfevents);
            this.panelEvents.Controls.Add(this.labelTotalevents);
            this.panelEvents.Location = new System.Drawing.Point(196, 54);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(263, 131);
            this.panelEvents.TabIndex = 0;
            // 
            // labNoOfevents
            // 
            this.labNoOfevents.AutoSize = true;
            this.labNoOfevents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNoOfevents.ForeColor = System.Drawing.Color.White;
            this.labNoOfevents.Location = new System.Drawing.Point(101, 59);
            this.labNoOfevents.Name = "labNoOfevents";
            this.labNoOfevents.Size = new System.Drawing.Size(39, 29);
            this.labNoOfevents.TabIndex = 1;
            this.labNoOfevents.Text = "10";
            this.labNoOfevents.Click += new System.EventHandler(this.labNoOfevents_Click);
            // 
            // labelTotalevents
            // 
            this.labelTotalevents.AutoSize = true;
            this.labelTotalevents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalevents.ForeColor = System.Drawing.Color.White;
            this.labelTotalevents.Location = new System.Drawing.Point(43, 19);
            this.labelTotalevents.Name = "labelTotalevents";
            this.labelTotalevents.Size = new System.Drawing.Size(158, 29);
            this.labelTotalevents.TabIndex = 0;
            this.labelTotalevents.Text = "Total Events";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 680);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelsidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelsidebar.ResumeLayout(false);
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
    }
}