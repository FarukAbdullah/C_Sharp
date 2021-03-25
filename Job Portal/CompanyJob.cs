using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobPortal
{
    public partial class CompanyJob : Form
    {
       
        private LogIn f1 { get; set; }
        private string Email { get; set; }
        
        public CompanyJob()
        {
            InitializeComponent();
        }

        public CompanyJob(string email)
        {
            InitializeComponent();
         
            this.Email = email;


        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            CompanyCreate create = new CompanyCreate(this.Email);
            create.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome info = new Welcome();
            info.Show();
            this.Hide();
        }

      

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCompany create = new EditCompany(this.Email);
            create.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete your Account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                string q = "delete from Company where Email='" + this.Email + "' ";
                string q1 = "delete from UserTable where Email='" + this.Email + "' ";
                try
                {
                    DataAccess.ExecuteQuery(q);
                    DataAccess.ExecuteQuery(q1);

                    MessageBox.Show("Deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Welcome f = new Welcome();
              
                f.Show();
                this.Hide();


            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search(this.Email);
            s.Show();
            this.Hide();
        }
    }
}

