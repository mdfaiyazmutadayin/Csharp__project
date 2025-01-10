using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class StaffPatientReportTime : Form
    {
        public StaffPatientReportTime()
        {
            InitializeComponent();
            getRecords();
        }

        

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public static int rSerial;
        private void getRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM reportData", sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            reportDataGridView.DataSource = dt;
        }
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from reportData", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            reportDataGridView.DataSource = dt;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM reportData where RID = @RID", sqlCon);
            cmd.Parameters.AddWithValue("@RID",rSerial);
            sqlCon.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            sqlCon.Close();
            {
                MessageBox.Show("Report with "+ rSerial +"  deleted successfully from the database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            getRecords();
            resetAll();
        }

        private void resetAll()
        {
            rTxt.Clear();
        }

        private void reportDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rSerial = Convert.ToInt32(reportDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            rTxt.Text = "Time : " + reportDataGridView.SelectedRows[0].Cells[3].Value.ToString() + "\n";
            rTxt.Text += "Report Text : ";
            rTxt.Text += reportDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void StaffPatientReportTime_Load(object sender, EventArgs e)
        {
            getRecords();
        }
    }
}
