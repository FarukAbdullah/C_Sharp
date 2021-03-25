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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome back = new Welcome();
            back.Show();
            this.Hide();
        }


        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs();
            cu.Show();
            this.Hide();
        }

      

        private void btnClient_Click(object sender, EventArgs e)
        {
            CreateClient client = new CreateClient();
            client.Show();
            this.Hide();
        }

    }
}
