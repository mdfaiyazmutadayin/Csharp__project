using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class NurseMsgForm : Form
    {
        public NurseMsgForm()
        {
            InitializeComponent();
        }
        //
        public int chatSerial;

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");


        public string thisName = SharedData.uName;

        public static int thisID = 0;
        public static int ChatSerial;

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
        private void getRecords()
        {

            SqlCommand cmd = new SqlCommand("select SenderID,Msg,Date from chatDB where RecID = @RecID", sqlCon);
            cmd.Parameters.AddWithValue("RecID", thisID);
            DataTable dt = new DataTable();
            sqlCon.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            msgDataGridView.DataSource = dt;
        }
        private void getSendRecords()
        {
            SqlCommand cmd = new SqlCommand("select RecID,Msg,Date from chatDB where SenderID = @SenderID", sqlCon);
            cmd.Parameters.AddWithValue("SenderID", thisID);
            DataTable dt = new DataTable();
            sqlCon.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            previouslySendMsgDataGridView.DataSource = dt;
        }
        private void resetAll()
        {
            sendMsgTxtBox.Clear();
            showMsgBox.Clear();
        }



        private void fillCombo()
        {
            cmbBox.Items.Clear();
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID,Name from medRegInfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbBox.Items.Add(dr["ID"].ToString() + " " + dr["Name"].ToString());
            }
            sqlCon.Close();
        }

        ///          /
        private bool IsValid()
        {
            if (sendMsgTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Please Write Message!", "Null Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string recipientInfo = this.cmbBox.Text.Trim();
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
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO chatDB (SenderID, RecID, Msg,Date) VALUES (@SenderID, @RecID, @Msg,@Date)", sqlCon);
                        cmd.Parameters.AddWithValue("@SenderID", thisID);
                        cmd.Parameters.AddWithValue("@RecID", recipientID);
                        cmd.Parameters.AddWithValue("@Msg", sendMsgTxtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString() );

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRecords();
                        resetAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getRecords();
            getSendRecords();
            resetAll();
        }

        private void msgDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            resetAll();
            chatSerial = Convert.ToInt32(msgDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            showMsgBox.Text = "Time : " + msgDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            showMsgBox.Text += "\n";
            showMsgBox.Text += "        Message :";
            showMsgBox.Text += msgDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void previouslySendMsgDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            resetAll();
            chatSerial = Convert.ToInt32(previouslySendMsgDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            showMsgBox.Text = "Time : " + previouslySendMsgDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            showMsgBox.Text += "\n";
            showMsgBox.Text += "          Message : ";
            showMsgBox.Text += previouslySendMsgDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void deleteMsgBtn_Click(object sender, EventArgs e)
        {
            if (chatSerial > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from chatDB where ChatSerial = @ChatSerial", sqlCon);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ChatSerial", chatSerial);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show(sendMsgTxtBox.Text + " message deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getRecords();
                resetAll();
            }
            else
            {
                MessageBox.Show("Please select message for Delete!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            getRecords();
            getSendRecords();
            resetAll();
        }

        private void NurseMsgForm_Load(object sender, EventArgs e)
        {
            getID();
            fillCombo();
            getRecords();
            getSendRecords();
        }
    }
}
