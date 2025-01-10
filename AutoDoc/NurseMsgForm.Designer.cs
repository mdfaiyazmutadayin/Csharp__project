namespace AutoDoc
{
    partial class NurseMsgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseMsgForm));
            this.previouslySendMsgDataGridView = new System.Windows.Forms.DataGridView();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.deleteMsgBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.showMsgBox = new System.Windows.Forms.TextBox();
            this.msgDataGridView = new System.Windows.Forms.DataGridView();
            this.sendMsgTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previouslySendMsgDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // previouslySendMsgDataGridView
            // 
            this.previouslySendMsgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previouslySendMsgDataGridView.Location = new System.Drawing.Point(626, 49);
            this.previouslySendMsgDataGridView.Name = "previouslySendMsgDataGridView";
            this.previouslySendMsgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.previouslySendMsgDataGridView.Size = new System.Drawing.Size(204, 202);
            this.previouslySendMsgDataGridView.TabIndex = 24;
            this.previouslySendMsgDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previouslySendMsgDataGridView_CellClick);
            // 
            // cmbBox
            // 
            this.cmbBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(116, 46);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(161, 25);
            this.cmbBox.TabIndex = 22;
            // 
            // deleteMsgBtn
            // 
            this.deleteMsgBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteMsgBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMsgBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteMsgBtn.Image")));
            this.deleteMsgBtn.Location = new System.Drawing.Point(-22, -34);
            this.deleteMsgBtn.Name = "deleteMsgBtn";
            this.deleteMsgBtn.Size = new System.Drawing.Size(158, 130);
            this.deleteMsgBtn.TabIndex = 21;
            this.deleteMsgBtn.UseVisualStyleBackColor = false;
            this.deleteMsgBtn.Click += new System.EventHandler(this.deleteMsgBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Image = ((System.Drawing.Image)(resources.GetObject("sendBtn.Image")));
            this.sendBtn.Location = new System.Drawing.Point(317, 263);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(61, 53);
            this.sendBtn.TabIndex = 20;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.Location = new System.Drawing.Point(-46, -29);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(169, 120);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // showMsgBox
            // 
            this.showMsgBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMsgBox.Location = new System.Drawing.Point(16, 103);
            this.showMsgBox.Multiline = true;
            this.showMsgBox.Name = "showMsgBox";
            this.showMsgBox.Size = new System.Drawing.Size(294, 154);
            this.showMsgBox.TabIndex = 18;
            // 
            // msgDataGridView
            // 
            this.msgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msgDataGridView.Location = new System.Drawing.Point(387, 46);
            this.msgDataGridView.Name = "msgDataGridView";
            this.msgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.msgDataGridView.Size = new System.Drawing.Size(219, 205);
            this.msgDataGridView.TabIndex = 17;
            this.msgDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msgDataGridView_CellClick);
            // 
            // sendMsgTxtBox
            // 
            this.sendMsgTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMsgTxtBox.Location = new System.Drawing.Point(16, 263);
            this.sendMsgTxtBox.Multiline = true;
            this.sendMsgTxtBox.Name = "sendMsgTxtBox";
            this.sendMsgTxtBox.Size = new System.Drawing.Size(295, 53);
            this.sendMsgTxtBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbBox);
            this.panel1.Controls.Add(this.previouslySendMsgDataGridView);
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Controls.Add(this.msgDataGridView);
            this.panel1.Controls.Add(this.showMsgBox);
            this.panel1.Controls.Add(this.sendMsgTxtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(116, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 337);
            this.panel1.TabIndex = 42;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Location = new System.Drawing.Point(452, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 59);
            this.panel2.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(685, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Sends";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(447, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Received";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "Chat Panel";
            // 
            // NurseMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NurseMsgForm";
            this.Text = "NurseMsgForm";
            this.Load += new System.EventHandler(this.NurseMsgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previouslySendMsgDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView previouslySendMsgDataGridView;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Button deleteMsgBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox showMsgBox;
        private System.Windows.Forms.DataGridView msgDataGridView;
        private System.Windows.Forms.TextBox sendMsgTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}