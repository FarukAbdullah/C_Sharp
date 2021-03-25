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
    public partial class Search : Form
    {
        private string Email { get; set; }

        public Search()
        {
            InitializeComponent();
        }
        public Search(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source= DESKTOP-SPA9M1F\RASHED;Initial Catalog=ProjectOOP2;Integrated Security=True";
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    con.Open();
        //    SqlDataReader dr;
        //    SqlCommand com = new SqlCommand("select experience from EmploymentHistory where experience like @experience");
        //    com.Parameters.Add(new SqlParameter("@experience", "%" + textBox1.Text + "%"));
        //    com.ExecuteNonQuery();
        //    dr = com.ExecuteReader();
        //    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        //    while (dr.Read())
        //    {
        //        col.Add(dr.GetString(0));
        //    }
        //    textBox1.AutoCompleteCustomSource = col;
        //    con.Close();
        //}

        //private void txtSkill_TextChanged(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source= DESKTOP-SPA9M1F\RASHED;Initial Catalog=ProjectOOP2;Integrated Security=True";
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    con.Open();
        //    SqlDataReader dr;
        //    SqlCommand com = new SqlCommand("select skill from Specialization where skill like @skill");
        //    com.Parameters.Add(new SqlParameter("@skill", "%" + txtSkill.Text + "%"));
        //    com.ExecuteNonQuery();
        //    dr = com.ExecuteReader();
        //    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        //    while (dr.Read())
        //    {
        //        col.Add(dr.GetString(0));
        //    }
        //    txtSkill.AutoCompleteCustomSource = col;
        //    con.Close();

        //}

        //private void txtEduLevel_TextChanged(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source= DESKTOP-SPA9M1F\RASHED;Initial Catalog=ProjectOOP2;Integrated Security=True";
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    con.Open();
        //    SqlDataReader dr;
        //    SqlCommand com = new SqlCommand("select Level from EducationLevel where Level like @Level");
        //    com.Parameters.Add(new SqlParameter("@Level", "%" + txtExperience.Text + "%"));
        //    com.ExecuteNonQuery();
        //    dr = com.ExecuteReader();
        //    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        //    while (dr.Read())
        //    {
        //        col.Add(dr.GetString(0));
        //    }
        //    txtExperience.AutoCompleteCustomSource = col;
        //    con.Close();

        //}

        //private void txtMajor_TextChanged(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source= DESKTOP-SPA9M1F\RASHED;Initial Catalog=ProjectOOP2;Integrated Security=True";
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    con.Open();
        //    SqlDataReader dr;
        //    SqlCommand com = new SqlCommand("select major from MSC where major like @major");
        //    com.Parameters.Add(new SqlParameter("@major", "%" + txtMajor.Text + "%"));
        //    com.ExecuteNonQuery();
        //    dr = com.ExecuteReader();
        //    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        //    while (dr.Read())
        //    {
        //        col.Add(dr.GetString(0));
        //    }
        //    txtMajor.AutoCompleteCustomSource = col;
        //    con.Close();
        //}

        //private void txtMinor_TextChanged(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source= DESKTOP-SPA9M1F\RASHED;Initial Catalog=ProjectOOP2;Integrated Security=True";
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    con.Open();
        //    SqlDataReader dr;
        //    SqlCommand com = new SqlCommand("select minor from MSC where minor like @minor");
        //    com.Parameters.Add(new SqlParameter("@minor", "%" + txtMinor.Text + "%"));
        //    com.ExecuteNonQuery();
        //    dr = com.ExecuteReader();
        //    AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        //    while (dr.Read())
        //    {
        //        col.Add(dr.GetString(0));
        //    }
        //    txtMinor.AutoCompleteCustomSource = col;
        //    con.Close();
        //}


        private void btnSearch_Click(object sender, EventArgs e)
        {
            clientDataGridSearch.DataSource = null;
            string skills = "";

            if (checkBox1.Checked == true)
            {
                skills += checkBox1.Text + ",";
            }
            if (checkBox2.Checked == true)
            {
                skills += checkBox2.Text + ",";
            }
            if (checkBox3.Checked == true)
            {
                skills += checkBox3.Text + ",";
            }

            if (chkAI.Checked == true)
            {
                skills += chkAI.Text + ",";
            }

            if (chkJScript.Checked == true)
            {
                skills += chkJScript.Text + ",";
            }

            if (chkDMining.Checked == true)
            {
                skills += chkDMining.Text + ",";
            }
            if (chkDWare.Checked == true)
            {
                skills += chkDWare.Text + ",";
            }

            if (chkLavarel.Checked == true)
            {
                skills += chkLavarel.Text + ",";
            }

            if (chkAccounting.Checked == true)
            {
                skills += chkAccounting.Text + ",";
            }
            if (chkFinance.Checked == true)
            {
                skills += chkFinance.Text + ",";
            }

            if (chkHtml.Checked == true)
            {
                skills += chkHtml.Text + ",";
            }

            if (chkCSS.Checked == true)
            {
                skills += chkCSS.Text + ",";
            }
            if (chkRobotics.Checked == true)
            {
                skills += chkRobotics.Text + ",";
            }

            if (chkPhP.Checked == true)
            {
                skills += chkPhP.Text + ",";
            }

            if (chkNetwork.Checked == true)
            {
                skills += chkNetwork.Text + ",";
            }
            if (chkMangnment.Checked == true)
            {
                skills += chkMangnment.Text + ",";
            }

            if (chkSTest.Checked == true)
            {
                skills += chkSTest.Text + ",";
            }

            if (chkRubby.Checked == true)
            {
                skills += chkRubby.Text + ",";
            }

            string Exp = cmbExp.Text;


            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
                {
                    sqlConnection.Open();
                    using (SqlDataAdapter a = new SqlDataAdapter( @"SELECT  D.Email, S.Skill, E.Experience
                                FROM ClientPersonalDetails D
                                INNER JOIN Specialization S ON S.Email = D.Email
                                INNER JOIN EmploymentHistory E ON E.Email = D.Email
                                WHERE S.Skill LIKE '%" + skills + "%' or E.Experience = '"+Exp+ "' and D.Email='" + this.Email + "' ", sqlConnection))
                        {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        clientDataGridSearch.DataSource = t;
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CompanyJob cjb = new CompanyJob(this.Email);
            cjb.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void clientDataGridSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ShowResume sr = new ShowResume(clientDataGridSearch.Rows[e.RowIndex].Cells[0].Value.ToString(), this);
                sr.Show();
                this.Hide();     
            }
        }
    }
}
