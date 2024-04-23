using PR_SalesManager.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_ChangePassword : Form
    {
        DataConnection connection;
        public int IDAccount;
        public Form_ChangePassword()
        {
            InitializeComponent();
            connection = new DataConnection();
        }

        private void ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true) txtOldPass.PasswordChar = '\0';
            else txtOldPass.PasswordChar = '×';
        }

        private void ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch2.Checked == true) txtNewPass.PasswordChar = '\0';
            else txtNewPass.PasswordChar = '×';
        }

        private void ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch3.Checked == true) txtConfirmPass.PasswordChar = '\0';
            else txtConfirmPass.PasswordChar = '×';
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var change = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (change != null)
            {
                if (txtOldPass.Text == change.Password)
                {
                    if (txtNewPass.Text == txtConfirmPass.Text)
                    {
                        if (txtOldPass.Text != txtNewPass.Text)
                        {
                            change.Password = txtConfirmPass.Text;
                            connection.Staffs.AddOrUpdate(change);
                            connection.SaveChanges();
                            this.Close();
                        }
                        else lblText.Text = "Đây là mật khẩu cũ";
                    }
                    else lblText.Text = "Không trùng mật khẩu";
                }
                else lblText.Text = "Sai mật khẩu";
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "")
                groupBox1.Text = "";
            else
                groupBox1.Text = "Mật Khẩu Hiện Tại";
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
                groupBox2.Text = "";
            else
                groupBox2.Text = "Mật Khẩu Mới";
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "")
                groupBox3.Text = "";
            else
                groupBox3.Text = "Xác Nhận Mật Khẩu";
        }

        private void Form_ChangePassword_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "";
            groupBox2.Text = "";
            groupBox3.Text = "";
            lblText.Text = "";
        }

    }
}
