namespace AutoDoc
{
    partial class PatientHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientHistoryForm));
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.rTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(366, 117);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(334, 267);
            this.reportDataGridView.TabIndex = 12;
            this.reportDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportDataGridView_CellClick);
            // 
            // rTxt
            // 
            this.rTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxt.Location = new System.Drawing.Point(38, 117);
            this.rTxt.Multiline = true;
            this.rTxt.Name = "rTxt";
            this.rTxt.Size = new System.Drawing.Size(300, 267);
            this.rTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "My Reports";
            // 
            // showAllBtn
            // 
            this.showAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Location = new System.Drawing.Point(325, 417);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(118, 58);
            this.showAllBtn.TabIndex = 14;
            this.showAllBtn.Text = "Show ALL";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // PatientHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 503);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.rTxt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientHistoryForm";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.TextBox rTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAllBtn;
    }
}