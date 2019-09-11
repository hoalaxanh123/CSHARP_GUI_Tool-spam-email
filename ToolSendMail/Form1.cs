using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotLiquid;

namespace ToolSendMail
{
    public partial class Form1 : Form
    {
        string NoiDung = "";
        public static string emailGui = "";
        public static string passEmailGui = "";
        public Form1()
        {
            InitializeComponent();
        }
        public static void SendEmail(string mailNhan, string tieuDe, string NoiDung)
        {
            try
            {
                MailMessage mail = new MailMessage("nguyenvanvuong975@gmail.com", mailNhan);
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.EnableSsl = true;
                mail.IsBodyHtml = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                NetworkCredential NetworkCred = new NetworkCredential(emailGui, passEmailGui);
                client.Credentials = NetworkCred;
                mail.Subject = tieuDe;
                try
                {
                    NoiDung = NoiDung.Replace("{username}", mailNhan);
                }
                catch (Exception)
                {

                }
                mail.Body = NoiDung;
                client.Send(mail);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox_TieuDe.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập vào tiêu đề mail", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtTemplate.TextLength == 0)
            {
                MessageBox.Show("Vui lòng chọn file template.html", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtEmailNhan.TextLength == 0)
            {
                MessageBox.Show("Vui lòng chọn file Mails.txt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkedListBox_ListEmail.Items.Count != 0)
            {
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                    btn_SendMail.Text = "Gửi Mail";
                }
                else
                {
                    progressBar_PhanTram.Value = progressBar_PhanTram.Minimum;
                    btn_SendMail.Text = "Stop";
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Không có email nào để gửi , vui lòng đưa vào file email nhận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn file chứa email người nhận";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(@openFileDialog1.FileName))
                {
                    string line;
                    int count = 0;
                    checkedListBox_ListEmail.Items.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        count++;
                        checkedListBox_ListEmail.Items.Add(line, true);
                    }
                    this.progressBar_PhanTram.Maximum = count;
                }
                txtEmailNhan.Text = openFileDialog1.FileName;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            foreach (var item in checkedListBox_ListEmail.Items)
            {
                if (checkedListBox_ListEmail.GetItemCheckState(i) == CheckState.Checked)
                {
                    SendEmail(item.ToString(), this.textBox_TieuDe.Text, NoiDung);
                    backgroundWorker1.ReportProgress(i + 1);
                }
                i++;
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker1.CancellationPending)
            {
                label_PhanTram.Text = e.ProgressPercentage + "/" + checkedListBox_ListEmail.Items.Count;
                progressBar_PhanTram.Value = e.ProgressPercentage;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done");
            btn_SendMail.Text = "Gửi Mail";
        }

        private void btn_ChonTemplate_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn file template";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(@openFileDialog1.FileName))
                {
                    string line;
                    NoiDung = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        NoiDung += line;
                    }
                }
                txtTemplate.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fb.com/hoalaxanh123");
            System.Diagnostics.Process.Start("http://fb.com/maytinhgiare97");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (StreamReader sr = new StreamReader(@"MailConfig.txt"))
            {
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (count == 0)
                        emailGui = line;
                    else
                        passEmailGui = line;
                    count++;
                }
            }
        }

        private void btn_XoaDS_Click(object sender, EventArgs e)
        {
            checkedListBox_ListEmail.Items.Clear();
            label_PhanTram.Text = "0%";
            progressBar_PhanTram.Value = 0;
        }
    }
}
