namespace Market_Application
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            labelSecond = new Label();
            labelMinute = new Label();
            labelHour = new Label();
            ımageList1 = new ImageList(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSecond.ForeColor = Color.White;
            labelSecond.Location = new Point(355, 9);
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
            labelMinute.Location = new Point(318, 9);
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
            labelHour.Location = new Point(281, 9);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(35, 20);
            labelHour.TabIndex = 8;
            labelHour.Text = "00 :";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Antrepo-Cargo-Boxes-Palet-01.256.png");
            ımageList1.Images.SetKeyName(1, "Hopstarter-Sleek-Xp-Basic-User-Group.256.png");
            ımageList1.Images.SetKeyName(2, "Oxygen-Icons.org-Oxygen-Actions-window-close.256.png");
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ImageKey = "Antrepo-Cargo-Boxes-Palet-01.256.png";
            button1.ImageList = ımageList1;
            button1.Location = new Point(38, 46);
            button1.Name = "button1";
            button1.Size = new Size(135, 127);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.ImageKey = "Hopstarter-Sleek-Xp-Basic-User-Group.256.png";
            button2.ImageList = ımageList1;
            button2.Location = new Point(218, 46);
            button2.Name = "button2";
            button2.Size = new Size(135, 127);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-window-close.256.png";
            button3.ImageList = ımageList1;
            button3.Location = new Point(126, 199);
            button3.Name = "button3";
            button3.Size = new Size(135, 127);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(389, 338);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelSecond);
            Controls.Add(labelMinute);
            Controls.Add(labelHour);
            Name = "AdminScreen";
            Text = "AdminPaneli";
            Load += AdminPaneli_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSecond;
        private Label labelMinute;
        private Label labelHour;
        private ImageList ımageList1;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}