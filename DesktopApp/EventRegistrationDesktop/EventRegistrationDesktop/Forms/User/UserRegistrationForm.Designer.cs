namespace EventRegistrationDesktop.Forms.User
{
    partial class UserRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Female = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.lbaccount = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.lbconfirmpassword = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbphoneNumber = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(293, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User Registration";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(206, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(215, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(396, 35);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(211, 623);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(401, 65);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(473, 694);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(120, 41);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Female);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.lbGender);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.lbaccount);
            this.panel1.Controls.Add(this.txtconfirmpassword);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.lbconfirmpassword);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.lbpassword);
            this.panel1.Controls.Add(this.lbphoneNumber);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtphonenumber);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(400, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 720);
            this.panel1.TabIndex = 5;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(438, 400);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(126, 33);
            this.Female.TabIndex = 15;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(287, 400);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(95, 33);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.White;
            this.lbGender.Location = new System.Drawing.Point(210, 368);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(107, 29);
            this.lbGender.TabIndex = 13;
            this.lbGender.Text = "Gender:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(54, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 44);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // lbaccount
            // 
            this.lbaccount.AutoSize = true;
            this.lbaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaccount.ForeColor = System.Drawing.Color.White;
            this.lbaccount.Location = new System.Drawing.Point(210, 695);
            this.lbaccount.Name = "lbaccount";
            this.lbaccount.Size = new System.Drawing.Size(230, 25);
            this.lbaccount.TabIndex = 11;
            this.lbaccount.Text = "Do you have Account?";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(211, 576);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(400, 35);
            this.txtconfirmpassword.TabIndex = 10;
            this.txtconfirmpassword.TextChanged += new System.EventHandler(this.txtconfirmpassword_TextChanged);
            // 
            // lbconfirmpassword
            // 
            this.lbconfirmpassword.AutoSize = true;
            this.lbconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirmpassword.ForeColor = System.Drawing.Color.White;
            this.lbconfirmpassword.Location = new System.Drawing.Point(206, 532);
            this.lbconfirmpassword.Name = "lbconfirmpassword";
            this.lbconfirmpassword.Size = new System.Drawing.Size(233, 29);
            this.lbconfirmpassword.TabIndex = 9;
            this.lbconfirmpassword.Text = "Confirm Password:";
            this.lbconfirmpassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.ForeColor = System.Drawing.Color.White;
            this.lbpassword.Location = new System.Drawing.Point(210, 436);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(135, 29);
            this.lbpassword.TabIndex = 8;
            this.lbpassword.Text = "Password:";
            this.lbpassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbphoneNumber
            // 
            this.lbphoneNumber.AutoSize = true;
            this.lbphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphoneNumber.ForeColor = System.Drawing.Color.White;
            this.lbphoneNumber.Location = new System.Drawing.Point(205, 267);
            this.lbphoneNumber.Name = "lbphoneNumber";
            this.lbphoneNumber.Size = new System.Drawing.Size(188, 29);
            this.lbphoneNumber.TabIndex = 7;
            this.lbphoneNumber.Text = "PhoneNumber:";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(210, 484);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(401, 35);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonenumber.Location = new System.Drawing.Point(211, 314);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(400, 35);
            this.txtphonenumber.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(211, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(205, 177);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(86, 29);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 780);
            this.Controls.Add(this.panel1);
            this.Name = "UserRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbphoneNumber;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbconfirmpassword;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbaccount;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton rbMale;
    }
}
