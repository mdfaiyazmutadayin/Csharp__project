using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class StaffsForm : Form
    {
        StaffsDashBoard staffsDashBoard;
        StaffPatientReportTime StaffPatientReportTime;
        termsConditionsForm tc;
        StaffsMedKitsForm staffsMedKitsForm;
        StaffsMsg staffsMsg;
        StaffMedicineList staffsMedicineList;
      
        SqlConnection conn = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        public static string thisName = SharedData.uName;
        public static int thisID = 0;
        public StaffsForm()
        {
            InitializeComponent();
            getID(SharedData.uName);
            label2.Text = "";
            sideBar.Width = 90;
            staffMenuContainer.Height = 58;
            InventoryflowLayoutPanel.Height = 65;
            personalProfileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalProfileBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            bool menuBarEx = false;
            private void menuTransition_Tick(object sender, EventArgs e)
            {

                if (menuBarEx == false)
                {
                    staffMenuContainer.Height += 5;
                    if (staffMenuContainer.Height >= 435)
                    {
                        menuBarEx = true;
                        menuTransition.Stop();
                    }
                }
                else
                {
                    staffMenuContainer.Height -= 5;
                    if (staffMenuContainer.Height <= 60)
                    {
                        menuTransition.Stop();
                        menuBarEx = false;
                    }
                }
            }




            private void StaffsForm_Load(object sender, EventArgs e)
            {

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
                    }
                    else
                    {
                        label1.Text = null;
                        personalProfileBox.Image = null;
                    }
                }
                conn.Close();
            }

            bool sidebarExpand = false;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 5;
                if (sideBar.Width <= 90)
                {
                    sidebarExpand = false;
                    sideBarTransition.Stop();
                    panel2.Width = sideBar.Width;
                    panel3.Width = sideBar.Width;
                    panel5.Width = sideBar.Width;
                    panel6.Width = sideBar.Width;
                    panel7.Width = sideBar.Width;
                    panel8.Width = sideBar.Width;
                    panel9.Width = sideBar.Width;
                    panel10.Width = sideBar.Width;

                    panel12.Width = sideBar.Width;
                    staffMenuContainer.Width = sideBar.Width;
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 250)
                {
                    sidebarExpand = true;
                    sideBarTransition.Stop();

                    panel2.Width = sideBar.Width;
                    panel3.Width = sideBar.Width;
                    panel5.Width = sideBar.Width;
                    panel6.Width = sideBar.Width;
                    panel7.Width = sideBar.Width;
                    panel8.Width = sideBar.Width;
                    panel9.Width = sideBar.Width;
                    panel10.Width = sideBar.Width;

                    panel12.Width = sideBar.Width;
                    staffMenuContainer.Width = sideBar.Width;
                }
            }
        }

            bool inventoryExpand = false;
            private void inventoryTransition_Tick(object sender, EventArgs e)
            {
                if (inventoryExpand == false)
                {
                    InventoryflowLayoutPanel.Height += 5;
                    if (InventoryflowLayoutPanel.Height >= 185)
                    {
                        inventoryExpand = true;
                        inventoryTransition.Stop();
                    }
                }
                else
                {
                    InventoryflowLayoutPanel.Height -= 5;
                    if (InventoryflowLayoutPanel.Height <= 65)
                    {
                        inventoryExpand = false;
                        inventoryTransition.Stop();
                    }
                }
            }

            private void dashboardBtn_Click_1(object sender, EventArgs e)
            {


            if (staffsDashBoard == null)
            {
                staffsDashBoard = new StaffsDashBoard();
                staffsDashBoard.FormClosed += sDashBoard_Closed;
                staffsDashBoard.MdiParent = this;
                staffsDashBoard.Dock = DockStyle.Fill;
                staffsDashBoard.Show();
            }
            else
            {
                staffsDashBoard.Activate();
            }
        }
        private void sDashBoard_Closed(object sender, EventArgs e)
        {
            staffsDashBoard = null;
        }

        private void menuButtonClick_Click_1(object sender, EventArgs e)
            {
                menuTransition.Start();
            }

            private void inventoryListBtn_Click_1(object sender, EventArgs e)
            {
                inventoryTransition.Start();
            }

            private void MedicineList_Click_1(object sender, EventArgs e)
            {

            if (staffsMedicineList == null)
            {
                staffsMedicineList = new StaffMedicineList();
                staffsMedicineList.FormClosed += patientMsgForm_Closed;
                staffsMedicineList.MdiParent = this;
                staffsMedicineList.Dock = DockStyle.Fill;
                staffsMedicineList.Show();
            }
            else
            {
                staffsMedicineList.Activate();
            }
        }
        private void patientMsgForm_Closed(object sender, EventArgs e)
        {
            staffsMedicineList = null;
        }

        private void healthKitsCheck_Click_1(object sender, EventArgs e)
            {

            if (staffsMedKitsForm == null)
            {
                staffsMedKitsForm = new StaffsMedKitsForm();
                staffsMedKitsForm.FormClosed += medkitClosed;
                staffsMedKitsForm.MdiParent = this;
                staffsMedKitsForm.Dock = DockStyle.Fill;
                staffsMedKitsForm.Show();
            }
            else
            {
                staffsMedKitsForm.Activate();
            }
        }
        private void medkitClosed(object sender, EventArgs e)
        {
            staffsMedKitsForm = null;
        }

        private void msgBtn_Click_1(object sender, EventArgs e)
            {

                if (staffsMsg == null)
                {
                    staffsMsg = new StaffsMsg();
                    staffsMsg.FormClosed += StaffPatient_Closed;
                    staffsMsg.MdiParent = this;
                    staffsMsg.Dock = DockStyle.Fill;
                    staffsMsg.Show();
                }
                else
                {
                    staffsMsg.Activate();
                }
            }
            private void StaffPatient_Closed(object sender, EventArgs e)
            {
                staffsMsg = null;

            }

            private void pReportTimeBtn_Click_1(object sender, EventArgs e)
            {

            if (StaffPatientReportTime == null)
            {
                StaffPatientReportTime = new StaffPatientReportTime();
                StaffPatientReportTime.FormClosed += sReport_Closed;
                StaffPatientReportTime.MdiParent = this;
                StaffPatientReportTime.Dock = DockStyle.Fill;
                StaffPatientReportTime.Show();
            }
            else
            {
                StaffPatientReportTime.Activate();
            }
        }
        private void sReport_Closed(object sender, EventArgs e)
        {
            StaffPatientReportTime = null;
        }

        private void tcBtn_Click_1(object sender, EventArgs e)
        {

            if (tc == null)
            {
                tc = new termsConditionsForm();
                tc.FormClosed += tcClosed;
                tc.MdiParent = this;
                tc.Dock = DockStyle.Fill;
                tc.Show();
            }
            else
            {
                tc.Activate();
            }
        }
        private void tcClosed(object sender, EventArgs e)
        {
            tc = null;
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            var nf = new LoginForm();
            nf.Show();
            this.Close();
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }
    }
}
