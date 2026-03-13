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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dtEventDate = new System.Windows.Forms.DateTimePicker();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrganizer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.txtCapacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(193, 46);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(265, 25);
            this.txtEventName.TabIndex = 2;
            this.txtEventName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(128, 452);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Event ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(192, 127);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(265, 25);
            this.txtLocation.TabIndex = 8;
            this.txtLocation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dtEventDate
            // 
            this.dtEventDate.Location = new System.Drawing.Point(192, 89);
            this.dtEventDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtEventDate.Name = "dtEventDate";
            this.dtEventDate.Size = new System.Drawing.Size(265, 25);
            this.dtEventDate.TabIndex = 9;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1171, 85);
            this.headerPanel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Event Management System";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Controls.Add(this.btnUploadImage);
            this.txtCapacity.Controls.Add(this.pictureBoxEvent);
            this.txtCapacity.Controls.Add(this.label9);
            this.txtCapacity.Controls.Add(this.txtOrganizer);
            this.txtCapacity.Controls.Add(this.btnAdd);
            this.txtCapacity.Controls.Add(this.label8);
            this.txtCapacity.Controls.Add(this.cmbCategory);
            this.txtCapacity.Controls.Add(this.label7);
            this.txtCapacity.Controls.Add(this.textBox2);
            this.txtCapacity.Controls.Add(this.label6);
            this.txtCapacity.Controls.Add(this.txtDescription);
            this.txtCapacity.Controls.Add(this.label5);
            this.txtCapacity.Controls.Add(this.label1);
            this.txtCapacity.Controls.Add(this.txtEventName);
            this.txtCapacity.Controls.Add(this.label2);
            this.txtCapacity.Controls.Add(this.txtLocation);
            this.txtCapacity.Controls.Add(this.dtEventDate);
            this.txtCapacity.Controls.Add(this.label3);
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(27, 93);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Padding = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Size = new System.Drawing.Size(467, 560);
            this.txtCapacity.TabIndex = 12;
            this.txtCapacity.TabStop = false;
            this.txtCapacity.Text = "Event Details";
            this.txtCapacity.Enter += new System.EventHandler(this.txtCapacity_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(191, 171);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 90);
            this.txtDescription.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capacity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Conference",
            "Workshop",
            "Seminar",
            "Training",
            "Meetup",
            "Webinar"});
            this.cmbCategory.Location = new System.Drawing.Point(193, 310);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 25);
            this.cmbCategory.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Organizer";
            // 
            // txtOrganizer
            // 
            this.txtOrganizer.Location = new System.Drawing.Point(191, 341);
            this.txtOrganizer.Name = "txtOrganizer";
            this.txtOrganizer.Size = new System.Drawing.Size(100, 25);
            this.txtOrganizer.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Event Image";
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(191, 383);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxEvent.TabIndex = 20;
            this.pictureBoxEvent.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(331, 410);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(75, 23);
            this.btnUploadImage.TabIndex = 21;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // EventManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1171, 680);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Management";
            this.Load += new System.EventHandler(this.EventManagementForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.txtCapacity.ResumeLayout(false);
            this.txtCapacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker dtEventDate;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox txtCapacity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrganizer;
        private System.Windows.Forms.Button btnUploadImage;
    }
}