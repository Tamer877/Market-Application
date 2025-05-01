namespace Market_Application
{
    partial class ChangePassword
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
            groupBox1 = new GroupBox();
            btnQuest = new Button();
            securityQuestion = new ComboBox();
            securityAnswer = new TextBox();
            userName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpChangePassword = new GroupBox();
            Change = new Button();
            label5 = new Label();
            newPasswordAgain = new TextBox();
            label4 = new Label();
            newPassword = new TextBox();
            grpChangePswWithMail = new GroupBox();
            btnConfirm = new Button();
            btnSendCode = new Button();
            Code = new TextBox();
            email = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            grpChangePassword.SuspendLayout();
            grpChangePswWithMail.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btnQuest);
            groupBox1.Controls.Add(securityQuestion);
            groupBox1.Controls.Add(securityAnswer);
            groupBox1.Controls.Add(userName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(255, 128, 0);
            groupBox1.Location = new Point(35, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Güvenlik Sorusu";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnQuest
            // 
            btnQuest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuest.ForeColor = Color.FromArgb(255, 128, 0);
            btnQuest.Location = new Point(15, 173);
            btnQuest.Name = "btnQuest";
            btnQuest.Size = new Size(306, 29);
            btnQuest.TabIndex = 3;
            btnQuest.Text = "Sorgula";
            btnQuest.UseVisualStyleBackColor = true;
            btnQuest.Click += btnQuest_Click;
            // 
            // securityQuestion
            // 
            securityQuestion.FormattingEnabled = true;
            securityQuestion.Location = new Point(142, 83);
            securityQuestion.Name = "securityQuestion";
            securityQuestion.Size = new Size(179, 28);
            securityQuestion.TabIndex = 1;
            // 
            // securityAnswer
            // 
            securityAnswer.Location = new Point(142, 124);
            securityAnswer.Name = "securityAnswer";
            securityAnswer.Size = new Size(179, 27);
            securityAnswer.TabIndex = 2;
            // 
            // userName
            // 
            userName.Location = new Point(142, 39);
            userName.Name = "userName";
            userName.Size = new Size(179, 27);
            userName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(15, 127);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 0;
            label3.Text = "Güvenlik Cevabı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 0;
            label2.Text = "Güvenlik Sorusu: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı: ";
            // 
            // grpChangePassword
            // 
            grpChangePassword.BackColor = Color.Black;
            grpChangePassword.Controls.Add(Change);
            grpChangePassword.Controls.Add(label5);
            grpChangePassword.Controls.Add(newPasswordAgain);
            grpChangePassword.Controls.Add(label4);
            grpChangePassword.Controls.Add(newPassword);
            grpChangePassword.ForeColor = Color.FromArgb(255, 128, 0);
            grpChangePassword.Location = new Point(262, 296);
            grpChangePassword.Name = "grpChangePassword";
            grpChangePassword.Size = new Size(402, 252);
            grpChangePassword.TabIndex = 2;
            grpChangePassword.TabStop = false;
            grpChangePassword.Text = "Şifreyi Değiştir";
            // 
            // Change
            // 
            Change.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Change.Location = new Point(206, 164);
            Change.Name = "Change";
            Change.Size = new Size(115, 29);
            Change.TabIndex = 2;
            Change.Text = "Değiştir";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(15, 109);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 0;
            label5.Text = "Yeni Şifre Tekrar:";
            // 
            // newPasswordAgain
            // 
            newPasswordAgain.Location = new Point(142, 106);
            newPasswordAgain.Name = "newPasswordAgain";
            newPasswordAgain.Size = new Size(179, 27);
            newPasswordAgain.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(15, 43);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Yeni Şifre:";
            // 
            // newPassword
            // 
            newPassword.Location = new Point(142, 40);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(179, 27);
            newPassword.TabIndex = 0;
            // 
            // grpChangePswWithMail
            // 
            grpChangePswWithMail.BackColor = Color.Black;
            grpChangePswWithMail.Controls.Add(btnConfirm);
            grpChangePswWithMail.Controls.Add(btnSendCode);
            grpChangePswWithMail.Controls.Add(Code);
            grpChangePswWithMail.Controls.Add(email);
            grpChangePswWithMail.Controls.Add(label7);
            grpChangePswWithMail.Controls.Add(label6);
            grpChangePswWithMail.Font = new Font("Segoe UI", 9F);
            grpChangePswWithMail.ForeColor = Color.FromArgb(255, 128, 0);
            grpChangePswWithMail.Location = new Point(477, 27);
            grpChangePswWithMail.Name = "grpChangePswWithMail";
            grpChangePswWithMail.Size = new Size(402, 239);
            grpChangePswWithMail.TabIndex = 1;
            grpChangePswWithMail.TabStop = false;
            grpChangePswWithMail.Text = "Mail İle Değiştir";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirm.Location = new Point(185, 190);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(193, 29);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Onayla";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnSendCode
            // 
            btnSendCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSendCode.Location = new Point(185, 82);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(193, 29);
            btnSendCode.TabIndex = 1;
            btnSendCode.Text = "Doğrulama Kodu Gönder";
            btnSendCode.UseVisualStyleBackColor = true;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // Code
            // 
            Code.Location = new Point(144, 148);
            Code.Name = "Code";
            Code.Size = new Size(234, 27);
            Code.TabIndex = 2;
            // 
            // email
            // 
            email.Location = new Point(144, 35);
            email.Name = "email";
            email.Size = new Size(234, 27);
            email.TabIndex = 0;
            email.TextChanged += email_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(6, 151);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 0;
            label7.Text = "Doğrulama Kodu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(4, 38);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 0;
            label6.Text = "Email Adresiniz: ";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(255, 128, 0);
            btnBack.Location = new Point(39, 598);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 50);
            btnBack.TabIndex = 2;
            btnBack.Text = "<-";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(927, 680);
            Controls.Add(btnBack);
            Controls.Add(grpChangePassword);
            Controls.Add(grpChangePswWithMail);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifreyi Değiştir";
            Load += ChangePassword_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpChangePassword.ResumeLayout(false);
            grpChangePassword.PerformLayout();
            grpChangePswWithMail.ResumeLayout(false);
            grpChangePswWithMail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnQuest;
        private ComboBox securityQuestion;
        private TextBox securityAnswer;
        private TextBox userName;
        private Label label3;
        private Label label2;
        private GroupBox grpChangePassword;
        private Label label5;
        private TextBox newPasswordAgain;
        private Label label4;
        private TextBox newPassword;
        private Button Change;
        private GroupBox grpChangePswWithMail;
        private Button btnSendCode;
        private TextBox email;
        private Label label6;
        private TextBox Code;
        private Label label7;
        private Button btnConfirm;
        private Button btnBack;
    }
}