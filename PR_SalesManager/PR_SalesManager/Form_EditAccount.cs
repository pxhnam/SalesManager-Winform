using PR_SalesManager.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_EditAccount : Form
    {
        DataConnection connection;
        public int IDAccount;
        public Form_EditAccount()
        {
            InitializeComponent();
            connection = new DataConnection();
        }

        public bool checkInput()
        {
            if (txtFullName.Text.Trim() == "" || txtPhoneNumber.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtGmail.Text.Trim() == "")
            {
                lblText.Text = "Cảnh Báo: Không Được Bỏ Trống !";
                return false;
            }
            if (!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$"))
            {
                lblText.Text = "Cảnh Báo: Vui Lòng Nhập Lại Gmail !";
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
        public void FillCombobox()
        {
            cmbSex.Items.Add("Nữ");
            cmbSex.Items.Add("Nam");
        }
        private void Form_EditAccount_Load(object sender, EventArgs e)
        {
            FillCombobox();
            lblText.Text = "";
            var checkInfor = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (checkInfor != null)
            {
                txtAccount.Text = checkInfor.Account;
                txtFullName.Text = checkInfor.FullName;
                cmbSex.SelectedIndex = checkInfor.Sex == true ? 1 : 0;
                txtPosition.Text = checkInfor.Type == 1 ? "Quản Lý" : "Nhân Viên";
                txtPhoneNumber.Text = checkInfor.PhoneNumber;
                dtpDOB.Value = checkInfor.DateOfBirth;
                txtAddress.Text = checkInfor.Address;
                txtGmail.Text = checkInfor.Gmail;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var up = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (checkInput())
            {
                up.FullName = txtFullName.Text;
                up.Sex = cmbSex.SelectedIndex == 1 ? true : false;
                up.PhoneNumber = txtPhoneNumber.Text;
                up.DateOfBirth = dtpDOB.Value;
                up.Address = txtAddress.Text;
                up.Gmail = txtGmail.Text;
                connection.Staffs.AddOrUpdate(up);
                connection.SaveChanges();
                this.Close();
            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Form_ChangePassword fChangePassword = new Form_ChangePassword();
            fChangePassword.IDAccount = IDAccount;
            fChangePassword.ShowDialog();
        }

    }
}
