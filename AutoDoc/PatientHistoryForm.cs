using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoDoc
{
    public partial class PatientHistoryForm : Form
    {
        public int rSerial = 0;
        public static string thisName = SharedData.uName;
        public int thisID;
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public PatientHistoryForm()
        {
            InitializeComponent();
            getRecords();
            getID(thisName);
        }

        private void Form7_Load(object sender, EventArgs e)
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
                thisID = reader.GetInt32(0);
            }
            sqlCon.Close();
        }
        private void getRecords()
        {
            SqlCommand cmd = new SqlCommand("select * from reportData where PID= @PID", sqlCon);
            cmd.Parameters.AddWithValue("@PID", thisID);
            DataTable dt = new DataTable();
            sqlCon.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            reportDataGridView.DataSource = dt;
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

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from reportData where PID= @PID", sqlCon);
            cmd.Parameters.AddWithValue("@PID", thisID);
            DataTable dt = new DataTable();
            sqlCon.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            reportDataGridView.DataSource = dt;

            
        }
    }
}
