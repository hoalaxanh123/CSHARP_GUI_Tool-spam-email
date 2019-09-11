namespace ToolSendMail
{
    partial class Form1
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
            this.btn_SendMail = new System.Windows.Forms.Button();
            this.checkedListBox_ListEmail = new System.Windows.Forms.CheckedListBox();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar_PhanTram = new System.Windows.Forms.ProgressBar();
            this.label_PhanTram = new System.Windows.Forms.Label();
            this.btn_ChonTemplate = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_XoaDS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TieuDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SendMail
            // 
            this.btn_SendMail.Location = new System.Drawing.Point(237, 16);
            this.btn_SendMail.Name = "btn_SendMail";
            this.btn_SendMail.Size = new System.Drawing.Size(99, 23);
            this.btn_SendMail.TabIndex = 0;
            this.btn_SendMail.Text = "Gửi mail";
            this.btn_SendMail.UseVisualStyleBackColor = true;
            this.btn_SendMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox_ListEmail
            // 
            this.checkedListBox_ListEmail.CheckOnClick = true;
            this.checkedListBox_ListEmail.FormattingEnabled = true;
            this.checkedListBox_ListEmail.Location = new System.Drawing.Point(28, 164);
            this.checkedListBox_ListEmail.Name = "checkedListBox_ListEmail";
            this.checkedListBox_ListEmail.Size = new System.Drawing.Size(312, 244);
            this.checkedListBox_ListEmail.TabIndex = 1;
            // 
            // btnMoFile
            // 
            this.btnMoFile.Location = new System.Drawing.Point(25, 16);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(99, 23);
            this.btnMoFile.TabIndex = 0;
            this.btnMoFile.Text = "Mở file mail";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar_PhanTram
            // 
            this.progressBar_PhanTram.Location = new System.Drawing.Point(28, 442);
            this.progressBar_PhanTram.Name = "progressBar_PhanTram";
            this.progressBar_PhanTram.Size = new System.Drawing.Size(312, 23);
            this.progressBar_PhanTram.TabIndex = 2;
            // 
            // label_PhanTram
            // 
            this.label_PhanTram.AutoSize = true;
            this.label_PhanTram.Location = new System.Drawing.Point(318, 426);
            this.label_PhanTram.Name = "label_PhanTram";
            this.label_PhanTram.Size = new System.Drawing.Size(21, 13);
            this.label_PhanTram.TabIndex = 3;
            this.label_PhanTram.Text = "0%";
            // 
            // btn_ChonTemplate
            // 
            this.btn_ChonTemplate.Location = new System.Drawing.Point(130, 16);
            this.btn_ChonTemplate.Name = "btn_ChonTemplate";
            this.btn_ChonTemplate.Size = new System.Drawing.Size(99, 23);
            this.btn_ChonTemplate.TabIndex = 0;
            this.btn_ChonTemplate.Text = "Chọn Template";
            this.btn_ChonTemplate.UseVisualStyleBackColor = true;
            this.btn_ChonTemplate.Click += new System.EventHandler(this.btn_ChonTemplate_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(223, 491);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright @1510289 DLU";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_XoaDS
            // 
            this.btn_XoaDS.Location = new System.Drawing.Point(28, 413);
            this.btn_XoaDS.Name = "btn_XoaDS";
            this.btn_XoaDS.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaDS.TabIndex = 5;
            this.btn_XoaDS.Text = "Xóa DS";
            this.btn_XoaDS.UseVisualStyleBackColor = true;
            this.btn_XoaDS.Click += new System.EventHandler(this.btn_XoaDS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiêu đề mail :";
            // 
            // textBox_TieuDe
            // 
            this.textBox_TieuDe.Location = new System.Drawing.Point(102, 43);
            this.textBox_TieuDe.Name = "textBox_TieuDe";
            this.textBox_TieuDe.Size = new System.Drawing.Size(234, 20);
            this.textBox_TieuDe.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File email nhận  :";
            // 
            // txtEmailNhan
            // 
            this.txtEmailNhan.Location = new System.Drawing.Point(117, 69);
            this.txtEmailNhan.Name = "txtEmailNhan";
            this.txtEmailNhan.ReadOnly = true;
            this.txtEmailNhan.Size = new System.Drawing.Size(219, 20);
            this.txtEmailNhan.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File template :";
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(102, 95);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ReadOnly = true;
            this.txtTemplate.Size = new System.Drawing.Size(234, 20);
            this.txtTemplate.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 514);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TieuDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaDS);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_ChonTemplate);
            this.Controls.Add(this.btnMoFile);
            this.Controls.Add(this.btn_SendMail);
            this.Controls.Add(this.label_PhanTram);
            this.Controls.Add(this.progressBar_PhanTram);
            this.Controls.Add(this.checkedListBox_ListEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool send emails- Code by 1510289 IT DLU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendMail;
        private System.Windows.Forms.CheckedListBox checkedListBox_ListEmail;
        private System.Windows.Forms.Button btnMoFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar_PhanTram;
        private System.Windows.Forms.Label label_PhanTram;
        private System.Windows.Forms.Button btn_ChonTemplate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_XoaDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemplate;
    }
}

