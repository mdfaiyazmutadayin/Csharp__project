using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class AdminRoomsControlForrm : Form
    {
        public AdminRoomsControlForrm()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public int ID;


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

        public string type = "";
        public string avail = "";
        public string searchType = "";
       
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

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                { 
                    int roomId;
                    int roomFloor;
                    if (!int.TryParse(IDTextBox.Text, out roomId) || !int.TryParse(floorTxt.Text, out roomFloor))
                    {
                        MessageBox.Show("Room ID and Floor must be valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert record into roomTable
                    SqlCommand cmd = new SqlCommand("INSERT INTO roomTable (RoomID, RoomType, Rfloor, RoomEmpty) VALUES (@RoomID, @RoomType, @Rfloor, @RoomEmpty)", sqlCon);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@RoomType", cmbType.Text);
                    cmd.Parameters.AddWithValue("@Rfloor", roomFloor);
                    cmd.Parameters.AddWithValue("@RoomEmpty", cmbAv.Text);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("New " + cmbType.Text + " created newly", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRecords();
                    resetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select user for update!!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValid()
        {
            if (IDTextBox.Text == string.Empty)
            {
                MessageBox.Show("Name is Required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDTextBox.Text)) // Check if ID is provided
            {
                try
                {
                    int roomId;
                    if (!int.TryParse(IDTextBox.Text, out roomId)) // Try to parse ID as an integer
                    {
                        MessageBox.Show("Room ID must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Delete record from medRegInfo table
                    SqlCommand cmd = new SqlCommand("DELETE FROM medRegInfo WHERE ID = @ID", sqlCon);
                    cmd.Parameters.AddWithValue("@ID", roomId);

                    sqlCon.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    sqlCon.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room with ID " + roomId + " deleted successfully from the database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRecords();
                        resetAll();
                    }
                    else
                    {
                        MessageBox.Show("Room with ID " + roomId + " not found in the database", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter Room ID for Delete", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getRecords();
            resetAll();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                try
                {
                    int roomId;
                    int roomFloor;
                    if (!int.TryParse(IDTextBox.Text, out roomId) || !int.TryParse(floorTxt.Text, out roomFloor))
                    {
                        MessageBox.Show("Room ID and Floor must be valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE roomTable SET RoomType = @RoomType, Rfloor = @Rfloor, RoomEmpty = @RoomEmpty WHERE RoomID = @RoomID", sqlCon);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@RoomType", cmbType.Text);
                    cmd.Parameters.AddWithValue("@Rfloor", roomFloor);
                    cmd.Parameters.AddWithValue("@RoomEmpty", cmbAv.Text);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Information for " + cmbType.Text + " updated successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRecords();
                    resetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a room for update!", "Select Please!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }
        private void resetAll()
        {
            IDTextBox.Clear();
            cmbType.ResetText();
            cmbAv.ResetText();
            cmbSearch.ResetText();
            floorTxt.Clear();
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            IDTextBox.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            cmbType.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            floorTxt.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            cmbAv.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void AdminRoomsControlForrm_Load(object sender, EventArgs e)
        {
            getRecords();
            resetAll();
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
    }
}
