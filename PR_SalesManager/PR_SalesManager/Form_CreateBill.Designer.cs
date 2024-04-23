using System.Windows.Forms;

namespace PR_SalesManager
{
    partial class Form_CreateBill
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbNameCustomer = new System.Windows.Forms.GroupBox();
            this.txtNameStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.txtDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.bgAmount = new System.Windows.Forms.GroupBox();
            this.num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.MessageOK = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.gbNameCustomer.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.bgAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.guna2ControlBox2.TabIndex = 30;
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
            this.btnClose.TabIndex = 29;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(251, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 48);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "HÓA ĐƠN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNameCustomer
            // 
            this.gbNameCustomer.Controls.Add(this.txtNameStaff);
            this.gbNameCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.gbNameCustomer.Location = new System.Drawing.Point(37, 82);
            this.gbNameCustomer.Name = "gbNameCustomer";
            this.gbNameCustomer.Size = new System.Drawing.Size(257, 56);
            this.gbNameCustomer.TabIndex = 32;
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
            // gbDate
            // 
            this.gbDate.Controls.Add(this.txtDate);
            this.gbDate.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDate.ForeColor = System.Drawing.Color.Black;
            this.gbDate.Location = new System.Drawing.Point(36, 216);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(202, 56);
            this.gbDate.TabIndex = 33;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Thời Gian";
            // 
            // txtDate
            // 
            this.txtDate.BorderThickness = 0;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.DefaultText = "";
            this.txtDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDate.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtDate.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDate.Location = new System.Drawing.Point(1, 17);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDate.PlaceholderText = "";
            this.txtDate.ReadOnly = true;
            this.txtDate.SelectedText = "";
            this.txtDate.Size = new System.Drawing.Size(200, 35);
            this.txtDate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCustomer);
            this.groupBox4.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(36, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 56);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khách Hàng";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cmbCustomer.BorderThickness = 0;
            this.cmbCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FocusedColor = System.Drawing.Color.Black;
            this.cmbCustomer.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cmbCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.cmbCustomer.ForeColor = System.Drawing.Color.Black;
            this.cmbCustomer.ItemHeight = 30;
            this.cmbCustomer.Location = new System.Drawing.Point(1, 18);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(255, 36);
            this.cmbCustomer.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbProduct);
            this.groupBox2.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(351, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 56);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã - Tên Sản Phẩm - Số Lượng";
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.Transparent;
            this.cmbProduct.BorderThickness = 0;
            this.cmbProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FocusedColor = System.Drawing.Color.Black;
            this.cmbProduct.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cmbProduct.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.cmbProduct.ForeColor = System.Drawing.Color.Black;
            this.cmbProduct.ItemHeight = 30;
            this.cmbProduct.Location = new System.Drawing.Point(1, 18);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(254, 36);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.lblTitle;
            this.DragControl.UseTransparentDrag = true;
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.txtPrice);
            this.gbPrice.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrice.ForeColor = System.Drawing.Color.Black;
            this.gbPrice.Location = new System.Drawing.Point(352, 149);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(138, 56);
            this.gbPrice.TabIndex = 33;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Giá";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderThickness = 0;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPrice.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPrice.Location = new System.Drawing.Point(1, 17);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(136, 35);
            this.txtPrice.TabIndex = 0;
            // 
            // bgAmount
            // 
            this.bgAmount.Controls.Add(this.num);
            this.bgAmount.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgAmount.ForeColor = System.Drawing.Color.Black;
            this.bgAmount.Location = new System.Drawing.Point(500, 149);
            this.bgAmount.Name = "bgAmount";
            this.bgAmount.Size = new System.Drawing.Size(107, 56);
            this.bgAmount.TabIndex = 34;
            this.bgAmount.TabStop = false;
            this.bgAmount.Text = "Số Lượng";
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.BorderColor = System.Drawing.Color.Transparent;
            this.num.Cursor = System.Windows.Forms.Cursors.Default;
            this.num.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(1, 18);
            this.num.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(105, 35);
            this.num.TabIndex = 42;
            this.num.UpDownButtonFillColor = System.Drawing.Color.White;
            this.num.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(254, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 39);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Animated = true;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.Black;
            this.btnRemove.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(370, 233);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 39);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "XÓA";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Black;
            this.btnPay.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 9F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(487, 233);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(120, 39);
            this.btnPay.TabIndex = 38;
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.AllowUserToAddRows = false;
            this.dtgvDetail.AllowUserToDeleteRows = false;
            this.dtgvDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDetail.ColumnHeadersHeight = 25;
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDetail.Location = new System.Drawing.Point(36, 292);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.ReadOnly = true;
            this.dtgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDetail.RowHeadersVisible = false;
            this.dtgvDetail.RowTemplate.Height = 25;
            this.dtgvDetail.Size = new System.Drawing.Size(585, 290);
            this.dtgvDetail.TabIndex = 0;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dtgvDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvDetail.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgvDetail.ThemeStyle.ReadOnly = true;
            this.dtgvDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDetail.ThemeStyle.RowsStyle.Height = 25;
            this.dtgvDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(32, 585);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 36);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "THÀNH TIỀN: ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageOK
            // 
            this.MessageOK.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageOK.Caption = null;
            this.MessageOK.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MessageOK.Parent = this;
            this.MessageOK.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageOK.Text = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Location = new System.Drawing.Point(607, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 290);
            this.panel1.TabIndex = 41;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Black;
            this.panelRight.Location = new System.Drawing.Point(0, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 290);
            this.panelRight.TabIndex = 44;
            // 
            // DragControl1
            // 
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.TargetControl = this.panel1;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Location = new System.Drawing.Point(36, 292);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1, 290);
            this.panelLeft.TabIndex = 43;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Location = new System.Drawing.Point(36, 581);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(571, 1);
            this.panelBottom.TabIndex = 44;
            // 
            // Form_CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 625);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvDetail);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bgAmount);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.gbNameCustomer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CreateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CreateBill";
            this.Load += new System.EventHandler(this.Form_CreateBill_Load);
            this.gbNameCustomer.ResumeLayout(false);
            this.gbDate.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbPrice.ResumeLayout(false);
            this.bgAmount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbNameCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtNameStaff;
        private System.Windows.Forms.GroupBox gbDate;
        private Guna.UI2.WinForms.Guna2TextBox txtDate;
        private System.Windows.Forms.GroupBox gbPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProduct;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCustomer;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.GroupBox bgAmount;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageOK;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2NumericUpDown num;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
    }
}