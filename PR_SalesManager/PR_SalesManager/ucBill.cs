using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class ucBill : UserControl
    {
        public int IDAccount { get; set; }
        DataConnection connection;
        public ucBill(int IDAccount)
        {
            InitializeComponent();
            this.IDAccount = IDAccount;
        }
        private void LoadData(List<Bill> lst)
        {
            dtgvBill.Rows.Clear();
            foreach (var item in lst)
            {
                int index = dtgvBill.Rows.Add();
                dtgvBill.Rows[index].Cells[0].Value = item.IDBill;
                dtgvBill.Rows[index].Cells[1].Value = item.Customer.FullName;
                DateTime dt = item.DatePay;
                dtgvBill.Rows[index].Cells[2].Value = dt.ToString("dd/MM/yyyy");
                dtgvBill.Rows[index].Cells[3].Value = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(item.TotalPrice.ToString()));
            }
        }
        private void FillCombobox()
        {
            cmbFilter.Items.Add("Mã Hóa Đơn");
            cmbFilter.Items.Add("Tên Khách Hàng");
            cmbFilter.Items.Add("Ngày");
            cmbFilter.SelectedIndex = 1;
        }
        private void reload()
        {
            connection = new DataConnection();
            var lst = connection.Bills.ToList();
            LoadData(lst);
        }
        private void ucBill_Load(object sender, EventArgs e)
        {
            reload();
            FillCombobox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_CreateBill fCreate = new Form_CreateBill(IDAccount);
            fCreate.FormClosing += FCreate_FormClosing;
            fCreate.ShowDialog();
        }

        private void FCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }
        private void filter()
        {
            connection = new DataConnection();
            var find = connection.Bills.ToList();
            if (cmbFilter.SelectedIndex == 0)
            {
                find = connection.Bills.Where(p => p.IDBill.ToString().Contains(txtSearch.Text)).ToList();
            }
            if (cmbFilter.SelectedIndex == 1)
            {
                find = connection.Bills.Where(p => p.Customer.FullName.Contains(txtSearch.Text)).ToList();
            }
            if (cmbFilter.SelectedIndex == 2)
            {
                find = connection.Bills.Where(p => p.DatePay.ToString().Contains(txtSearch.Text)).ToList();
            }
            LoadData(find);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }
        private void dtgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IDBill = int.Parse(dtgvBill[0, dtgvBill.CurrentRow.Index].Value.ToString());
            Form_InforBill fInfor = new Form_InforBill(IDAccount);
            fInfor.IDBill = IDBill;
            fInfor.FormClosing += FInfor_FormClosing;
            fInfor.ShowDialog();
        }

        private void FInfor_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }
    }
}
