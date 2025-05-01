namespace Market_Application
{
    partial class FruitAndVegetables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitAndVegetables));
            grpMenu = new GroupBox();
            btnExit = new Button();
            btnFruitAndVegetables = new Button();
            ımageList1 = new ImageList(components);
            btnBean = new Button();
            btnMilk = new Button();
            btnMeat = new Button();
            labelSecond = new Label();
            labelMinute = new Label();
            labelHour = new Label();
            grpProducts = new GroupBox();
            label7 = new Label();
            label4 = new Label();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnBroccoli = new Button();
            imgListFruitAndVegetables = new ImageList(components);
            btnApple = new Button();
            btnBanana = new Button();
            btnOrange = new Button();
            btnCabbage = new Button();
            btnStrawberry = new Button();
            btnGrappe = new Button();
            grpCalculator = new GroupBox();
            btnEquals = new Button();
            btnSix = new Button();
            btnMinus = new Button();
            btnThree = new Button();
            btnSum = new Button();
            btnClear = new Button();
            btnNine = new Button();
            btnSeven = new Button();
            btnFour = new Button();
            btnDivide = new Button();
            btnOne = new Button();
            btnBack = new Button();
            btnEight = new Button();
            btnFive = new Button();
            btnProduct = new Button();
            btnTwo = new Button();
            txtResult = new TextBox();
            grpQRCode = new GroupBox();
            txtBarcode = new TextBox();
            pictureBoxCamera = new PictureBox();
            btnCloseCamera = new Button();
            openCamera = new Button();
            comboBoxChooseCamera = new ComboBox();
            lblProductName = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerBarcode = new System.Windows.Forms.Timer(components);
            grpMenu.SuspendLayout();
            grpProducts.SuspendLayout();
            grpCalculator.SuspendLayout();
            grpQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(btnExit);
            grpMenu.Controls.Add(btnFruitAndVegetables);
            grpMenu.Controls.Add(btnBean);
            grpMenu.Controls.Add(btnMilk);
            grpMenu.Controls.Add(btnMeat);
            grpMenu.ForeColor = Color.White;
            grpMenu.Location = new Point(12, 12);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(163, 687);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menü";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(6, 636);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 35);
            btnExit.TabIndex = 1;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnFruitAndVegetables
            // 
            btnFruitAndVegetables.FlatStyle = FlatStyle.Popup;
            btnFruitAndVegetables.ImageIndex = 3;
            btnFruitAndVegetables.ImageList = ımageList1;
            btnFruitAndVegetables.Location = new Point(6, 455);
            btnFruitAndVegetables.Name = "btnFruitAndVegetables";
            btnFruitAndVegetables.Size = new Size(149, 137);
            btnFruitAndVegetables.TabIndex = 0;
            btnFruitAndVegetables.UseVisualStyleBackColor = true;
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
            ımageList1.Images.SetKeyName(4, "Pelfusion-Long-Shadow-Media-Camera.512.png");
            // 
            // btnBean
            // 
            btnBean.FlatStyle = FlatStyle.Popup;
            btnBean.ImageIndex = 2;
            btnBean.ImageList = ımageList1;
            btnBean.Location = new Point(6, 312);
            btnBean.Name = "btnBean";
            btnBean.Size = new Size(149, 137);
            btnBean.TabIndex = 0;
            btnBean.UseVisualStyleBackColor = true;
            // 
            // btnMilk
            // 
            btnMilk.FlatStyle = FlatStyle.Popup;
            btnMilk.ImageIndex = 1;
            btnMilk.ImageList = ımageList1;
            btnMilk.Location = new Point(6, 169);
            btnMilk.Name = "btnMilk";
            btnMilk.Size = new Size(149, 137);
            btnMilk.TabIndex = 0;
            btnMilk.UseVisualStyleBackColor = true;
            // 
            // btnMeat
            // 
            btnMeat.FlatStyle = FlatStyle.Popup;
            btnMeat.ImageIndex = 0;
            btnMeat.ImageList = ımageList1;
            btnMeat.Location = new Point(6, 26);
            btnMeat.Name = "btnMeat";
            btnMeat.Size = new Size(149, 137);
            btnMeat.TabIndex = 0;
            btnMeat.UseVisualStyleBackColor = true;
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSecond.ForeColor = Color.White;
            labelSecond.Location = new Point(1324, 0);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(27, 20);
            labelSecond.TabIndex = 6;
            labelSecond.Text = "00";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMinute.ForeColor = Color.White;
            labelMinute.Location = new Point(1287, 0);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(35, 20);
            labelMinute.TabIndex = 7;
            labelMinute.Text = "00 :";
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelHour.ForeColor = Color.White;
            labelHour.Location = new Point(1250, 0);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(35, 20);
            labelHour.TabIndex = 8;
            labelHour.Text = "00 :";
            // 
            // grpProducts
            // 
            grpProducts.Controls.Add(label7);
            grpProducts.Controls.Add(label4);
            grpProducts.Controls.Add(label8);
            grpProducts.Controls.Add(label6);
            grpProducts.Controls.Add(label3);
            grpProducts.Controls.Add(label5);
            grpProducts.Controls.Add(label2);
            grpProducts.Controls.Add(btnBroccoli);
            grpProducts.Controls.Add(btnApple);
            grpProducts.Controls.Add(btnBanana);
            grpProducts.Controls.Add(btnOrange);
            grpProducts.Controls.Add(btnCabbage);
            grpProducts.Controls.Add(btnStrawberry);
            grpProducts.Controls.Add(btnGrappe);
            grpProducts.ForeColor = Color.White;
            grpProducts.Location = new Point(209, 210);
            grpProducts.Name = "grpProducts";
            grpProducts.Size = new Size(607, 489);
            grpProducts.TabIndex = 9;
            grpProducts.TabStop = false;
            grpProducts.Text = "Ürünler";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(475, 180);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 1;
            label7.Text = "6 TL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(475, 29);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 1;
            label4.Text = "10 TL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(270, 333);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 1;
            label8.Text = "7 TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(270, 180);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 1;
            label6.Text = "15 TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(270, 29);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 1;
            label3.Text = "8 TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(71, 180);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 1;
            label5.Text = "5 TL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(71, 29);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "2 TL";
            // 
            // btnBroccoli
            // 
            btnBroccoli.FlatStyle = FlatStyle.Popup;
            btnBroccoli.ImageIndex = 5;
            btnBroccoli.ImageList = imgListFruitAndVegetables;
            btnBroccoli.Location = new Point(425, 203);
            btnBroccoli.Name = "btnBroccoli";
            btnBroccoli.Size = new Size(149, 137);
            btnBroccoli.TabIndex = 0;
            btnBroccoli.UseVisualStyleBackColor = true;
            // 
            // imgListFruitAndVegetables
            // 
            imgListFruitAndVegetables.ColorDepth = ColorDepth.Depth32Bit;
            imgListFruitAndVegetables.ImageStream = (ImageListStreamer)resources.GetObject("imgListFruitAndVegetables.ImageStream");
            imgListFruitAndVegetables.TransparentColor = Color.Transparent;
            imgListFruitAndVegetables.Images.SetKeyName(0, "Aha-Soft-Desktop-Buffet-Grapes.256.png");
            imgListFruitAndVegetables.Images.SetKeyName(1, "Fengsj-Vegetables-Cabbage.128.png");
            imgListFruitAndVegetables.Images.SetKeyName(2, "Fi3ur-Fruitsalad-Apple.256.png");
            imgListFruitAndVegetables.Images.SetKeyName(3, "Fi3ur-Fruitsalad-Strawberry.256.png");
            imgListFruitAndVegetables.Images.SetKeyName(4, "Gcds-Chinese-New-Year-Orange.512.png");
            imgListFruitAndVegetables.Images.SetKeyName(5, "Google-Noto-Emoji-Food-Drink-32367-broccoli.512.png");
            imgListFruitAndVegetables.Images.SetKeyName(6, "Iconicon-Veggies-Bananas.512.png");
            // 
            // btnApple
            // 
            btnApple.FlatStyle = FlatStyle.Popup;
            btnApple.ImageIndex = 2;
            btnApple.ImageList = imgListFruitAndVegetables;
            btnApple.Location = new Point(425, 40);
            btnApple.Name = "btnApple";
            btnApple.Size = new Size(149, 137);
            btnApple.TabIndex = 0;
            btnApple.UseVisualStyleBackColor = true;
            // 
            // btnBanana
            // 
            btnBanana.FlatStyle = FlatStyle.Popup;
            btnBanana.ImageIndex = 6;
            btnBanana.ImageList = imgListFruitAndVegetables;
            btnBanana.Location = new Point(222, 346);
            btnBanana.Name = "btnBanana";
            btnBanana.Size = new Size(149, 137);
            btnBanana.TabIndex = 0;
            btnBanana.UseVisualStyleBackColor = true;
            // 
            // btnOrange
            // 
            btnOrange.FlatStyle = FlatStyle.Popup;
            btnOrange.ImageIndex = 4;
            btnOrange.ImageList = imgListFruitAndVegetables;
            btnOrange.Location = new Point(222, 203);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(149, 137);
            btnOrange.TabIndex = 0;
            btnOrange.UseVisualStyleBackColor = true;
            // 
            // btnCabbage
            // 
            btnCabbage.FlatStyle = FlatStyle.Popup;
            btnCabbage.ImageIndex = 1;
            btnCabbage.ImageList = imgListFruitAndVegetables;
            btnCabbage.Location = new Point(222, 40);
            btnCabbage.Name = "btnCabbage";
            btnCabbage.Size = new Size(149, 137);
            btnCabbage.TabIndex = 0;
            btnCabbage.UseVisualStyleBackColor = true;
            // 
            // btnStrawberry
            // 
            btnStrawberry.FlatStyle = FlatStyle.Popup;
            btnStrawberry.ImageIndex = 3;
            btnStrawberry.ImageList = imgListFruitAndVegetables;
            btnStrawberry.Location = new Point(24, 203);
            btnStrawberry.Name = "btnStrawberry";
            btnStrawberry.Size = new Size(149, 137);
            btnStrawberry.TabIndex = 0;
            btnStrawberry.UseVisualStyleBackColor = true;
            // 
            // btnGrappe
            // 
            btnGrappe.FlatStyle = FlatStyle.Popup;
            btnGrappe.ImageIndex = 0;
            btnGrappe.ImageList = imgListFruitAndVegetables;
            btnGrappe.Location = new Point(24, 40);
            btnGrappe.Name = "btnGrappe";
            btnGrappe.Size = new Size(149, 137);
            btnGrappe.TabIndex = 0;
            btnGrappe.UseVisualStyleBackColor = true;
            // 
            // grpCalculator
            // 
            grpCalculator.Controls.Add(btnEquals);
            grpCalculator.Controls.Add(btnSix);
            grpCalculator.Controls.Add(btnMinus);
            grpCalculator.Controls.Add(btnThree);
            grpCalculator.Controls.Add(btnSum);
            grpCalculator.Controls.Add(btnClear);
            grpCalculator.Controls.Add(btnNine);
            grpCalculator.Controls.Add(btnSeven);
            grpCalculator.Controls.Add(btnFour);
            grpCalculator.Controls.Add(btnDivide);
            grpCalculator.Controls.Add(btnOne);
            grpCalculator.Controls.Add(btnBack);
            grpCalculator.Controls.Add(btnEight);
            grpCalculator.Controls.Add(btnFive);
            grpCalculator.Controls.Add(btnProduct);
            grpCalculator.Controls.Add(btnTwo);
            grpCalculator.Controls.Add(txtResult);
            grpCalculator.ForeColor = Color.White;
            grpCalculator.Location = new Point(838, 23);
            grpCalculator.Name = "grpCalculator";
            grpCalculator.Size = new Size(524, 676);
            grpCalculator.TabIndex = 10;
            grpCalculator.TabStop = false;
            grpCalculator.Text = "Hesap Makinesi";
            grpCalculator.Enter += grpCalculator_Enter;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 20F);
            btnEquals.ForeColor = Color.Black;
            btnEquals.Location = new Point(378, 351);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(107, 176);
            btnEquals.TabIndex = 2;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSix.ForeColor = Color.Black;
            btnSix.Location = new Point(265, 351);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(107, 85);
            btnSix.TabIndex = 1;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += clickedButton;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinus.ForeColor = Color.Black;
            btnMinus.Location = new Point(265, 168);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(107, 85);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += operationButton;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThree.ForeColor = Color.Black;
            btnThree.Location = new Point(265, 260);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(107, 85);
            btnThree.TabIndex = 1;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += clickedButton;
            // 
            // btnSum
            // 
            btnSum.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSum.ForeColor = Color.Black;
            btnSum.Location = new Point(377, 168);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(107, 85);
            btnSum.TabIndex = 1;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += operationButton;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(378, 260);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 85);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNine.ForeColor = Color.Black;
            btnNine.Location = new Point(265, 442);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(107, 85);
            btnNine.TabIndex = 1;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += clickedButton;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSeven.ForeColor = Color.Black;
            btnSeven.Location = new Point(39, 442);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(107, 85);
            btnSeven.TabIndex = 1;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += clickedButton;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFour.ForeColor = Color.Black;
            btnFour.Location = new Point(39, 351);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(107, 85);
            btnFour.TabIndex = 1;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += clickedButton;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDivide.ForeColor = Color.Black;
            btnDivide.Location = new Point(39, 168);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(107, 85);
            btnDivide.TabIndex = 1;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += operationButton;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOne.ForeColor = Color.Black;
            btnOne.Location = new Point(39, 260);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(107, 85);
            btnOne.TabIndex = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += clickedButton;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(39, 533);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(446, 85);
            btnBack.TabIndex = 1;
            btnBack.Text = "< Geri Gel";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEight.ForeColor = Color.Black;
            btnEight.Location = new Point(152, 442);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(107, 85);
            btnEight.TabIndex = 1;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += clickedButton;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFive.ForeColor = Color.Black;
            btnFive.Location = new Point(152, 351);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(107, 85);
            btnFive.TabIndex = 1;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += clickedButton;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProduct.ForeColor = Color.Black;
            btnProduct.Location = new Point(152, 168);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(107, 85);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "X";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += operationButton;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTwo.ForeColor = Color.Black;
            btnTwo.Location = new Point(152, 260);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(107, 85);
            btnTwo.TabIndex = 1;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += clickedButton;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtResult.Location = new Point(30, 42);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(472, 83);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // grpQRCode
            // 
            grpQRCode.Controls.Add(txtBarcode);
            grpQRCode.Controls.Add(pictureBoxCamera);
            grpQRCode.Controls.Add(btnCloseCamera);
            grpQRCode.Controls.Add(openCamera);
            grpQRCode.Controls.Add(comboBoxChooseCamera);
            grpQRCode.Controls.Add(lblProductName);
            grpQRCode.Controls.Add(label10);
            grpQRCode.Controls.Add(label9);
            grpQRCode.Controls.Add(label1);
            grpQRCode.ForeColor = Color.White;
            grpQRCode.Location = new Point(209, 12);
            grpQRCode.Name = "grpQRCode";
            grpQRCode.Size = new Size(607, 192);
            grpQRCode.TabIndex = 11;
            grpQRCode.TabStop = false;
            grpQRCode.Text = "QR Kod İle Ürünü Okut";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(190, 120);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(171, 27);
            txtBarcode.TabIndex = 4;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Image = (Image)resources.GetObject("pictureBoxCamera.Image");
            pictureBoxCamera.Location = new Point(367, 11);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(207, 175);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCamera.TabIndex = 3;
            pictureBoxCamera.TabStop = false;
            // 
            // btnCloseCamera
            // 
            btnCloseCamera.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCloseCamera.ForeColor = Color.Black;
            btnCloseCamera.Location = new Point(241, 61);
            btnCloseCamera.Name = "btnCloseCamera";
            btnCloseCamera.Size = new Size(120, 28);
            btnCloseCamera.TabIndex = 2;
            btnCloseCamera.Text = "Kamera Kapat";
            btnCloseCamera.UseVisualStyleBackColor = true;
            btnCloseCamera.Click += btnCloseCamera_Click;
            // 
            // openCamera
            // 
            openCamera.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            openCamera.ForeColor = Color.Black;
            openCamera.Location = new Point(115, 61);
            openCamera.Name = "openCamera";
            openCamera.Size = new Size(120, 28);
            openCamera.TabIndex = 2;
            openCamera.Text = "Kamera Aç";
            openCamera.UseVisualStyleBackColor = true;
            openCamera.Click += openCamera_Click;
            // 
            // comboBoxChooseCamera
            // 
            comboBoxChooseCamera.FormattingEnabled = true;
            comboBoxChooseCamera.Location = new Point(115, 27);
            comboBoxChooseCamera.Name = "comboBoxChooseCamera";
            comboBoxChooseCamera.Size = new Size(246, 28);
            comboBoxChooseCamera.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Black;
            lblProductName.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            lblProductName.ForeColor = Color.Red;
            lblProductName.Location = new Point(277, 155);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(0, 20);
            lblProductName.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(190, 155);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 0;
            label10.Text = "Ürün Adı : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(117, 123);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 0;
            label9.Text = "Barkod :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Kamera Seç:";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timerBarcode
            // 
            timerBarcode.Interval = 1;
            timerBarcode.Tick += timerBarcode_Tick;
            // 
            // FruitAndVegetables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1375, 710);
            Controls.Add(grpQRCode);
            Controls.Add(grpCalculator);
            Controls.Add(grpProducts);
            Controls.Add(labelSecond);
            Controls.Add(labelMinute);
            Controls.Add(labelHour);
            Controls.Add(grpMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FruitAndVegetables";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meyve Ve Sebzeler";
            Load += FruitAndVegetables_Load;
            grpMenu.ResumeLayout(false);
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            grpCalculator.ResumeLayout(false);
            grpCalculator.PerformLayout();
            grpQRCode.ResumeLayout(false);
            grpQRCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMenu;
        private Button btnMeat;
        private Button btnFruitAndVegetables;
        private Button btnBean;
        private Button btnMilk;
        private Button btnExit;
        private ImageList ımageList1;
        private Label labelSecond;
        private Label labelMinute;
        private Label labelHour;
        private GroupBox grpProducts;
        private GroupBox grpCalculator;
        private GroupBox grpQRCode;
        private Label label1;
        private PictureBox pictureBoxCamera;
        private Button openCamera;
        private ComboBox comboBoxChooseCamera;
        private Button btnTwo;
        private TextBox txtResult;
        private Button btnThree;
        private Button btnClear;
        private Button btnFour;
        private Button btnOne;
        private Button btnFive;
        private Button btnSix;
        private Button btnNine;
        private Button btnSeven;
        private Button btnEight;
        private Button btnApple;
        private Button btnCabbage;
        private Button btnGrappe;
        private Button btnBroccoli;
        private Button btnBanana;
        private Button btnOrange;
        private Button btnStrawberry;
        private ImageList imgListFruitAndVegetables;
        private Label label7;
        private Label label4;
        private Label label8;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Button btnEquals;
        private Button btnMinus;
        private Button btnSum;
        private Button btnDivide;
        private Button btnBack;
        private Button btnProduct;
        private System.Windows.Forms.Timer timer1;
        private Button btnCloseCamera;
        private TextBox txtBarcode;
        private System.Windows.Forms.Timer timerBarcode;
        private Label lblProductName;
        private Label label10;
        private Label label9;
    }
}