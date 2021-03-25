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
    public partial class CompanyCreate : Form
    {
        private string Email { set; get; }

        public CompanyCreate()
        {
            InitializeComponent();
        }

        public CompanyCreate(string email)
        {
            InitializeComponent();
            this.txtEmail.Text = email;

            this.Email = email;

        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string mb1 = txtMob1.Text;
            string mb2 = txtMob2.Text;
            string mb3 = txtMob3.Text;
            string add = rtxtAddress.Text;

            if (!VerifyEmail(email))
            {
                MessageBox.Show("Invalid Email !!");
            }
            else if(!VerifyEmpty(mb1) && !VerifyMobile(mb1))
            {
                MessageBox.Show("Invalid Mobile!!");
            }
            else if (!VerifyEmpty(mb2) && !VerifyMobile(mb2))
            {
                MessageBox.Show("Invalid Other Number!!");
            }
            else if (!VerifyEmpty(mb3) && !VerifyMobile(mb3))
            {
                MessageBox.Show("Invalid Alternative Number!!");
            }
            else
            {
                string q = "Update Company set Name='" + txtName.Text + "',Mobile1='" + txtMob1.Text + "',Mobile2='" + txtMob2.Text + "',Mobile3='" + txtMob3.Text + "',Address='" + rtxtAddress.Text + "' where Email='" + this.Email + "';";

                try
                {
                    DataAccess.ExecuteQuery(q);

                    MessageBox.Show("Work done Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void SqlCommand(object query)
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CompanyJob cj = new CompanyJob(this.Email);
            cj.Show();
            this.Hide();
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
            catch(Exception exc)
            {
                MessageBox.Show("Error : " + exc);
            }


        }




        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Welcome a = new Welcome();
            a.Show();
            this.Hide();
        }

        private void CompanyCreate_Load(object sender, EventArgs e)
        {
            ShowData();
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
    
