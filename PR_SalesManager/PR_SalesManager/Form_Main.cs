using PR_SalesManager.Model;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_Main : Form
    {
        private DataConnection connection;
        public bool isExit = true;
        public event EventHandler Logout;
        public int IDAccount;
        public Form_Main()
        {
            InitializeComponent();
        }
        private void DangXuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }
        private void ShowControl(UserControl uc)
        {
            if (uc != null)
            {
                uc.Hide();
            }
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            panelMain.Tag = uc;
            uc.BringToFront();
            uc.Show();
        }
        private void ShowProfile(Staff s)
        {
            var checkBill = s.Bills.Count();
            lblNumberBill.Text = checkBill.ToString();

            var checkBillDetails = s.Bills.ToList();
            var sum = 0;
            foreach (var item in checkBillDetails)
            {
                var checkM = item.BillDetails.Sum(p => p.Amount);
                sum += checkM;
            }
            lblNumberProduct.Text = sum.ToString();

            var checkMoney = s.Bills.Sum(p => p.TotalPrice);
            lblNumberMoney.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(checkMoney.ToString())) + " VNĐ";

            lblHi.Text = "Xin Chào, " + s.FullName;
        }
        public void reload()
        {
            connection = new DataConnection();
            var info = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            ShowProfile(info);
        }
        public void Form_Main_Load(object sender, EventArgs e)
        {
            connection = new DataConnection();
            var check = connection.Staffs.SingleOrDefault(p => p.IDStaff == IDAccount);
            if (check.Type == 0)
            {
                lblStatistical.Visible = false;
                lblManager.Visible = false;
            }
            lblProd_Click(this, new EventArgs());
            tip.SetToolTip(btnEdit, "Chỉnh sửa thông tin cá nhân");
        }

        private void lblProd_Click(object sender, EventArgs e)
        {
            reload();
            ShowControl(new ucProduct(IDAccount));
            Line.Width = 0;
            timerProduct.Start();
        }
        private void lblBill_Click(object sender, EventArgs e)
        {
            reload();
            ShowControl(new ucBill(IDAccount));
            Line.Width = 0;
            timerBill.Start();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            reload();
            ShowControl(new ucCustomer(IDAccount));
            Line.Width = 0;
            timerCustomer.Start();
        }
        private void lblStatistical_Click(object sender, EventArgs e)
        {
            reload();
            ShowControl(new ucStatistical());
            Line.Width = 0;
            timerStatistical.Start();
        }
        private void lblManager_Click(object sender, EventArgs e)
        {
            reload();
            ShowControl(new ucManager(IDAccount));
            Line.Width = 0;
            timerManager.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form_EditAccount editAccount = new Form_EditAccount();
            editAccount.IDAccount = IDAccount;
            editAccount.FormClosing += EditAccount_FormClosing;
            editAccount.ShowDialog();
        }

        private void EditAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            reload();
        }

        private void timerProduct_Tick(object sender, EventArgs e)
        {
            Line.Width += 10;
            if (Line.Width >= lblProd.Width)
            {
                timerProduct.Stop();
            }
            if (Line.Width >= lblProd.Width)
            {
                Line.Width = lblProd.Width;
            }
            Line.Left = lblProd.Left;
        }

        private void timerBill_Tick(object sender, EventArgs e)
        {
            Line.Width += 10;
            if (Line.Width >= lblBill.Width)
            {
                timerBill.Stop();
            }
            if (Line.Width >= lblBill.Width)
            {
                Line.Width = lblBill.Width;
            }
            Line.Left = lblBill.Left;
        }

        private void timerCustomer_Tick(object sender, EventArgs e)
        {
            Line.Width += 10;
            if (Line.Width >= lblCustomer.Width)
            {
                timerCustomer.Stop();
            }
            if (Line.Width >= lblCustomer.Width)
            {
                Line.Width = lblCustomer.Width;
            }
            Line.Left = lblCustomer.Left;
        }

        private void timerStatistical_Tick(object sender, EventArgs e)
        {
            Line.Width += 10;
            if (Line.Width >= lblStatistical.Width)
            {
                timerStatistical.Stop();
            }
            if (Line.Width >= lblStatistical.Width)
            {
                Line.Width = lblStatistical.Width;
            }
            Line.Left = lblStatistical.Left;
        }

        private void timerManager_Tick(object sender, EventArgs e)
        {
            Line.Width += 10;
            if (Line.Width >= lblManager.Width)
            {
                timerManager.Stop();
            }
            if (Line.Width >= lblManager.Width)
            {
                Line.Width = lblManager.Width;
            }
            Line.Left = lblManager.Left;
        }
    }
}
