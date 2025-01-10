using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class NurseCheckMedForm : Form
    {
        public NurseCheckMedForm()
        {
            InitializeComponent();
        }
        public int mID;
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        private void medcineListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < medcineListDataGridView.Rows.Count)
                {
                    DataGridViewRow selectedRow = medcineListDataGridView.Rows[e.RowIndex];
                    if (selectedRow.Cells[0].Value != null)
                    {
                        mID = Convert.ToInt32(selectedRow.Cells[0].Value);
                        medIDtxt.Text = selectedRow.Cells[0].Value.ToString();
                        medNameTxt.Text = selectedRow.Cells[1].Value.ToString();
                        medPriceTxt.Text = selectedRow.Cells[2].Value.ToString();
                        takingCauseBox.Text = selectedRow.Cells[3].Value.ToString();

                        DateTime dob;
                        if (DateTime.TryParseExact(selectedRow.Cells[4].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
                        {
                            expDate.Text = dob.ToString();
                        }
                        else
                        {
                            expDate.Text = string.Empty;
                        }

                        if (selectedRow.Cells[5].Value != null)
                        {
                            byte[] img = (byte[])selectedRow.Cells[5].Value;
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                medPicBox.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            medPicBox.Image = null;
                        }
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
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

        private void searchBtn_Click(object sender, EventArgs e)
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

        private void NurseCheckMedForm_Load(object sender, EventArgs e)
        {
            getRecords();
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
    }
}
