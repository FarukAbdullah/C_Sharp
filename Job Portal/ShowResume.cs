using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal
{
    public partial class ShowResume : Form
    {
        private Form _parent;
        private string Email { set; get; }

        public ShowResume()
        {
            InitializeComponent();
        }
        public ShowResume(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        public ShowResume(string email, Form parent) : this()
        {
            Email = email;
            _parent = parent;
            InitializeResume();
        }

        private void InitializeResume()
        {
            FillDataEducation();
            FillDataEployement();
            lb_email.Text = "e-mail : " + Email; 
            string q = "select * from ClientPersonalDetails where Email= '" + Email + "';";
            string q1 = "select * from Address where Email= '" + Email + "';";
            string q2 = "select * from Specialization where Email= '" + Email + "';";
            string q3 = "select * from Photograph where Email= '" + Email + "';";
            try
            {
                DataSet ds = DataAccess.GetDataSet(q);
                lb_name.Text = (ds.Tables[0].Rows[0][0].ToString() + " " + ds.Tables[0].Rows[0][1].ToString()).ToUpper();
                lb_fathers_name.Text = ": " + ds.Tables[0].Rows[0][2].ToString();
                lb_mothers_name.Text = ": " + ds.Tables[0].Rows[0][3].ToString();
                lb_dob.Text = ": " + ds.Tables[0].Rows[0][4].ToString();
                lb_mobile_1.Text = "Mobile No: " + ds.Tables[0].Rows[0][11].ToString();
                lb_nationality.Text = ": " + ds.Tables[0].Rows[0][8].ToString();
                lb_marital_status.Text = ": " + ds.Tables[0].Rows[0][7].ToString();
                lb_gender.Text = ": " + ds.Tables[0].Rows[0][5].ToString();
                lb_religion.Text = ": " + ds.Tables[0].Rows[0][6].ToString();
                ds = DataAccess.GetDataSet(q1);
                lb_address.Text = "Address: " + ds.Tables[0].Rows[0][2].ToString();
                lb_permanent_address.Text = ": " + ds.Tables[0].Rows[0][1].ToString();
                ds = DataAccess.GetDataSet(q2);
                lb_expertise.Text = ": " + ds.Tables[0].Rows[0][1].ToString();
                ds = DataAccess.GetDataSet(q3);
                byte[] img = (byte[]) ds.Tables[0].Rows[0][1];
                if(img!=null)
                {
                    MemoryStream ms = new MemoryStream(img);
                    pb_user_image.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDataEducation()
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
            {
                sqlConnection.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(
                        @"SELECT  t.institution_name,t.grp,t.result,t.ExamPlace, t.DegreeTitle,t.passing_year,d.degree_name
                            FROM education_info t 
                            INNER JOIN education_degree d on d.id = t.degree_id where t.Email='" + Email + "' ", sqlConnection))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    data_academic_qualification.DataSource = t;
                }

                sqlConnection.Close();
            }
        }

        private void FillDataEployement()
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
            {
                sqlConnection.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(
                        @"SELECT  CompanyName, Designation, Experience, Salary, Location
                            FROM EmploymentHistory 
                            WHERE Email='" + Email + "' ", sqlConnection))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    data_employment_history.DataSource = t;
                }

                sqlConnection.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

             _parent.Show();
              this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }
    }
}
