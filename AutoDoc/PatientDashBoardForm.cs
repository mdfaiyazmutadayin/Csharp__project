using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class PatientDashBoardForm : Form
    {
        public PatientDashBoardForm()
        {
            InitializeComponent();
            getID(SharedData.uName);
            dpBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dpBox.BackgroundImageLayout = ImageLayout.Stretch;

        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public static string name = SharedData.uName;

        private void getID(string uName)
        {
            sqlCon.Open();
            string sqlQuery = "SELECT * FROM medRegInfo WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon);

            cmd.Parameters.AddWithValue("@Name", uName);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                idLabel.Text = reader.GetInt32(0).ToString();
                nameLabel.Text = reader.GetString(1);
                pwdLabel.Text = reader.GetString(2);
                DateTime dob = reader.GetDateTime(3);
                dobLabel.Text = dob.ToString("dd-MM-yyyy");
                genderLabel.Text = reader.GetString(4);
                typeLabel.Text = reader.GetString(5);
                byte[] imageData = reader["Picture"] as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        dpBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    label1.Text = null;
                    dpBox.Image = null;
                }
                phoneLabel.Text = reader.GetString(7);
                balanceLabel.Text = reader.GetDouble(8).ToString();
            }
            sqlCon.Close();
        }

        private void PatientDashBoardForm_Load(object sender, EventArgs e)
        {
            
        }



    }
}
