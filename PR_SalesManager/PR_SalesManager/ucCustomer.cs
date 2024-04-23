using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class ucCustomer : UserControl
    {
        DataConnection connection;
        public int IDAccount { get; set; }
        public ucCustomer(int IDAccount)
        {
            InitializeComponent();
            this.IDAccount = IDAccount;
        }
        private void AddCombobox()
        {
            cmbFilter.Items.Add("Mã Khách Hàng");
            cmbFilter.Items.Add("Tên Khách Hàng");
            cmbFilter.Items.Add("Số Điện Thoại");
            cmbFilter.Items.Add("Địa Chỉ");
            cmbFilter.Items.Add("Gmail");
            cmbFilter.SelectedIndex = 1;
        }
        private void LoadData(List<Customer> lst)
        {
            dtgvCustomer.Rows.Clear();
            foreach (var item in lst)
            {
                int index = dtgvCustomer.Rows.Add();
                dtgvCustomer.Rows[index].Cells[0].Value = item.IDCustomer;
                dtgvCustomer.Rows[index].Cells[1].Value = item.FullName;
                dtgvCustomer.Rows[index].Cells[2].Value = item.PhoneNumber;
                dtgvCustomer.Rows[index].Cells[3].Value = item.Address;
                dtgvCustomer.Rows[index].Cells[4].Value = item.Gmail;
            }
        }
        private void reload()
        {
            connection = new DataConnection();
            var lst = connection.Customers.ToList();
            LoadData(lst);
        }
        private void ucCustomer_Load(object sender, EventArgs e)
        {
            AddCombobox();
            reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddCustomer fAdd = new Form_AddCustomer();
            fAdd.FormClosing += FAdd_FormClosing;
            fAdd.ShowDialog();
        }

        private void FAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        private void dtgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var checkPos = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (checkPos.Type == 1)
            {
                int IDCustomer = int.Parse(dtgvCustomer[0, dtgvCustomer.CurrentRow.Index].Value.ToString());
                Form_EditCustomer fEdit = new Form_EditCustomer(IDCustomer);
                fEdit.FormClosing += FEdit_FormClosing;
                fEdit.ShowDialog();
            }
        }

        private void FEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }
        private void filter()
        {
            connection = new DataConnection();
            var find = connection.Customers.ToList();
            if (cmbFilter.SelectedIndex == 0)
            {
                find = find.Where(p => p.IDCustomer.ToString().Contains(txtSearch.Text)).ToList();
            }
            if (cmbFilter.SelectedIndex == 1)
            {
                find = find.Where(p => p.FullName.Contains(txtSearch.Text)).ToList();
            }
            if (cmbFilter.SelectedIndex == 2)
            {
                find = find.Where(p => p.PhoneNumber.Contains(txtSearch.Text)).ToList();
            }
            if (cmbFilter.SelectedIndex == 3)
            {
                find = find.Where(p => p.Address.Contains(txtSearch.Text)).ToList();
            }
            if (cmbFilter.SelectedIndex == 4)
            {
                find = find.Where(p => p.Gmail.Contains(txtSearch.Text)).ToList();
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
    }
}
