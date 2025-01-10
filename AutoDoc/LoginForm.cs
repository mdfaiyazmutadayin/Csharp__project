using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginFlowPanel.Height = 0;
            panelLog.Height = 0;
        }
        SqlConnection sqlcn = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");

        private void contriBtn_Click(object sender, EventArgs e)
        {
            ContributorsForm cf = new ContributorsForm();
            cf.Show();
            this.Hide();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Login 
            string username = usrnameBox.Text;
            SharedData.uName = username;
            string password = pwdBox.Text;

            if (username == "Admin" && password == "11")
            {

                var nf = new AdminMainForm();
                nf.Show();
                this.Hide();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT Name, Password, Type FROM medRegInfo WHERE Name = @Name AND Password = @Password", sqlcn);
                cmd.Parameters.AddWithValue("@Name", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string userType = dt.Rows[0]["Type"].ToString();

                    MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (userType == "Patient")
                    {
                        //patient form

                        var nf = new PatientForm();
                        nf.Show();
                    }
                    else if (userType == "Doctor")
                    {
                        //Doctor form

                        var df = new DoctorsForm();
                        df.Show();
                    }
                    else if (userType == "Staff")
                    {
                        // Open staff form
                        var sf = new StaffsForm();
                        sf.Show();
                    }
                    else if (userType == "Admin")
                    {
                        var nf = new AdminMainForm();
                        nf.Show();

                    }
                    else if (userType == "Nurse")
                    {
                        var nf = new NurseForm();
                        nf.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginTimerTransition.Start();
        }
        bool loginPanelExpand = false;
        private void loginTimerTransition_Tick(object sender, EventArgs e)
        {
            try
            {
                if (loginPanelExpand == false)
                {
                    loginFlowPanel.Height += 10;
                    panelLog.Height = loginFlowPanel.Height;
                    if (loginFlowPanel.Height >= 520)
                    {
                        loginPanelExpand = true;
                        loginTimerTransition.Stop();
                    }

                }
                else
                {

                    loginFlowPanel.Height -= 10;
                    panelLog.Height = loginFlowPanel.Height;
                    if (loginFlowPanel.Height <= 0)
                    {
                        loginPanelExpand = false;
                        loginTimerTransition.Stop();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            // reset
            usrnameBox.Clear();
            pwdBox.Clear();
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            // SignUP
            var newForm = new UserSignUpForm();
            newForm.Show();
            this.Hide();
        }
    }
}
