namespace Market_Application
{
    partial class ProductScreen
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
            grpProduct = new GroupBox();
            cmbProductName = new ComboBox();
            dateUpdateDate = new DateTimePicker();
            dateCreationDate = new DateTimePicker();
            btnUpdate = new Button();
            btnDelete = new Button();
            button1 = new Button();
            btnAdd = new Button();
            txtWeight = new TextBox();
            txtPrice = new TextBox();
            txtTurnover = new TextBox();
            txtId = new TextBox();
            txtBarkodCode = new TextBox();
            txtQrCode = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(cmbProductName);
            grpProduct.Controls.Add(dateUpdateDate);
            grpProduct.Controls.Add(dateCreationDate);
            grpProduct.Controls.Add(btnUpdate);
            grpProduct.Controls.Add(btnDelete);
            grpProduct.Controls.Add(button1);
            grpProduct.Controls.Add(btnAdd);
            grpProduct.Controls.Add(txtWeight);
            grpProduct.Controls.Add(txtPrice);
            grpProduct.Controls.Add(txtTurnover);
            grpProduct.Controls.Add(txtId);
            grpProduct.Controls.Add(txtBarkodCode);
            grpProduct.Controls.Add(txtQrCode);
            grpProduct.Controls.Add(label4);
            grpProduct.Controls.Add(label3);
            grpProduct.Controls.Add(label7);
            grpProduct.Controls.Add(label2);
            grpProduct.Controls.Add(label6);
            grpProduct.Controls.Add(label8);
            grpProduct.Controls.Add(label9);
            grpProduct.Controls.Add(label5);
            grpProduct.Controls.Add(label1);
            grpProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpProduct.ForeColor = Color.White;
            grpProduct.Location = new Point(21, 265);
            grpProduct.Name = "grpProduct";
            grpProduct.Size = new Size(763, 371);
            grpProduct.TabIndex = 3;
            grpProduct.TabStop = false;
            grpProduct.Text = "Ürün";
            // 
            // cmbProductName
            // 
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Location = new Point(542, 37);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(199, 28);
            cmbProductName.TabIndex = 5;
            cmbProductName.SelectedIndexChanged += cmbProductName_SelectedIndexChanged;
            // 
            // dateUpdateDate
            // 
            dateUpdateDate.Location = new Point(171, 219);
            dateUpdateDate.Name = "dateUpdateDate";
            dateUpdateDate.Size = new Size(198, 27);
            dateUpdateDate.TabIndex = 4;
            // 
            // dateCreationDate
            // 
            dateCreationDate.Location = new Point(172, 177);
            dateCreationDate.Name = "dateCreationDate";
            dateCreationDate.Size = new Size(198, 27);
            dateCreationDate.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(602, 303);
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
            btnDelete.Location = new Point(407, 303);
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
            button1.Location = new Point(17, 303);
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
            btnAdd.Location = new Point(209, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Kayıt Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(542, 85);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(198, 27);
            txtWeight.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(544, 132);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(198, 27);
            txtPrice.TabIndex = 1;
            // 
            // txtTurnover
            // 
            txtTurnover.Location = new Point(543, 177);
            txtTurnover.Name = "txtTurnover";
            txtTurnover.Size = new Size(198, 27);
            txtTurnover.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(198, 27);
            txtId.TabIndex = 1;
            // 
            // txtBarkodCode
            // 
            txtBarkodCode.Location = new Point(173, 129);
            txtBarkodCode.Name = "txtBarkodCode";
            txtBarkodCode.Size = new Size(198, 27);
            txtBarkodCode.TabIndex = 1;
            // 
            // txtQrCode
            // 
            txtQrCode.Location = new Point(173, 83);
            txtQrCode.Name = "txtQrCode";
            txtQrCode.Size = new Size(198, 27);
            txtQrCode.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(412, 180);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 0;
            label4.Text = "Ciro :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(17, 224);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 0;
            label3.Text = "Güncellenme Tarih:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(408, 132);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 0;
            label7.Text = "Fiyat :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(17, 177);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 0;
            label2.Text = "Oluşturulma Tarih:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(408, 85);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 0;
            label6.Text = "Kilo : ";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(17, 135);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 0;
            label9.Text = "Barkod Kodu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(408, 41);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 0;
            label5.Text = "Ürün İsim :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(17, 89);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Qr Kod:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(763, 228);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // ProductScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(820, 648);
            Controls.Add(grpProduct);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Paneli";
            Load += ProductScreen_Load;
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProduct;
        private ComboBox cmbAuthority;
        private ComboBox cmbSecurityQuestion;
        private Button btnUpdate;
        private Button btnDelete;
        private Button button1;
        private Button btnAdd;
        private TextBox txtPrice;
        private TextBox txtTurnover;
        private TextBox txtId;
        private TextBox txtQrCode;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateUpdateDate;
        private DateTimePicker dateCreationDate;
        private ComboBox cmbProductName;
        private TextBox txtWeight;
        private TextBox txtBarkodCode;
        private Label label9;
    }
}