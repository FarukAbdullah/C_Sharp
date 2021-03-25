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
    public partial class JobClient : Form
    {
        private string Email { set; get; }
        public bool isCollapsed;
        public bool subCollapsed;
        //Form f;
        //int count = 0;

        public JobClient()
        {
            InitializeComponent();
        }

        public JobClient(string email)
        {
            InitializeComponent();
            this.Email= email;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlDropDown.Height += 10;
                if (pnlDropDown.Size == pnlDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                pnlDropDown.Height -= 10;
                if (pnlDropDown.Size == pnlDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }


            }

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlDropDown2.Height += 10;
                if (pnlDropDown2.Size == pnlDropDown2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }

            }
            else
            {

                pnlDropDown2.Height -= 10;
                if (pnlDropDown2.Size == pnlDropDown2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }


            }

        private void btnEducationTra_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnEmployment_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlDropDown3.Height += 10;
                if (pnlDropDown3.Size == pnlDropDown3.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }

            }
            else
            {

                pnlDropDown3.Height -= 10;
                if (pnlDropDown3.Size == pnlDropDown3.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlDropDown4.Height += 10;
                if (pnlDropDown4.Size == pnlDropDown4.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed = false;
                }

            }
            else
            {

                pnlDropDown4.Height -= 10;
                if (pnlDropDown4.Size == pnlDropDown4.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnOtherInfo_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void btnPersonalDetails_Click(object sender, EventArgs e)
        {


            ClientPersonalDetails pd = new ClientPersonalDetails(this.Email);
            pd.Show();
            this.Hide();


        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            Address add = new Address(this.Email);
            add.Show();
            this.Hide();
        }

        private void btnCareerInfo_Click(object sender, EventArgs e)
        {
            Photograph pg = new Photograph(this.Email);
            pg.Show();
            this.Hide();
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            //timer5.Start();
            EducationInfo eifno = new EducationInfo(this.Email);
            eifno.Show();
            this.Hide();

        }

        private void btnQualification_Click(object sender, EventArgs e)
        {
            PerQualification pq = new PerQualification(this.Email);
            pq.Show();
            this.Hide();
        }

       private void button2_Click(object sender, EventArgs e)
        {
            EHistory h = new EHistory(this.Email);
            h.Show();
            this.Hide();
        }

        private void btnSpecialization_Click(object sender, EventArgs e)
        {
            Specialization spe = new Specialization(this.Email);
            spe.Show();
            this.Hide();
        }

        private void btnLangugeProficiency_Click(object sender, EventArgs e)
        {
            Language lng = new Language(this.Email);
            lng.Show();
            this.Hide();
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            References re = new References(this.Email);
            re.Show();
            this.Hide();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete your Account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
                con.Open();

                string q = "delete from Address where Email='" + this.Email + "' ;";
               
                string q2 = "delete from ClientCareer where Email='" + this.Email + "' ";
                string q3 = "delete from ClientPersonalDetails where Email='" + this.Email + "' ";
                string q4 = "delete from EmploymentHistory where Email='" + this.Email + "' ";
                string q5 = "delete from Languages where Email='" + this.Email + "' ";
                string q6 = "delete from PerQualification where Email='" + this.Email + "' ";
                string q7 = "delete from Photograph where Email='" + this.Email + "' ";
                string q8 = "delete from Refer where Email='" + this.Email + "' ";
                string q9 = "delete from Specialization where Email='" + this.Email + "' ";
                string q10 = "delete from ClientHistory where Email='" + this.Email + "' ";
                string q11 = "delete from UserTable where Email='" + this.Email + "' ";


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
                    con.Close();
                

                    MessageBox.Show("Deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Welcome f = new Welcome();

                f.Show();
                this.Hide();


            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowResume s = new ShowResume(this.Email, this);
            s.Show();
            this.Hide();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
