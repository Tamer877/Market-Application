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
    public partial class CashierScreen : Form
    {
        public CashierScreen()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void CashierScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHour.Text = DateTime.Now.Hour.ToString() + ":";
            labelMinute.Text = DateTime.Now.Minute.ToString() + ":";
            labelSecond.Text = DateTime.Now.Second.ToString();
        }

        private void labelSecond_Click(object sender, EventArgs e)
        {

        }

        private void labelMinute_Click(object sender, EventArgs e)
        {

        }

        private void btnFruitVegetable_Click(object sender, EventArgs e)
        {
            FruitAndVegetables fruitAndVegetables = new FruitAndVegetables();
            this.Hide();
            fruitAndVegetables.Show();
        }
    }
}
