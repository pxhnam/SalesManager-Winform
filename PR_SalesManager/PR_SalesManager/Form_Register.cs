using PR_SalesManager.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_Register : Form
    {
        DataConnection connection;
        public Form_Register()
        {
            InitializeComponent();
            connection = new DataConnection();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            cmbSex.Items.Add("Nam");
            cmbSex.Items.Add("Nữ");
            lblText.Text = "";
        }
        public bool checkInput()
        {
            if (txtAccount.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtFullName.Text.Trim() == "" || txtPhoneNumber.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtGmail.Text.Trim() == "")
            {
                lblText.Text = "Cảnh Báo: Không Được Bỏ Trống !";
                return false;
            }
            if (!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$"))
            {
                lblText.Text = "Cảnh Báo: Vui Lòng Nhập Lại Gmail !";
                return false;
            }
            if (!Regex.IsMatch(txtAccount.Text, "^[a-zA-Z0-9]{6,20}$"))
            {
                lblText.Text = "Cảnh Báo: Tài khoản từ 6 kí tự trở lên !";
                return false;
            }
            if (cmbSex.SelectedIndex == -1)
            {
                lblText.Text = "Cảnh Báo: Vui Lòng Chọn Giới Tính";
                return false;
            }
            if (!Regex.IsMatch(txtPhoneNumber.Text, "^[0-9]{9,12}$"))
            {
                lblText.Text = "Nhập lại số điện thoại !";
                return false;
            }
            if (DateTime.Now.Year - dtpDOB.Value.Year < 10)
            {
                lblText.Text = "Cảnh Báo: Độ Tuổi Không Phù Hợp";
                return false;
            }
            return true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var checkRegister = connection.Staffs.SingleOrDefault(p => p.Account == txtAccount.Text);
            if (checkInput())
            {
                if (checkRegister == null)
                {
                    Staff s = new Staff
                    {
                        Account = txtAccount.Text,
                        Password = txtPassword.Text,
                        FullName = txtFullName.Text,
                        Sex = cmbSex.Text == "Nam" ? true : false,
                        PhoneNumber = txtPhoneNumber.Text,
                        DateOfBirth = dtpDOB.Value,
                        Address = txtAddress.Text,
                        Gmail = txtGmail.Text,
                    };
                    connection.Staffs.Add(s);
                    connection.SaveChanges();

                    this.Close();
                }
            }
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            var checkAccount = connection.Staffs.SingleOrDefault(p => p.Account == txtAccount.Text);
            if (checkAccount != null)
                lblText.Text = "Cảnh Báo: Tài Khoản Đã Tồn Tại !";
            else
                lblText.Text = "";
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                picShow.BringToFront();
                txtPassword.PasswordChar = '×';

            }
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '×')
            {
                picHide.BringToFront();
                txtPassword.PasswordChar = '\0';

            }
        }
    }
}
