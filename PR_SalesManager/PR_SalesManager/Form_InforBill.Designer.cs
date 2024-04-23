namespace PR_SalesManager
{
    partial class Form_InforBill
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.textTotal = new System.Windows.Forms.Label();
            this.dtgvInforBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNameCustomer = new System.Windows.Forms.GroupBox();
            this.txtNameStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.textIDBill = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.textDate = new System.Windows.Forms.Label();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelButton = new System.Windows.Forms.Panel();
            this.MessageYesNo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforBill)).BeginInit();
            this.gbNameCustomer.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.AnimationInterval = 200;
            this.BorderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.BorderlessForm.BorderRadius = 20;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(556, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 32;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(604, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 31;
            // 
            // textTotal
            // 
            this.textTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTotal.AutoSize = true;
            this.textTotal.BackColor = System.Drawing.Color.White;
            this.textTotal.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(38, 503);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(145, 36);
            this.textTotal.TabIndex = 52;
            this.textTotal.Text = "THÀNH TIỀN: ";
            this.textTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvInforBill
            // 
            this.dtgvInforBill.AllowUserToAddRows = false;
            this.dtgvInforBill.AllowUserToDeleteRows = false;
            this.dtgvInforBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvInforBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInforBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvInforBill.ColumnHeadersHeight = 25;
            this.dtgvInforBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInforBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInforBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvInforBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInforBill.Location = new System.Drawing.Point(43, 205);
            this.dtgvInforBill.Name = "dtgvInforBill";
            this.dtgvInforBill.ReadOnly = true;
            this.dtgvInforBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInforBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvInforBill.RowHeadersVisible = false;
            this.dtgvInforBill.RowTemplate.Height = 25;
            this.dtgvInforBill.Size = new System.Drawing.Size(590, 290);
            this.dtgvInforBill.TabIndex = 0;
            this.dtgvInforBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInforBill.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtgvInforBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtgvInforBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInforBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvInforBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInforBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInforBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dtgvInforBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvInforBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInforBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvInforBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInforBill.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgvInforBill.ThemeStyle.ReadOnly = true;
            this.dtgvInforBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInforBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInforBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInforBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvInforBill.ThemeStyle.RowsStyle.Height = 25;
            this.dtgvInforBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInforBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // gbNameCustomer
            // 
            this.gbNameCustomer.Controls.Add(this.txtNameStaff);
            this.gbNameCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.gbNameCustomer.Location = new System.Drawing.Point(42, 137);
            this.gbNameCustomer.Name = "gbNameCustomer";
            this.gbNameCustomer.Size = new System.Drawing.Size(257, 56);
            this.gbNameCustomer.TabIndex = 42;
            this.gbNameCustomer.TabStop = false;
            this.gbNameCustomer.Text = "Nhân Viên";
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.BorderThickness = 0;
            this.txtNameStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameStaff.DefaultText = "";
            this.txtNameStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameStaff.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtNameStaff.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtNameStaff.ForeColor = System.Drawing.Color.Black;
            this.txtNameStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtNameStaff.Location = new System.Drawing.Point(1, 17);
            this.txtNameStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.PasswordChar = '\0';
            this.txtNameStaff.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNameStaff.PlaceholderText = "";
            this.txtNameStaff.ReadOnly = true;
            this.txtNameStaff.SelectedText = "";
            this.txtNameStaff.Size = new System.Drawing.Size(255, 35);
            this.txtNameStaff.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(175, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 48);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "THÔNG TIN HÓA ĐƠN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.Animated = true;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.Black;
            this.btnExport.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(343, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(156, 39);
            this.btnExport.TabIndex = 53;
            this.btnExport.Text = "XUẤT HÓA ĐƠN";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(55, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 39);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "XÓA HÓA ĐƠN";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textIDBill
            // 
            this.textIDBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textIDBill.BackColor = System.Drawing.Color.White;
            this.textIDBill.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDBill.Location = new System.Drawing.Point(0, 71);
            this.textIDBill.Name = "textIDBill";
            this.textIDBill.Size = new System.Drawing.Size(650, 30);
            this.textIDBill.TabIndex = 55;
            this.textIDBill.Text = "MÃ HÓA ĐƠN";
            this.textIDBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.txtCustomer);
            this.gbCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.ForeColor = System.Drawing.Color.Black;
            this.gbCustomer.Location = new System.Drawing.Point(356, 137);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(257, 56);
            this.gbCustomer.TabIndex = 43;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Khách Hàng";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BorderThickness = 0;
            this.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomer.DefaultText = "";
            this.txtCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtCustomer.Location = new System.Drawing.Point(1, 18);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCustomer.PlaceholderText = "";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.Size = new System.Drawing.Size(255, 35);
            this.txtCustomer.TabIndex = 0;
            // 
            // textDate
            // 
            this.textDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDate.BackColor = System.Drawing.Color.White;
            this.textDate.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDate.Location = new System.Drawing.Point(0, 101);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(650, 28);
            this.textDate.TabIndex = 56;
            this.textDate.Text = "NGÀY";
            this.textDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl1
            // 
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.TargetControl = this.lblTitle;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.textIDBill;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // DragControl3
            // 
            this.DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl3.TargetControl = this.textDate;
            this.DragControl3.UseTransparentDrag = true;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnDelete);
            this.panelButton.Controls.Add(this.btnExport);
            this.panelButton.Location = new System.Drawing.Point(40, 552);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(571, 39);
            this.panelButton.TabIndex = 57;
            // 
            // MessageYesNo
            // 
            this.MessageYesNo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.MessageYesNo.Caption = null;
            this.MessageYesNo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MessageYesNo.Parent = null;
            this.MessageYesNo.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageYesNo.Text = null;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(613, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 482);
            this.panel1.TabIndex = 58;
            // 
            // DragControl4
            // 
            this.DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl4.TargetControl = this.panel1;
            this.DragControl4.UseTransparentDrag = true;
            // 
            // Form_InforBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvInforBill);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.textIDBill);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.gbNameCustomer);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_InforBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_InforBill";
            this.Load += new System.EventHandler(this.Form_InforBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforBill)).EndInit();
            this.gbNameCustomer.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label textTotal;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvInforBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.GroupBox gbNameCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtNameStaff;
        private System.Windows.Forms.Label textDate;
        private System.Windows.Forms.GroupBox gbCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomer;
        private System.Windows.Forms.Label textIDBill;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl3;
        private System.Windows.Forms.Panel panelButton;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageYesNo;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl4;
    }
}