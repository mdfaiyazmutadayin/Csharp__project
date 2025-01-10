namespace AutoDoc
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.usrnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contriBtn = new System.Windows.Forms.Button();
            this.loginTimerTransition = new System.Windows.Forms.Timer(this.components);
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFlowPanel
            // 
            this.loginFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginFlowPanel.Location = new System.Drawing.Point(437, 130);
            this.loginFlowPanel.Name = "loginFlowPanel";
            this.loginFlowPanel.Size = new System.Drawing.Size(457, 520);
            this.loginFlowPanel.TabIndex = 0;
            // 
            // panelLog
            // 
            this.panelLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLog.BackgroundImage")));
            this.panelLog.Controls.Add(this.label4);
            this.panelLog.Controls.Add(this.signupBtn);
            this.panelLog.Controls.Add(this.pwdBox);
            this.panelLog.Controls.Add(this.usrnameBox);
            this.panelLog.Controls.Add(this.label3);
            this.panelLog.Controls.Add(this.label2);
            this.panelLog.Controls.Add(this.resetBtn);
            this.panelLog.Controls.Add(this.loginBtn);
            this.panelLog.Controls.Add(this.label1);
            this.panelLog.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLog.Location = new System.Drawing.Point(437, 130);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(433, 520);
            this.panelLog.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Don\'t Have Account?";
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.Location = new System.Drawing.Point(261, 461);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(82, 37);
            this.signupBtn.TabIndex = 8;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(70, 273);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '#';
            this.pwdBox.Size = new System.Drawing.Size(296, 35);
            this.pwdBox.TabIndex = 7;
            // 
            // usrnameBox
            // 
            this.usrnameBox.Location = new System.Drawing.Point(70, 183);
            this.usrnameBox.Name = "usrnameBox";
            this.usrnameBox.Size = new System.Drawing.Size(296, 35);
            this.usrnameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(167, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(167, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(261, 337);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(72, 37);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Lime;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(107, 337);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(72, 37);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(155, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Panel";
            // 
            // contriBtn
            // 
            this.contriBtn.Image = ((System.Drawing.Image)(resources.GetObject("contriBtn.Image")));
            this.contriBtn.Location = new System.Drawing.Point(138, 393);
            this.contriBtn.Name = "contriBtn";
            this.contriBtn.Size = new System.Drawing.Size(68, 64);
            this.contriBtn.TabIndex = 4;
            this.contriBtn.UseVisualStyleBackColor = true;
            this.contriBtn.Click += new System.EventHandler(this.contriBtn_Click);
            // 
            // loginTimerTransition
            // 
            this.loginTimerTransition.Interval = 10;
            this.loginTimerTransition.Tick += new System.EventHandler(this.loginTimerTransition_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 718);
            this.Controls.Add(this.contriBtn);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.loginFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel loginFlowPanel;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contriBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Timer loginTimerTransition;
        public System.Windows.Forms.TextBox usrnameBox;
        public System.Windows.Forms.TextBox pwdBox;
    }
}