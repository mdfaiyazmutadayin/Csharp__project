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
    public partial class PatientMedicineShop : Form
    {
        public PatientMedicineShop()
        {
            InitializeComponent();
        }
        public int mID;
        public string thisName = SharedData.uName;
        public static int thisID = 0;
        public static int mPrice = 0;
        public static int thisBalance = 0;

        private void PatientMedicineShop_Load(object sender, EventArgs e)
        {
            getRecords();
            getID();
            FILLDGV();
        }


        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");


        
        private void getID()
        {

            sqlCon.Open();
            string sqlQuery = "SELECT * FROM medListInfo WHERE mName = @mName";
            SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
            command.Parameters.AddWithValue("@mName", thisName);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                thisID = reader.GetInt32(0);
            }
            sqlCon.Close();
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
            medPicBox.Image = null;
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
        private void medcineListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mID = Convert.ToInt32(medcineListDataGridView.SelectedRows[0].Cells[0].Value);

            medIDtxt.Text = medcineListDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            medNameTxt.Text = medcineListDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            medPriceTxt.Text = medcineListDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            mPrice = Convert.ToInt32(medPriceTxt.Text);
            takingCauseBox.Text = medcineListDataGridView.SelectedRows[0].Cells[3].Value.ToString();

            DateTime dob;
            if (DateTime.TryParseExact(medcineListDataGridView.SelectedRows[0].Cells[4].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
            {
                expDateBox.Text = dob.ToString();
            }

            Byte[] img = (Byte[])medcineListDataGridView.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            medPicBox.Image = Image.FromStream(ms);
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

        private void buyMedBtn_Click(object sender, EventArgs e)
        {

            int mPrice = 0;/* get the price of the medicine */

            sqlCon.Open();


            SqlCommand cmd = new SqlCommand("SELECT Balance FROM medRegInfo WHERE ID = @ID", sqlCon);
            cmd.Parameters.AddWithValue("@ID", thisID);
            SqlDataReader reader = cmd.ExecuteReader();

            
            if (reader.Read())
            {
                
                int thisBalance = reader.GetInt32(8);
                sqlCon.Close(); 
                if (mPrice <= thisBalance)
                {
                    // new balance
                    int newBalance = thisBalance - mPrice;

                    // Update balance
                    SqlCommand updateCmd = new SqlCommand("UPDATE medRegInfo SET Balance = @NewBalance WHERE ID = @ID", sqlCon);
                    updateCmd.Parameters.AddWithValue("@NewBalance", newBalance);
                    updateCmd.Parameters.AddWithValue("@ID", thisID);

                    sqlCon.Open();
                    updateCmd.ExecuteNonQuery(); 
                    sqlCon.Close(); 

                    MessageBox.Show("Medicine Purchased successfully!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not enough Balance!", "Money Shortage!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                sqlCon.Close(); // Close connection if no balance is found
                MessageBox.Show("No balance found for this ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
