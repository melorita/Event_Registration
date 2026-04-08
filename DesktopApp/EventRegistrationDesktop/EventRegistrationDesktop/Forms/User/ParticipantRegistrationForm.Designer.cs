namespace EventRegistrationDesktop.Forms.User
{
    partial class ParticipantRegistrationForm
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
            this.panelHeaderPart = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblEventTitleSummary = new System.Windows.Forms.Label();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.grpParticipantInfo = new System.Windows.Forms.GroupBox();
            this.lblParticipantCount = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnAddAnother = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelHeaderPart.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.grpParticipantInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderPart
            // 
            this.panelHeaderPart.BackColor = System.Drawing.Color.White;
            this.panelHeaderPart.Controls.Add(this.lblHeader);
            this.panelHeaderPart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderPart.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderPart.Name = "panelHeaderPart";
            this.panelHeaderPart.Size = new System.Drawing.Size(700, 70);
            this.panelHeaderPart.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(160, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(381, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Event Registration Form";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblEventTitleSummary);
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Location = new System.Drawing.Point(38, 85);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(600, 100);
            this.pnlSummary.TabIndex = 1;
            // 
            // lblEventTitleSummary
            // 
            this.lblEventTitleSummary.AutoSize = true;
            this.lblEventTitleSummary.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEventTitleSummary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEventTitleSummary.Location = new System.Drawing.Point(15, 45);
            this.lblEventTitleSummary.Name = "lblEventTitleSummary";
            this.lblEventTitleSummary.Size = new System.Drawing.Size(196, 38);
            this.lblEventTitleSummary.TabIndex = 1;
            this.lblEventTitleSummary.Text = "[Event Name]";
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSummaryTitle.Location = new System.Drawing.Point(15, 10);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(155, 28);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Event Summary";
            // 
            // grpParticipantInfo
            // 
            this.grpParticipantInfo.Controls.Add(this.lblParticipantCount);
            this.grpParticipantInfo.Controls.Add(this.txtEmail);
            this.grpParticipantInfo.Controls.Add(this.txtFullName);
            this.grpParticipantInfo.Controls.Add(this.lblEmail);
            this.grpParticipantInfo.Controls.Add(this.lblFullName);
            this.grpParticipantInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpParticipantInfo.Location = new System.Drawing.Point(38, 205);
            this.grpParticipantInfo.Name = "grpParticipantInfo";
            this.grpParticipantInfo.Size = new System.Drawing.Size(600, 250);
            this.grpParticipantInfo.TabIndex = 2;
            this.grpParticipantInfo.TabStop = false;
            this.grpParticipantInfo.Text = "Participant Details";
            // 
            // lblParticipantCount
            // 
            this.lblParticipantCount.AutoSize = true;
            this.lblParticipantCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblParticipantCount.ForeColor = System.Drawing.Color.Gray;
            this.lblParticipantCount.Location = new System.Drawing.Point(20, 210);
            this.lblParticipantCount.Name = "lblParticipantCount";
            this.lblParticipantCount.Size = new System.Drawing.Size(178, 25);
            this.lblParticipantCount.TabIndex = 4;
            this.lblParticipantCount.Text = "Participants added: 0";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 34);
            this.txtEmail.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(150, 60);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(400, 34);
            this.txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 28);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 63);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 28);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // btnAddAnother
            // 
            this.btnAddAnother.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnother.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAnother.Location = new System.Drawing.Point(38, 480);
            this.btnAddAnother.Name = "btnAddAnother";
            this.btnAddAnother.Size = new System.Drawing.Size(280, 50);
            this.btnAddAnother.TabIndex = 3;
            this.btnAddAnother.Text = "Register for Another";
            this.btnAddAnother.UseVisualStyleBackColor = false;
            this.btnAddAnother.Click += new System.EventHandler(this.btnAddAnother_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(358, 480);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(280, 50);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Final Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.Location = new System.Drawing.Point(38, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ParticipantRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnAddAnother);
            this.Controls.Add(this.grpParticipantInfo);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.panelHeaderPart);
            this.Name = "ParticipantRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Participant Registration";
            this.panelHeaderPart.ResumeLayout(false);
            this.panelHeaderPart.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.grpParticipantInfo.ResumeLayout(false);
            this.grpParticipantInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblEventTitleSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.GroupBox grpParticipantInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblParticipantCount;
        private System.Windows.Forms.Button btnAddAnother;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelHeaderPart;
    }
}