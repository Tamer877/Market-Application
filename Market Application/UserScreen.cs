using Market_Application.controller;
using Market_Application.enumeration;
using Market_Application.model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = Market_Application.model.User;

namespace Market_Application
{
    public partial class UserScreen : Form
    {
        Controller controller = new Controller();
        public UserScreen()
        {
            InitializeComponent();
        }

        private void grpUser_Enter(object sender, EventArgs e)
        {

        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            setDefaultValues();
            getLoginTable();
        }

        private void setDefaultValues()
        {
            List<LoginTable> loginTable = controller.GetLoginTable();

            foreach (LoginTable user in loginTable)
            {
                cmbSecurityQuestion.Items.Add(user.securityQuestion);
            }
            cmbAuthority.Items.Add("Admin");
            cmbAuthority.Items.Add("Kasiyer");

            cmbSecurityQuestion.SelectedIndex = 0;
            cmbAuthority.SelectedIndex = 0;

        }
        private void getLoginTable()
        {
            List<LoginTable> loginTable = new List<LoginTable>();
            loginTable = controller.GetLoginTable();
            dataGridView1.DataSource = loginTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = txtUserName.Text;
            user.password = txtPassword.Text;
            user.authority = cmbAuthority.SelectedItem.ToString();
            user.region = txtRegion.Text;
            user.email = txtEmail.Text;
            user.securityQuestion = cmbSecurityQuestion.SelectedItem.ToString();
            user.securityAnswer = txtSecurityAnswer.Text;

            loginStatus result = controller.addUser(user);

            if (loginStatus.Success == result)
            {
                MessageBox.Show("Kayıt Eklendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.GetLoginTable();
            }
            else
                MessageBox.Show("Gerekli alanların hepsini doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbAuthority.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtRegion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbSecurityQuestion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSecurityAnswer.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(txtId.Text);
            user.userName = txtUserName.Text;
            user.password = txtPassword.Text;
            user.authority = cmbAuthority.SelectedItem.ToString();
            user.region = txtRegion.Text;
            user.email = txtEmail.Text;
            user.securityQuestion = cmbSecurityQuestion.SelectedItem.ToString();
            user.securityAnswer = txtSecurityAnswer.Text;
            loginStatus result = controller.updateUser(user);


            if (loginStatus.Success == result)
            {
                MessageBox.Show("Kayıt Güncellendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.GetLoginTable();
            }
            else
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loginStatus result = controller.deleteUser(txtId.Text);

            if (result == loginStatus.Success)
            {
                MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = controller.GetLoginTable();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminScreen admin = new AdminScreen();
            admin.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
