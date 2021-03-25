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
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome back = new Welcome();
            back.Show();
            this.Hide();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount aa = new CreateAccount();
            aa.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            About_Us ab = new About_Us();
            ab.Show();
            this.Hide();

        }
    }
}
