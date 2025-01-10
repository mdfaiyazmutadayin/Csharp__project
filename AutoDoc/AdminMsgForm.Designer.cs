namespace AutoDoc
{
    partial class AdminMsgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMsgForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previouslySendMsgDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.deleteMsgBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.showMsgBox = new System.Windows.Forms.TextBox();
            this.msgDataGridView = new System.Windows.Forms.DataGridView();
            this.sendMsgTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.previouslySendMsgDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(710, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sends";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(447, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Received";
            // 
            // previouslySendMsgDataGridView
            // 
            this.previouslySendMsgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previouslySendMsgDataGridView.Location = new System.Drawing.Point(632, 49);
            this.previouslySendMsgDataGridView.Name = "previouslySendMsgDataGridView";
            this.previouslySendMsgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.previouslySendMsgDataGridView.Size = new System.Drawing.Size(204, 202);
            this.previouslySendMsgDataGridView.TabIndex = 36;
            this.previouslySendMsgDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previouslySendMsgDataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Search";
            // 
            // cmbBox
            // 
            this.cmbBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(121, 49);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(191, 25);
            this.cmbBox.TabIndex = 34;
            // 
            // deleteMsgBtn
            // 
            this.deleteMsgBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteMsgBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMsgBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteMsgBtn.Image")));
            this.deleteMsgBtn.Location = new System.Drawing.Point(-41, -10);
            this.deleteMsgBtn.Name = "deleteMsgBtn";
            this.deleteMsgBtn.Size = new System.Drawing.Size(204, 79);
            this.deleteMsgBtn.TabIndex = 33;
            this.deleteMsgBtn.UseVisualStyleBackColor = false;
            this.deleteMsgBtn.Click += new System.EventHandler(this.deleteMsgBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Image = ((System.Drawing.Image)(resources.GetObject("sendBtn.Image")));
            this.sendBtn.Location = new System.Drawing.Point(310, 253);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(61, 53);
            this.sendBtn.TabIndex = 32;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(-49, -34);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(179, 130);
            this.clearBtn.TabIndex = 31;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // showMsgBox
            // 
            this.showMsgBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMsgBox.Location = new System.Drawing.Point(18, 90);
            this.showMsgBox.Multiline = true;
            this.showMsgBox.Name = "showMsgBox";
            this.showMsgBox.ReadOnly = true;
            this.showMsgBox.Size = new System.Drawing.Size(294, 154);
            this.showMsgBox.TabIndex = 30;
            // 
            // msgDataGridView
            // 
            this.msgDataGridView.AllowUserToAddRows = false;
            this.msgDataGridView.AllowUserToDeleteRows = false;
            this.msgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msgDataGridView.Location = new System.Drawing.Point(392, 49);
            this.msgDataGridView.Name = "msgDataGridView";
            this.msgDataGridView.ReadOnly = true;
            this.msgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.msgDataGridView.Size = new System.Drawing.Size(214, 202);
            this.msgDataGridView.TabIndex = 29;
            this.msgDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msgDataGridView_CellClick);
            // 
            // sendMsgTxtBox
            // 
            this.sendMsgTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMsgTxtBox.Location = new System.Drawing.Point(18, 253);
            this.sendMsgTxtBox.Multiline = true;
            this.sendMsgTxtBox.Name = "sendMsgTxtBox";
            this.sendMsgTxtBox.Size = new System.Drawing.Size(295, 53);
            this.sendMsgTxtBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Chat Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.msgDataGridView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.showMsgBox);
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Controls.Add(this.previouslySendMsgDataGridView);
            this.panel1.Controls.Add(this.sendMsgTxtBox);
            this.panel1.Location = new System.Drawing.Point(130, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 326);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Location = new System.Drawing.Point(452, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 59);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.deleteMsgBtn);
            this.panel3.Location = new System.Drawing.Point(673, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 59);
            this.panel3.TabIndex = 40;
            // 
            // AdminMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMsgForm";
            this.Text = "adminMsgPanel";
            this.Load += new System.EventHandler(this.AdminMsgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previouslySendMsgDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView previouslySendMsgDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Button deleteMsgBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox showMsgBox;
        private System.Windows.Forms.DataGridView msgDataGridView;
        private System.Windows.Forms.TextBox sendMsgTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}