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
    public partial class Specialization : Form
    {
        private string Email { set; get; }
        public Specialization()
        {
            InitializeComponent();

        
        }

        public Specialization(string email)
        {
            InitializeComponent();
            this.Email = email;
            FillData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            JobClient jb = new JobClient(this.Email);
            jb.Show();
            this.Hide();
        }
        private void Populate()
        {
            string sql = "select * from specialization where Email='"+this.Email+"'";
            DataSet DS = DataAccess.GetDataSet(sql);

            this.skillDataGrid.AutoGenerateColumns = false;
            this.skillDataGrid.DataSource = DS.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            skillSave();
            Populate();
        }

        private void skillSave()
        {
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

            

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
            con.Open();


            string q = "Update Specialization set Skill = '" + skills + "' where Email = '" + this.Email + "'";
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
        private void FillData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
            {
                sqlConnection.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(
                        @"select * from specialization where Email='"+this.Email+"'", sqlConnection))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    skillDataGrid.DataSource = t;
                }

                sqlConnection.Close();
            }
        }


        private void Specialization_Load(object sender, EventArgs e)
        {
           //ShowData();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            skillSave();
            Populate();
        }
    }
    }


