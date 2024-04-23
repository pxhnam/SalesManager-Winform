using PR_SalesManager.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PR_SalesManager
{
    public partial class ucStatistical : UserControl
    {
        DataConnection connection;
        public ucStatistical()
        {
            InitializeComponent();
            connection = new DataConnection();
        }
        private void fillcmb()
        {
            cmbSelect.Items.Add("Tổng Quan");
            cmbSelect.Items.Add("Doanh Thu Tháng");
            cmbSelect.Items.Add("Doanh Thu Năm");
            cmbSelect.SelectedIndex = 0;
        }
        private void showChartPie()
        {
            var lst = connection.Products.ToList();

            foreach (var item in lst)
            {
                var sum = item.BillDetails.Sum(p => p.Amount);
                if (sum == 0) continue;
                chartPie.Series[0].Points.AddXY(item.NameProduct, sum);
            }
            //
            chartPie.Series[0].ToolTip = "#VALX: #VALY";
            chartPie.Series[0].Label = "#VALY (#PERCENT)";
            chartPie.Series[0].LegendText = "#VALX";
            chartPie.Legends["Legend1"].Docking = Docking.Bottom;
            chartPie.Legends["Legend1"].IsDockedInsideChartArea = false;
        }
        private void showChartMonth()
        {
            chartMonth.Titles[0].Text = "Biểu Đồ Doanh Thu Tháng " + DateTime.Now.Month + "/" + DateTime.Now.Year;
            int day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            chartMonth.ChartAreas[0].AxisX.Interval = 1;
            chartMonth.ChartAreas[0].AxisX.Title = "Ngày";
            chartMonth.ChartAreas[0].AxisY.Title = "Doanh Thu";
            for (int i = 1; i <= day; i++)
            {
                var checkDay = connection.Bills.Where(p => p.DatePay.Day == i && p.DatePay.Month == DateTime.Now.Month && p.DatePay.Year == DateTime.Now.Year).ToList();
                var bill = checkDay.Sum(p => p.TotalPrice);
                chartMonth.Series["Doanh Thu"].Points.AddXY(i, bill);
            }
            chartMonth.Series[0].ToolTip = "#VALY";
        }
        private void showChartYear()
        {
            chartYear.Titles[0].Text = "Biểu Đồ Doanh Thu Năm " + DateTime.Now.Year;
            chartYear.ChartAreas[0].AxisX.Interval = 1;
            chartYear.ChartAreas[0].AxisX.Title = "Tháng";
            chartYear.ChartAreas[0].AxisY.Title = "Doanh Thu";
            for (int i = 1; i <= 12; i++)
            {
                var checkDay = connection.Bills.Where(p => p.DatePay.Month == i && p.DatePay.Year == DateTime.Now.Year).ToList();
                var bill = checkDay.Sum(p => p.TotalPrice);
                chartYear.Series["Doanh Thu"].Points.AddXY(i, bill);
            }
            chartYear.Series[0].ToolTip = "#VALY";
        }
        private void ucStatistical_Load(object sender, EventArgs e)
        {
            fillcmb();
            showChartPie();
            showChartMonth();
            showChartYear();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.SelectedIndex == 0)
            {
                chartPie.BringToFront();
            }
            if (cmbSelect.SelectedIndex == 1)
            {
                chartMonth.BringToFront();
            }
            if (cmbSelect.SelectedIndex == 2)
            {
                chartYear.BringToFront();
            }
            cmbSelect.BringToFront();
        }
    }
}
