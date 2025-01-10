namespace AutoDoc
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.personalProfileBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSidebar = new System.Windows.Forms.PictureBox();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
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
            this.medicineBuyBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.historyBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tcBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalProfileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 50);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(853, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserPanel";
            // 
            // personalProfileBox
            // 
            this.personalProfileBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personalProfileBox.BackgroundImage")));
            this.personalProfileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personalProfileBox.Location = new System.Drawing.Point(119, 3);
            this.personalProfileBox.Margin = new System.Windows.Forms.Padding(2);
            this.personalProfileBox.Name = "personalProfileBox";
            this.personalProfileBox.Size = new System.Drawing.Size(51, 47);
            this.personalProfileBox.TabIndex = 5;
            this.personalProfileBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(234, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserPanel";
            // 
            // btnSidebar
            // 
            this.btnSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSidebar.Image = ((System.Drawing.Image)(resources.GetObject("btnSidebar.Image")));
            this.btnSidebar.Location = new System.Drawing.Point(11, 9);
            this.btnSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(44, 37);
            this.btnSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSidebar.TabIndex = 4;
            this.btnSidebar.TabStop = false;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
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
            this.sideBar.Size = new System.Drawing.Size(305, 653);
            this.sideBar.TabIndex = 4;
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
            this.dashboardBtn.Size = new System.Drawing.Size(237, 62);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "                      Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Controls.Add(this.panel10);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Location = new System.Drawing.Point(0, 54);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(281, 380);
            this.menuContainer.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuButtonClick);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 64);
            this.panel2.TabIndex = 11;
            // 
            // menuButtonClick
            // 
            this.menuButtonClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menuButtonClick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButtonClick.ForeColor = System.Drawing.Color.White;
            this.menuButtonClick.Image = ((System.Drawing.Image)(resources.GetObject("menuButtonClick.Image")));
            this.menuButtonClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButtonClick.Location = new System.Drawing.Point(-7, -20);
            this.menuButtonClick.Margin = new System.Windows.Forms.Padding(2);
            this.menuButtonClick.Name = "menuButtonClick";
            this.menuButtonClick.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.menuButtonClick.Size = new System.Drawing.Size(281, 103);
            this.menuButtonClick.TabIndex = 9;
            this.menuButtonClick.Text = "                       Menu";
            this.menuButtonClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButtonClick.UseVisualStyleBackColor = false;
            this.menuButtonClick.Click += new System.EventHandler(this.menuButtonClick_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.msgBtn);
            this.panel5.Location = new System.Drawing.Point(2, 70);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 63);
            this.panel5.TabIndex = 12;
            // 
            // msgBtn
            // 
            this.msgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.msgBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBtn.ForeColor = System.Drawing.Color.White;
            this.msgBtn.Image = ((System.Drawing.Image)(resources.GetObject("msgBtn.Image")));
            this.msgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBtn.Location = new System.Drawing.Point(-10, -38);
            this.msgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.Padding = new System.Windows.Forms.Padding(19, 0, 0, 6);
            this.msgBtn.Size = new System.Drawing.Size(313, 148);
            this.msgBtn.TabIndex = 3;
            this.msgBtn.Text = "                      Messages";
            this.msgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBtn.UseVisualStyleBackColor = false;
            this.msgBtn.Click += new System.EventHandler(this.msgBtn_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.appointmentBtn);
            this.panel4.Location = new System.Drawing.Point(2, 137);
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
            this.appointmentBtn.Size = new System.Drawing.Size(226, 76);
            this.appointmentBtn.TabIndex = 6;
            this.appointmentBtn.Text = "                      Take Appointment";
            this.appointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentBtn.UseVisualStyleBackColor = false;
            this.appointmentBtn.Click += new System.EventHandler(this.appointmentBtn_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.medicineBuyBtn);
            this.panel10.Location = new System.Drawing.Point(2, 191);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(190, 50);
            this.panel10.TabIndex = 13;
            // 
            // medicineBuyBtn
            // 
            this.medicineBuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.medicineBuyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineBuyBtn.ForeColor = System.Drawing.Color.White;
            this.medicineBuyBtn.Image = ((System.Drawing.Image)(resources.GetObject("medicineBuyBtn.Image")));
            this.medicineBuyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicineBuyBtn.Location = new System.Drawing.Point(-4, -11);
            this.medicineBuyBtn.Margin = new System.Windows.Forms.Padding(0);
            this.medicineBuyBtn.Name = "medicineBuyBtn";
            this.medicineBuyBtn.Padding = new System.Windows.Forms.Padding(19, 0, 0, 6);
            this.medicineBuyBtn.Size = new System.Drawing.Size(225, 76);
            this.medicineBuyBtn.TabIndex = 3;
            this.medicineBuyBtn.Text = "                       Buy Medicines";
            this.medicineBuyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicineBuyBtn.UseVisualStyleBackColor = false;
            this.medicineBuyBtn.Click += new System.EventHandler(this.medicineBuyBtn_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.historyBtn);
            this.panel6.Location = new System.Drawing.Point(2, 245);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 59);
            this.panel6.TabIndex = 12;
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.historyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.ForeColor = System.Drawing.Color.White;
            this.historyBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyBtn.Image")));
            this.historyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyBtn.Location = new System.Drawing.Point(-4, -15);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(0);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Padding = new System.Windows.Forms.Padding(22, 10, 0, 8);
            this.historyBtn.Size = new System.Drawing.Size(225, 81);
            this.historyBtn.TabIndex = 10;
            this.historyBtn.Text = "                      History";
            this.historyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tcBtn);
            this.panel7.Location = new System.Drawing.Point(2, 308);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 50);
            this.panel7.TabIndex = 13;
            // 
            // tcBtn
            // 
            this.tcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.tcBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBtn.ForeColor = System.Drawing.Color.White;
            this.tcBtn.Image = ((System.Drawing.Image)(resources.GetObject("tcBtn.Image")));
            this.tcBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tcBtn.Location = new System.Drawing.Point(-7, -15);
            this.tcBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tcBtn.Name = "tcBtn";
            this.tcBtn.Padding = new System.Windows.Forms.Padding(19, 4, 0, 8);
            this.tcBtn.Size = new System.Drawing.Size(254, 76);
            this.tcBtn.TabIndex = 5;
            this.tcBtn.Text = "                        Terms and Conditions";
            this.tcBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tcBtn.UseVisualStyleBackColor = false;
            this.tcBtn.Click += new System.EventHandler(this.tcBtn_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button4);
            this.panel8.Location = new System.Drawing.Point(2, 436);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(210, 50);
            this.panel8.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-7, -8);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(225, 67);
            this.button4.TabIndex = 7;
            this.button4.Text = "                        Logout";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 703);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalProfileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox personalProfileBox;
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
        private System.Windows.Forms.Button medicineBuyBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button tcBtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}