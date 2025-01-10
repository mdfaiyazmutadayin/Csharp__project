namespace AutoDoc
{
    partial class StaffMedicineList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMedicineList));
            this.label1 = new System.Windows.Forms.Label();
            this.medcineListDataGridView = new System.Windows.Forms.DataGridView();
            this.addMedBtn = new System.Windows.Forms.Button();
            this.updateMedBtn = new System.Windows.Forms.Button();
            this.removeMedBtn = new System.Windows.Forms.Button();
            this.medIDtxt = new System.Windows.Forms.TextBox();
            this.medNameTxt = new System.Windows.Forms.TextBox();
            this.medPriceTxt = new System.Windows.Forms.TextBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.medPicBox = new System.Windows.Forms.PictureBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.takingCauseBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchMedTxtBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.expDate = new System.Windows.Forms.DateTimePicker();
            this.showAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medcineListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medPicBox)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine List";
            // 
            // medcineListDataGridView
            // 
            this.medcineListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medcineListDataGridView.Location = new System.Drawing.Point(511, 180);
            this.medcineListDataGridView.Name = "medcineListDataGridView";
            this.medcineListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medcineListDataGridView.Size = new System.Drawing.Size(448, 369);
            this.medcineListDataGridView.TabIndex = 1;
            this.medcineListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medcineListDataGridView_CellClick);
            // 
            // addMedBtn
            // 
            this.addMedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedBtn.Location = new System.Drawing.Point(44, 590);
            this.addMedBtn.Name = "addMedBtn";
            this.addMedBtn.Size = new System.Drawing.Size(93, 49);
            this.addMedBtn.TabIndex = 2;
            this.addMedBtn.Text = "Add";
            this.addMedBtn.UseVisualStyleBackColor = true;
            this.addMedBtn.Click += new System.EventHandler(this.addMedBtn_Click);
            // 
            // updateMedBtn
            // 
            this.updateMedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedBtn.Location = new System.Drawing.Point(158, 590);
            this.updateMedBtn.Name = "updateMedBtn";
            this.updateMedBtn.Size = new System.Drawing.Size(93, 49);
            this.updateMedBtn.TabIndex = 3;
            this.updateMedBtn.Text = "Update";
            this.updateMedBtn.UseVisualStyleBackColor = true;
            this.updateMedBtn.Click += new System.EventHandler(this.updateMedBtn_Click);
            // 
            // removeMedBtn
            // 
            this.removeMedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMedBtn.Location = new System.Drawing.Point(273, 590);
            this.removeMedBtn.Name = "removeMedBtn";
            this.removeMedBtn.Size = new System.Drawing.Size(93, 49);
            this.removeMedBtn.TabIndex = 4;
            this.removeMedBtn.Text = "Remove";
            this.removeMedBtn.UseVisualStyleBackColor = true;
            this.removeMedBtn.Click += new System.EventHandler(this.removeMedBtn_Click);
            // 
            // medIDtxt
            // 
            this.medIDtxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medIDtxt.Location = new System.Drawing.Point(218, 338);
            this.medIDtxt.Name = "medIDtxt";
            this.medIDtxt.Size = new System.Drawing.Size(227, 33);
            this.medIDtxt.TabIndex = 7;
            // 
            // medNameTxt
            // 
            this.medNameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameTxt.Location = new System.Drawing.Point(218, 379);
            this.medNameTxt.Name = "medNameTxt";
            this.medNameTxt.Size = new System.Drawing.Size(227, 33);
            this.medNameTxt.TabIndex = 8;
            // 
            // medPriceTxt
            // 
            this.medPriceTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medPriceTxt.Location = new System.Drawing.Point(218, 426);
            this.medPriceTxt.Name = "medPriceTxt";
            this.medPriceTxt.Size = new System.Drawing.Size(227, 33);
            this.medPriceTxt.TabIndex = 9;
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(391, 590);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(93, 49);
            this.clrBtn.TabIndex = 10;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Medicine ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Medicine Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Medicine Price";
            // 
            // medPicBox
            // 
            this.medPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medPicBox.BackgroundImage")));
            this.medPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medPicBox.Location = new System.Drawing.Point(218, 84);
            this.medPicBox.Name = "medPicBox";
            this.medPicBox.Size = new System.Drawing.Size(182, 176);
            this.medPicBox.TabIndex = 14;
            this.medPicBox.TabStop = false;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(318, 266);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(82, 32);
            this.uploadBtn.TabIndex = 15;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Taking Cause";
            // 
            // takingCauseBox
            // 
            this.takingCauseBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takingCauseBox.Location = new System.Drawing.Point(218, 476);
            this.takingCauseBox.Name = "takingCauseBox";
            this.takingCauseBox.Size = new System.Drawing.Size(227, 33);
            this.takingCauseBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Expiry Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Medicine Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Search Medicine ";
            // 
            // searchMedTxtBox
            // 
            this.searchMedTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMedTxtBox.Location = new System.Drawing.Point(643, 115);
            this.searchMedTxtBox.Name = "searchMedTxtBox";
            this.searchMedTxtBox.Size = new System.Drawing.Size(266, 33);
            this.searchMedTxtBox.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.searchBtn);
            this.panel7.Location = new System.Drawing.Point(937, 105);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 59);
            this.panel7.TabIndex = 41;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(-36, -36);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(37, 0, 0, 6);
            this.searchBtn.Size = new System.Drawing.Size(341, 136);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "           Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // expDate
            // 
            this.expDate.CustomFormat = "dd-MM-yyyy";
            this.expDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDate.Location = new System.Drawing.Point(218, 524);
            this.expDate.MaxDate = new System.DateTime(2060, 1, 1, 0, 0, 0, 0);
            this.expDate.MinDate = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            this.expDate.Name = "expDate";
            this.expDate.Size = new System.Drawing.Size(242, 25);
            this.expDate.TabIndex = 65;
            this.expDate.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Location = new System.Drawing.Point(511, 590);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(93, 49);
            this.showAllBtn.TabIndex = 66;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // StaffMedicineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 709);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.expDate);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchMedTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.takingCauseBox);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.medPicBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.medPriceTxt);
            this.Controls.Add(this.medNameTxt);
            this.Controls.Add(this.medIDtxt);
            this.Controls.Add(this.removeMedBtn);
            this.Controls.Add(this.updateMedBtn);
            this.Controls.Add(this.addMedBtn);
            this.Controls.Add(this.medcineListDataGridView);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffMedicineList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMedicineList";
            this.Load += new System.EventHandler(this.StaffMedicineList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medcineListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medPicBox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView medcineListDataGridView;
        private System.Windows.Forms.Button addMedBtn;
        private System.Windows.Forms.Button updateMedBtn;
        private System.Windows.Forms.Button removeMedBtn;
        private System.Windows.Forms.TextBox medIDtxt;
        private System.Windows.Forms.TextBox medNameTxt;
        private System.Windows.Forms.TextBox medPriceTxt;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox medPicBox;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox takingCauseBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchMedTxtBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker expDate;
        private System.Windows.Forms.Button showAllBtn;
    }
}