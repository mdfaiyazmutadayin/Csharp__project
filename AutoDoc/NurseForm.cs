using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class NurseForm : Form
    {
        NurseDashBoard ndashBoard;
        termsConditionsForm tc;
        NurseMsgForm nurseMsg;
        NurseCheckMedForm nurseMedicineListForm;
        NurseVisitRoomForm nurseVisitRoomForm;

        public static string name = SharedData.uName;
        public NurseForm()
        {
            InitializeComponent();

            getID(SharedData.uName);
            menuContainer.Height = 60;
            sideBar.Width = 75;
            label2.Text = "Welcome " + name;
            personalProfileBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personalProfileBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=TISHAD\SQLEXPRESS02;Initial Catalog=HospitalManagement_DB;Integrated Security=True;Encrypt=False");
        private void Form8_Load(object sender, EventArgs e)
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

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

            if (ndashBoard == null)
            {
                ndashBoard = new NurseDashBoard();
                ndashBoard.FormClosed += sDashBoard_Closed;
                ndashBoard.MdiParent = this;
                ndashBoard.Dock = DockStyle.Fill;
                ndashBoard.Show();
            }
            else
            {
                ndashBoard.Activate();
            }
        }
        private void sDashBoard_Closed(object sender, EventArgs e)
        {
            ndashBoard = null;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            menuBarTransition.Start();
        }

        private void msgBtn_Click(object sender, EventArgs e)
        {

            if (nurseMsg == null)
            {
                nurseMsg = new NurseMsgForm();
                nurseMsg.FormClosed += nurseMsgClosed;
                nurseMsg.MdiParent = this;
                nurseMsg.Dock = DockStyle.Fill;
                nurseMsg.Show();
            }
            else
            {
                nurseMsg.Activate();
            }
        }
        private void nurseMsgClosed(object sender, EventArgs e)
        {
            ndashBoard = null;
        }

        private void visitRoomBtn_Click(object sender, EventArgs e)
        {

            if (nurseVisitRoomForm == null)
            {
                nurseVisitRoomForm = new NurseVisitRoomForm();
                nurseVisitRoomForm.FormClosed += vRoomClosed;
                nurseVisitRoomForm.MdiParent = this;
                nurseVisitRoomForm.Dock = DockStyle.Fill;
                nurseVisitRoomForm.Show();
            }
            else
            {
                nurseVisitRoomForm.Activate();
            }
        }
        private void vRoomClosed(object sender, EventArgs e)
        {
            ndashBoard = null;
        }

        private void medCheckBtn_Click(object sender, EventArgs e)
        {
        if (nurseMedicineListForm == null)
            {
                nurseMedicineListForm = new NurseCheckMedForm();
                nurseMedicineListForm.FormClosed += medListClosed;
                nurseMedicineListForm.MdiParent = this;
                nurseMedicineListForm.Dock = DockStyle.Fill;
                nurseMedicineListForm.Show();
            }
            else
            {
                nurseMedicineListForm.Activate();
            }
        }
        private void medListClosed(object sender, EventArgs e)
        {
            nurseMedicineListForm = null;
        }

        private void tcBtn_Click(object sender, EventArgs e)
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            SharedData.uName = null;
            personalProfileBox.Image = null;
            // LogOut
            var newForm = new LoginForm();
            newForm.Show();
            this.Close();
        }

        bool menuExpand = false;
        private void menuBarTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 5;
                if (menuContainer.Height >= 320)
                {
                    menuBarTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 5;
                if (menuContainer.Height <= 85)
                {
                    menuBarTransition.Stop();
                    menuExpand = false;
                }
            }
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

                    panel9.Width = sideBar.Width;
                    panel11.Width = sideBar.Width;
                    panel13.Width = sideBar.Width;
                    panel14.Width = sideBar.Width;
                    panel15.Width = sideBar.Width;
                    panel17.Width = sideBar.Width;
                    panel18.Width = sideBar.Width;
                    menuContainer.Width = sideBar.Width;
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 240)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    panel9.Width = sideBar.Width;
                    panel11.Width = sideBar.Width;
                    panel13.Width = sideBar.Width;
                    panel14.Width = sideBar.Width;
                    panel15.Width = sideBar.Width;
                    panel17.Width = sideBar.Width;
                    panel18.Width = sideBar.Width;
                    menuContainer.Width = sideBar.Width;
                }
            }
        }
        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
