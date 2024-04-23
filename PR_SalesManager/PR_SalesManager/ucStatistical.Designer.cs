namespace PR_SalesManager
{
    partial class ucStatistical
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chartYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMonth
            // 
            this.chartMonth.BackColor = System.Drawing.Color.Transparent;
            this.chartMonth.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartMonth.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartMonth.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.MaximumAutoSize = 25F;
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.AxisX2.MaximumAutoSize = 25F;
            chartArea7.AxisX2.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.AxisY.MaximumAutoSize = 25F;
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.AxisY2.MaximumAutoSize = 25F;
            chartArea7.AxisY2.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.BorderColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "DoanhThu";
            this.chartMonth.ChartAreas.Add(chartArea7);
            this.chartMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            legend7.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartMonth.Legends.Add(legend7);
            this.chartMonth.Location = new System.Drawing.Point(0, 0);
            this.chartMonth.Name = "chartMonth";
            this.chartMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartMonth.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))))};
            series7.BackSecondaryColor = System.Drawing.Color.Transparent;
            series7.BorderColor = System.Drawing.Color.Transparent;
            series7.ChartArea = "DoanhThu";
            series7.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsXValueIndexed = true;
            series7.Legend = "Legend1";
            series7.MarkerSize = 6;
            series7.Name = "Doanh Thu";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartMonth.Series.Add(series7);
            this.chartMonth.Size = new System.Drawing.Size(1185, 450);
            this.chartMonth.TabIndex = 0;
            title7.Font = new System.Drawing.Font("DVN-Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Doanh Thu";
            title7.Text = "BIỂU ĐỒ DOANH THU";
            this.chartMonth.Titles.Add(title7);
            // 
            // chartPie
            // 
            this.chartPie.BackColor = System.Drawing.Color.Transparent;
            this.chartPie.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisX2.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisY.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisY2.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.BorderColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea8);
            this.chartPie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            legend8.TitleFont = new System.Drawing.Font("DVN-Poppins ExtBd", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartPie.Legends.Add(legend8);
            this.chartPie.Location = new System.Drawing.Point(0, 0);
            this.chartPie.Name = "chartPie";
            this.chartPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series8.BackSecondaryColor = System.Drawing.Color.Transparent;
            series8.BorderColor = System.Drawing.Color.Transparent;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.CustomProperties = "PieLabelStyle=Outside, PieLineColor=Gainsboro";
            series8.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.Legend = "Legend1";
            series8.Name = "ChartProduct";
            this.chartPie.Series.Add(series8);
            this.chartPie.Size = new System.Drawing.Size(1185, 450);
            this.chartPie.TabIndex = 1;
            this.chartPie.Text = "chart1";
            title8.Font = new System.Drawing.Font("DVN-Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "SỐ LƯỢNG SẢN PHẨM BÁN RA";
            this.chartPie.Titles.Add(title8);
            // 
            // cmbSelect
            // 
            this.cmbSelect.BackColor = System.Drawing.Color.Transparent;
            this.cmbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.cmbSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.cmbSelect.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.cmbSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSelect.ItemHeight = 30;
            this.cmbSelect.Location = new System.Drawing.Point(1, 1);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(165, 36);
            this.cmbSelect.TabIndex = 6;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // chartYear
            // 
            this.chartYear.BackColor = System.Drawing.Color.Transparent;
            this.chartYear.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartYear.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartYear.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.MaximumAutoSize = 25F;
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisX2.MaximumAutoSize = 25F;
            chartArea9.AxisX2.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisY.MaximumAutoSize = 25F;
            chartArea9.AxisY.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisY2.MaximumAutoSize = 25F;
            chartArea9.AxisY2.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.BorderColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "DoanhThu";
            this.chartYear.ChartAreas.Add(chartArea9);
            this.chartYear.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend9.IsTextAutoFit = false;
            legend9.Name = "Legend1";
            legend9.TitleFont = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartYear.Legends.Add(legend9);
            this.chartYear.Location = new System.Drawing.Point(0, 0);
            this.chartYear.Name = "chartYear";
            this.chartYear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartYear.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))))};
            series9.BackSecondaryColor = System.Drawing.Color.Transparent;
            series9.BorderColor = System.Drawing.Color.Transparent;
            series9.ChartArea = "DoanhThu";
            series9.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsXValueIndexed = true;
            series9.Legend = "Legend1";
            series9.MarkerSize = 6;
            series9.Name = "Doanh Thu";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartYear.Series.Add(series9);
            this.chartYear.Size = new System.Drawing.Size(1185, 450);
            this.chartYear.TabIndex = 7;
            title9.Font = new System.Drawing.Font("DVN-Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.Name = "Doanh Thu";
            title9.Text = "BIỂU ĐỒ DOANH THU";
            this.chartYear.Titles.Add(title9);
            // 
            // ucStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.chartYear);
            this.Controls.Add(this.chartMonth);
            this.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucStatistical";
            this.Size = new System.Drawing.Size(1185, 450);
            this.Load += new System.EventHandler(this.ucStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYear;
    }
}
