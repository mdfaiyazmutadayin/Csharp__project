namespace AutoDoc
{
    partial class DoctorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.personalProfileBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSidebar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menubarTransition = new System.Windows.Forms.Timer(this.components);
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuButtonClick = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.msgBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.medicineListCheckBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalProfileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(13)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.personalProfileBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSidebar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 50);
            this.panel1.TabIndex = 4;
            // 
            // personalProfileBox
            // 
            this.personalProfileBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personalProfileBox.BackgroundImage")));
            this.personalProfileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personalProfileBox.Location = new System.Drawing.Point(131, 2);
            this.personalProfileBox.Margin = new System.Windows.Forms.Padding(2);
            this.personalProfileBox.Name = "personalProfileBox";
            this.personalProfileBox.Size = new System.Drawing.Size(51, 47);
            this.personalProfileBox.TabIndex = 5;
            this.personalProfileBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(307, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DoctorsPanel";
            // 
            // btnSidebar
            // 
            this.btnSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSidebar.Image = ((System.Drawing.Image)(resources.GetObject("btnSidebar.Image")));
            this.btnSidebar.Location = new System.Drawing.Point(23, 0);
            this.btnSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(44, 40);
            this.btnSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSidebar.TabIndex = 4;
            this.btnSidebar.TabStop = false;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // menubarTransition
            // 
            this.menubarTransition.Interval = 10;
            this.menubarTransition.Tick += new System.EventHandler(this.menubarTransition_Tick);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 10;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sideBar.Controls.Add(this.panel9);
            this.sideBar.Controls.Add(this.menuContainer);
            this.sideBar.Controls.Add(this.panel8);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 50);
            this.sideBar.Margin = new System.Windows.Forms.Padding(2);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(308, 811);
            this.sideBar.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dashboardBtn);
            this.panel9.Location = new System.Drawing.Point(2, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(190, 50);
            this.panel9.TabIndex = 16;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(-7, -5);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(278, 62);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "                      Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click_1);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Controls.Add(this.panel10);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Location = new System.Drawing.Point(0, 54);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(281, 327);
            this.menuContainer.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuButtonClick);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 66);
            this.panel2.TabIndex = 11;
            // 
            // menuButtonClick
            // 
            this.menuButtonClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menuButtonClick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButtonClick.ForeColor = System.Drawing.Color.White;
            this.menuButtonClick.Image = ((System.Drawing.Image)(resources.GetObject("menuButtonClick.Image")));
            this.menuButtonClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButtonClick.Location = new System.Drawing.Point(-4, -28);
            this.menuButtonClick.Margin = new System.Windows.Forms.Padding(2);
            this.menuButtonClick.Name = "menuButtonClick";
            this.menuButtonClick.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.menuButtonClick.Size = new System.Drawing.Size(320, 126);
            this.menuButtonClick.TabIndex = 9;
            this.menuButtonClick.Text = "                       Menu";
            this.menuButtonClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButtonClick.UseVisualStyleBackColor = false;
            this.menuButtonClick.Click += new System.EventHandler(this.menuButtonClick_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.msgBtn);
            this.panel5.Location = new System.Drawing.Point(2, 72);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 65);
            this.panel5.TabIndex = 12;
            // 
            // msgBtn
            // 
            this.msgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.msgBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBtn.ForeColor = System.Drawing.Color.White;
            this.msgBtn.Image = ((System.Drawing.Image)(resources.GetObject("msgBtn.Image")));
            this.msgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBtn.Location = new System.Drawing.Point(-8, -23);
            this.msgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.Padding = new System.Windows.Forms.Padding(19, 0, 0, 6);
            this.msgBtn.Size = new System.Drawing.Size(279, 112);
            this.msgBtn.TabIndex = 3;
            this.msgBtn.Text = "                      Messages";
            this.msgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBtn.UseVisualStyleBackColor = false;
            this.msgBtn.Click += new System.EventHandler(this.msgBtn_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.appointmentBtn);
            this.panel4.Location = new System.Drawing.Point(2, 141);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 50);
            this.panel4.TabIndex = 12;
            // 
            // appointmentBtn
            // 
            this.appointmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.appointmentBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBtn.ForeColor = System.Drawing.Color.White;
            this.appointmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("appointmentBtn.Image")));
            this.appointmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentBtn.Location = new System.Drawing.Point(-4, -17);
            this.appointmentBtn.Margin = new System.Windows.Forms.Padding(0);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Padding = new System.Windows.Forms.Padding(19, 8, 0, 0);
            this.appointmentBtn.Size = new System.Drawing.Size(275, 76);
            this.appointmentBtn.TabIndex = 6;
            this.appointmentBtn.Text = "                       Appointments";
            this.appointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentBtn.UseVisualStyleBackColor = false;
            this.appointmentBtn.Click += new System.EventHandler(this.appointmentBtn_Click_1);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.medicineListCheckBtn);
            this.panel10.Location = new System.Drawing.Point(2, 195);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(210, 50);
            this.panel10.TabIndex = 13;
            // 
            // medicineListCheckBtn
            // 
            this.medicineListCheckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.medicineListCheckBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineListCheckBtn.ForeColor = System.Drawing.Color.White;
            this.medicineListCheckBtn.Image = ((System.Drawing.Image)(resources.GetObject("medicineListCheckBtn.Image")));
            this.medicineListCheckBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicineListCheckBtn.Location = new System.Drawing.Point(-8, -11);
            this.medicineListCheckBtn.Margin = new System.Windows.Forms.Padding(0);
            this.medicineListCheckBtn.Name = "medicineListCheckBtn";
            this.medicineListCheckBtn.Padding = new System.Windows.Forms.Padding(22, 6, 0, 7);
            this.medicineListCheckBtn.Size = new System.Drawing.Size(279, 76);
            this.medicineListCheckBtn.TabIndex = 9;
            this.medicineListCheckBtn.Text = "                        Medicine List";
            this.medicineListCheckBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicineListCheckBtn.UseVisualStyleBackColor = false;
            this.medicineListCheckBtn.Click += new System.EventHandler(this.medicineListCheckBtn_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reportBtn);
            this.panel6.Location = new System.Drawing.Point(2, 249);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 59);
            this.panel6.TabIndex = 12;
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportBtn.Image")));
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(-4, -10);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 8);
            this.reportBtn.Size = new System.Drawing.Size(275, 81);
            this.reportBtn.TabIndex = 10;
            this.reportBtn.Text = "                       Write Reports";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.logoutBtn);
            this.panel8.Location = new System.Drawing.Point(2, 383);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(210, 50);
            this.panel8.TabIndex = 15;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(-7, -8);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(278, 67);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "                        Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click_1);
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 861);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "DoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalProfileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox personalProfileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSidebar;
        private System.Windows.Forms.Timer menubarTransition;
        private System.Windows.Forms.Timer sideBarTransition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menuButtonClick;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button msgBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button medicineListCheckBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button logoutBtn;
    }
}