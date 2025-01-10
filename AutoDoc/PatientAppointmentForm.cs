using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoDoc
{
    public partial class PatientAppointmentForm : Form
    {
        public PatientAppointmentForm()
        {
            InitializeComponent();
        }

        public static string thisName = SharedData.uName;
        public static int thisID;

        private void Form6_Load(object sender, EventArgs e)
        {
            getID();
            fillCombo();
            getRecords();
        }

        private void fillCombo()
        {
            cmb.Items.Clear();
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID,Name from medRegInfo where Type = @Type";
            cmd.Parameters.AddWithValue("@Type", "Doctor");
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

        private void clrBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public int ID;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thisID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

        
            cmb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


            DateTime dob;
            if (DateTime.TryParseExact(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
            {
                apDate.Text = dob.ToString();
            }
            reasonTxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            

        }

        private void getID()
        {

            sqlCon.Open();
            string sqlQuery = "SELECT ID FROM medRegInfo WHERE Name = @Name";
            SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
            command.Parameters.AddWithValue("@Name", thisName);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                thisID = reader.GetInt32(0);
            }
            sqlCon.Close();
        }

        private void resetAll()
        {

            reasonTxt.Clear();
            apDate.Value = DateTime.Now;

        }

        private void getRecords()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM apTable", sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            dataGridView1.DataSource = dt;

        }
        private void reqbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string recipientInfo = this.cmb.Text.Trim();
                string[] recipientParts = recipientInfo.Split(' ');
                string recipientID = recipientParts[0];

                if (string.IsNullOrEmpty(recipientID))
                {
                    MessageBox.Show("Please select a Doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO apTable (pName, dName, date, reason, isDone) VALUES (@pName, @dName, @date, @reason,@isDone)", sqlCon);
                        cmd.Parameters.AddWithValue("@pName", thisID);
                        cmd.Parameters.AddWithValue("@dName", recipientID);
                        cmd.Parameters.AddWithValue("@date", apDate.Value);
                        cmd.Parameters.AddWithValue("@reason", reasonTxt.Text);
                        cmd.Parameters.AddWithValue("@isDone", "NO");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                getRecords();
                resetAll();
            }
            else
            {
                MessageBox.Show("Please select an user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool UserExists(string userID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM medRegInfo WHERE ID = @ID", sqlCon);
                    cmd.Parameters.AddWithValue("@ID", userID);
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
        private bool IsValid()
        {
            if (reasonTxt.Text == string.Empty)
            {
                MessageBox.Show("Please Write reasons!", "Null reason", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
