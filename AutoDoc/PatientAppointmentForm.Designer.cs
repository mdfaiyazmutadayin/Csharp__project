namespace AutoDoc
{
    partial class PatientAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAppointmentForm));
            this.clrBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reasonTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reqbtn = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.apDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.Tomato;
            this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(555, 479);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 33);
            this.clrBtn.TabIndex = 25;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Doctor";
            // 
            // reasonTxt
            // 
            this.reasonTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonTxt.Location = new System.Drawing.Point(102, 113);
            this.reasonTxt.Multiline = true;
            this.reasonTxt.Name = "reasonTxt";
            this.reasonTxt.Size = new System.Drawing.Size(230, 158);
            this.reasonTxt.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 289);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // reqbtn
            // 
            this.reqbtn.BackColor = System.Drawing.Color.Chartreuse;
            this.reqbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqbtn.Location = new System.Drawing.Point(437, 479);
            this.reqbtn.Name = "reqbtn";
            this.reqbtn.Size = new System.Drawing.Size(97, 33);
            this.reqbtn.TabIndex = 26;
            this.reqbtn.Text = "Request";
            this.reqbtn.UseVisualStyleBackColor = false;
            this.reqbtn.Click += new System.EventHandler(this.reqbtn_Click);
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(103, 15);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(229, 28);
            this.cmb.TabIndex = 27;
            // 
            // apDate
            // 
            this.apDate.CustomFormat = "dd-MM-yyyy";
            this.apDate.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apDate.Location = new System.Drawing.Point(102, 66);
            this.apDate.MaxDate = new System.DateTime(2099, 11, 26, 0, 0, 0, 0);
            this.apDate.MinDate = new System.DateTime(2024, 5, 9, 0, 0, 0, 0);
            this.apDate.Name = "apDate";
            this.apDate.Size = new System.Drawing.Size(230, 29);
            this.apDate.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.apDate);
            this.panel1.Controls.Add(this.reasonTxt);
            this.panel1.Controls.Add(this.cmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(58, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 309);
            this.panel1.TabIndex = 29;
            // 
            // PatientAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reqbtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientAppointmentForm";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reasonTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button reqbtn;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.DateTimePicker apDate;
        private System.Windows.Forms.Panel panel1;
    }
}