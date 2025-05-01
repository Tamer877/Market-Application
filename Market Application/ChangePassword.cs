using Market_Application.controller;
using Market_Application.enumeration;
using Market_Application.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Application
{
    public partial class ChangePassword : Form
    {
        int code;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            List<LoginTable> loginTableList = controller.GetLoginTable();
            foreach (LoginTable loginTable in loginTableList)
            {
                securityQuestion.Items.Add(loginTable.securityQuestion.ToString());
            }

            grpChangePassword.Enabled = false;
            grpChangePswWithMail.Enabled = false;
        }

        private void btnQuest_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            loginStatus result = controller.doAuthentication(userName.Text, securityQuestion.Text, securityAnswer.Text);

            if (result == loginStatus.Success)
                grpChangePswWithMail.Enabled = true;
            else if (result == loginStatus.Unsuccess)
                MessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Tüm alanları doldurunuz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string emaill = controller.IsEmailCorrect(userName.Text);
            if (emaill.Equals(email.Text))
            {
                Random rnd = new Random();
                code = rnd.Next(111111, 999999);

                MailAddress receiver = new MailAddress(email.Text, userName.Text);
                MailAddress senderr = new MailAddress("unknown@hotmail.com", "Unknown person");
                MailMessage message = new MailMessage(senderr, receiver);

                message.To.Add(receiver);
                message.From = senderr;
                message.Subject = "Şifre Değiştirme";
                message.Body = "Şifrenizi değiştirmek için kodunuz: " + code;

                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("unknown@hotmail.com", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Send(message);
                MessageBox.Show("Doğrulama kodu gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Geçerli bir mail giriniz...", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Code.Text == code.ToString())
            {
                grpChangePassword.Enabled = true;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            if (newPassword.Text.Equals(newPasswordAgain.Text))
            {
                loginStatus result = controller.changePassword(userName.Text, newPassword.Text);

                if (result == loginStatus.Success)
                {
                    MessageBox.Show("Şifreniz Değiştirilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("İki şifre birbirleriyle aynı değildir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }

}
