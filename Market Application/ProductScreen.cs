using Market_Application.controller;
using Market_Application.enumeration;
using Market_Application.model;
using System;
using System.Collections;
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
    public partial class ProductScreen : Form
    {
        Controller controller = new Controller();
        public ProductScreen()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.id = int.Parse(txtId.Text);
            product.qrCode = txtQrCode.Text;
            product.barkodCode = txtBarkodCode.Text;
            product.creationDate = dateCreationDate.Value;
            product.updateDate = dateUpdateDate.Value;
            product.productName = cmbProductName.SelectedItem.ToString();
            product.weight = int.Parse(txtWeight.Text);
            product.price = int.Parse(txtPrice.Text);
            product.turnover = int.Parse(txtTurnover.Text);



            loginStatus result = controller.addProduct(product);

            if (loginStatus.Success == result)
            {
                MessageBox.Show("Ürün Eklendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getAllProducts();
                deleteProductNames();
                defaultProductNames();
            }
            else if (loginStatus.Unsuccess == result)
            {
                MessageBox.Show("Ürün Eklenemedi :(", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Gerekli alanların hepsini doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public void defaultProductNames()
        {
            ArrayList productNames = new ArrayList();
            productNames = controller.getProductNames();
            for (int i = 0; i < productNames.Count; i++)
            {
                cmbProductName.Items.Add(productNames[i]);
            }
        }
        public void deleteProductNames()
        {
            int count = cmbProductName.Items.Count;
            for (int i = 0; i < count; i++)
            {
                cmbProductName.Items.RemoveAt(0);
            }
        }
        private void ProductScreen_Load(object sender, EventArgs e)
        {
            getAllProducts();
            defaultProductNames();
        }
        public void getAllProducts()
        {
            dataGridView1.DataSource = controller.getAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminScreen adminScreen = new AdminScreen();
            this.Hide();
            adminScreen.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtQrCode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBarkodCode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateCreationDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
                dateUpdateDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            cmbProductName.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtWeight.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtTurnover.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.id = int.Parse(txtId.Text);
            product.qrCode = txtQrCode.Text;
            product.barkodCode = txtBarkodCode.Text;
            product.creationDate = dateCreationDate.Value;
            product.updateDate = dateUpdateDate.Value;
            product.productName = cmbProductName.SelectedItem.ToString();
            product.weight = int.Parse(txtWeight.Text);
            product.price = int.Parse(txtPrice.Text);
            product.turnover = int.Parse(txtTurnover.Text);



            loginStatus result = controller.updateProduct(product);

            if (loginStatus.Success == result)
            {
                MessageBox.Show("Ürün Güncellendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getAllProducts();
            }
            else if (loginStatus.Unsuccess == result)
            {
                MessageBox.Show("Ürün Güncellenemedi :(", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Gerekli alanların hepsini doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loginStatus result = controller.deleteProduct(txtId.Text);

            if (result == loginStatus.Success)
            {
                MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = controller.getAllProducts();
                deleteProductNames();
                defaultProductNames();
            }
            else if (result == loginStatus.Unsuccess)
            {
                MessageBox.Show("Kayıt silinirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Silmek istediğini kaydın id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
