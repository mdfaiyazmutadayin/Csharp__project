using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class DoctorAptForm : Form
    {
        public DoctorAptForm()
        {
            InitializeComponent();
            getID();
            getRecords();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public int ID;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


                DateTime dob;
                if (DateTime.TryParseExact(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
                {
                    textBox3.Text = dob.ToString();
                }
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
        }

        public string thisName = SharedData.uName;

        public static int thisID;
        public static int serial;
        private void getID()
        {
            try
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

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string isDone = "";
        private void doneBtn_Click(object sender, EventArgs e)
        {

            try
            {
                isDone = textBox4.Text;


                SqlCommand cmd = new SqlCommand("update apTable set isDone = @isDone where aid = @aid", sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@aid", serial);
                cmd.Parameters.AddWithValue("@isDone", isDone);


                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (isDone == "YES")
                {
                    MessageBox.Show("Appointment Done", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Appointment Not Done", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                getRecords();
                resetAll();
            } catch(Exception ex)
            {  
                MessageBox.Show(ex.Message);
            }
        }

        private void resetAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
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

        private void DoctorAptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
