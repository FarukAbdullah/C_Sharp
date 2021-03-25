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
    public partial class Language : Form
    {
        private string Email { set; get; }
        public Language()
        {
            InitializeComponent();
        }
        public Language(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            JobClient jb = new JobClient(this.Email);
            jb.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
            con.Open();


            string q = "Update Languages set Language = '" + rtxtLanguage.Text + "' where Email = '" + this.Email + "'";
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

            string q = "select * from Languages where Email= '" + this.Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);


                this.rtxtLanguage.Text = ds.Tables[0].Rows[0][1].ToString();
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Language_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
