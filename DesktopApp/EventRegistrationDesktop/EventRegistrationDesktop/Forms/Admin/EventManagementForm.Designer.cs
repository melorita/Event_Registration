namespace EventRegistrationDesktop.Forms.Admin
{
    partial class EventManagementForm
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
            this.panelView = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.colEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.SteelBlue;
            this.panelView.Controls.Add(this.lblTitle);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1200, 80);
            this.panelView.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Existing Events";
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEventName,
            this.colEventDate,
            this.colLocation,
            this.colCapacity,
            this.colActionEdit,
            this.colActionDelete});
            this.dataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEvents.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 62;
            this.dataGridViewEvents.RowTemplate.Height = 28;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1200, 612);
            this.dataGridViewEvents.TabIndex = 1;
            // 
            // colEventName
            // 
            this.colEventName.HeaderText = "Event Name";
            this.colEventName.MinimumWidth = 8;
            this.colEventName.Name = "colEventName";
            this.colEventName.Width = 250;
            // 
            // colEventDate
            // 
            this.colEventDate.HeaderText = "Date";
            this.colEventDate.MinimumWidth = 8;
            this.colEventDate.Name = "colEventDate";
            this.colEventDate.Width = 150;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.MinimumWidth = 8;
            this.colLocation.Name = "colLocation";
            this.colLocation.Width = 200;
            // 
            // colCapacity
            // 
            this.colCapacity.HeaderText = "Capacity";
            this.colCapacity.MinimumWidth = 8;
            this.colCapacity.Name = "colCapacity";
            this.colCapacity.Width = 100;
            // 
            // colActionEdit
            // 
            this.colActionEdit.HeaderText = "Edit";
            this.colActionEdit.MinimumWidth = 8;
            this.colActionEdit.Name = "colActionEdit";
            this.colActionEdit.Text = "Edit";
            this.colActionEdit.UseColumnTextForButtonValue = true;
            this.colActionEdit.Width = 100;
            // 
            // colActionDelete
            // 
            this.colActionDelete.HeaderText = "Delete";
            this.colActionDelete.MinimumWidth = 8;
            this.colActionDelete.Name = "colActionDelete";
            this.colActionDelete.Text = "Delete";
            this.colActionDelete.UseColumnTextForButtonValue = true;
            this.colActionDelete.Width = 100;
            // 
            // EventManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.panelView);
            this.Name = "EventManagementForm";
            this.Text = "Manage Events";
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
        private System.Windows.Forms.DataGridViewButtonColumn colActionEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colActionDelete;
    }
}
