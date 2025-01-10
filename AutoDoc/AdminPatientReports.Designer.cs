namespace AutoDoc
{
    partial class AdminPatientReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPatientReports));
            this.label1 = new System.Windows.Forms.Label();
            this.rTxt = new System.Windows.Forms.TextBox();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Patient Reports";
            // 
            // rTxt
            // 
            this.rTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxt.Location = new System.Drawing.Point(23, 103);
            this.rTxt.Multiline = true;
            this.rTxt.Name = "rTxt";
            this.rTxt.Size = new System.Drawing.Size(300, 267);
            this.rTxt.TabIndex = 14;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Location = new System.Drawing.Point(36, 404);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(94, 43);
            this.showAllBtn.TabIndex = 17;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(152, 404);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 43);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(351, 103);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(334, 267);
            this.reportDataGridView.TabIndex = 15;
            this.reportDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportDataGridView_CellClick);
            // 
            // AdminPatientReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 538);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.rTxt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPatientReports";
            this.Text = "AdminGiveAppointmentForm";
            this.Load += new System.EventHandler(this.AdminPatientReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rTxt;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView reportDataGridView;
    }
}