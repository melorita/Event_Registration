using EventRegistrationDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventRegistrationDesktop.Forms.Admin
{
    public partial class EventManagementForm : Form
    {
        List<Event> events = new List<Event>();
        string imagePath = "";
        public EventManagementForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void EventManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            // Allow only image files
            op.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

            // Title of the dialog
            op.Title = "Select Event Image";

            if (op.ShowDialog() == DialogResult.OK)
            {
                // Save image path
                imagePath = op.FileName;

                // Display image in PictureBox
                pictureBoxEvent.Image = Image.FromFile(imagePath);
                pictureBoxEvent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtCapacity_Enter(object sender, EventArgs e)
        {

        }
    }
}
