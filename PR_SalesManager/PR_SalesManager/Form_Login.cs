using PR_SalesManager.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_Login : Form
    {
        DataConnection connection;
        public Form_Login()
        {
            InitializeComponent();
            connection = new DataConnection();
        }

        private void lblRegister_MouseHover(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.Black;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.FromArgb(213, 218, 223);
        }
        public bool checkInput()
        {
            if (txtAccount.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                lblText.Text = "Cảnh Báo: Không Được Bỏ Trống !";
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var checkLogin = connection.Staffs.SingleOrDefault(p => p.Account == txtAccount.Text && p.Password == txtPassword.Text);
            if (checkInput())
            {
                if (checkLogin != null)
                {
                    Form_Main main = new Form_Main();
                    main.IDAccount = checkLogin.IDStaff;
                    main.Show();
                    this.Hide();
                    main.Logout += Main_Logout;
                    lblText.Text = "";
                }
                else
                {
                    lblText.Text = "Lỗi: Sai Tài Khoản, Mật Khẩu !";
                }
            }
        }

        private void Main_Logout(object sender, EventArgs e)
        {
            (sender as Form_Main).isExit = false;
            (sender as Form_Main).Close();
            this.Show();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Form_Register register = new Form_Register();
            register.ShowDialog();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            lblText.Text = "";
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
                gbAccount.Text = "";
            else
                gbAccount.Text = txtAccount.PlaceholderText;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                gbPassword.Text = "";
            else
                gbPassword.Text = txtPassword.PlaceholderText;
        }
    }
}
