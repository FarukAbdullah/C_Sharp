using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn open = new LogIn();
            open.Show();
            this.Hide();
        }


        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber == 10)
            {
                imageNumber = 1;
            }

            slideImage.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount acc = new CreateAccount();
            acc.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            About_Us about = new About_Us();
            about.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            ContactUs contact = new ContactUs();
            contact.Show();
            this.Hide();
        }
    }
}
