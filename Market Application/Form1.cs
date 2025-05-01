using Market_Application.controller;
using Market_Application.enumeration;
using Market_Application.model;

namespace Market_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.login(txtUserName.Text, txtPassword.Text);

            if (result!=null && result.status==loginStatus.Success && result.authority=="admin")
            {
                AdminScreen admin = new AdminScreen();
                this.Hide();
                admin.Show();
            }
            else if (result != null && result.status == loginStatus.Success && result.authority == "kasiyer")
            {
                CashierScreen cashier = new CashierScreen();
                this.Hide();
                cashier.Show();
            }
            else if(result != null && result.status == loginStatus.Unsuccess)
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre hatasý","Uyarý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            ChangePassword CP = new ChangePassword();
            CP.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
