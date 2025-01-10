using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class PatientForm : Form
    {
        public static string uN = SharedData.uName;
        public PatientForm()
        {
            InitializeComponent();

            getID(SharedData.uName);
            menuContainer.Height = 60;
            sideBar.Width = 75;

            label1.Text = "Welcome "+uN;
            label1.Visible =true;

            personalProfileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalProfileBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        

        PatientDashBoardForm dashboard;
        PatientAppointmentForm Appointment;
        PatientHistoryForm history;
        termsConditionsForm tc;
        PatientMsgForm messages;
        PatientMedicineShop patientMedicineShop;

        
        SqlConnection conn = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainer.Height += 5;
                if(menuContainer.Height >= 380)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            } else
            {
                menuContainer.Height -= 5;
                if(menuContainer.Height <= 60)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void menuButtonClick_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 5;
                if (sideBar.Width <= 75)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    panel2.Width = sideBar.Width;
                    panel4.Width = sideBar.Width;
                    panel5.Width = sideBar.Width;
                    panel6.Width = sideBar.Width;
                    panel7.Width = sideBar.Width;
                    panel8.Width = sideBar.Width;
                    panel9.Width = sideBar.Width;
                    menuContainer.Width = sideBar.Width;
                }
            }
            else {
                sideBar.Width += 5;
                if (sideBar.Width >= 211)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    panel2.Width = sideBar.Width;
                    panel4.Width = sideBar.Width;
                    panel5.Width = sideBar.Width;
                    panel6.Width = sideBar.Width;
                    panel7.Width = sideBar.Width;
                    panel8.Width = sideBar.Width;
                    panel9.Width = sideBar.Width;
                    menuContainer.Width = sideBar.Width;
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        


        private void Form2_Load(object sender, EventArgs e)
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

        private void PatientDetailsForm_Closed(Object sender, EventArgs e)
        {
            tc = null;
        }

        private void AppointmentForm_Closed(object sender, EventArgs e)
        {
            Appointment = null;
        }

        private void patientMsgForm_Closed(object sender, EventArgs e)
        {
            messages = null;
        }

     
        
        private void patientHistoryForm_Closed(Object sender, EventArgs e)
        {
            history = null;
        }
        
        private void PatientMedicineBuyForm_Closed(Object sender, EventArgs e)
        {
            history = null;
        }

        private void medicineBuyBtn_Click_1(object sender, EventArgs e)
        {
            if (patientMedicineShop == null)
            {
                patientMedicineShop = new PatientMedicineShop();
                patientMedicineShop.FormClosed += PatientMedicineBuyForm_Closed;
                patientMedicineShop.MdiParent = this;
                patientMedicineShop.Dock = DockStyle.Fill;
                patientMedicineShop.Show();
            }
            else
            {
                patientMedicineShop.Activate();
            }
        }

        private void menuButtonClick_Click_1(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new PatientDashBoardForm();
                dashboard.FormClosed += DashBoardForm_Closed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void DashBoardForm_Closed(object sender, EventArgs e)
        {
            dashboard = null;
        }

  

        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            if (Appointment == null)
            {
                Appointment = new PatientAppointmentForm();
                Appointment.FormClosed += PatientDetailsForm_Closed;
                Appointment.MdiParent = this;
                Appointment.Dock = DockStyle.Fill;
                Appointment.Show();
            }
            else
            {
                Appointment.Activate();
            }
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            if (history == null)
            {
                history = new PatientHistoryForm();
                history.FormClosed += patientHistoryForm_Closed;
                history.MdiParent = this;
                history.Dock = DockStyle.Fill;
                history.Show();
            }
            else
            {
                history.Activate();
            }
        }

        private void tcBtn_Click(object sender, EventArgs e)
        {
            if (tc == null)
            {
                tc = new termsConditionsForm();
                tc.FormClosed += PatientDetailsForm_Closed;
                tc.MdiParent = this;
                tc.Dock = DockStyle.Fill;
                tc.Show();

            }
            else
            {
                tc.Activate();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SharedData.uName = null;
            personalProfileBox.Image = null;
            // LogOut
            var newForm = new LoginForm();
            newForm.Show();
            this.Close();
        }

        private void msgBtn_Click_1(object sender, EventArgs e)
        {
            if (messages == null)
            {
                messages = new PatientMsgForm();
                messages.FormClosed += patientMsgForm_Closed;
                messages.MdiParent = this;
                messages.Dock = DockStyle.Fill;
                messages.Show();
            }
            else
            {
                messages.Activate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
