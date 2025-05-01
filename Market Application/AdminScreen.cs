using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Application
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.Hour.ToString() + ":";
            labelMinute.Text = DateTime.Now.Minute.ToString() + ":";
            labelSecond.Text = DateTime.Now.Second.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserScreen user = new UserScreen();
            user.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();
            this.Hide();
            productScreen.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        { 
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
           
        }
    }
}
