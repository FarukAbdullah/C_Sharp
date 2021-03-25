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
    public partial class EHistory : Form
    {
        private string Email { set; get; }
        public EHistory()
        {
            InitializeComponent();
        }
        public EHistory(string email)
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbExp.SelectedItem == null)
            {

                MessageBox.Show("Invalid Type");
            }
            string Exp = cmbExp.Text;

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
            con.Open();


            string q = "Update EmploymentHistory set CompanyName = '" + txtCompanyName.Text + "', Designation = '" + txtDesignation.Text + "', Salary = '" + txtSalary.Text + "',Experience = '" + Exp + "', Location = '" + rtxtLocation.Text + "' where Email = '" + this.Email + "'";
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

            string q = "select * from EmploymentHistory where Email= '" + this.Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);

                this.txtCompanyName.Text = ds.Tables[0].Rows[0][1].ToString();
                this.txtDesignation.Text = ds.Tables[0].Rows[0][2].ToString();
                this.cmbExp.Text = ds.Tables[0].Rows[0][3].ToString();
                this.txtSalary.Text = ds.Tables[0].Rows[0][4].ToString();

                this.rtxtLocation.Text = ds.Tables[0].Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
