using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_AddProduct : Form
    {
        DataConnection connection;
        LoadImage li;
        public Form_AddProduct()
        {
            InitializeComponent();
            connection = new DataConnection();
            li = new LoadImage();
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
            if (picProduct.Image != null)
            {
                addImage.Visible = false;
            }
        }

        public void FillCombobox(List<ProductType> type)
        {
            cmbType.DataSource = type;
            cmbType.ValueMember = "IDType";
            cmbType.DisplayMember = "NameType";
            cmbType.SelectedIndex = -1;
        }
        private void Form_AddProduct_Load(object sender, EventArgs e)
        {
            var type = connection.ProductTypes.ToList();
            lblText.Text = "";
            FillCombobox(type);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput())
                {
                    Product p = new Product
                    {
                        Pic = li.ImageToByteArray(picProduct.Image),
                        NameProduct = txtNameProduct.Text,
                        Price = float.Parse(txtPrice.Text),
                        IDType = int.Parse(cmbType.SelectedValue.ToString()),
                        Amount = int.Parse(num.Value.ToString()),
                        Describe = rtbDescribe.Text,
                    };
                    connection.Products.Add(p);
                    connection.SaveChanges();
                    this.Close();
                }
            }
            catch (FormatException) { }
        }
    }
}
