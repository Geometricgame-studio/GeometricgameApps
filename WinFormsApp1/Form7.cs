using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace All_tools_Form_Apps
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            send_email(form_account.Text, form_pass.Text, to_account.Text, title.Text, text.Text);
        }

        private async void send_email(string form, string password, string to, string subject, string body) {
            var o = new All_tools_Form_Apps.MessageBoxs.Sendemail_messagebox1();
            o.Show();
            await Task.Delay(10);
            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    mail.From = new MailAddress(form);
            //    mail.To.Add(to);
            //    mail.Subject = subject;
            //    mail.Body = body;

            //    using (SmtpClient smtp = new SmtpClient("smtp-relay.gmail.com", 465))
            //    {
            //        smtp.Credentials = new NetworkCredential(form, password);
            //        smtp.EnableSsl = true;
            //        smtp.Send(mail);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    
            //}
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential()
                {
                    UserName = form,
                    Password = password,
                };
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Send(to, form, subject, body);
                o.Close();
            }
            catch (Exception ex)
            {
                o.Close();
                if (ex.Message == "The value cannot be an empty string. (Parameter 'address')")
                {
                    MessageBox.Show("寄件人或收件人的Email不能為空。", "錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message == "The SMTP server requires a secure connection or the client was not authenticated. The server response was: 5.7.0 Authentication Required. For more information, go to")
                {
                    Program.show_notify("Email 寄送失敗", "您的Email無法寄出。", 2500, "error", false);
                    MessageBox.Show("寄送郵件時發生錯誤!\n\n===詳細資料===\n" +
                        "SMTP 伺服器需要安全連線或用戶端沒有通過身分驗證。\n伺服器回傳: 5.7.0 ，需要身分驗證。", "錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message == "The value cannot be an empty string. (Parameter 'addresses')")
                {
                    MessageBox.Show("寄件人或收件人的Email不能為空。", "錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message == "The specified string is not in the form required for an e-mail address.")
                {
                    MessageBox.Show("寄件人或收件人的Email格式不符。", "錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "An Unknow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
