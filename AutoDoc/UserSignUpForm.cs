using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class UserSignUpForm : Form
    {
        public UserSignUpForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            signUpTimer.Start();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");

        private string gender = "";
        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (SignUpPicBox.Image != null)
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("insert into medRegInfo values (@Name,@Password,@DOB,@Gender,@Type,@Picture,@Phone,@Balance,@Salary)", sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    //    cmd.Parameters.AddWithValue("@ID", idTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DOB", dOB_Box.Value);
                    cmd.Parameters.AddWithValue("@Password", pwdBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Type", typeBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", phneBox.Text);
                    cmd.Parameters.AddWithValue("@Balance", (0));
                    cmd.Parameters.AddWithValue("@Salary", (0));
                    cmd.Parameters.AddWithValue("@Picture", getPhoto());

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Your information is successfully registered!", "Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetAll();
                }
            } else
            {
                MessageBox.Show("Please Enter Picture","NULL Image",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private byte[] getPhoto()
        {
            if (SignUpPicBox.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                SignUpPicBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg); // Save as JPEG format for compatibility
                return stream.ToArray();
            }
            else
            {
                return null;
            }
        }

        private void resetAll()
        {
            nameTextBox.Clear();
            pwdBox.Clear();
            phneBox.Clear();
            typeBox.ResetText();
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            otherRBtn.Checked = false;
            nameTextBox.Focus();
            SignUpPicBox.Image = null;
        }

        private bool IsValid()
        {
            if (nameTextBox.Text == string.Empty && SignUpPicBox.Image== null && pwdBox.Text == string.Empty && typeBox.Text == string.Empty && gender == string.Empty && dOB_Box.Value == null)
            {
                MessageBox.Show("All Information are not given. All data is Required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }

            else
            {

                return true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var nfa = new LoginForm();
            nfa.Show();
            this.Close();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }

      

        private void signUpFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        bool signUpBar = false;
        private void signUpTimer_Tick(object sender, EventArgs e)
        {
            if (signUpBar == false)
            {
                signUpFlowPanel.Height += 5;
                if (signUpFlowPanel.Height >= 500)
                {
                    signUpBar = true;
                    signUpTimer.Stop();
                }
            }
            else
            {
                signUpFlowPanel.Height -= 5;
                if (signUpFlowPanel.Height <= 0)
                {
                    signUpBar = false;
                    signUpTimer.Stop();
                }
            }
        }

        private void SignUpPicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SignUpPicBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maleRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void femaleRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void otherRBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }
    }
}
