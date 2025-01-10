namespace AutoDoc
{
    partial class DoctorWriteReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorWriteReportForm));
            this.cmb = new System.Windows.Forms.ComboBox();
            this.rTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(240, 143);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(148, 29);
            this.cmb.TabIndex = 0;
            // 
            // rTxt
            // 
            this.rTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxt.Location = new System.Drawing.Point(104, 242);
            this.rTxt.Multiline = true;
            this.rTxt.Name = "rTxt";
            this.rTxt.Size = new System.Drawing.Size(286, 215);
            this.rTxt.TabIndex = 2;
            this.rTxt.TextChanged += new System.EventHandler(this.rTxt_TextChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(104, 478);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(86, 31);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Report ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Patient";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(222, 478);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(71, 31);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(432, 242);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(334, 215);
            this.reportDataGridView.TabIndex = 8;
            this.reportDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportDataGridView_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Report History";
            // 
            // DoctorWriteReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.rTxt);
            this.Controls.Add(this.cmb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorWriteReportForm";
            this.Text = "DoctorAppointment";
            this.Load += new System.EventHandler(this.DoctorAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox rTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Label label3;
    }
}