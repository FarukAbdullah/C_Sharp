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
using System.IO;


namespace JobPortal
{
    public partial class Photograph : Form
    {
        private string Email { set; get; }
        public Photograph()
        {
            InitializeComponent();
        }

        public Photograph(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        SqlConnection conection = new SqlConnection(@"Data Source = DESKTOP-1CCJE90\SAMIA; Initial Catalog = ProjectOOP2; Integrated Security = True");
        string imglocation = "";
        SqlCommand cmd;

        public void Save()
        {
             byte[] images = null;
            FileStream Streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);

            images = brs.ReadBytes((int)Streem.Length);


            conection.Open();
            
            string sqlQuery = "Insert into Photograph(Email,Image)values('" + this.Email + "',@images)";
            try
            {
                cmd = new SqlCommand(sqlQuery, conection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                conection.Close();
                MessageBox.Show(N.ToString() + "Data Saved Successfully..!");
            }
            catch
            {
                MessageBox.Show("Please insert your image");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public void Upload()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            JobClient jb = new JobClient(this.Email);
            jb.Show();
            this.Hide();
        }

        public void ViewPhoto()
        {
            conection.Open();

            string sqlQuery = "select Image from Photograph Where Email='" + this.Email + "'";
            try
            {
                cmd = new SqlCommand(sqlQuery, conection);
                SqlDataReader DataRead = cmd.ExecuteReader();
                DataRead.Read();

                if (DataRead.HasRows)
                {
                    byte[] images = ((byte[])DataRead[0]);

                    if (images == null)
                    {
                        pictureBox1.Image = null;
                    }


                    else
                    {
                        MemoryStream mstreem = new MemoryStream(images);
                        pictureBox1.Image = Image.FromStream(mstreem);
                    }
                }

                else
                {
                    MessageBox.Show("Enter Image");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please insert Valid Input");
            }
            conection.Close();
        }
       
        private void Photograph_Load(object sender, EventArgs e)
        {
            ViewPhoto();
        }

        
    }
    }


    

