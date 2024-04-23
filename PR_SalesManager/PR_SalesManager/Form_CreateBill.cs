using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_CreateBill : Form
    {
        DataConnection connection;
        public int IDAccount { get; set; }
        private string[] ID;
        BillDetail detail;
        List<BillDetail> lstDetail;
        Bill bill;
        public Form_CreateBill(int iDAccount)
        {
            InitializeComponent();
            this.IDAccount = iDAccount;
            connection = new DataConnection();
            bill = new Bill();
            lstDetail = new List<BillDetail>();
        }
        private void LoadDTGV(List<BillDetail> lst)
        {
            dtgvDetail.Rows.Clear();
            foreach (var item in lst)
            {
                int index = dtgvDetail.Rows.Add();
                dtgvDetail.Rows[index].Cells[0].Value = item.IDProduct;
                var checkName = connection.Products.SingleOrDefault(p => p.IDProduct == item.IDProduct);
                dtgvDetail.Rows[index].Cells[1].Value = checkName.NameProduct;
                dtgvDetail.Rows[index].Cells[2].Value = item.Amount;
                dtgvDetail.Rows[index].Cells[3].Value = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(item.Price.ToString()));
            }
        }
        private void reload()
        {
            LoadDTGV(lstDetail);
            FillComboboxProduct();
        }
        private void refesh()
        {
            txtPrice.Clear();
            num.Value = 1;
        }
        private void FillComboboxCustomer()
        {
            var lst = connection.Customers.ToList();
            cmbCustomer.Items.Clear();
            foreach (var item in lst)
            {
                cmbCustomer.Items.Add(item.IDCustomer + " - " + item.FullName);
            }
        }
        private void FillComboboxProduct()
        {
            var lst = connection.Products.ToList();
            cmbProduct.Items.Clear();
            foreach (var item in lst)
            {
                if (item.Amount == 0) continue;
                cmbProduct.Items.Add(item.IDProduct + " - " + item.NameProduct + " - " + item.Amount);
            }
        }
        private void Form_CreateBill_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString();
            var acc = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (acc != null)
            {
                txtNameStaff.Text = acc.IDStaff + " - " + acc.FullName;
            }
            FillComboboxCustomer();
            FillComboboxProduct();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = cmbProduct.SelectedItem.ToString().Split('-');
            int IDProduct = int.Parse(ID[0].Trim());
            var p = connection.Products.SingleOrDefault(i => i.IDProduct == IDProduct);
            num.Maximum = p.Amount;
            txtPrice.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(p.Price.ToString()));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkAdd = true;
                int amount = int.Parse(num.Value.ToString());
                if (cmbProduct.SelectedIndex == -1)
                {
                    MessageOK.Show("Chưa có sản phẩm", "Thông Báo");
                    return;
                }
                if (num.Value == 0)
                {
                    MessageOK.Show("Nhập số lượng", "Thông Báo");
                    return;
                }
                //Lấy ID sản phẩm
                ID = cmbProduct.SelectedItem.ToString().Split('-');
                //Lấy số lượng sản phẩm
                int checkAmount = int.Parse(ID[2].Trim());
                if (amount > checkAmount)
                {
                    MessageOK.Show("Quá số lượng đang có", "Thông Báo");
                    return;
                }
                if (amount <= 0)
                {
                    MessageOK.Show("Nhập lại số lượng cần mua", "Thông Báo");
                    return;
                }

                //Lấy mã sản phẩm
                int IDProduct = int.Parse(ID[0].Trim());
                var product = connection.Products.SingleOrDefault(i => i.IDProduct == IDProduct);
                double price = product.Price;
                foreach (var item in lstDetail)
                {
                    if (IDProduct == item.IDProduct)
                    {
                        item.Amount += amount;
                        item.Price = price * item.Amount;
                        checkAdd = false;
                    }
                }
                if (checkAdd)
                {
                    detail = new BillDetail()
                    {
                        IDBill = bill.IDBill,
                        IDProduct = IDProduct,
                        Amount = amount,
                        Price = price * amount,
                    };
                    lstDetail.Add(detail);
                }
            }
            catch (FormatException) { }
            var total = lstDetail.Sum(p => p.Price);
            lblTotal.Text = "THÀNH TIỀN: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(total.ToString())) + " VNĐ";
            reload();
            refesh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.dtgvDetail.SelectedRows.Count > 0)
            {
                lstDetail.RemoveAt(this.dtgvDetail.SelectedRows[0].Index);
                var total = lstDetail.Sum(p => p.Price);
                lblTotal.Text = "THÀNH TIỀN: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(total.ToString())) + " VNĐ";
                reload();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (this.dtgvDetail.SelectedRows.Count > 0)
            {
                var lstProduct = connection.Products.ToList();
                foreach (var item in lstProduct)
                {
                    var temp = lstDetail.Where(p => p.IDProduct == item.IDProduct).ToList();
                    var sum = temp.Sum(p => p.Amount);
                    if (sum > item.Amount)
                    {
                        MessageOK.Show("Kiểm Tra Lại Số Lượng", "Thông Báo");
                        return;
                    }
                    else
                    {
                        item.Amount -= sum;
                        connection.Products.AddOrUpdate(item);
                    }
                }
                if (cmbCustomer.SelectedIndex != -1)
                {
                    ID = cmbCustomer.SelectedItem.ToString().Split('-');
                    int IDCustomer = int.Parse(ID[0].Trim());

                    bill.IDStaff = IDAccount;
                    bill.IDCustomer = IDCustomer;
                    bill.DatePay = DateTime.Now;
                    bill.TotalPrice = lstDetail.Sum(p => p.Price);

                    foreach (var item in lstDetail)
                    {
                        connection.BillDetails.Add(item);
                    }
                    connection.Bills.Add(bill);
                    connection.SaveChanges();
                    this.Close();
                }
                else MessageOK.Show("Chọn Khách Hàng", "Thông Báo");
            }
            else MessageOK.Show("Không Có Sản Phẩm", "Thông Báo");
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            if (num.Value > num.Maximum)
            {
                num.Value = num.Maximum;
            }
        }
    }
}
