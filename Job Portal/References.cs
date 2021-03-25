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
    public partial class References : Form
    {
        private string Email { set; get; }
        public References()
        {
            InitializeComponent();
           
        }

        public References(string email)
        {
            InitializeComponent();
            this.Email = email;
            ShowData();
        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            JobClient jb = new JobClient(this.Email);
            jb.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!VerifyEmail(txtrEmail.Text))
            {
                MessageBox.Show("Invalid Email !!");
            }
            else if (!VerifyEmpty(txtMob.Text) && !VerifyMobile(txtMob.Text))
            {
                MessageBox.Show("Invalid Mobile Number !!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
                con.Open();


                string q = "Update Refer set Name = '" + txtName.Text + "', rEmail = '" + txtrEmail.Text + "', Mobile = '" + txtMob.Text + "', Phone = '" + txtPhone.Text + "', Organization = '" + txtOrga.Text + "', Relation = '" + txtRelation.Text + "', Address = '" + rtxtAddress.Text + "' where Email = '" + this.Email + "'";
                try
                {
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Work done Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void ShowData()
        {

            string q = "select * from Refer where Email= '" + this.Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);

                this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                this.txtrEmail.Text = ds.Tables[0].Rows[0][2].ToString();
                this.txtMob.Text = ds.Tables[0].Rows[0][3].ToString();
                this.txtPhone.Text = ds.Tables[0].Rows[0][4].ToString();
                this.txtOrga.Text = ds.Tables[0].Rows[0][5].ToString();
                this.txtRelation.Text = ds.Tables[0].Rows[0][6].ToString();
                this.rtxtAddress.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void References_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!VerifyEmail(txtrEmail.Text))
            {
                MessageBox.Show("Invalid Email !!");
            }
            else if (!VerifyEmpty(txtMob.Text) && !VerifyMobile(txtMob.Text))
            {
                MessageBox.Show("Invalid Mobile Number !!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
                con.Open();


                string q = "Update Refer set Name = '" + txtName.Text + "', rEmail = '" + txtrEmail.Text + "', Mobile = '" + txtMob.Text + "', Phone = '" + txtPhone.Text + "', Organization = '" + txtOrga.Text + "', Relation = '" + txtRelation.Text + "', Address = '" + rtxtAddress.Text + "' where Email = '" + this.Email + "'";
                try
                {
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Work done Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
