using PR_SalesManager.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_AddCustomer : Form
    {
        DataConnection connection;
        public Form_AddCustomer()
        {
            InitializeComponent();
            connection = new DataConnection();
        }

        private void txtNameCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "") gbNameCustomer.Text = "";
            else gbNameCustomer.Text = txtNameCustomer.PlaceholderText;
        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text == "") gbNumberPhone.Text = "";
            else gbNumberPhone.Text = txtNumberPhone.PlaceholderText;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "") gbAddress.Text = "";
            else gbAddress.Text = txtAddress.PlaceholderText;
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            if (txtGmail.Text == "") gbGmail.Text = "";
            else gbGmail.Text = txtGmail.PlaceholderText;
        }

        private void Form_AddCustomer_Load(object sender, EventArgs e)
        {
            lblText.Text = "";
        }
        private bool checkInput()
        {
            if (txtNameCustomer.Text.Trim() == "" || txtNumberPhone.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtGmail.Text.Trim() == "")
            {
                lblText.Text = "Điền đầy đủ thông tin khách hàng !";
                return false;
            }
            if (!Regex.IsMatch(txtNumberPhone.Text, "^[0-9]{9,12}$"))
            {
                lblText.Text = "Nhập lại số điện thoại !";
                return false;
            }
            if (!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$"))
            {
                lblText.Text = "Nhập lại gmail !";
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Customer c = new Customer()
                {
                    FullName = txtNameCustomer.Text,
                    PhoneNumber = txtNumberPhone.Text,
                    Address = txtAddress.Text,
                    Gmail = txtGmail.Text,
                };
                connection.Customers.Add(c);
                connection.SaveChanges();
                this.Close();
            }
        }
    }
}
