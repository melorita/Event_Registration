namespace EventRegistrationDesktop.Forms.Admin
{
    partial class AddEventForm
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
            this.lbaddevent = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.GroupBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrganizer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(193, 46);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(265, 34);
            this.txtEventName.TabIndex = 2;
            this.txtEventName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(270, 387);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(312, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Event ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(590, 89);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(265, 34);
            this.txtLocation.TabIndex = 8;
            this.txtLocation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dtEventDate
            // 
            this.dtEventDate.Location = new System.Drawing.Point(192, 89);
            this.dtEventDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtEventDate.Name = "dtEventDate";
            this.dtEventDate.Size = new System.Drawing.Size(265, 34);
            this.dtEventDate.TabIndex = 9;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.lbaddevent);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1171, 63);
            this.headerPanel.TabIndex = 11;
            // 
            // lbaddevent
            // 
            this.lbaddevent.AutoSize = true;
            this.lbaddevent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddevent.ForeColor = System.Drawing.Color.White;
            this.lbaddevent.Location = new System.Drawing.Point(474, 9);
            this.lbaddevent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbaddevent.Name = "lbaddevent";
            this.lbaddevent.Size = new System.Drawing.Size(188, 45);
            this.lbaddevent.TabIndex = 0;
            this.lbaddevent.Text = "Add Events";
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.txtCapacity.Size = new System.Drawing.Size(867, 560);
            this.txtCapacity.TabIndex = 12;
            this.txtCapacity.TabStop = false;
            this.txtCapacity.Text = "Event Details";
            this.txtCapacity.Enter += new System.EventHandler(this.txtCapacity_Enter);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(330, 308);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(101, 46);
            this.btnUploadImage.TabIndex = 21;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(192, 308);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxEvent.TabIndex = 20;
            this.pictureBoxEvent.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Event Image";
            // 
            // txtOrganizer
            // 
            this.txtOrganizer.Location = new System.Drawing.Point(590, 248);
            this.txtOrganizer.Name = "txtOrganizer";
            this.txtOrganizer.Size = new System.Drawing.Size(265, 34);
            this.txtOrganizer.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Organizer";
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
            this.cmbCategory.Location = new System.Drawing.Point(193, 248);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(263, 36);
            this.cmbCategory.TabIndex = 16;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Category";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(590, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 34);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capacity";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(191, 145);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 90);
            this.txtDescription.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1171, 680);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.txtCapacity.ResumeLayout(false);
            this.txtCapacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lbaddevent;
        private System.Windows.Forms.GroupBox txtCapacity;
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