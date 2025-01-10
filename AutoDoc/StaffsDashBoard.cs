using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoDoc
{
    public partial class StaffsDashBoard : Form
    {
        public StaffsDashBoard()
        {
            InitializeComponent();
            getID(SharedData.uName);
            dpBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dpBox.BackgroundImageLayout = ImageLayout.Stretch;
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");

        private void StaffsDashBoard_Load(object sender, EventArgs e)
        {
            
        }

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
                salaryLabel.Text = reader.GetDouble(9).ToString();
            }
            sqlCon.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
