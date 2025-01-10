namespace AutoDoc
{
    partial class NurseVisitRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseVisitRoomForm));
            this.label1 = new System.Windows.Forms.Label();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.floorTxt = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cmbAv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visit the Rooms";
            // 
            // showAllBtn
            // 
            this.showAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.ForeColor = System.Drawing.Color.Black;
            this.showAllBtn.Location = new System.Drawing.Point(468, 535);
            this.showAllBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(90, 53);
            this.showAllBtn.TabIndex = 93;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 331);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(414, 257);
            this.dataGridView.TabIndex = 92;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 114;
            this.label5.Text = "Floor No";
            // 
            // floorTxt
            // 
            this.floorTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorTxt.Location = new System.Drawing.Point(175, 214);
            this.floorTxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.floorTxt.Name = "floorTxt";
            this.floorTxt.Size = new System.Drawing.Size(265, 25);
            this.floorTxt.TabIndex = 113;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Patient Rooms",
            "Operating Rooms (OR)",
            "Intensive Care Units (ICU)",
            "Labor and Delivery Rooms",
            "Emergency Rooms (ER)",
            "Diagnostic Rooms",
            "Procedure Rooms",
            "Recovery Rooms",
            "Isolation Rooms",
            "Consultation Rooms"});
            this.cmbSearch.Location = new System.Drawing.Point(175, 82);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(265, 24);
            this.cmbSearch.TabIndex = 112;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Patient Rooms",
            "Operating Rooms (OR)",
            "Intensive Care Units (ICU)",
            "Labor and Delivery Rooms",
            "Emergency Rooms (ER)",
            "Diagnostic Rooms",
            "Procedure Rooms",
            "Recovery Rooms",
            "Isolation Rooms",
            "Consultation Rooms"});
            this.cmbType.Location = new System.Drawing.Point(175, 172);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(265, 24);
            this.cmbType.TabIndex = 111;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.searchBtn);
            this.panel7.Location = new System.Drawing.Point(468, 66);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 59);
            this.panel7.TabIndex = 110;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
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
            // cmbAv
            // 
            this.cmbAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAv.FormattingEnabled = true;
            this.cmbAv.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbAv.Location = new System.Drawing.Point(175, 257);
            this.cmbAv.Name = "cmbAv";
            this.cmbAv.Size = new System.Drawing.Size(265, 24);
            this.cmbAv.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 108;
            this.label3.Text = "Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 107;
            this.label2.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 106;
            this.label4.Text = "Room ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(175, 124);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(265, 29);
            this.IDTextBox.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 104;
            this.label8.Text = "Search by type";
            // 
            // NurseVisitRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 674);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.floorTxt);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cmbAv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NurseVisitRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NurseVisitRoomForm";
            this.Load += new System.EventHandler(this.NurseVisitRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox floorTxt;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox cmbAv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label8;
    }
}