using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class ucProduct : UserControl
    {
        DataConnection connection;
        public int IDAccount { get; set; }
        LoadImage li;
        public ucProduct(int IDAccount)
        {
            this.IDAccount = IDAccount;
            InitializeComponent();
            //connection = new DataConnection();
            li = new LoadImage();
        }
        public void FillCombobox()
        {
            connection = new DataConnection();
            cmbFilter.Items.Add("Tất Cả");
            var type = connection.ProductTypes.ToList();
            foreach (var item in type)
            {
                cmbFilter.Items.Add(item.NameType);
            }
            cmbFilter.SelectedIndex = 0;
        }
        private void LoadData(List<Product> list)
        {
            ucItem item;
            flpMain.Controls.Clear();
            foreach (var i in list)
            {
                item = new ucItem(i.IDProduct);
                if (i.Amount == 0)
                {
                    item.SoldOut.Visible = true;
                }
                item.IDAccount = IDAccount;
                item.Name = i.NameProduct;
                item.Price = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(i.Price.ToString())) + " VNĐ";
                item.Img = li.ByteArrayToImage(i.Pic);
                item.btnShow.Click += BtnShow_Click;
                flpMain.Controls.Add(item);
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            connection = new DataConnection();
            var checkPos = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (checkPos.Type == 1)
            {
                reload();
            }
        }

        private void reload()
        {
            connection = new DataConnection();
            var listProduct = connection.Products.ToList();
            LoadData(listProduct);
        }
        private void ucProduct_Load(object sender, EventArgs e)
        {
            FillCombobox();
            reload();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddProduct addProduct = new Form_AddProduct();
            addProduct.FormClosing += AddProduct_FormClosing;
            addProduct.ShowDialog();
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }
        private void filter()
        {
            connection = new DataConnection();
            var list = connection.Products.ToList();
            if (cmbFilter.SelectedIndex == 0)
            {
                list = list.Where(p => p.NameProduct.Contains(txtSearch.Text)).ToList();
            }
            else
            {
                for (int i = 1; i < cmbFilter.Items.Count; i++)
                {
                    if (cmbFilter.SelectedIndex == i)
                    {
                        list = list.Where(p => p.IDType == i && p.NameProduct.Contains(txtSearch.Text)).ToList();
                    }
                }
            }
            LoadData(list);
            if (list.Count == 0)
            {
                lblShowNull.Visible = true;
                flpMain.Controls.Add(lblShowNull);
            }
            else lblShowNull.Visible = false;
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
