namespace AutoDoc
{
    partial class StaffsMedKitsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffsMedKitsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.medNameTxt = new System.Windows.Forms.TextBox();
            this.medPriceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.medPicBox = new System.Windows.Forms.PictureBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.searchMedTxtBox = new System.Windows.Forms.TextBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.removeMedBtn = new System.Windows.Forms.Button();
            this.updateMedBtn = new System.Windows.Forms.Button();
            this.addMedBtn = new System.Windows.Forms.Button();
            this.medcineListDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medPicBox)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medcineListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.medNameTxt);
            this.panel1.Controls.Add(this.medPriceTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.medPicBox);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Location = new System.Drawing.Point(43, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 393);
            this.panel1.TabIndex = 96;
            // 
            // medNameTxt
            // 
            this.medNameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameTxt.Location = new System.Drawing.Point(98, 281);
            this.medNameTxt.Name = "medNameTxt";
            this.medNameTxt.Size = new System.Drawing.Size(227, 33);
            this.medNameTxt.TabIndex = 71;
            // 
            // medPriceTxt
            // 
            this.medPriceTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medPriceTxt.Location = new System.Drawing.Point(98, 333);
            this.medPriceTxt.Name = "medPriceTxt";
            this.medPriceTxt.Size = new System.Drawing.Size(227, 33);
            this.medPriceTxt.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 82;
            this.label7.Text = "Image";
            // 
            // medPicBox
            // 
            this.medPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medPicBox.BackgroundImage")));
            this.medPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medPicBox.InitialImage = null;
            this.medPicBox.Location = new System.Drawing.Point(112, 32);
            this.medPicBox.Name = "medPicBox";
            this.medPicBox.Size = new System.Drawing.Size(182, 165);
            this.medPicBox.TabIndex = 77;
            this.medPicBox.TabStop = false;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(212, 203);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(82, 32);
            this.uploadBtn.TabIndex = 78;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.searchBtn);
            this.panel7.Location = new System.Drawing.Point(615, 61);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 59);
            this.panel7.TabIndex = 95;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(-30, -36);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(37, 0, 0, 6);
            this.searchBtn.Size = new System.Drawing.Size(228, 136);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "           Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 94;
            this.label8.Text = "Search  ";
            // 
            // searchMedTxtBox
            // 
            this.searchMedTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMedTxtBox.Location = new System.Drawing.Point(402, 75);
            this.searchMedTxtBox.Name = "searchMedTxtBox";
            this.searchMedTxtBox.Size = new System.Drawing.Size(206, 33);
            this.searchMedTxtBox.TabIndex = 93;
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(713, 470);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(81, 49);
            this.clrBtn.TabIndex = 92;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // removeMedBtn
            // 
            this.removeMedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMedBtn.Location = new System.Drawing.Point(607, 470);
            this.removeMedBtn.Name = "removeMedBtn";
            this.removeMedBtn.Size = new System.Drawing.Size(81, 49);
            this.removeMedBtn.TabIndex = 91;
            this.removeMedBtn.Text = "Remove";
            this.removeMedBtn.UseVisualStyleBackColor = true;
            this.removeMedBtn.Click += new System.EventHandler(this.removeMedBtn_Click);
            // 
            // updateMedBtn
            // 
            this.updateMedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedBtn.Location = new System.Drawing.Point(506, 470);
            this.updateMedBtn.Name = "updateMedBtn";
            this.updateMedBtn.Size = new System.Drawing.Size(81, 49);
            this.updateMedBtn.TabIndex = 90;
            this.updateMedBtn.Text = "Update";
            this.updateMedBtn.UseVisualStyleBackColor = true;
            this.updateMedBtn.Click += new System.EventHandler(this.updateMedBtn_Click);
            // 
            // addMedBtn
            // 
            this.addMedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedBtn.Location = new System.Drawing.Point(408, 470);
            this.addMedBtn.Name = "addMedBtn";
            this.addMedBtn.Size = new System.Drawing.Size(81, 49);
            this.addMedBtn.TabIndex = 89;
            this.addMedBtn.Text = "Add";
            this.addMedBtn.UseVisualStyleBackColor = true;
            this.addMedBtn.Click += new System.EventHandler(this.addMedBtn_Click);
            // 
            // medcineListDataGridView
            // 
            this.medcineListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medcineListDataGridView.Location = new System.Drawing.Point(405, 126);
            this.medcineListDataGridView.Name = "medcineListDataGridView";
            this.medcineListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medcineListDataGridView.Size = new System.Drawing.Size(440, 309);
            this.medcineListDataGridView.TabIndex = 88;
            this.medcineListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medcineListDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 87;
            this.label1.Text = "Instruments";
            // 
            // StaffsMedKitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchMedTxtBox);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.removeMedBtn);
            this.Controls.Add(this.updateMedBtn);
            this.Controls.Add(this.addMedBtn);
            this.Controls.Add(this.medcineListDataGridView);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffsMedKitsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffsMedKitsForm";
            this.Load += new System.EventHandler(this.StaffsMedKitsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medPicBox)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medcineListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox medNameTxt;
        private System.Windows.Forms.TextBox medPriceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox medPicBox;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchMedTxtBox;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button removeMedBtn;
        private System.Windows.Forms.Button updateMedBtn;
        private System.Windows.Forms.Button addMedBtn;
        private System.Windows.Forms.DataGridView medcineListDataGridView;
        private System.Windows.Forms.Label label1;
    }
}