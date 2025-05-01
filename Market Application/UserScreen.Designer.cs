namespace Market_Application
{
    partial class UserScreen
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
            dataGridView1 = new DataGridView();
            grpUser = new GroupBox();
            txtPassword = new TextBox();
            cmbAuthority = new ComboBox();
            cmbSecurityQuestion = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            button1 = new Button();
            btnAdd = new Button();
            txtSecurityAnswer = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            txtUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtRegion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpUser.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(763, 228);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // grpUser
            // 
            grpUser.Controls.Add(txtRegion);
            grpUser.Controls.Add(txtPassword);
            grpUser.Controls.Add(cmbAuthority);
            grpUser.Controls.Add(cmbSecurityQuestion);
            grpUser.Controls.Add(btnUpdate);
            grpUser.Controls.Add(btnDelete);
            grpUser.Controls.Add(button1);
            grpUser.Controls.Add(btnAdd);
            grpUser.Controls.Add(txtSecurityAnswer);
            grpUser.Controls.Add(txtEmail);
            grpUser.Controls.Add(txtId);
            grpUser.Controls.Add(txtUserName);
            grpUser.Controls.Add(label4);
            grpUser.Controls.Add(label3);
            grpUser.Controls.Add(label7);
            grpUser.Controls.Add(label2);
            grpUser.Controls.Add(label6);
            grpUser.Controls.Add(label8);
            grpUser.Controls.Add(label5);
            grpUser.Controls.Add(label1);
            grpUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpUser.ForeColor = Color.White;
            grpUser.Location = new Point(25, 265);
            grpUser.Name = "grpUser";
            grpUser.Size = new Size(763, 303);
            grpUser.TabIndex = 1;
            grpUser.TabStop = false;
            grpUser.Text = "Kullanıcı";
            grpUser.Enter += grpUser_Enter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // cmbAuthority
            // 
            cmbAuthority.FormattingEnabled = true;
            cmbAuthority.Location = new Point(543, 179);
            cmbAuthority.Name = "cmbAuthority";
            cmbAuthority.Size = new Size(199, 28);
            cmbAuthority.TabIndex = 3;
            // 
            // cmbSecurityQuestion
            // 
            cmbSecurityQuestion.FormattingEnabled = true;
            cmbSecurityQuestion.Location = new Point(543, 85);
            cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            cmbSecurityQuestion.Size = new Size(199, 28);
            cmbSecurityQuestion.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(603, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 43);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(406, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Kayıt Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(18, 239);
            button1.Name = "button1";
            button1.Size = new Size(59, 43);
            button1.TabIndex = 2;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(210, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Kayıt Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSecurityAnswer
            // 
            txtSecurityAnswer.Location = new Point(544, 132);
            txtSecurityAnswer.Name = "txtSecurityAnswer";
            txtSecurityAnswer.Size = new Size(198, 27);
            txtSecurityAnswer.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(544, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(123, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(198, 27);
            txtId.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(122, 86);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 27);
            txtUserName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(412, 180);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 0;
            label4.Text = "Yetki :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(18, 180);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 0;
            label3.Text = "Bölge :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(408, 132);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 0;
            label7.Text = "Güvenlik Cevabı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(18, 133);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Şifre :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(408, 85);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 0;
            label6.Text = "Güvenlik Sorusu :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(18, 44);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 0;
            label8.Text = "Id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(408, 41);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 0;
            label5.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(17, 89);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(121, 173);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(200, 27);
            txtRegion.TabIndex = 5;
            txtRegion.TextChanged += textBox1_TextChanged_1;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(811, 594);
            Controls.Add(grpUser);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Paneli";
            Load += UserScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpUser.ResumeLayout(false);
            grpUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grpUser;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox password;
        private TextBox textBox6;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label1;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtSecurityAnswer;
        private Label label7;
        private Button btnUpdate;
        private ComboBox cmbAuthority;
        private ComboBox cmbSecurityQuestion;
        private TextBox txtPassword;
        private TextBox txtId;
        private Label label8;
        private Button button1;
        private TextBox txtRegion;
    }
}