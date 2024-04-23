using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_EditProduct : Form
    {
        DataConnection connection;
        LoadImage li;
        public int ID { get; set; }
        public Form_EditProduct(int ID)
        {
            InitializeComponent();
            connection = new DataConnection();
            this.ID = ID;
            li = new LoadImage();
        }

        public void FillCombobox(List<ProductType> listType)
        {
            cmbType.DataSource = listType;
            cmbType.ValueMember = "IDType";
            cmbType.DisplayMember = "NameType";
        }
        private void Form_EditProduct_Load(object sender, EventArgs e)
        {
            lblText.Text = "";
            var listType = connection.ProductTypes.ToList();
            FillCombobox(listType);
            var p = connection.Products.SingleOrDefault(i => i.IDProduct == ID);
            if (p != null)
            {
                txtNameProduct.Text = p.NameProduct;
                txtPrice.Text = p.Price.ToString();
                cmbType.Text = p.ProductType.NameType;
                num.Value = p.Amount;
                rtbDescribe.Text = p.Describe;
                picProduct.Image = li.ByteArrayToImage(p.Pic);
            }
            else
                this.Close();
        }

        public bool checkInput()
        {
            float price = 0f;
            if (txtNameProduct.Text.Trim() == "" || txtPrice.Text.Trim() == "" || rtbDescribe.Text.Trim() == "")
            {
                lblText.Text = "Không được để trống !";
                return false;
            }
            if (picProduct.Image == null)
            {
                lblText.Text = "Thêm ảnh cho sản phẩm !";
                return false;
            }
            if (cmbType.SelectedIndex == -1)
            {
                lblText.Text = "Chọn loại sản phẩm !";
                return false;
            }
            if (!float.TryParse(txtPrice.Text, out price))
                return false;
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var p = connection.Products.SingleOrDefault(i => i.IDProduct == ID);
            try
            {
                if (checkInput())
                {
                    if (p != null)
                    {
                        p.NameProduct = txtNameProduct.Text;
                        p.Price = float.Parse(txtPrice.Text);
                        p.IDType = int.Parse(cmbType.SelectedValue.ToString());
                        p.Amount = int.Parse(num.Value.ToString());
                        p.Describe = rtbDescribe.Text;
                        p.Pic = li.ImageToByteArray(picProduct.Image);
                        connection.Products.AddOrUpdate(p);
                        connection.SaveChanges();
                        this.Close();
                    }
                }
            }
            catch (FormatException) { }
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picProduct.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var p = connection.Products.SingleOrDefault(i => i.IDProduct == ID);
            if (p != null)
            {
                DialogResult dr = MessageYesNo.Show("Bạn muốn xóa sản phẩm?", "Thông Báo");
                if (dr == DialogResult.Yes)
                {
                    var detail = p.BillDetails.ToList();
                    if (detail != null)
                    {
                        foreach (var item in detail)
                        {
                            connection.BillDetails.Remove(item);
                        }
                    }
                    connection.Products.Remove(p);
                    connection.SaveChanges();

                    this.Close();
                }
            }
        }
    }
}
