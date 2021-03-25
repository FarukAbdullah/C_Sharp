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

namespace JobPortal
{
    public partial class PerQualification : Form
    {
        private string Email { set; get; }
        public PerQualification()
        {
            InitializeComponent();
        }

        public PerQualification(string email)
        {
            InitializeComponent();
            this.Email= email;
        }

     

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Welcome cu = new Welcome();
            cu.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            JobClient j = new JobClient(this.Email);
            j.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
            con.Open();


            string q = "Update PerQualification set CertificateDetails = '" + txtCertificate.Text + "', Year = '" + txtYear.Text + "', Location = '" + rtxtLocation.Text + "' where Email = '" + this.Email + "'";
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
        public void ShowData()
        {

            string q = "select * from PerQualification where Email= '" + this.Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);

                
                this.txtCertificate.Text = ds.Tables[0].Rows[0][1].ToString();
                this.txtYear.Text = ds.Tables[0].Rows[0][2].ToString();
                this.rtxtLocation.Text = ds.Tables[0].Rows[0][3].ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void PerQualification_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
            con.Open();


            string q = "Update PerQualification set CertificateDetails = '" + txtCertificate.Text + "', Year = '" + txtYear.Text + "', Location = '" + rtxtLocation.Text + "' where Email = '" + this.Email + "'";
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
}
