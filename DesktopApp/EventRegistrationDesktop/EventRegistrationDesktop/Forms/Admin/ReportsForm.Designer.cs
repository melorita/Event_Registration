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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelEvent.SuspendLayout();
            this.panelParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReports)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1293, 63);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report And Analytics";
            // 
            // panelEvent
            // 
            this.panelEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelEvent.Controls.Add(this.lblTotalEvents);
            this.panelEvent.Controls.Add(this.label2);
            this.panelEvent.Location = new System.Drawing.Point(43, 85);
            this.panelEvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(247, 72);
            this.panelEvent.TabIndex = 1;
            // 
            // lblTotalEvents
            // 
            this.lblTotalEvents.AutoSize = true;
            this.lblTotalEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEvents.ForeColor = System.Drawing.Color.White;
            this.lblTotalEvents.Location = new System.Drawing.Point(93, 45);
            this.lblTotalEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEvents.Name = "lblTotalEvents";
            this.lblTotalEvents.Size = new System.Drawing.Size(24, 25);
            this.lblTotalEvents.TabIndex = 1;
            this.lblTotalEvents.Text = "0";
            this.lblTotalEvents.Click += new System.EventHandler(this.lblTotalEvents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Events";
            // 
            // panelParticipants
            // 
            this.panelParticipants.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelParticipants.Controls.Add(this.lblTotalParticipants);
            this.panelParticipants.Controls.Add(this.label3);
            this.panelParticipants.Location = new System.Drawing.Point(43, 191);
            this.panelParticipants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelParticipants.Name = "panelParticipants";
            this.panelParticipants.Size = new System.Drawing.Size(253, 72);
            this.panelParticipants.TabIndex = 2;
            // 
            // lblTotalParticipants
            // 
            this.lblTotalParticipants.AutoSize = true;
            this.lblTotalParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParticipants.ForeColor = System.Drawing.Color.White;
            this.lblTotalParticipants.Location = new System.Drawing.Point(98, 45);
            this.lblTotalParticipants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalParticipants.Name = "lblTotalParticipants";
            this.lblTotalParticipants.Size = new System.Drawing.Size(24, 25);
            this.lblTotalParticipants.TabIndex = 1;
            this.lblTotalParticipants.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Participants";
            // 
            // chartReports
            // 
            this.chartReports.BackColor = System.Drawing.Color.Gray;
            chartArea3.Name = "ChartArea1";
            this.chartReports.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartReports.Legends.Add(legend3);
            this.chartReports.Location = new System.Drawing.Point(494, 85);
            this.chartReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartReports.Name = "chartReports";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "EventStatistics";
            this.chartReports.Series.Add(series5);
            this.chartReports.Series.Add(series6);
            this.chartReports.Size = new System.Drawing.Size(398, 247);
            this.chartReports.TabIndex = 3;
            this.chartReports.Text = "chart1";
            this.chartReports.Click += new System.EventHandler(this.chartReports_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.lblTotalApproved);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(43, 314);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 72);
            this.panel1.TabIndex = 4;
            // 
            // lblTotalApproved
            // 
            this.lblTotalApproved.AutoSize = true;
            this.lblTotalApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalApproved.ForeColor = System.Drawing.Color.White;
            this.lblTotalApproved.Location = new System.Drawing.Point(97, 45);
            this.lblTotalApproved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalApproved.Name = "lblTotalApproved";
            this.lblTotalApproved.Size = new System.Drawing.Size(24, 25);
            this.lblTotalApproved.TabIndex = 5;
            this.lblTotalApproved.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Approved";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportPDF.Location = new System.Drawing.Point(523, 455);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(233, 45);
            this.btnExportPDF.TabIndex = 5;
            this.btnExportPDF.Text = "Export Report (PDF)";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(43, 435);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 72);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Rejected";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartReports);
            this.Controls.Add(this.panelParticipants);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(200, 250);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report Dashboard";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
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

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}