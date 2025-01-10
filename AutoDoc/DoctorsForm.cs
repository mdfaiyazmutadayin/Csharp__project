using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class DoctorsForm : Form
    {
        public static string name = SharedData.uName;
        public int userID { get; set; }

        DoctorWriteReportForm wRForm;
        DoctorDashboardForm doctorDashboardForm;
        DoctorMedicineListForm medList;
        DoctorMsgForm doctorMsgForm;
        DoctorAptForm aptForm;
        SqlConnection conn = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");

        public DoctorsForm()
        {
            InitializeComponent();

            getID(SharedData.uName);
            label1.Visible = true;
            label1.Text = "Welcome Dr. " + name;
            sideBar.Width = 73;
            menuContainer.Height = 62;
            personalProfileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalProfileBox.BackgroundImageLayout = ImageLayout.Stretch;
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
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void docDash_Closed(object sender, EventArgs e)
        {
            doctorDashboardForm = null;
        }
            
            

        private void doctorReportClosed(object sender, EventArgs e)
        {
            wRForm = null;
        }
       


        // transitions
        bool menuExpand = false;
        private void menubarTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 5;
                if (menuContainer.Height >= 327)
                {
                    menubarTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 5;
                if (menuContainer.Height <= 62)
                {
                    menubarTransition.Stop();
                    menuExpand = false;
                }
            }
        }


        bool sidebarExpand = false;

        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 5;
                if (sideBar.Width <= 73)
                {
                    sidebarExpand = false;
                    sideBarTransition.Stop();

                    panel2.Width = sideBar.Width;
                    panel4.Width = sideBar.Width;
                    panel5.Width = sideBar.Width;
                    panel6.Width = sideBar.Width;
                    panel10.Width = sideBar.Width;
                    panel8.Width = sideBar.Width;
                    panel9.Width = sideBar.Width;
                    menuContainer.Width = sideBar.Width;
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 265)
                {
                    sidebarExpand = true;
                    sideBarTransition.Stop();

                    panel2.Width = sideBar.Width;
                    panel4.Width = sideBar.Width;
                    panel5.Width = sideBar.Width;
                    panel6.Width = sideBar.Width;
                    panel10.Width = sideBar.Width;
                    panel8.Width = sideBar.Width;
                    panel9.Width = sideBar.Width;
                    menuContainer.Width = sideBar.Width;
                }
            }
        }


      
        private void medListClosed(object sender, EventArgs e)
        {
            medList = null;
        }

        private void dashboardBtn_Click_1(object sender, EventArgs e)
        {
            if (doctorDashboardForm == null)
            {
                doctorDashboardForm = new DoctorDashboardForm();
                doctorDashboardForm.FormClosed += docDash_Closed;
                doctorDashboardForm.MdiParent = this;
                doctorDashboardForm.Dock = DockStyle.Fill;
                doctorDashboardForm.Show();
            }
            else
            {
                doctorDashboardForm.Activate();
            }
        }

        private void menuButtonClick_Click_1(object sender, EventArgs e)
        {
            menubarTransition.Start();
        }



            private void msgBtn_Click_1(object sender, EventArgs e)
        {

                if (doctorMsgForm == null)
                {
                    doctorMsgForm = new DoctorMsgForm();
                    doctorMsgForm.FormClosed += docMsgForm_Closed;
                    doctorMsgForm.MdiParent = this;
                    doctorMsgForm.Dock = DockStyle.Fill;
                    doctorMsgForm.Show();
                }
                else
                {
                    doctorMsgForm.Activate();
                }
        }
            private void docMsgForm_Closed(object sender, EventArgs e)
            {
                doctorMsgForm = null;
            }

            private void appointmentBtn_Click_1(object sender, EventArgs e)
        {
            if (aptForm == null)
            {
                aptForm = new DoctorAptForm();
                aptForm.FormClosed += doctorAppointmentFormClosed;
                aptForm.MdiParent = this;
                aptForm.Dock = DockStyle.Fill;
                aptForm.Show();
            }
            else
            {
                aptForm.Activate();
            }
        }
        private void doctorAppointmentFormClosed(object sender, EventArgs e)
        {
            aptForm = null;
        }

        private void medicineListCheckBtn_Click_1(object sender, EventArgs e)
        {

            if (medList == null)
            {
                medList = new DoctorMedicineListForm();
                medList.FormClosed += medListClosed;
                medList.MdiParent = this;
                medList.Dock = DockStyle.Fill;
                medList.Show();
            }
            else
            {
                medList.Activate();
            }
        }

        private void reportBtn_Click_1(object sender, EventArgs e)
        {
            if (wRForm == null)
            {
                wRForm = new DoctorWriteReportForm();
                wRForm.FormClosed += doctorReportClosed;
                wRForm.MdiParent = this;
                wRForm.Dock = DockStyle.Fill;
                wRForm.Show();
            }
            else
            {
                wRForm.Activate();
            }
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            SharedData.uName = null;
            personalProfileBox.Image = null;
            var nf = new LoginForm();
            nf.Show();
            this.Close();
        }
        private void btnSidebar_Click1(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
