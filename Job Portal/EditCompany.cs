using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace JobPortal
{
    public partial class EditCompany : Form
    {
        private string Email { set; get; }

        public EditCompany()
        {
            InitializeComponent();
        }
        public EditCompany(string email)
        {
            InitializeComponent();
            this.Email = email;
            ShowData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CompanyJob cj = new CompanyJob(this.Email);
            cj.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!VerifyEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email !!");
            }
            else if (!VerifyEmpty(txtMob1.Text) && !VerifyMobile(txtMob1.Text))
            {
                MessageBox.Show("Invalid Mobile Number 1 !!");
            }
            else if (!VerifyEmpty(txtMob2.Text) && !VerifyMobile(txtMob2.Text))
            {
                MessageBox.Show("Invalid Mobile Number 2 !!");
            }
            else if (!VerifyEmpty(txtMob3.Text) && !VerifyMobile(txtMob3.Text))
            {
                MessageBox.Show("Invalid Mobile Number 3 !!");
            }
            else
            {
                string q = "Update Company set Name='" + txtName.Text + "',Email='" + txtEmail.Text + "',Mobile1='" + txtMob1.Text + "',Mobile2='" + txtMob2.Text + "',Mobile3='" + txtMob3.Text + "',Address='" + rtxtAddress.Text + "' where Email='" + txtEmail.Text + "';";
                try
                {
                    DataAccess.ExecuteQuery(q);

                    MessageBox.Show("Updated Successfully");
                }
                catch 
                {
                    MessageBox.Show("Enter Correct Input");
                }
            }
        }

        public void ShowData()
        {
            
            string q = "select * from Company where Email= '" + this.Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);

                this.txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                this.txtEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                this.txtMob1.Text = ds.Tables[0].Rows[0][2].ToString();
                this.txtMob2.Text = ds.Tables[0].Rows[0][3].ToString();
                this.txtMob3.Text = ds.Tables[0].Rows[0][4].ToString();
                this.rtxtAddress.Text = ds.Tables[0].Rows[0][5].ToString();
            }
            catch 
            {
                MessageBox.Show("Enter Correct Input");
            }

           
        }
      

        private void EditCompany_Load(object sender, EventArgs e)
        {
         //   ShowData();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn In = new LogIn();
            In.Show();
            this.Close();
        }

        private bool VerifyEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }
        private bool VerifyMobile(string mobile)
        {
            return Regex.IsMatch(mobile, @"^(\d{11})$");
        }
        private bool VerifyEmpty(string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }
    }
}
