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
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTech = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.flowEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1048, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = " Available Events";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMusic);
            this.panel1.Controls.Add(this.btnBusiness);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnTech);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(899, 19);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(75, 32);
            this.btnMusic.TabIndex = 3;
            this.btnMusic.Text = "Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.Location = new System.Drawing.Point(802, 19);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(91, 32);
            this.btnBusiness.TabIndex = 4;
            this.btnBusiness.Text = "Business";
            this.btnBusiness.UseVisualStyleBackColor = true;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(56, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search event";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnTech
            // 
            this.btnTech.Location = new System.Drawing.Point(687, 19);
            this.btnTech.Name = "btnTech";
            this.btnTech.Size = new System.Drawing.Size(109, 32);
            this.btnTech.TabIndex = 2;
            this.btnTech.Text = "Technology ";
            this.btnTech.UseVisualStyleBackColor = true;
            this.btnTech.Click += new System.EventHandler(this.btnTech_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(606, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 32);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // flowEvents
            // 
            this.flowEvents.AutoScroll = true;
            this.flowEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowEvents.Location = new System.Drawing.Point(0, 140);
            this.flowEvents.Name = "flowEvents";
            this.flowEvents.Size = new System.Drawing.Size(1048, 310);
            this.flowEvents.TabIndex = 2;
            // 
            // EventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
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
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnTech;
        private System.Windows.Forms.Button btnAll;
    }
}