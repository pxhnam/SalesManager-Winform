using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class ucManager : UserControl
    {
        DataConnection connection;
        public int IDLog { get; set; }
        public ucManager(int IDLog)
        {
            InitializeComponent();
            this.IDLog = IDLog;
        }
        private void FillCombobox()
        {
            cmbFilter.Items.Add("Tài Khoản");
            cmbFilter.Items.Add("Họ Và Tên");
            cmbFilter.Items.Add("Số Điện Thoại");
            cmbFilter.Items.Add("Địa Chỉ");
            cmbFilter.Items.Add("Gmail");
            cmbFilter.SelectedIndex = 1;
        }
        private void LoadData(List<Staff> lst)
        {
            dtgvStaff.Rows.Clear();
            foreach (var item in lst)
            {
                int index = dtgvStaff.Rows.Add();
                dtgvStaff.Rows[index].Cells[0].Value = item.IDStaff;
                dtgvStaff.Rows[index].Cells[1].Value = item.Account;
                dtgvStaff.Rows[index].Cells[2].Value = item.FullName;
                dtgvStaff.Rows[index].Cells[3].Value = item.PhoneNumber;
                DateTime dt = item.DateOfBirth;
                dtgvStaff.Rows[index].Cells[4].Value = dt.ToString("dd/MM/yyyy");
                dtgvStaff.Rows[index].Cells[5].Value = item.Address;
                dtgvStaff.Rows[index].Cells[6].Value = item.Gmail;
            }
        }
        private void reload()
        {
            connection = new DataConnection();
            var lst = connection.Staffs.ToList();
            LoadData(lst);
        }
        private void ucManager_Load(object sender, EventArgs e)
        {
            reload();
            FillCombobox();
        }

        private void dtgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dtgvStaff[0, dtgvStaff.CurrentRow.Index].Value.ToString());
            Form_EditStaff fEdit = new Form_EditStaff(ID);
            fEdit.IDLog = IDLog;
            fEdit.FormClosing += FEdit_FormClosing;
            fEdit.ShowDialog();
        }

        private void FEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }
        private void filter()
        {
            connection = new DataConnection();
            var find = connection.Staffs.ToList();
            if (cmbFilter.SelectedIndex == 0)
            {
                find = find.Where(p => p.Account.Contains(txtSearch.Text)).ToList();
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
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
