namespace AutoDoc
{
    partial class NurseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.personalProfileBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSidebar = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.visitRoomBtn = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.msgBtn = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.medCheckBtn = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tcBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalProfileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).BeginInit();
            this.panel18.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel9.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(13)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.personalProfileBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSidebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1620, 77);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(279, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "NursePanel";
            // 
            // personalProfileBox
            // 
            this.personalProfileBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personalProfileBox.BackgroundImage")));
            this.personalProfileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personalProfileBox.Location = new System.Drawing.Point(158, 5);
            this.personalProfileBox.Name = "personalProfileBox";
            this.personalProfileBox.Size = new System.Drawing.Size(76, 72);
            this.personalProfileBox.TabIndex = 5;
            this.personalProfileBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(958, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "NursePanel";
            // 
            // btnSidebar
            // 
            this.btnSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSidebar.Image = ((System.Drawing.Image)(resources.GetObject("btnSidebar.Image")));
            this.btnSidebar.Location = new System.Drawing.Point(16, 8);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(66, 58);
            this.btnSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSidebar.TabIndex = 4;
            this.btnSidebar.TabStop = false;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.logoutBtn);
            this.panel18.Location = new System.Drawing.Point(3, 595);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(346, 94);
            this.panel18.TabIndex = 15;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(-30, -12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(396, 120);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "                        Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menuContainer.Controls.Add(this.panel11);
            this.menuContainer.Controls.Add(this.panel13);
            this.menuContainer.Controls.Add(this.panel14);
            this.menuContainer.Controls.Add(this.panel15);
            this.menuContainer.Controls.Add(this.panel17);
            this.menuContainer.Location = new System.Drawing.Point(0, 100);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(422, 492);
            this.menuContainer.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.menuBtn);
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(346, 94);
            this.panel11.TabIndex = 11;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Location = new System.Drawing.Point(-16, -23);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.menuBtn.Size = new System.Drawing.Size(396, 142);
            this.menuBtn.TabIndex = 9;
            this.menuBtn.Text = "                       Menu";
            this.menuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.visitRoomBtn);
            this.panel13.Location = new System.Drawing.Point(3, 103);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(346, 94);
            this.panel13.TabIndex = 12;
            // 
            // visitRoomBtn
            // 
            this.visitRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.visitRoomBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitRoomBtn.ForeColor = System.Drawing.Color.White;
            this.visitRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("visitRoomBtn.Image")));
            this.visitRoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitRoomBtn.Location = new System.Drawing.Point(-16, -28);
            this.visitRoomBtn.Margin = new System.Windows.Forms.Padding(0);
            this.visitRoomBtn.Name = "visitRoomBtn";
            this.visitRoomBtn.Padding = new System.Windows.Forms.Padding(38, 12, 0, 0);
            this.visitRoomBtn.Size = new System.Drawing.Size(396, 142);
            this.visitRoomBtn.TabIndex = 6;
            this.visitRoomBtn.Text = "                      Visit Room";
            this.visitRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitRoomBtn.UseVisualStyleBackColor = false;
            this.visitRoomBtn.Click += new System.EventHandler(this.visitRoomBtn_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.msgBtn);
            this.panel14.Location = new System.Drawing.Point(3, 203);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(346, 94);
            this.panel14.TabIndex = 12;
            // 
            // msgBtn
            // 
            this.msgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.msgBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBtn.ForeColor = System.Drawing.Color.White;
            this.msgBtn.Image = ((System.Drawing.Image)(resources.GetObject("msgBtn.Image")));
            this.msgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBtn.Location = new System.Drawing.Point(-16, -25);
            this.msgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.Padding = new System.Windows.Forms.Padding(38, 0, 0, 9);
            this.msgBtn.Size = new System.Drawing.Size(396, 142);
            this.msgBtn.TabIndex = 3;
            this.msgBtn.Text = "                      Messages";
            this.msgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBtn.UseVisualStyleBackColor = false;
            this.msgBtn.Click += new System.EventHandler(this.msgBtn_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.medCheckBtn);
            this.panel15.Location = new System.Drawing.Point(3, 303);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(346, 94);
            this.panel15.TabIndex = 13;
            // 
            // medCheckBtn
            // 
            this.medCheckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.medCheckBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medCheckBtn.ForeColor = System.Drawing.Color.White;
            this.medCheckBtn.Image = ((System.Drawing.Image)(resources.GetObject("medCheckBtn.Image")));
            this.medCheckBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medCheckBtn.Location = new System.Drawing.Point(-16, -25);
            this.medCheckBtn.Margin = new System.Windows.Forms.Padding(0);
            this.medCheckBtn.Name = "medCheckBtn";
            this.medCheckBtn.Padding = new System.Windows.Forms.Padding(38, 0, 0, 9);
            this.medCheckBtn.Size = new System.Drawing.Size(396, 142);
            this.medCheckBtn.TabIndex = 3;
            this.medCheckBtn.Text = "                       Check Medicines";
            this.medCheckBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medCheckBtn.UseVisualStyleBackColor = false;
            this.medCheckBtn.Click += new System.EventHandler(this.medCheckBtn_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.tcBtn);
            this.panel17.Location = new System.Drawing.Point(3, 403);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(346, 94);
            this.panel17.TabIndex = 13;
            // 
            // tcBtn
            // 
            this.tcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.tcBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBtn.ForeColor = System.Drawing.Color.White;
            this.tcBtn.Image = ((System.Drawing.Image)(resources.GetObject("tcBtn.Image")));
            this.tcBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tcBtn.Location = new System.Drawing.Point(-16, -26);
            this.tcBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tcBtn.Name = "tcBtn";
            this.tcBtn.Padding = new System.Windows.Forms.Padding(38, 6, 0, 12);
            this.tcBtn.Size = new System.Drawing.Size(396, 135);
            this.tcBtn.TabIndex = 5;
            this.tcBtn.Text = "                        Terms and Conditions";
            this.tcBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tcBtn.UseVisualStyleBackColor = false;
            this.tcBtn.Click += new System.EventHandler(this.tcBtn_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dashboardBtn);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(346, 94);
            this.panel9.TabIndex = 16;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(-16, -28);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(396, 142);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "                      Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sideBar.Controls.Add(this.panel9);
            this.sideBar.Controls.Add(this.menuContainer);
            this.sideBar.Controls.Add(this.panel18);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 77);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(360, 885);
            this.sideBar.TabIndex = 18;
            // 
            // menuBarTransition
            // 
            this.menuBarTransition.Interval = 10;
            this.menuBarTransition.Tick += new System.EventHandler(this.menuBarTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 962);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "NurseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalProfileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).EndInit();
            this.panel18.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox personalProfileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSidebar;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button msgBtn;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button visitRoomBtn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button medCheckBtn;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button tcBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer menuBarTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}