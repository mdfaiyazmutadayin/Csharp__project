using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AutoDoc
{

    public partial class AdminMainForm : Form
    {
        public static string name = SharedData.uName;
        public static int thisID;
        AdminDashBoard adminDashBoard;
        AdminControlForm adminControlForm;
        AdminMsgForm msgCheck;
        AdminHealthKitsForm adminHealthKitsForm;
        AdminMedicineForm adminMedicineForm;
        AdminPatientReports adminPatientReports;
        AdminRoomsControlForrm roomsControl;
        SqlConnection conn = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");

        public AdminMainForm()
        {
            InitializeComponent();




            adminMenubar.Height = 63;
            adminSideBar.Width = 75;
            InventoryflowLayoutPanel.Height = 68;
            ScheduleflowLayoutPanel.Height = 72;

            label1.Text = "Welcome " + Name;
            label1.Visible = true;

            personalProfileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalProfileBox.BackgroundImageLayout = ImageLayout.Stretch;
            getID(SharedData.uName);
        }

        bool adminMenuExpand = false;

        private void adminMenubarTransition_Tick(object sender, EventArgs e)
        {
            if (adminMenuExpand == false)
            {
                adminMenubar.Height += 5;
                if (adminMenubar.Height >= 570)
                {
                    adminMenuExpand = true;
                    adminMenubarTransition.Stop();
                }
            }
            else
            {
                adminMenubar.Height -= 5;
                if (adminMenubar.Height <= 63)
                {
                    adminMenuExpand = false;
                    adminMenubarTransition.Stop();
                }
            }
        }
        private void adminMenuBtn_Click(object sender, EventArgs e)
        {
            adminMenubarTransition.Start();
        }
        private void getID(string uName)
        {
            conn.Open();
            string sqlQuery = "SELECT * FROM medRegInfo WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            cmd.Parameters.AddWithValue("@Name", uName);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label1.Text = reader.GetString(1);
                byte[] imageData = reader["Picture"] as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        personalProfileBox.Image = Image.FromStream(ms);
                    }
                } else
                {
                    label1.Text = null;
                    personalProfileBox.Image = null;
                }
            }
            conn.Close();
        }


        bool adminSidebarExpand = false;
        private void adminSidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (adminSidebarExpand)
            {
                adminSideBar.Width -= 5;
                if (adminSideBar.Width <= 75)
                {
                    adminSidebarExpand = false;
                    adminSidebarTransition.Stop();
                    // 3,16,17,5,7,11,12,13,14,4,10,8
                    panel2.Width = adminSideBar.Width;
                    panel3.Width = adminSideBar.Width;
                    panel5.Width = adminSideBar.Width;
                    panel7.Width = adminSideBar.Width;
                    panel8.Width = adminSideBar.Width;
                    panel9.Width = adminSideBar.Width;
                    panel10.Width = adminSideBar.Width;
                    panel11.Width = adminSideBar.Width;
                    panel12.Width = adminSideBar.Width;
    
                    panel16.Width = adminSideBar.Width;
                    panel17.Width = adminSideBar.Width;
                    adminMenubar.Width = adminSideBar.Width;
                }
            }
            else
            {
                adminSideBar.Width += 5;
                if (adminSideBar.Width >= 215)
                {
                    adminSidebarExpand = true;
                    adminSidebarTransition.Stop();

                    panel2.Width = adminSideBar.Width;
                    panel3.Width = adminSideBar.Width;
                    panel5.Width = adminSideBar.Width;
                    panel7.Width = adminSideBar.Width;
                    panel8.Width = adminSideBar.Width;
                    panel9.Width = adminSideBar.Width;
                    panel10.Width = adminSideBar.Width;
                    panel11.Width = adminSideBar.Width;
                    panel12.Width = adminSideBar.Width;
             
                    panel16.Width = adminSideBar.Width;
                    panel17.Width = adminSideBar.Width;
                    adminMenubar.Width = adminSideBar.Width;
                }
            }
        }
        private void adminBtnSidebar_Click(object sender, EventArgs e)
        {
            adminSidebarTransition.Start();
        }


        private void editUserBtn_Click(object sender, EventArgs e)
        {

            if (adminControlForm == null)
            {
                adminControlForm = new AdminControlForm();
                adminControlForm.FormClosed += EditUserFormClosed;
                adminControlForm.MdiParent = this;
                adminControlForm.Dock = DockStyle.Fill;
                adminControlForm.Show();
            }
            else
            {
                adminControlForm.Activate();
            }

        }

        private void EditUserFormClosed(object sender, EventArgs e)
        {
            adminControlForm = null;
        }




        private void adminMsgBtn_Click(object sender, EventArgs e)
        {
            if (msgCheck == null)
            {
                msgCheck = new AdminMsgForm();

                msgCheck.FormClosed += adminMsgCheckClosed;
                msgCheck.MdiParent = this;
                msgCheck.Dock = DockStyle.Fill;
                msgCheck.Show();
            }
            else
            {
                msgCheck.Activate();
            }
        }

        private void adminMsgCheckClosed(object sender, EventArgs e)
        {
            msgCheck = null;
        }


        private void roomBtn_Click(object sender, EventArgs e)
        {
            if (roomsControl == null)
            {
                roomsControl = new AdminRoomsControlForrm();
                roomsControl.FormClosed += adminRoomControlClosed;
                roomsControl.MdiParent = this;
                roomsControl.Dock = DockStyle.Fill;
                roomsControl.Show();
            }
            else
            {
                roomsControl.Activate();
            }
        }
        private void adminRoomControlClosed(object sender, EventArgs e)
        {
            roomsControl = null;
        }

        private void adminDashboardBtn_Click(object sender, EventArgs e)
        {

            if (adminDashBoard == null)
            {
                adminDashBoard = new AdminDashBoard();
                adminDashBoard.FormClosed += adminDashboardClosed;
                adminDashBoard.MdiParent = this;
                adminDashBoard.Dock = DockStyle.Fill;
                adminDashBoard.Show();
            }
            else
            {
                adminDashBoard.Activate();
            }
        }
        private void adminDashboardClosed(object sender, EventArgs e)
        {
            adminDashBoard = null;
        }

        private void AdminLogoutBtn_Click(object sender, EventArgs e)
        {
            SharedData.uName = null;
            personalProfileBox.Image = null;
            var af = new LoginForm();
            af.Show();
            this.Close();
        }

        private void MedicineBtn_Click(object sender, EventArgs e)
        {
            if (adminMedicineForm == null)
            {
                adminMedicineForm = new AdminMedicineForm();
                adminMedicineForm.FormClosed += adminMedicineFormClosed;
                adminMedicineForm.MdiParent = this;
                adminMedicineForm.Dock = DockStyle.Fill;
                adminMedicineForm.Show();
            }
            else
            {
                adminMedicineForm.Activate();
            }
        }
        private void adminMedicineFormClosed(object sender, EventArgs e)
        {
            adminMedicineForm = null;
        }

        private void healthkitsBtn_Click(object sender, EventArgs e)
        {

            if (adminHealthKitsForm == null)
            {
                adminHealthKitsForm = new AdminHealthKitsForm();
                adminHealthKitsForm.FormClosed += adminHealthKitsClosed;
                adminHealthKitsForm.MdiParent = this;
                adminHealthKitsForm.Dock = DockStyle.Fill;
                adminHealthKitsForm.Show();
            }
            else
            {
                adminHealthKitsForm.Activate();
            }
        }
        private void adminHealthKitsClosed(object sender, EventArgs e)
        {
            adminHealthKitsForm = null;
        }

        bool invMenu = false;
        private void inventoryTransition_Tick(object sender, EventArgs e)
        {

            if (invMenu == false)
            {
                InventoryflowLayoutPanel.Height += 5;
                if (InventoryflowLayoutPanel.Height >= 200)
                {
                    inventoryTransition.Stop();
                    invMenu = true;
                }
            }
            else
            {
                InventoryflowLayoutPanel.Height -= 5;
                if (InventoryflowLayoutPanel.Height <= 68)
                {
                    inventoryTransition.Stop();
                    invMenu = false;
                }
            }
        }
        private void ManageInventoryBtn_Click(object sender, EventArgs e)
        {
            inventoryTransition.Start();
        }

        bool scheduleEx = false;
        private void scheduleTransition_Tick(object sender, EventArgs e)
        {
            if (scheduleEx == false)
            {
                ScheduleflowLayoutPanel.Height += 5;
                if (ScheduleflowLayoutPanel.Height >= 140)
                {
                    scheduleTransition.Stop();
                    scheduleEx = true;
                }
            }
            else
            {
                ScheduleflowLayoutPanel.Height -= 5;
                if (ScheduleflowLayoutPanel.Height <= 70)
                {
                    scheduleTransition.Stop();
                    scheduleEx = false;
                }
            }
        }


        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            // transition

            scheduleTransition.Start();

        }



        private void ReportsBtn_Click(object sender, EventArgs e)
        {

            if (adminPatientReports == null)
            {
                adminPatientReports = new AdminPatientReports();
                adminPatientReports.FormClosed += adminPatientReportClosed;
                adminPatientReports.MdiParent = this;
                adminPatientReports.Dock = DockStyle.Fill;
                adminPatientReports.Show();
            }
            else
            {
                adminPatientReports.Activate();
            }
        }
        private void adminPatientReportClosed(object sender, EventArgs e)
        {
            adminPatientReports = null;
        }



        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
