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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelsidebar = new System.Windows.Forms.Panel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnparticipants = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalevents = new System.Windows.Forms.Label();
            this.labNoOfevents = new System.Windows.Forms.Label();
            this.labelTotalPartcipant = new System.Windows.Forms.Label();
            this.labelNoOfparticipant = new System.Windows.Forms.Label();
            this.labelpending = new System.Windows.Forms.Label();
            this.labelNoOfPending = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelsidebar.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.panelEvents.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1322, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelsidebar.Controls.Add(this.btnLogout);
            this.panelsidebar.Controls.Add(this.btnReports);
            this.panelsidebar.Controls.Add(this.btnparticipants);
            this.panelsidebar.Controls.Add(this.btnEvents);
            this.panelsidebar.Controls.Add(this.btndashboard);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 100);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(200, 458);
            this.panelsidebar.TabIndex = 1;
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.statusStrip1);
            this.panelmain.Controls.Add(this.chart1);
            this.panelmain.Controls.Add(this.panel3);
            this.panelmain.Controls.Add(this.panel2);
            this.panelmain.Controls.Add(this.panelEvents);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(200, 100);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1122, 458);
            this.panelmain.TabIndex = 2;
            // 
            // btndashboard
            // 
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.Location = new System.Drawing.Point(45, 34);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(149, 35);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = true;
            // 
            // btnEvents
            // 
            this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.Location = new System.Drawing.Point(45, 85);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(149, 38);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "ManageEvents";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnparticipants
            // 
            this.btnparticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparticipants.Location = new System.Drawing.Point(45, 142);
            this.btnparticipants.Name = "btnparticipants";
            this.btnparticipants.Size = new System.Drawing.Size(149, 37);
            this.btnparticipants.TabIndex = 2;
            this.btnparticipants.Text = "Participants";
            this.btnparticipants.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(45, 204);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(149, 38);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(45, 272);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 34);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panelEvents
            // 
            this.panelEvents.Controls.Add(this.labNoOfevents);
            this.panelEvents.Controls.Add(this.labelTotalevents);
            this.panelEvents.Location = new System.Drawing.Point(101, 23);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(200, 100);
            this.panelEvents.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelNoOfparticipant);
            this.panel2.Controls.Add(this.labelTotalPartcipant);
            this.panel2.Location = new System.Drawing.Point(360, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNoOfPending);
            this.panel3.Controls.Add(this.labelpending);
            this.panel3.Location = new System.Drawing.Point(612, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 100);
            this.panel3.TabIndex = 2;
            // 
            // labelTotalevents
            // 
            this.labelTotalevents.AutoSize = true;
            this.labelTotalevents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalevents.Location = new System.Drawing.Point(26, 11);
            this.labelTotalevents.Name = "labelTotalevents";
            this.labelTotalevents.Size = new System.Drawing.Size(158, 29);
            this.labelTotalevents.TabIndex = 0;
            this.labelTotalevents.Text = "Total Events";
            // 
            // labNoOfevents
            // 
            this.labNoOfevents.AutoSize = true;
            this.labNoOfevents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNoOfevents.Location = new System.Drawing.Point(65, 49);
            this.labNoOfevents.Name = "labNoOfevents";
            this.labNoOfevents.Size = new System.Drawing.Size(39, 29);
            this.labNoOfevents.TabIndex = 1;
            this.labNoOfevents.Text = "10";
            // 
            // labelTotalPartcipant
            // 
            this.labelTotalPartcipant.AutoSize = true;
            this.labelTotalPartcipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPartcipant.Location = new System.Drawing.Point(16, 11);
            this.labelTotalPartcipant.Name = "labelTotalPartcipant";
            this.labelTotalPartcipant.Size = new System.Drawing.Size(204, 29);
            this.labelTotalPartcipant.TabIndex = 0;
            this.labelTotalPartcipant.Text = "Total Participant";
            // 
            // labelNoOfparticipant
            // 
            this.labelNoOfparticipant.AutoSize = true;
            this.labelNoOfparticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfparticipant.Location = new System.Drawing.Point(95, 49);
            this.labelNoOfparticipant.Name = "labelNoOfparticipant";
            this.labelNoOfparticipant.Size = new System.Drawing.Size(39, 29);
            this.labelNoOfparticipant.TabIndex = 1;
            this.labelNoOfparticipant.Text = "30";
            this.labelNoOfparticipant.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelpending
            // 
            this.labelpending.AutoSize = true;
            this.labelpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpending.Location = new System.Drawing.Point(21, 11);
            this.labelpending.Name = "labelpending";
            this.labelpending.Size = new System.Drawing.Size(256, 29);
            this.labelpending.TabIndex = 0;
            this.labelpending.Text = "pending Registration";
            this.labelpending.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNoOfPending
            // 
            this.labelNoOfPending.AutoSize = true;
            this.labelNoOfPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfPending.Location = new System.Drawing.Point(130, 49);
            this.labelNoOfPending.Name = "labelNoOfPending";
            this.labelNoOfPending.Size = new System.Drawing.Size(26, 29);
            this.labelNoOfPending.TabIndex = 1;
            this.labelNoOfPending.Text = "5";
            this.labelNoOfPending.Click += new System.EventHandler(this.labelNoOfPending_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(132, 156);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(747, 252);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(1191, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 25);
            this.toolStripStatusLabel1.Text = "status=ready";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(677, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Event Registration System - Admin Dashboard";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 558);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelsidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelsidebar.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}