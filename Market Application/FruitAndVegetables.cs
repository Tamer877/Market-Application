using AForge.Video.DirectShow;
using Market_Application.controller;
using Market_Application.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Market_Application
{
    public partial class FruitAndVegetables : Form
    {
        int number1;
        int number2;
        int result;
        char operation = ' ';
        public FruitAndVegetables()
        {
            InitializeComponent();
        }

        private void grpCalculator_Enter(object sender, EventArgs e)
        {

        }

        private void clickedButton(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == operation)
            {
                txtResult.Text = "0";
            }
            if (txtResult.Text == "0")
                txtResult.Text = "";

            txtResult.Text += ((Button)sender).Text;

        }
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void FruitAndVegetables_Load(object sender, EventArgs e)
        {
            timer1.Start();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                comboBoxChooseCamera.Items.Add(camera.Name);
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation != ' ' && !(txtResult.Text == "+" || txtResult.Text == "/" || txtResult.Text == "X" || txtResult.Text == "-"))
            {
                number2 = int.Parse(txtResult.Text);
                if (operation == '+')
                {
                    result = number1 + number2;
                }
                else if (operation == '-')
                {
                    result = number1 - number2;
                }
                else if (operation == 'X')
                {
                    result = number1 * number2;
                }
                else if (operation == '/')
                {
                    result = number1 / number2;
                }
                txtResult.Text = result.ToString();
                number1 = 0;
                number2 = 0;
                operation = ' ';
            }


        }

        private void operationButton(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                number1 = int.Parse(txtResult.Text);
                txtResult.Text = "";
                txtResult.Text = ((Button)sender).Text;
                operation = txtResult.Text[0];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
                if (string.IsNullOrEmpty(txtResult.Text))
                {
                    txtResult.Text = "0";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.Hour.ToString() + " :";
            labelMinute.Text = DateTime.Now.Minute.ToString() + " :";
            labelSecond.Text = DateTime.Now.Second.ToString();
        }

        private void openCamera_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[comboBoxChooseCamera.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timerBarcode.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnCloseCamera_Click(object sender, EventArgs e)
        {
            vcd.SignalToStop();
            pictureBoxCamera.Image = Image.FromFile("C:\\Users\\katal\\Desktop\\Software\\Images\\Pelfusion-Long-Shadow-Media-Camera.512.png");
        }

        private void timerBarcode_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBoxCamera.Image);

                if (result != null)
                {
                    txtBarcode.Text = result.ToString();
                }

            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            Product product = controller.GetProduct(txtBarcode.Text);
            lblProductName.Text = product.productName.ToString();
            txtResult.Text = product.price.ToString();
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = "barcode.wav";
            sound.Play();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CashierScreen cashierScreen = new CashierScreen();
            this.Hide();
            cashierScreen.Show();
        }
    }
}
