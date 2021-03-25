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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to Create Account?", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                        string query = "insert into UserTable (Email, Password, Status) values('" + email + "', '" + pass + "', '" + 0 + "');";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();


                        string query2 = "insert into Company (Email) values('" + email + "');";
                        SqlCommand cmdd = new SqlCommand(query2, con);
                        cmdd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Welcome!!! Have a nice journey with us.");
                        CompanyJob form = new CompanyJob(this.txtEmail.Text);
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
            About_Us us = new About_Us();
            us.Show();
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
            CreateAccount u = new CreateAccount();
            u.Show();
            this.Hide();
        }

        private bool VerifyEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

      
    }
}

