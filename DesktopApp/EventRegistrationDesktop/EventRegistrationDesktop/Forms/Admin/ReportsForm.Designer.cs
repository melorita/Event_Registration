namespace EventRegistrationDesktop.Forms.Admin
{
    partial class ReportsForm
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
            this.panelEvent = new System.Windows.Forms.Panel();
            this.lblTotalEvents = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelParticipants = new System.Windows.Forms.Panel();
            this.lblTotalParticipants = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartReports = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalApproved = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRejected = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelEvent.SuspendLayout();
            this.panelParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReports)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEvent
            // 
            this.panelEvent.BackColor = System.Drawing.Color.White;
            this.panelEvent.Controls.Add(this.lblTotalEvents);
            this.panelEvent.Controls.Add(this.label2);
            this.panelEvent.Location = new System.Drawing.Point(30, 20);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(260, 100);
            this.panelEvent.TabIndex = 1;
            // 
            // lblTotalEvents
            // 
            this.lblTotalEvents.AutoSize = true;
            this.lblTotalEvents.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalEvents.Location = new System.Drawing.Point(20, 40);
            this.lblTotalEvents.Name = "lblTotalEvents";
            this.lblTotalEvents.Size = new System.Drawing.Size(46, 54);
            this.lblTotalEvents.TabIndex = 1;
            this.lblTotalEvents.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Events";
            // 
            // panelParticipants
            // 
            this.panelParticipants.BackColor = System.Drawing.Color.White;
            this.panelParticipants.Controls.Add(this.lblTotalParticipants);
            this.panelParticipants.Controls.Add(this.label3);
            this.panelParticipants.Location = new System.Drawing.Point(310, 20);
            this.panelParticipants.Name = "panelParticipants";
            this.panelParticipants.Size = new System.Drawing.Size(260, 100);
            this.panelParticipants.TabIndex = 2;
            // 
            // lblTotalParticipants
            // 
            this.lblTotalParticipants.AutoSize = true;
            this.lblTotalParticipants.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalParticipants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTotalParticipants.Location = new System.Drawing.Point(20, 40);
            this.lblTotalParticipants.Name = "lblTotalParticipants";
            this.lblTotalParticipants.Size = new System.Drawing.Size(46, 54);
            this.lblTotalParticipants.TabIndex = 1;
            this.lblTotalParticipants.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Participants";
            // 
            // chartReports
            // 
            this.chartReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartReports.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartReports.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReports.Legends.Add(legend1);
            this.chartReports.Location = new System.Drawing.Point(30, 140);
            this.chartReports.Name = "chartReports";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "EventStatistics";
            this.chartReports.Series.Add(series1);
            this.chartReports.Size = new System.Drawing.Size(890, 400);
            this.chartReports.TabIndex = 3;
            this.chartReports.Text = "Reports Chart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTotalApproved);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(590, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 100);
            this.panel1.TabIndex = 4;
            // 
            // lblTotalApproved
            // 
            this.lblTotalApproved.AutoSize = true;
            this.lblTotalApproved.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalApproved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalApproved.Location = new System.Drawing.Point(20, 40);
            this.lblTotalApproved.Name = "lblTotalApproved";
            this.lblTotalApproved.Size = new System.Drawing.Size(46, 54);
            this.lblTotalApproved.TabIndex = 1;
            this.lblTotalApproved.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Approved";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnExportPDF.FlatAppearance.BorderSize = 0;
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Location = new System.Drawing.Point(945, 140);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(260, 45);
            this.btnExportPDF.TabIndex = 5;
            this.btnExportPDF.Text = "📄 Export Report (PDF)";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalRejected);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(870, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 100);
            this.panel2.TabIndex = 6;
            // 
            // lblTotalRejected
            // 
            this.lblTotalRejected.AutoSize = true;
            this.lblTotalRejected.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRejected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblTotalRejected.Location = new System.Drawing.Point(20, 40);
            this.lblTotalRejected.Name = "lblTotalRejected";
            this.lblTotalRejected.Size = new System.Drawing.Size(46, 54);
            this.lblTotalRejected.TabIndex = 1;
            this.lblTotalRejected.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Rejected";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartReports);
            this.Controls.Add(this.panelParticipants);
            this.Controls.Add(this.panelEvent);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports & Analytics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            this.panelParticipants.ResumeLayout(false);
            this.panelParticipants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReports)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalEvents;
        private System.Windows.Forms.Panel panelParticipants;
        private System.Windows.Forms.Label lblTotalParticipants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalApproved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRejected;
        private System.Windows.Forms.Label label6;
    }
}