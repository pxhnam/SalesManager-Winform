using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_InforBill : Form
    {
        public int IDBill { get; set; }
        public int IDAccount { get; set; }
        DataConnection connection;
        public Form_InforBill(int ID)
        {
            InitializeComponent();
            IDAccount = ID;
            connection = new DataConnection();
        }
        private void LoadData(List<BillDetail> lst)
        {
            dtgvInforBill.Rows.Clear();
            foreach (var item in lst)
            {
                int index = dtgvInforBill.Rows.Add();
                dtgvInforBill.Rows[index].Cells[0].Value = item.IDProduct;
                dtgvInforBill.Rows[index].Cells[1].Value = item.Product.NameProduct;
                dtgvInforBill.Rows[index].Cells[2].Value = item.Amount;
                dtgvInforBill.Rows[index].Cells[3].Value = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(item.Price.ToString()));
            }
        }
        private void Form_InforBill_Load(object sender, EventArgs e)
        {
            var checkPos = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (checkPos.Type != 1)
            {
                btnDelete.Visible = false;
                btnExport.Dock = DockStyle.Fill;
            }
            var bill = connection.Bills.SingleOrDefault(p => p.IDBill == IDBill);
            textIDBill.Text = IDBill.ToString();
            DateTime dt = bill.DatePay;
            textDate.Text = dt.ToString("dd/MM/yyyy");
            txtNameStaff.Text = bill.IDStaff == null ? "Không Tồn Tại" : bill.IDStaff + " - " + bill.Staff.FullName;
            txtCustomer.Text = bill.IDCustomer + " - " + bill.Customer.FullName;
            LoadData(bill.BillDetails.ToList());
            textTotal.Text = "THÀNH TIỀN: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(bill.TotalPrice.ToString())) + " VNĐ";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Form_Report report = new Form_Report(IDBill);
            report.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var bill = connection.Bills.SingleOrDefault(p => p.IDBill == IDBill);
            DialogResult dr = MessageYesNo.Show("Bạn Muốn Xóa Hóa Đơn Này ?", "Thông Báo");
            if (dr == DialogResult.Yes)
            {
                var detail = bill.BillDetails.ToList();
                foreach (var item in detail)
                {
                    connection.BillDetails.Remove(item);
                }
                connection.Bills.Remove(bill);
                connection.SaveChanges();
                this.Close();
            }
        }
    }
}
