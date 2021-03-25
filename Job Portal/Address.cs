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
    public partial class Address : Form
    {
        private string Email { set; get; }

        public Address()
        {
            InitializeComponent();
        }

        public Address(string email)
        {
            InitializeComponent();
            this.Email = email;
            ShowData();
        }

        public void ShowData()
        {

            string q = "select * from address where Email= '" + this.Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);

                this.rtxtPermanent.Text = ds.Tables[0].Rows[0][1].ToString();
                this.rtxtPresent.Text = ds.Tables[0].Rows[0][2].ToString();
                
            }
            catch 
            {
                MessageBox.Show("Empty Value");
            }


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Welcome l = new Welcome();
            l.Show();
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

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
            con.Open();
            string q = "Update Address set PermanentAdd = '" + rtxtPermanent.Text + "', PresentAddress = '" + rtxtPresent.Text + "' where Email = '" + this.Email + "'";
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
