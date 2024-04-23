using PR_SalesManager.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_EditStaff : Form
    {
        public int ID { get; set; }
        public int IDLog { get; set; }

        DataConnection connection;
        public Form_EditStaff(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            connection = new DataConnection();
        }
        private void FillCombobox()
        {
            cmbType.Items.Add("Nhân Viên");
            cmbType.Items.Add("Quản Lý");
            cmbSex.Items.Add("Nữ");
            cmbSex.Items.Add("Nam");
        }
        private void Form_EditStaff_Load(object sender, EventArgs e)
        {
            FillCombobox();
            textWarning.Text = "";
            var infor = connection.Staffs.SingleOrDefault(p => p.IDStaff == ID);
            txtIDStaff.Text = infor.IDStaff.ToString();
            txtPassword.Text = infor.Password;
            txtAccount.Text = infor.Account;
            cmbType.SelectedIndex = infor.Type;
            txtFullName.Text = infor.FullName;
            cmbSex.SelectedIndex = infor.Sex == true ? 1 : 0;
            txtPhoneNumber.Text = infor.PhoneNumber.ToString();
            dtpDOB.Value = infor.DateOfBirth;
            txtAddress.Text = infor.Address;
            txtGmail.Text = infor.Gmail;
        }

        private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch.Checked == true) { txtPassword.PasswordChar = '\0'; }
            else { txtPassword.PasswordChar = '×'; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var acc = connection.Staffs.SingleOrDefault(p => p.IDStaff == ID);
            if (acc != null)
            {
                if (acc.IDStaff == 1)
                {
                    MessageOk.Show("Không được xóa tài khoản admin");
                    return;
                }
                var bill = acc.Bills.ToList();
                DialogResult dr = MessageYesNo.Show("Bạn muốn xóa tài khoản này?", "Thông Báo");
                if (dr == DialogResult.Yes)
                {
                    if (bill != null)
                    {
                        foreach (var item in bill)
                        {
                            item.IDStaff = null;
                            connection.Bills.AddOrUpdate(item);
                        }
                    }
                    connection.Staffs.Remove(acc);
                    connection.SaveChanges();
                    this.Close();
                }

                if (IDLog == acc.IDStaff)
                {
                    Application.Exit();
                }
            }
        }
        public bool checkInput()
        {
            if (txtAccount.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtFullName.Text.Trim() == "" || txtPhoneNumber.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtGmail.Text.Trim() == "")
            {
                textWarning.Text = "Cảnh Báo: Không Được Bỏ Trống !";
                return false;
            }
            if (DateTime.Now.Year - dtpDOB.Value.Year < 10)
            {
                textWarning.Text = "Cảnh Báo: Độ Tuổi Không Phù Hợp";
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                var acc = connection.Staffs.SingleOrDefault(p => p.IDStaff == ID);
                if (acc != null)
                {
                    acc.IDStaff = int.Parse(txtIDStaff.Text);
                    acc.Password = txtPassword.Text;
                    acc.Account = txtAccount.Text;
                    acc.Type = cmbType.SelectedIndex;
                    acc.FullName = txtFullName.Text;
                    acc.Sex = cmbSex.SelectedIndex == 1 ? true : false;
                    acc.PhoneNumber = txtPhoneNumber.Text;
                    acc.DateOfBirth = dtpDOB.Value;
                    acc.Address = txtAddress.Text;
                    acc.Gmail = txtGmail.Text;
                    connection.Staffs.AddOrUpdate(acc);
                    connection.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
