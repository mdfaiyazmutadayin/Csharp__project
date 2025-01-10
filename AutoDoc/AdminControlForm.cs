using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoDoc
{
    public partial class AdminControlForm : Form
    {
        public AdminControlForm()
        {
            InitializeComponent();
            picBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUser.BackgroundImageLayout = ImageLayout.Stretch;
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public int uID;
        private void Form3_Load(object sender, EventArgs e)
        {
            getRecords();
            FILLDGV();
        }

        public void FILLDGV()
        {

            SqlCommand cmd = new SqlCommand("select * from medRegInfo",sqlCon);
            
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            dataGridView.DataSource = dt;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn) dataGridView.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void getRecords()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM medRegInfo", sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            dataGridView.DataSource = dt;


            /*
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        */
            
        }

        string gender = "";

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (picBoxUser.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    picBoxUser.Image.Save(ms, picBoxUser.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    SqlCommand cmd = new SqlCommand("insert into medRegInfo values (@Name,@Password,@DOB,@Gender,@Type,@Picture,@Phone,@Balance,@Salary)", sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", pwdBox.Text);
                    cmd.Parameters.AddWithValue("@DOB", dOB_Box.Value);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Type", typeBox.Text);
                    cmd.Parameters.AddWithValue("@Picture", img);
                    cmd.Parameters.AddWithValue("@Phone", phneBox.Text);
                    cmd.Parameters.AddWithValue("@Balance", balanceBox.Text);
                    cmd.Parameters.AddWithValue("@Salary", salaryBox.Text);


                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("New " + typeBox.Text + " saved in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRecords();
                    resetAll();
                } else
                {
                    MessageBox.Show("Please select an image.", "Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select user for update!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValid()
        {
            if(nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Name is Required!","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            } else
            {
                return true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (uID > 0)
            {
   
                if (picBoxUser.Image != null)
                {
             
                    MemoryStream ms = new MemoryStream();
                    picBoxUser.Image.Save(ms, picBoxUser.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    SqlCommand cmd = new SqlCommand("update medRegInfo set Name = @Name, Password = @Password, DOB = @DOB, Gender = @Gender, Type = @Type, Picture = @Picture, Phone = @Phone, Balance = @Balance, Salary = @Salary where ID = @ID", sqlCon);
                    cmd.CommandType = CommandType.Text;
                 //   cmd.Parameters.AddWithValue("@uID", uID);
                    cmd.Parameters.AddWithValue("@ID", idTxtBox.Text);
                    
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", pwdBox.Text);
                    cmd.Parameters.AddWithValue("@DOB", dOB_Box.Value);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Type", typeBox.Text);
                    cmd.Parameters.AddWithValue("@Picture", img);
                    cmd.Parameters.AddWithValue("@Phone", phneBox.Text);
                    cmd.Parameters.AddWithValue("@Balance", balanceBox.Text);
                    cmd.Parameters.AddWithValue("@Salary", salaryBox.Text);

          
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();

            
                    MessageBox.Show("Information " + typeBox.Text + " Updated successfully in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRecords();
                    resetAll();
                }
                else
                {
                    MessageBox.Show("Please select an image.", "Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select user for update!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idTxtBox.Text))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM medRegInfo where ID = @ID", sqlCon);
                cmd.Parameters.AddWithValue("ID",uID);
                sqlCon.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                sqlCon.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted successfully from the database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRecords();
                    resetAll();
                }
            }     
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void resetAll()
        {
            uID = 0;
            nameTextBox.Clear();
            idTxtBox.Clear();
            pwdBox.Clear();
            phneBox.Clear();
            typeBox.ResetText();
            salaryBox.Clear();
            balanceBox.Clear();
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            otherRBtn.Checked = false;
            nameTextBox.Focus();
            picBoxUser.Image = null;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void patientsShowBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo where Type = @Type", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@Type", "Patient");
            sqlCon.Open();
   
            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void doctorShowBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo where Type = @Type", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@Type", "Doctor");
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void staffsShowBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo where Type = @Type", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@Type", "Staff");
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchID = searchBox.Text;
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo where ID = @ID", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@ID", searchID);
            sqlCon.Open();
            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var nfa = new LoginForm();
            nfa.Show();
            this.Close();
        }



        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
           
            idTxtBox.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            
            pwdBox.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();

            DateTime dob;
            if (DateTime.TryParseExact(dataGridView.SelectedRows[0].Cells[3].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
            {
                dOB_Box.Text = dob.ToString();
            }

            string gen = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (gen == "Male")
            {
                maleRadioBtn.Checked = true;
                femaleRadioBtn.Checked = false;
                otherRBtn.Checked = false;
                gender = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            } else if(gen == "Female") 
            {
                maleRadioBtn.Checked = false;
                femaleRadioBtn.Checked = true;
                otherRBtn.Checked = false;
                gender = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                maleRadioBtn.Checked = false;
                femaleRadioBtn.Checked = false;
                otherRBtn.Checked = true;
                gender = dataGridView.SelectedRows[0].Cells[4].Value.ToString();

            }

            typeBox.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();

            Byte[] img = (Byte[])dataGridView.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            picBoxUser.Image = Image.FromStream(ms);

            phneBox.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
            balanceBox.Text = (dataGridView.SelectedRows[0].Cells[8].Value.ToString());
            salaryBox.Text = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxUser.Image = new Bitmap(ofd.FileName);
            }
        }

        private void maleRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void femaleRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Female";
        }
        private void otherRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Other";
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo where Type = @Type", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@Type", "Admin");
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void nurseBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo where Type = @Type", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@Type", "Nurse");
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }
    }
}
