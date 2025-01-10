namespace AutoDoc
{
    partial class UserSignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignUpForm));
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.signUpFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SignUpPicBox = new System.Windows.Forms.PictureBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.phneBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.otherRBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.dOB_Box = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.signUpTimer = new System.Windows.Forms.Timer(this.components);
            this.signUpFlowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(-7, -15);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.saveBtn.Size = new System.Drawing.Size(199, 92);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "               Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(-8, -15);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 74);
            this.backBtn.TabIndex = 31;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.Transparent;
            this.clrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.ForeColor = System.Drawing.Color.Black;
            this.clrBtn.Image = ((System.Drawing.Image)(resources.GetObject("clrBtn.Image")));
            this.clrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clrBtn.Location = new System.Drawing.Point(-3, -14);
            this.clrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(172, 92);
            this.clrBtn.TabIndex = 32;
            this.clrBtn.Text = "              Clear";
            this.clrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // signUpFlowPanel
            // 
            this.signUpFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.signUpFlowPanel.Controls.Add(this.panel1);
            this.signUpFlowPanel.Location = new System.Drawing.Point(200, 107);
            this.signUpFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.signUpFlowPanel.Name = "signUpFlowPanel";
            this.signUpFlowPanel.Size = new System.Drawing.Size(645, 406);
            this.signUpFlowPanel.TabIndex = 33;
            this.signUpFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signUpFlowPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SignUpPicBox);
            this.panel1.Controls.Add(this.pwdBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.typeBox);
            this.panel1.Controls.Add(this.phneBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.otherRBtn);
            this.panel1.Controls.Add(this.femaleRadioBtn);
            this.panel1.Controls.Add(this.maleRadioBtn);
            this.panel1.Controls.Add(this.dOB_Box);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(458, 193);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 56);
            this.panel5.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(503, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 72;
            this.label7.Text = "Choose an Image";
            // 
            // SignUpPicBox
            // 
            this.SignUpPicBox.BackColor = System.Drawing.Color.Transparent;
            this.SignUpPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpPicBox.BackgroundImage")));
            this.SignUpPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignUpPicBox.Location = new System.Drawing.Point(458, 34);
            this.SignUpPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpPicBox.Name = "SignUpPicBox";
            this.SignUpPicBox.Size = new System.Drawing.Size(153, 154);
            this.SignUpPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignUpPicBox.TabIndex = 71;
            this.SignUpPicBox.TabStop = false;
            this.SignUpPicBox.Click += new System.EventHandler(this.SignUpPicBox_Click);
            // 
            // pwdBox
            // 
            this.pwdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwdBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdBox.Location = new System.Drawing.Point(148, 151);
            this.pwdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(268, 29);
            this.pwdBox.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Password";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Patient",
            "Doctor",
            "Staff",
            "Nurse"});
            this.typeBox.Location = new System.Drawing.Point(148, 269);
            this.typeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(268, 29);
            this.typeBox.TabIndex = 66;
            // 
            // phneBox
            // 
            this.phneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phneBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phneBox.Location = new System.Drawing.Point(148, 324);
            this.phneBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phneBox.Name = "phneBox";
            this.phneBox.Size = new System.Drawing.Size(268, 29);
            this.phneBox.TabIndex = 64;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(148, 34);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 29);
            this.nameTextBox.TabIndex = 62;
            // 
            // otherRBtn
            // 
            this.otherRBtn.AutoSize = true;
            this.otherRBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherRBtn.ForeColor = System.Drawing.Color.White;
            this.otherRBtn.Location = new System.Drawing.Point(334, 210);
            this.otherRBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.otherRBtn.Name = "otherRBtn";
            this.otherRBtn.Size = new System.Drawing.Size(67, 24);
            this.otherRBtn.TabIndex = 61;
            this.otherRBtn.TabStop = true;
            this.otherRBtn.Text = "Other";
            this.otherRBtn.UseVisualStyleBackColor = true;
            this.otherRBtn.CheckedChanged += new System.EventHandler(this.otherRBtn_CheckedChanged_1);
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioBtn.ForeColor = System.Drawing.Color.White;
            this.femaleRadioBtn.Location = new System.Drawing.Point(245, 210);
            this.femaleRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(77, 24);
            this.femaleRadioBtn.TabIndex = 60;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            this.femaleRadioBtn.CheckedChanged += new System.EventHandler(this.femaleRadioBtn_CheckedChanged_1);
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioBtn.ForeColor = System.Drawing.Color.White;
            this.maleRadioBtn.Location = new System.Drawing.Point(168, 210);
            this.maleRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(61, 24);
            this.maleRadioBtn.TabIndex = 59;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            this.maleRadioBtn.CheckedChanged += new System.EventHandler(this.maleRadioBtn_CheckedChanged_1);
            // 
            // dOB_Box
            // 
            this.dOB_Box.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOB_Box.Location = new System.Drawing.Point(148, 96);
            this.dOB_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dOB_Box.Name = "dOB_Box";
            this.dOB_Box.Size = new System.Drawing.Size(268, 27);
            this.dOB_Box.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Location = new System.Drawing.Point(106, 463);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 46);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Location = new System.Drawing.Point(501, 525);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 60);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.clrBtn);
            this.panel4.Location = new System.Drawing.Point(712, 524);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 60);
            this.panel4.TabIndex = 36;
            // 
            // signUpTimer
            // 
            this.signUpTimer.Interval = 10;
            this.signUpTimer.Tick += new System.EventHandler(this.signUpTimer_Tick);
            // 
            // UserSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 635);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signUpFlowPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserSignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.signUpFlowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.FlowLayoutPanel signUpFlowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SignUpPicBox;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox phneBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton otherRBtn;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.DateTimePicker dOB_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer signUpTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
    }
}