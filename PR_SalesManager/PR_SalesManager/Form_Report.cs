using Microsoft.Reporting.WinForms;
using PR_SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PR_SalesManager
{
    public partial class Form_Report : Form
    {
        DataConnection connection;
        public int ID { get; set; }
        public Form_Report(int ID)
        {
            InitializeComponent();
            connection = new DataConnection();
            this.ID = ID;
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            var infor = connection.Bills.SingleOrDefault(p => p.IDBill == ID);
            List<BillDetail> billDetails = connection.BillDetails.Where(p => p.IDBill == ID).ToList();
            List<ListBill> listBill = new List<ListBill>();
            foreach (var item in billDetails)
            {
                ListBill bill = new ListBill();
                bill.ID = item.IDProduct;
                bill.Name = item.Product.NameProduct;
                bill.Amount = item.Amount;
                //bill.Price = (float)item.Product.Price;
                bill.Total = (float)item.Price;
                listBill.Add(bill);
            }
            rptViewer.LocalReport.ReportPath = "rptBill.rdlc";
            var source = new ReportDataSource("BillDataSet", listBill);
            var TenKhachHang = new ReportParameter("TenKhachHang", infor.Customer.FullName);
            var SoDienThoai = new ReportParameter("SoDienThoai", infor.Customer.PhoneNumber);
            var DiaChi = new ReportParameter("DiaChi", infor.Customer.Address);
            var TongTien = new ReportParameter("TongTien", string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(infor.TotalPrice.ToString())));
            DateTime dt = infor.DatePay;
            var NgayLap = new ReportParameter("NgayLap", dt.ToString("dd/MM/yyyy"));
            var MaHoaDon = new ReportParameter("MaHoaDon", infor.IDBill.ToString());

            this.rptViewer.LocalReport.SetParameters(TenKhachHang);
            this.rptViewer.LocalReport.SetParameters(SoDienThoai);
            this.rptViewer.LocalReport.SetParameters(DiaChi);
            this.rptViewer.LocalReport.SetParameters(TongTien);
            this.rptViewer.LocalReport.SetParameters(NgayLap);
            this.rptViewer.LocalReport.SetParameters(MaHoaDon);
            this.rptViewer.LocalReport.DataSources.Clear();
            this.rptViewer.LocalReport.DataSources.Add(source);
            this.rptViewer.RefreshReport();
        }
    }
}
