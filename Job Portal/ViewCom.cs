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
    public partial class ViewCom : Form
    {
       private string EmailClicked { get; set; }
        public ViewCom()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True"))
            {
                sqlConnection.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(
                        @"SELECT * from Company ", sqlConnection))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    eduDataGrid.DataSource = t;
                }

                sqlConnection.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminJob aj = new AdminJob();
            aj.Show();
            this.Hide();
        }
        private void Populate()
        {
            string sql = "select * from company";
            DataSet DS = DataAccess.GetDataSet(sql);

            this.eduDataGrid.AutoGenerateColumns = false;
            this.eduDataGrid.DataSource = DS.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string sql = "select * from company where Email like '" + this.txtSearch.Text + "%';";
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
                string sql = "delete from company where Email = '" + this.EmailClicked + "';";
                string sq2 = "delete from usertable where Email = '" + this.EmailClicked + "';";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand(sq2, con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Deleted");
                    this.Populate();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void eduDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmailClicked = this.eduDataGrid.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Welcome w1 = new Welcome();
            w1.Show();
            this.Hide();
        }
    }
}
