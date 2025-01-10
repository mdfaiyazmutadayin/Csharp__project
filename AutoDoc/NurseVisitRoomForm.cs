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
    public partial class NurseVisitRoomForm : Form
    {
        public NurseVisitRoomForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public int ID;
        private void NurseVisitRoomForm_Load(object sender, EventArgs e)
        {
            getRecords();
        }

        private void getRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM roomTable", sqlCon);
            DataTable dt = new DataTable();
            sqlCon.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            dataGridView.DataSource = dt;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchType = cmbSearch.Text;
            SqlCommand sCmd = new SqlCommand("select * from roomTable where RoomType = @RoomType", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@RoomType", searchType);
            sqlCon.Open();
            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from roomTable", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            dataGridView.DataSource = dt;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            IDTextBox.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            cmbType.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            floorTxt.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            cmbAv.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
