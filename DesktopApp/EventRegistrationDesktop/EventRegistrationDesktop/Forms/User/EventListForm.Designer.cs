namespace EventRegistrationDesktop.Forms.User
{
    partial class EventListForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.flowEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoEvents = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1205, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(340, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = " Available Events";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbFilterCategory);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 60);
            this.panel1.TabIndex = 1;
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Items.AddRange(new object[] {
            "All Categories",
            "Technology",
            "Music",
            "Health",
            "Conference",
            "Seminar",
            "Workshop",
            "Training",
            "Other"});
            this.cmbFilterCategory.Location = new System.Drawing.Point(600, 15);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(250, 36);
            this.cmbFilterCategory.TabIndex = 5;
            this.cmbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCategory_SelectedIndexChanged);
            // 
            // flowEvents
            // 
            this.flowEvents.Controls.Add(this.lblNoEvents);
            this.flowEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowEvents.AutoScroll = true;
            this.flowEvents.Location = new System.Drawing.Point(0, 140);
            this.flowEvents.Name = "flowEvents";
            this.flowEvents.Size = new System.Drawing.Size(1205, 514);
            this.flowEvents.TabIndex = 2;
            // 
            // lblNoEvents
            // 
            this.lblNoEvents.AutoSize = true;
            this.lblNoEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNoEvents.ForeColor = System.Drawing.Color.Gray;
            this.lblNoEvents.Location = new System.Drawing.Point(30, 30);
            this.lblNoEvents.Name = "lblNoEvents";
            this.lblNoEvents.Size = new System.Drawing.Size(350, 32);
            this.lblNoEvents.TabIndex = 0;
            this.lblNoEvents.Text = "No events in this category";
            this.lblNoEvents.Visible = false;
            // 
            // EventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 654);
            this.Controls.Add(this.flowEvents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "EventListForm";
            this.Text = "EventListForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowEvents;
        private System.Windows.Forms.ComboBox cmbFilterCategory;

        private System.Windows.Forms.Label lblNoEvents;
    }
}