namespace Market_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            ımageList1 = new ImageList(components);
            forgotPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(259, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(259, 64);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            label2.Click += label1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(384, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(211, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(384, 65);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Black;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.ImageKey = "8679872_login_circle_line_icon.ico";
            btnLogin.ImageList = ımageList1;
            btnLogin.Location = new Point(449, 157);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += login_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "8679872_login_circle_line_icon.ico");
            // 
            // forgotPassword
            // 
            forgotPassword.AutoSize = true;
            forgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            forgotPassword.ForeColor = Color.Blue;
            forgotPassword.Location = new Point(295, 181);
            forgotPassword.Name = "forgotPassword";
            forgotPassword.Size = new Size(117, 20);
            forgotPassword.TabIndex = 3;
            forgotPassword.Text = "Şifremi Unuttum";
            forgotPassword.Click += forgotPassword_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(636, 231);
            Controls.Add(forgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Sayfası";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private ImageList ımageList1;
        private Label forgotPassword;
    }
}
