using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class DoctorMedicineListForm : Form
    {
        public int mID;
        public DoctorMedicineListForm()
        {
            InitializeComponent();
            medPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            medPicBox.BackgroundImageLayout = ImageLayout.Stretch;
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");


        private void DoctorMedicineListForm_Load(object sender, EventArgs e)
        {
            getRecords();
            FILLDGV();

        }

        public void FILLDGV()
        {

            SqlCommand cmd = new SqlCommand("select * from medListInfo", sqlCon);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            medcineListDataGridView.DataSource = dt;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)medcineListDataGridView.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void getRecords()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM medListInfo", sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            medcineListDataGridView.DataSource = dt;


            /*
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        */

        }
        private void resetAll()
        {
            medNameTxt.Clear();
            medIDtxt.Clear();
            medPriceTxt.Clear();
            takingCauseBox.Clear();
            medPicBox.Image = null;
        }
  

        private void medcineListDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            mID = Convert.ToInt32(medcineListDataGridView.SelectedRows[0].Cells[0].Value);

            medIDtxt.Text = medcineListDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            medNameTxt.Text = medcineListDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            medPriceTxt.Text = medcineListDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            takingCauseBox.Text = medcineListDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            DateTime dob;
            if (DateTime.TryParseExact(medcineListDataGridView.SelectedRows[0].Cells[3].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
            {
                expDate.Text = dob.ToString();
            }
            Byte[] img = (Byte[])medcineListDataGridView.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            medPicBox.Image = Image.FromStream(ms);
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            string searchID = searchMedTxtBox.Text;
            SqlCommand sCmd = new SqlCommand("select * from medListInfo where mID = @mID", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@mID", searchID);
            sqlCon.Open();
            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            medcineListDataGridView.DataSource = dt;
        }

        private void clrBtn_Click_1(object sender, EventArgs e)
        {
            resetAll();
        }

        private void showAllBtn_Click_1(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medListInfo", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            medcineListDataGridView.DataSource = dt;
        }
    }
}
