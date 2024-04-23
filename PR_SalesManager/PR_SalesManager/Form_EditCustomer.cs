using PR_SalesManager.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_EditCustomer : Form
    {
        DataConnection connection;
        public int IDCustomer { get; set; }

        public Form_EditCustomer(int ID)
        {
            InitializeComponent();
            this.IDCustomer = ID;
            connection = new DataConnection();

        }

        private void txtNameCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "")
                gbNameCustomer.Text = "";
            else
                gbNameCustomer.Text = txtNameCustomer.PlaceholderText;
        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text == "")
                gbNumberPhone.Text = "";
            else
                gbNumberPhone.Text = txtNumberPhone.PlaceholderText;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
                gbAddress.Text = "";
            else
                gbAddress.Text = txtAddress.PlaceholderText;
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            if (txtGmail.Text == "")
                gbGmail.Text = "";
            else
                gbGmail.Text = txtGmail.PlaceholderText;
        }

        private void Form_EditCustomer_Load(object sender, EventArgs e)
        {
            var customer = connection.Customers.SingleOrDefault(p => p.IDCustomer == IDCustomer);
            lblText.Text = "";
            if (customer != null)
            {
                txtNameCustomer.Text = customer.FullName;
                txtNumberPhone.Text = customer.PhoneNumber;
                txtAddress.Text = customer.Address;
                txtGmail.Text = customer.Gmail;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var customer = connection.Customers.SingleOrDefault(p => p.IDCustomer == IDCustomer);
            DialogResult dr = MessageYesNo.Show("Bạn muốn xóa khách hàng nay?", "Thông Báo");
            if (dr == DialogResult.Yes)
            {
                var bill = customer.Bills.ToList();
                if (bill != null)
                {
                    foreach (var item in bill)
                    {
                        var detail = item.BillDetails.ToList();
                        foreach (var i in detail)
                        {
                            connection.BillDetails.Remove(i);
                        }
                        connection.Bills.Remove(item);
                    }
                }
                connection.Customers.Remove(customer);
                connection.SaveChanges();
                this.Close();
            }
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
                lblText.Text = "Nhập Số Điện Thoại !";
                return false;
            }
            if (!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$"))
            {
                lblText.Text = "Nhập Lại Gmail !";
                return false;
            }

            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = connection.Customers.SingleOrDefault(p => p.IDCustomer == IDCustomer);
            if (checkInput())
            {
                if (customer != null)
                {
                    customer.FullName = txtNameCustomer.Text;
                    customer.PhoneNumber = txtNumberPhone.Text;
                    customer.Address = txtAddress.Text;
                    customer.Gmail = txtGmail.Text;
                    connection.Customers.AddOrUpdate(customer);
                    connection.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
