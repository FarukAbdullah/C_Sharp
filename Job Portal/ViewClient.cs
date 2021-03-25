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
    public partial class ViewClient : Form
    {
        private string EmailClicked { get; set; }
        public ViewClient()
        {
            InitializeComponent();
            FillData();
           // Populate();

        }

        private void FillData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
            {
                sqlConnection.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(
                        @"select p.Email, (p.FirstName +' '+p.LastName) Name

                         from ClientPersonalDetails p
                         INNER JOIN Address A ON P.Email = A.Email
                         INNER JOIN CLIENTCAREER C ON C.EMAIL = A.EMAIL
                         INNER JOIN Languages L ON L.Email = A.Email
                         INNER JOIN EmploymentHistory H ON H.Email = A.Email
                         INNER JOIN PerQualification Q ON Q.Email = A.Email
                         INNER JOIN Refer R ON R.Email = A.Email
                         INNER JOIN Specialization S ON S.Email = A.Email
                         INNER JOIN UserTable U ON U.Email = A.Email
                         WHERE U.Status = 1", sqlConnection))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    eduDataGrid.DataSource = t;
                }

                sqlConnection.Close();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminJob a = new AdminJob();
            a.Show();
            this.Hide();
        }


        private void eduDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ShowResume sr = new ShowResume(eduDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                sr.Show();
                this.Hide();
            }
        }

        private void Populate()
        {
            string sql =  @"select p.* , a.PermanentAdd, a.PresentAddress, C.Obejctive, C.ExpectedSalary, C.PresentSalary, C.JobNature, C.PreferedDivision, C.SpecialQualification, C.CareerSummary,
                         L.LANGUAGE, H.CompanyName, H.Designation, H.Experience, H.Salary, H.Location, Q.CertificateDetails, Q.Year,Q.Location,
                         R.Name, R.rEmail, R.Mobile, R.Phone, R.Organization, R.Relation, R.Address, S.SKILL

                         from ClientPersonalDetails p
                         INNER JOIN Address A ON P.Email = A.Email
                        INNER JOIN CLIENTCAREER C ON C.Email = A.Email
                         INNER JOIN Languages L ON L.Email = A.Email
                         INNER JOIN EmploymentHistory H ON H.Email = A.Email
                         INNER JOIN PerQualification Q ON Q.Email = A.Email
                         INNER JOIN Refer R ON R.Email = A.Email
                         INNER JOIN Specialization S ON S.Email = A.Email
                         INNER JOIN UserTable U ON U.Email = A.Email
                         WHERE U.Status = 1";
            DataSet DS = DataAccess.GetDataSet(sql);

            this.eduDataGrid.AutoGenerateColumns = false;
            this.eduDataGrid.DataSource = DS.Tables[0];
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select Email, (FirstName +' '+LastName) Name from ClientPersonalDetails where Email like '" + this.txtSearch.Text + "%';";
            DataSet DS = DataAccess.GetDataSet(sql);

            this.eduDataGrid.AutoGenerateColumns = false;
            this.eduDataGrid.DataSource = DS.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete your Account?", "Delete Account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
                con.Open();

                string q = "delete from Address where Email='" + this.EmailClicked + "' ;";

               string q2 = "delete from ClientCareer where Email='" + this.EmailClicked + "' ";
                string q3 = "delete from ClientPersonalDetails where Email='" + this.EmailClicked + "' ";
                string q4 = "delete from EmploymentHistory where Email='" + this.EmailClicked + "' ";
                string q5 = "delete from Languages where Email='" + this.EmailClicked + "' ";
                string q6 = "delete from PerQualification where Email='" + this.EmailClicked + "' ";
                string q7 = "delete from Photograph where Email='" + this.EmailClicked + "' ";
                string q8 = "delete from Refer where Email='" + this.EmailClicked + "' ";
                string q9 = "delete from Specialization where Email='" + this.EmailClicked + "' ";
                string q10 = "delete from ClientHistory where Email='" + this.EmailClicked + "' ";
                string q11 = "delete from UserTable where Email='" + this.EmailClicked + "' ";


                try
                {
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand(q2, con);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand(q3, con);
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand(q4, con);
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd5 = new SqlCommand(q5, con);
                    cmd5.ExecuteNonQuery();

                    SqlCommand cmd6 = new SqlCommand(q6, con);
                    cmd6.ExecuteNonQuery();

                    SqlCommand cmd7 = new SqlCommand(q7, con);
                    cmd7.ExecuteNonQuery();

                    SqlCommand cmd8 = new SqlCommand(q8, con);
                    cmd8.ExecuteNonQuery();

                    SqlCommand cmd9 = new SqlCommand(q9, con);
                    cmd9.ExecuteNonQuery();


                    SqlCommand cmd10 = new SqlCommand(q10, con);
                    cmd10.ExecuteNonQuery();


                    SqlCommand cmd11 = new SqlCommand(q11, con);
                    cmd11.ExecuteNonQuery();
                    this.Populate();
                    con.Close();


                    MessageBox.Show("Deleted Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void eduDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmailClicked = eduDataGrid.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Welcome w1 = new Welcome();
            w1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
