namespace EventRegistrationDesktop.Forms.User
{
    partial class UserDashboardForm
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
            this.PHuserdahboard = new System.Windows.Forms.FlowLayoutPanel();
            this.userdashboardmainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PHuserdahboard
            // 
            this.PHuserdahboard.BackColor = System.Drawing.Color.SteelBlue;
            this.PHuserdahboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.PHuserdahboard.Location = new System.Drawing.Point(0, 0);
            this.PHuserdahboard.Name = "PHuserdahboard";
            this.PHuserdahboard.Size = new System.Drawing.Size(1284, 100);
            this.PHuserdahboard.TabIndex = 0;
            // 
            // userdashboardmainPanel
            // 
            this.userdashboardmainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userdashboardmainPanel.Location = new System.Drawing.Point(0, 100);
            this.userdashboardmainPanel.Name = "userdashboardmainPanel";
            this.userdashboardmainPanel.Size = new System.Drawing.Size(1284, 616);
            this.userdashboardmainPanel.TabIndex = 1;
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 716);
            this.Controls.Add(this.userdashboardmainPanel);
            this.Controls.Add(this.PHuserdahboard);
            this.Name = "UserDashboardForm";
            this.Text = "UserDashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PHuserdahboard;
        private System.Windows.Forms.Panel userdashboardmainPanel;
    }
}