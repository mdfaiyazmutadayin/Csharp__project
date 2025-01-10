using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class AdminHealthKitsForm : Form
    {
        private int mID;

        public AdminHealthKitsForm()
        {
            InitializeComponent();
            medPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            medPicBox.BackgroundImageLayout = ImageLayout.Stretch;

        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        private void AdminHealthKitsForm_Load(object sender, EventArgs e)
        {
            getRecords();
        }


        public void FILLDGV()
        {

            SqlCommand cmd = new SqlCommand("select * from healthKitTableTable", sqlCon);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            medcineListDataGridView.DataSource = dt;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)medcineListDataGridView.Columns[3];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                medPicBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchID = searchMedTxtBox.Text;
            SqlCommand sCmd = new SqlCommand("select * from healthKitListTable where kID = @kID", sqlCon);
            DataTable dt = new DataTable();
            sCmd.CommandType = CommandType.Text;
            sCmd.Parameters.AddWithValue("@kID", searchID);
            sqlCon.Open();
            SqlDataReader sr = sCmd.ExecuteReader();
            dt.Load(sr);
            sqlCon.Close();

            medcineListDataGridView.DataSource = dt;
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

                    SqlCommand cmd = new SqlCommand("insert into healthKitListTable values (@kName,@kPrice,@kImage)", sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@kName", medNameTxt.Text);
                    cmd.Parameters.AddWithValue("@kPrice", medPriceTxt.Text);
                    cmd.Parameters.AddWithValue("@kImage", img);

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
            getRecords();
        }

        private void getRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM healthKitListTable", sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            sqlCon.Close();
            medcineListDataGridView.DataSource = dt;
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


                    SqlCommand cmd = new SqlCommand("update healthKitListTable set kName = @kName,kPrice = @kPrice,kImage = @kImage where kID = @kID", sqlCon);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@kID", mID);
                    cmd.Parameters.AddWithValue("@kName", medNameTxt.Text);
                    cmd.Parameters.AddWithValue("@kPrice", medPriceTxt.Text);
                    cmd.Parameters.AddWithValue("@kImage", img);


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
                MessageBox.Show("Please select kit for update!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getRecords();
        }

        private void resetAll()
        {
            medNameTxt.Clear();
            medPriceTxt.Clear();
            searchMedTxtBox.Clear();
            medPicBox.Image = null;
        }

        private void removeMedBtn_Click(object sender, EventArgs e)
        {
            if (mID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from healthKitListTable where kID = @kID", sqlCon);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@kID", mID);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show(medNameTxt.Text + " Kit, " + medNameTxt.Text + " deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getRecords();
                resetAll();
            }
            else
            {
                MessageBox.Show("Please select kit for Delete!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void medcineListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mID = Convert.ToInt32(medcineListDataGridView.SelectedRows[0].Cells[0].Value);
            medNameTxt.Text = medcineListDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            medPriceTxt.Text = medcineListDataGridView.SelectedRows[0].Cells[2].Value.ToString();


            Byte[] img = (Byte[])medcineListDataGridView.CurrentRow.Cells[3].Value;
            MemoryStream ms = new MemoryStream(img);
            medPicBox.Image = Image.FromStream(ms);
        }
    }
}
