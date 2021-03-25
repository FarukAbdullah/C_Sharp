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
using System.Text.RegularExpressions;

namespace JobPortal
{
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to Create  Account?", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            string email = txtEmail.Text;
            string pass = txtPassword.Text;

                if (!VerifyEmail(email))
                {
                    MessageBox.Show("Invalid Email !!");
                }
                else
                {
                    try
                    {

                        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
                        con.Open();

                        string query = "insert into UserTable (Email, Password, Status) values('" + email + "', '" + pass + "', '" + 1 + "');";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        string query1 = "insert into ClientPersonalDetails (Email) values('" + email + "')";
                        SqlCommand cmdd = new SqlCommand(query1, con);
                        cmdd.ExecuteNonQuery();

                        string query2 = "insert into Address (Email) values ('" + email + "')";
                        SqlCommand cmd1 = new SqlCommand(query2, con);
                        cmd1.ExecuteNonQuery();

                        //string query3 = "insert into ClientCareer (Email) values ('" + email + "')";
                        //SqlCommand cmd2 = new SqlCommand(query3, con);
                        //cmd2.ExecuteNonQuery();

                        string query4 = "insert into ClientHistory (Email) values ('" + email + "')";
                        SqlCommand cmd3 = new SqlCommand(query4, con);
                        cmd3.ExecuteNonQuery();

                        string query5 = "insert into EmploymentHistory (Email) values ('" + email + "')";
                        SqlCommand cmd4 = new SqlCommand(query5, con);
                        cmd4.ExecuteNonQuery();

                        string query6 = "insert into Languages (Email) values ('" + email + "')";
                        SqlCommand cmd5 = new SqlCommand(query6, con);
                        cmd5.ExecuteNonQuery();

                        string query7 = "insert into PerQualification (Email) values ('" + email + "')";
                        SqlCommand cmd6 = new SqlCommand(query7, con);
                        cmd6.ExecuteNonQuery();

                        string query8 = "insert into Refer (Email) values ('" + email + "')";
                        SqlCommand cmd7 = new SqlCommand(query8, con);
                        cmd7.ExecuteNonQuery();

                        string query9 = "insert into Specialization (Email) values ('" + email + "')";
                        SqlCommand cmd8 = new SqlCommand(query9, con);
                        cmd8.ExecuteNonQuery();


                        MessageBox.Show("Welcome!!! Have a nice journey with us.");
                        con.Close();

                        JobClient form = new JobClient(this.txtEmail.Text);
                        form.Show();
                        this.Hide();
                    }

                    catch
                    {
                        MessageBox.Show("Please give valid input");
                    }
                }
            }

            
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs();
            cu.Show();
            this.Hide();
        }

        private bool VerifyEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount a = new CreateAccount();
            a.Show();
            this.Hide();
        }
    }
}
