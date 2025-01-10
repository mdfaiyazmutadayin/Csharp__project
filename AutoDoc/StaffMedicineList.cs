using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class StaffMedicineList : Form
    {
        public int mID;
        public StaffMedicineList()
        {
            InitializeComponent();
        }
        
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        
        
        
        private void StaffMedicineList_Load(object sender, EventArgs e)
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
        private void addMedBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (medPicBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    medPicBox.Image.Save(ms, medPicBox.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    SqlCommand cmd = new SqlCommand("insert into medListInfo values (@mName,@mPrice,@mCause,@mExpDate,@mImage)", sqlCon);
                    cmd.CommandType = CommandType.Text;

                  //  cmd.Parameters.AddWithValue("@mID", medIDtxt.Text);
                    cmd.Parameters.AddWithValue("@mName", medNameTxt.Text);
                    cmd.Parameters.AddWithValue("@mPrice", medPriceTxt.Text);
                    cmd.Parameters.AddWithValue("@mCause", takingCauseBox.Text);
                    cmd.Parameters.AddWithValue("@mExpDate", expDate.Value);
                    cmd.Parameters.AddWithValue("@mImage", img);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("New " + medNameTxt.Text + " saved in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRecords();
                    resetAll();
                }
                else
                {
                    MessageBox.Show("Please select an image.", "Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select medicine for update!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValid()
        {
            if (medNameTxt.Text == string.Empty)
            {
                MessageBox.Show("Name is Required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void updateMedBtn_Click(object sender, EventArgs e)
        {
            if (mID > 0)
            {

                if (medPicBox.Image != null)
                {

                    MemoryStream ms = new MemoryStream();
                    medPicBox.Image.Save(ms, medPicBox.Image.RawFormat);
                    byte[] img = ms.ToArray();


                    SqlCommand cmd = new SqlCommand("update medListInfo set mName = @mName,mPrice = @mPrice,mCause = @mCause,mExpDate = @mExpDate,mImage = @mImage where mID = @mID", sqlCon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@mID", mID);
                    cmd.Parameters.AddWithValue("@mName", medNameTxt.Text);
                    cmd.Parameters.AddWithValue("@mPrice", medPriceTxt.Text);
                    cmd.Parameters.AddWithValue("@mCause", takingCauseBox.Text);
                    cmd.Parameters.AddWithValue("@mExpDate", expDate.Value);
                    cmd.Parameters.AddWithValue("@mImage", img);


                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();


                    MessageBox.Show("Information " + medNameTxt.Text + " Updated successfully in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRecords();
                    resetAll();
                }
                else
                {
                    MessageBox.Show("Please select an image.", "Image Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select Medicine for update!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeMedBtn_Click(object sender, EventArgs e)
        {
            if (mID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from medListInfo where mID = @mID", sqlCon);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@mID", mID);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show(medNameTxt.Text + " medicine, " + medNameTxt.Text + " deleted successfully in database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getRecords();
                resetAll();
            }
            else
            {
                MessageBox.Show("Please select medicine for Delete!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }
        private void resetAll()
        {
            medNameTxt.Clear();
            medIDtxt.Clear();
            medPriceTxt.Clear();
            medPicBox.Image = null;
        }
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                medPicBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void medcineListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchID = searchMedTxtBox.Text;
            SqlCommand sCmd = new SqlCommand("select * from medListTable where mID = @mID", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@mID", searchID);
            sqlCon.Open();
            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            medcineListDataGridView.DataSource = dt;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sCmd = new SqlCommand("select * from medRegInfo", sqlCon);
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
