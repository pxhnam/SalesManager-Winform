using PR_SalesManager.Model;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_ShowProduct : Form
    {
        DataConnection connection;

        LoadImage li;
        public int ID { get; set; }
        public Form_ShowProduct(int ID)
        {
            InitializeComponent();
            connection = new DataConnection();
            this.ID = ID;
            li = new LoadImage();
        }

        private void Form_ShowProduct_Load(object sender, System.EventArgs e)
        {
            var p = connection.Products.SingleOrDefault(i => i.IDProduct == ID);
            if (p != null)
            {
                textName.Text = p.NameProduct;
                textPrice.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(p.Price.ToString())) + " VNĐ";
                textType.Text = p.ProductType.NameType;
                textAmount.Text = p.Amount.ToString();
                rtbDes.Text = p.Describe;
                picProduct.Image = li.ByteArrayToImage(p.Pic);
            }
        }
    }
}
