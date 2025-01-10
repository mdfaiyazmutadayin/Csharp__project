using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class DoctorDashboardForm : Form
    {
        public DoctorDashboardForm()
        {
            InitializeComponent();
            dpBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dpBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public static string name = SharedData.uName;

        private void getID()
        {
            sqlCon.Open();
            string sqlQuery = "SELECT * FROM medRegInfo WHERE Name = @Name";
            SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
            command.Parameters.AddWithValue("@Name", name);

            SqlDataReader reader = command.ExecuteReader();
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
                    MessageBox.Show("No Image","NULL",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                phoneLabel.Text = reader.GetString(7);
                balanceLabel.Text = reader.GetDouble(8).ToString();
                salaryLabel.Text = reader.GetDouble(9).ToString();
            }
            sqlCon.Close();
        }

        private void DoctorDashboardForm_Load(object sender, EventArgs e)
        {
            getID();
        }
    }
}
