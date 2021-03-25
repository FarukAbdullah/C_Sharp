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

    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string Email = txtEmail.Text;
            string Password = txtPassword.Text;

            using (SqlConnection con = new SqlConnection(@"Data Source = SOHAN; Initial Catalog = ProjectOOP2; Integrated Security = True"))
              {
                 con.Open();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM UserTable WHERE email = @Email", con))
                {
                    command.Parameters.Add(new SqlParameter("Email", Email));
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            if (Password.Equals(reader["password"].ToString()))
                            {
                                    if(Convert.ToInt32(reader["Status"]).Equals(0))
                                    {
                                        CompanyJob cjob = new CompanyJob(this.txtEmail.Text);
                                        cjob.Show();
                                        this.Close();
                                    }

                                    else if (Convert.ToInt32(reader["Status"]).Equals(1))
                                    {
                                        JobClient cjob = new JobClient(this.txtEmail.Text);
                                        cjob.Show();
                                        this.Close();
                                    }

                                    else
                                    {
                                        AdminJob cjob = new AdminJob(this.txtEmail.Text);
                                        cjob.Show();
                                        this.Close();
                                    }

                                }
                            else 
                                {
                                    MessageBox.Show("Password Does not Match. Try Again.");
                                }
                        }
                        else
                            {
                                MessageBox.Show("Email Does not exist.");
                            }
                    }

                }
            }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Hide();
        }
    }
}
