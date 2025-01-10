using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoDoc
{

    public partial class DoctorWriteReportForm : Form
    {
        public static string dName = SharedData.uName;
        public static string pName;
        public static int thisID;
        public static int rSerial = 0;
        public DoctorWriteReportForm()
        {
            InitializeComponent();
            getDID();
            getRecords();
            fillCombo();
        }

        private void DoctorAppointment_Load(object sender, EventArgs e)
        {
            rTxt.GotFocus += rTxt_GotFocus;
            rTxt.LostFocus += rTxt_LostFocus;

            rTxt.Text = "Enter your text here...";
            rTxt.ForeColor = Color.Gray;
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        private void rTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void rTxt_GotFocus(object sender, EventArgs e)
        {
            if (rTxt.Text == "Enter your text here...")
            {
                rTxt.Text = "";
                rTxt.ForeColor = Color.Black; // Change the text color if needed
            }
        }

        private void rTxt_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rTxt.Text))
            {
                rTxt.Text = "Enter your text here...";
                rTxt.ForeColor = Color.Gray; // Change the text color if needed
            }
        }
        private void getDID()
        {

            sqlCon.Open();
            string sqlQuery = "SELECT ID FROM medRegInfo WHERE Name = @Name";
            SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
            command.Parameters.AddWithValue("@Name", dName);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                thisID = reader.GetInt32(0);
            }
            sqlCon.Close();
        }


        private void getRecords()
        {

            SqlCommand cmd = new SqlCommand("select PID,RText,Date from reportData where DID= @DID", sqlCon);
            cmd.Parameters.AddWithValue("@DID", thisID);
            DataTable dt = new DataTable();
            sqlCon.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            reportDataGridView.DataSource = dt;
        }


        private void resetAll()
        {
            cmb.ResetText();
            rTxt.Clear();

        }
        

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string recipientInfo = this.cmb.Text.Trim();
                string[] recipientParts = recipientInfo.Split(' ');
                string recipientID = recipientParts[0];

                if (string.IsNullOrEmpty(recipientID))
                {
                    MessageBox.Show("Please select a recipient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!UserExists(recipientID))
                {
                    MessageBox.Show("Selected recipient does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False"))
                {
                    try
                    {
                        string currDate = DateTime.Now.ToString();
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO reportData (DID, PID, Date, RText) VALUES (@DID, @PID, @Date ,@RText)", sqlCon);
                        cmd.Parameters.AddWithValue("@DID", thisID);
                        cmd.Parameters.AddWithValue("@PID", recipientID);
                        cmd.Parameters.AddWithValue("@Date", currDate);
                        cmd.Parameters.AddWithValue("@RText", rTxt.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                getRecords();
               // getSendRecords();
                resetAll();
            }
            else
            {
                MessageBox.Show("Please select an user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValid()
        {
            if (rTxt.Text == string.Empty)
            {
                MessageBox.Show("Please Write Message!", "Null Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool UserExists(string recipientID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM medRegInfo WHERE ID = @ID", sqlCon);
                    cmd.Parameters.AddWithValue("@ID", recipientID);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void fillCombo()
        {
            cmb.Items.Clear();
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID,Name from medRegInfo Where Type = @Type";
            cmd.Parameters.AddWithValue("@Type","Patient");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmb.Items.Add(dr["ID"].ToString() + " " + dr["Name"].ToString());
            }
            sqlCon.Close();
        }

        private void Rewrite_Click(object sender, EventArgs e)
        {
           
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void reportDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rSerial = Convert.ToInt32(reportDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            rTxt.Text = "Time : " + reportDataGridView.SelectedRows[0].Cells[2].Value.ToString() + "\n";
            rTxt.Text += "Report Text : ";
            rTxt.Text += reportDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

       
    }
}
