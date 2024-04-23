using PR_SalesManager.Model;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class ucItem : UserControl
    {
        DataConnection connection;
        public int IDAccount { get; set; }
        public int ID { get; set; }
        public string Name
        {
            get { return textName.Text; }
            set { textName.Text = value; }
        }
        public string Price
        {
            get { return textPrice.Text; }
            set { textPrice.Text = value; }
        }
        public Image Img
        {
            get { return Pic.Image; }
            set { Pic.Image = value; }
        }
        public ucItem(int ID)
        {
            InitializeComponent();
            connection = new DataConnection();
            this.ID = ID;
        }

        private void btnShow_Click(object sender, System.EventArgs e)
        {
            var checkPos = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (checkPos.Type == 1)
            {
                Form_EditProduct fEdit = new Form_EditProduct(ID);
                fEdit.ShowDialog();
            }
            else
            {
                Form_ShowProduct fShow = new Form_ShowProduct(ID);
                fShow.ShowDialog();
            }
        }
    }
}
