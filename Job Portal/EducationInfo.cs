using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal
{

    public partial class EducationInfo : Form
    {
        private string Email { set; get; }
      
        int indexRow;

        public EducationInfo()
        {
            InitializeComponent();
            fillDegree();
            FillData();
        }
        public EducationInfo(string email)
        {

            InitializeComponent();
            this.Email = email;
            fillDegree();
            FillData();
        }

        public void fillDegree()
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
            {
                SqlCommand sqlCmd = new SqlCommand(@"select t.id, t.degree_name from education_degree t order by t.degree_order asc", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    drpDegree.Items.Add(sqlReader["id"].ToString() + ", " + sqlReader["degree_name"].ToString());
                }

                sqlReader.Close();
            }
        }

        private void FillData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
            {
                sqlConnection.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(
                        @"SELECT  t.institution_name,t.grp,t.result,t.ExamPlace, t.DegreeTitle,t.passing_year,d.degree_name
                            FROM education_info t 
                            INNER JOIN education_degree d on d.id = t.degree_id where t.Email='" + this.Email + "' ", sqlConnection))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    eduDataGrid.DataSource = t;
                }

                sqlConnection.Close();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedItem == null)
            {

                MessageBox.Show("Invalid group");
            }
            string grp = cmbGroup.Text;

            if (cmbPlace.SelectedItem == null)
            {

                MessageBox.Show("Invali Place");
            }
            string Eplace = cmbPlace.Text;

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
            con.Open();


            try
            {

                string q = @"INSERT INTO education_info(Email, degree_id, institution_name,grp,result,ExamPlace,DegreeTitle,passing_year)
                         VALUES('" + this.Email + "', '" + Convert.ToInt64(drpDegree.SelectedItem.ToString().Split(',')[0]) + "','" + textInsName.Text + "','" + grp + "', '" + txtResult.Text + "','" + Eplace + "','" + txtDTitle.Text + "','" + txtYear.Text + "')";

                SqlCommand cmd1 = new SqlCommand(q, con);
                cmd1.ExecuteNonQuery();
                con.Close();

                FillData();
                MessageBox.Show("Work done Successfully");


            }
            catch
            {

                MessageBox.Show("Please give valid input");

            }
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            JobClient cj = new JobClient(this.Email);
            cj.Show();
            this.Hide();
        }
        
        private void eduDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = eduDataGrid.Rows[indexRow];
            drpDegree.Text = row.Cells[6].Value.ToString();
            textInsName.Text = row.Cells[0].Value.ToString();
            cmbGroup.Text = row.Cells[1].Value.ToString();
            txtResult.Text = row.Cells[2].Value.ToString();
            txtYear.Text = row.Cells[5].Value.ToString();
            cmbPlace.Text = row.Cells[3].Value.ToString();
            txtDTitle.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DataGridViewRow newDataRow = eduDataGrid.Rows[indexRow];
            newDataRow.Cells[0].Value = textInsName.Text;
            newDataRow.Cells[1].Value = cmbGroup.Text;
            newDataRow.Cells[2].Value = txtResult.Text;
            newDataRow.Cells[3].Value = cmbPlace.Text;
            newDataRow.Cells[4].Value = txtDTitle.Text;
            newDataRow.Cells[5].Value = txtYear.Text;
            newDataRow.Cells[6].Value = drpDegree.Text;
            MessageBox.Show("Updated SuccessFully");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textInsName.Text = "";
            this.cmbGroup.Text = "";
            this.txtResult.Text = "";
            this.cmbPlace.Text = "";
            this.txtDTitle.Text = "";
            this.txtYear.Text = "";
            this.drpDegree.Text = "";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Welcome l = new Welcome();
            l.Show();
            this.Hide();
        }
    }
    }


