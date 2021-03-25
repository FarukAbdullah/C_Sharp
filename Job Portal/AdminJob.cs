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
    public partial class AdminJob : Form
    {
        private string Email { set; get; }

        public AdminJob()
        {
            InitializeComponent();
        }

        public AdminJob(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            LogIn l = new LogIn();
            l.Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ViewClient v = new ViewClient();
            v.Show();
            this.Hide();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            ViewCom v = new ViewCom();
            v.Show();
            this.Hide();
        }
    }
}
