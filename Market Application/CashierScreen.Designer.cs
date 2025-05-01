namespace Market_Application
{
    partial class CashierScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierScreen));
            btn_meat = new Button();
            ımageList1 = new ImageList(components);
            btnMilk = new Button();
            btnBean = new Button();
            btnFruitVegetable = new Button();
            Exit = new Button();
            labelHour = new Label();
            labelMinute = new Label();
            labelSecond = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_meat
            // 
            btn_meat.FlatStyle = FlatStyle.Popup;
            btn_meat.ImageIndex = 0;
            btn_meat.ImageList = ımageList1;
            btn_meat.Location = new Point(39, 12);
            btn_meat.Name = "btn_meat";
            btn_meat.Size = new Size(205, 165);
            btn_meat.TabIndex = 0;
            btn_meat.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Google-Noto-Emoji-Food-Drink-32380-cut-of-meat.256.png");
            ımageList1.Images.SetKeyName(1, "Jommans-Cafe-Noon-Milk.128.png");
            ımageList1.Images.SetKeyName(2, "Microsoft-Fluentui-Emoji-3d-Beans-3d.256.png");
            ımageList1.Images.SetKeyName(3, "Iconshow-Agriculture-Fruits-Vegetables.256.png");
            // 
            // btnMilk
            // 
            btnMilk.FlatStyle = FlatStyle.Popup;
            btnMilk.ImageIndex = 1;
            btnMilk.ImageList = ımageList1;
            btnMilk.Location = new Point(300, 12);
            btnMilk.Name = "btnMilk";
            btnMilk.Size = new Size(205, 165);
            btnMilk.TabIndex = 1;
            btnMilk.UseVisualStyleBackColor = true;
            // 
            // btnBean
            // 
            btnBean.FlatStyle = FlatStyle.Popup;
            btnBean.ImageIndex = 2;
            btnBean.ImageList = ımageList1;
            btnBean.Location = new Point(39, 199);
            btnBean.Name = "btnBean";
            btnBean.Size = new Size(205, 165);
            btnBean.TabIndex = 2;
            btnBean.UseVisualStyleBackColor = true;
            // 
            // btnFruitVegetable
            // 
            btnFruitVegetable.FlatStyle = FlatStyle.Popup;
            btnFruitVegetable.ImageIndex = 3;
            btnFruitVegetable.ImageList = ımageList1;
            btnFruitVegetable.Location = new Point(300, 199);
            btnFruitVegetable.Name = "btnFruitVegetable";
            btnFruitVegetable.Size = new Size(205, 165);
            btnFruitVegetable.TabIndex = 3;
            btnFruitVegetable.UseVisualStyleBackColor = true;
            btnFruitVegetable.Click += btnFruitVegetable_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Exit.Location = new Point(39, 370);
            Exit.Name = "Exit";
            Exit.Size = new Size(205, 48);
            Exit.TabIndex = 4;
            Exit.Text = "Çıkış";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelHour.ForeColor = Color.White;
            labelHour.Location = new Point(372, 384);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(35, 20);
            labelHour.TabIndex = 5;
            labelHour.Text = "00 :";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMinute.ForeColor = Color.White;
            labelMinute.Location = new Point(409, 384);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(35, 20);
            labelMinute.TabIndex = 5;
            labelMinute.Text = "00 :";
            labelMinute.Click += labelMinute_Click;
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSecond.ForeColor = Color.White;
            labelSecond.Location = new Point(446, 384);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(27, 20);
            labelSecond.TabIndex = 5;
            labelSecond.Text = "00";
            labelSecond.Click += labelSecond_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // CashierScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(546, 430);
            Controls.Add(labelSecond);
            Controls.Add(labelMinute);
            Controls.Add(labelHour);
            Controls.Add(Exit);
            Controls.Add(btnFruitVegetable);
            Controls.Add(btnMilk);
            Controls.Add(btnBean);
            Controls.Add(btn_meat);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CashierScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KasiyerPanel";
            Load += CashierScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_meat;
        private Button btnMilk;
        private Button btnBean;
        private Button btnFruitVegetable;
        private ImageList ımageList1;
        private Button Exit;
        private Label labelHour;
        private Label labelMinute;
        private Label labelSecond;
        private System.Windows.Forms.Timer timer1;
    }
}