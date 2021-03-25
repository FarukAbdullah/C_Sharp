using System;
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
    public partial class ClientPersonalDetails : Form
    {
        private string Email { set; get; }
        public ClientPersonalDetails()
        {
            InitializeComponent();
        }

        public ClientPersonalDetails(string email)
        {
            InitializeComponent();
            this.Email = email;
            ShowData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dob = Convert.ToDateTime(dtpDOB.Text);
            string gender = "";
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }


            string religion = "";
            if (rdbIslam.Checked)
            {
                religion = "Islam";
            }
            else if (rdbHindu.Checked)
            {
                religion = "Hindu";
            }
            else if (rdbBuddhist.Checked)
            {
                religion = "Buddhist";
            }
            else
            {
                religion = "Christian";
            }


            string marital = "";
            if (rdbMarried.Checked)
            {
                marital = "Married";
            }
            else
            {
                marital = "Unmarried";
            }


            if (!VerifyEmpty(txtMob1.Text) && !VerifyMobile(txtMob1.Text))
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
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
                con.Open();


                string q = "Update ClientPersonalDetails set FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', FatherName = '" + txtFatherName.Text + "', MotherName = '" + txtMotherName.Text + "', DOB = '" + dob + "', Gender = '" + gender + "', Religion = '" + religion + "', MaritalStatus = '" + marital + "', Nationality = '" + txtNationality.Text + "', NationalIDNo = '" + txtNationalID.Text + "', PassportNo = '" + txtPassport.Text + "', MobileNo1 = '" + txtMob1.Text + "', MobileNo2 = '" + txtMob2.Text + "', MobileNo3 = '" + txtMob3.Text + "' where Email = '" + this.Email + "'";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            JobClient jb = new JobClient(this.Email);
            jb.Show();
            this.Close();
        }

        public void ShowData()
        {

            string q = "select * from ClientPersonalDetails where Email= '" + this.Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);

                this.txtFirstName.Text = ds.Tables[0].Rows[0][0].ToString();
                this.txtLastName.Text = ds.Tables[0].Rows[0][1].ToString();
                this.txtFatherName.Text = ds.Tables[0].Rows[0][2].ToString();
                this.txtMotherName.Text = ds.Tables[0].Rows[0][3].ToString();
                this.dtpDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                this.txtNationality.Text = ds.Tables[0].Rows[0][8].ToString();
                this.txtNationalID.Text = ds.Tables[0].Rows[0][9].ToString();
                this.txtPassport.Text = ds.Tables[0].Rows[0][10].ToString();
                this.txtMob1.Text = ds.Tables[0].Rows[0][11].ToString();
                this.txtMob2.Text = ds.Tables[0].Rows[0][12].ToString();
                this.txtMob3.Text = ds.Tables[0].Rows[0][13].ToString();
                switch (ds.Tables[0].Rows[0][5].ToString())
                {
                    case "Male":
                        rdbMale.Checked = true;
                        break;
                    case "Female":
                        rdbFemale.Checked = true;
                        break;
                }

                switch (ds.Tables[0].Rows[0][6].ToString())
                {
                    case "Islam":
                        rdbIslam.Checked = true;
                        break;
                    case "Hindu":
                        rdbHindu.Checked = true;
                        break;
                    case "Buddhist":
                        rdbBuddhist.Checked = true;
                        break;
                    case "Christian":
                        rdbChristian.Checked = true;
                        break;
                }

                switch (ds.Tables[0].Rows[0][7].ToString())
                {
                    case "Married":
                        rdbMarried.Checked = true;
                        break;
                    case "Unmarried":
                        rdbUnmarried.Checked = true;
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private bool VerifyMobile(string mobile)
        {
            return Regex.IsMatch(mobile, @"^(\d{11})$");
        }
        private bool VerifyEmpty(string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClientPersonalDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Hide();
        }
    }
}
