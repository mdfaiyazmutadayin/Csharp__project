namespace AutoDoc
{
    partial class StaffPatientReportTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPatientReportTime));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.rTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(-45, -22);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 97);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Location = new System.Drawing.Point(-31, -26);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(176, 110);
            this.showAllBtn.TabIndex = 22;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Patient Reports";
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(367, 121);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(283, 262);
            this.reportDataGridView.TabIndex = 20;
            this.reportDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportDataGridView_CellClick);
            // 
            // rTxt
            // 
            this.rTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxt.Location = new System.Drawing.Point(48, 121);
            this.rTxt.Multiline = true;
            this.rTxt.Name = "rTxt";
            this.rTxt.Size = new System.Drawing.Size(263, 262);
            this.rTxt.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Location = new System.Drawing.Point(176, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 50);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showAllBtn);
            this.panel2.Location = new System.Drawing.Point(48, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 53);
            this.panel2.TabIndex = 25;
            // 
            // StaffPatientReportTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.rTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffPatientReportTime";
            this.Text = "StaffPatientReportTime";
            this.Load += new System.EventHandler(this.StaffPatientReportTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.TextBox rTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}