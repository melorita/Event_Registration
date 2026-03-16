namespace EventRegistrationDesktop.Forms.User
{
    partial class ViewRegistrationForm
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
            this.panelViewreg = new System.Windows.Forms.Panel();
            this.lbviewReg = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eventdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registrayiondate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelViewreg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelViewreg
            // 
            this.panelViewreg.BackColor = System.Drawing.Color.White;
            this.panelViewreg.Controls.Add(this.lbviewReg);
            this.panelViewreg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewreg.ForeColor = System.Drawing.Color.SteelBlue;
            this.panelViewreg.Location = new System.Drawing.Point(0, 0);
            this.panelViewreg.Name = "panelViewreg";
            this.panelViewreg.Size = new System.Drawing.Size(1200, 80);
            this.panelViewreg.TabIndex = 0;
            // 
            // lbviewReg
            // 
            this.lbviewReg.BackColor = System.Drawing.Color.Transparent;
            this.lbviewReg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbviewReg.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbviewReg.Location = new System.Drawing.Point(450, 20);
            this.lbviewReg.Name = "lbviewReg";
            this.lbviewReg.Size = new System.Drawing.Size(312, 46);
            this.lbviewReg.TabIndex = 0;
            this.lbviewReg.Text = "My Registrations";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.Eventdate,
            this.EventLocation,
            this.Registrayiondate,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 612);
            this.dataGridView1.TabIndex = 1;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "EventName";
            this.EventName.MinimumWidth = 50;
            this.EventName.Name = "EventName";
            this.EventName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EventName.Width = 150;
            // 
            // Eventdate
            // 
            this.Eventdate.HeaderText = "Eventdate";
            this.Eventdate.MinimumWidth = 8;
            this.Eventdate.Name = "Eventdate";
            this.Eventdate.Width = 150;
            // 
            // EventLocation
            // 
            this.EventLocation.HeaderText = "EventLocation";
            this.EventLocation.MinimumWidth = 8;
            this.EventLocation.Name = "EventLocation";
            this.EventLocation.Width = 150;
            // 
            // Registrayiondate
            // 
            this.Registrayiondate.HeaderText = "Registration Date";
            this.Registrayiondate.MinimumWidth = 8;
            this.Registrayiondate.Name = "Registrayiondate";
            this.Registrayiondate.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // ViewRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelViewreg);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewRegistrationForm";
            this.Text = "ViewRegistrationForm";
            this.panelViewreg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelViewreg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbviewReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eventdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registrayiondate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}