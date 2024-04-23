namespace PR_SalesManager
{
    partial class Form_Register
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
            this.BorderlessForm_Register = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtGmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm_Register
            // 
            this.BorderlessForm_Register.AnimateWindow = true;
            this.BorderlessForm_Register.AnimationInterval = 200;
            this.BorderlessForm_Register.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.BorderlessForm_Register.BorderRadius = 15;
            this.BorderlessForm_Register.ContainerControl = this;
            this.BorderlessForm_Register.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm_Register.ResizeForm = false;
            this.BorderlessForm_Register.TransparentWhileDrag = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Animated = true;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FillColor = System.Drawing.Color.Black;
            this.btnRegister.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(150, 436);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 35);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(204, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 28);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "ĐĂNG KÝ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Animated = true;
            this.dtpDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpDOB.Checked = true;
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpDOB.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.dtpDOB.ForeColor = System.Drawing.Color.Black;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(3, 19);
            this.dtpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(196, 33);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.Value = new System.DateTime(2022, 11, 29, 16, 39, 46, 160);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(0, 387);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(495, 23);
            this.lblText.TabIndex = 18;
            this.lblText.Text = "Text Warning !!!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // txtAccount
            // 
            this.txtAccount.BorderThickness = 0;
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.DefaultText = "";
            this.txtAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccount.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtAccount.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtAccount.ForeColor = System.Drawing.Color.Black;
            this.txtAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtAccount.Location = new System.Drawing.Point(1, 17);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAccount.PlaceholderText = "";
            this.txtAccount.SelectedText = "";
            this.txtAccount.Size = new System.Drawing.Size(200, 35);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbSex);
            this.groupBox4.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(264, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 56);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới Tính";
            // 
            // cmbSex
            // 
            this.cmbSex.BackColor = System.Drawing.Color.Transparent;
            this.cmbSex.BorderThickness = 0;
            this.cmbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FocusedColor = System.Drawing.Color.Black;
            this.cmbSex.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cmbSex.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.cmbSex.ForeColor = System.Drawing.Color.Black;
            this.cmbSex.ItemHeight = 30;
            this.cmbSex.Location = new System.Drawing.Point(1, 17);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(200, 36);
            this.cmbSex.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picShow);
            this.groupBox2.Controls.Add(this.picHide);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(263, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mật Khẩu";
            // 
            // picShow
            // 
            this.picShow.Image = global::PR_SalesManager.Properties.Resources.show;
            this.picShow.Location = new System.Drawing.Point(165, 20);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(25, 25);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 20;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // picHide
            // 
            this.picHide.Image = global::PR_SalesManager.Properties.Resources.hide;
            this.picHide.Location = new System.Drawing.Point(165, 20);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(25, 25);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 19;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPassword.Location = new System.Drawing.Point(1, 17);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '×';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 35);
            this.txtPassword.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFullName);
            this.groupBox3.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(27, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Họ Và Tên";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderThickness = 0;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtFullName.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtFullName.Location = new System.Drawing.Point(1, 17);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(200, 35);
            this.txtFullName.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPhoneNumber);
            this.groupBox5.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(27, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 56);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Số Điện Thoại";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderThickness = 0;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(1, 17);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 35);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpDOB);
            this.groupBox6.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(264, 230);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(202, 56);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ngày Sinh";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtAddress);
            this.groupBox7.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(28, 297);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(202, 56);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Địa Chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderThickness = 0;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtAddress.Location = new System.Drawing.Point(1, 17);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(200, 35);
            this.txtAddress.TabIndex = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtGmail);
            this.groupBox8.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(263, 297);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(202, 56);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Gmail";
            // 
            // txtGmail
            // 
            this.txtGmail.BorderThickness = 0;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.DefaultText = "";
            this.txtGmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGmail.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtGmail.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtGmail.ForeColor = System.Drawing.Color.Black;
            this.txtGmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtGmail.Location = new System.Drawing.Point(1, 17);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.PasswordChar = '\0';
            this.txtGmail.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtGmail.PlaceholderText = "";
            this.txtGmail.SelectedText = "";
            this.txtGmail.Size = new System.Drawing.Size(200, 35);
            this.txtGmail.TabIndex = 7;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(402, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 20;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(450, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 19;
            // 
            // Form_Register
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 500);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(495, 500);
            this.MinimumSize = new System.Drawing.Size(495, 0);
            this.Name = "Form_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Register";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm_Register;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtAccount;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSex;
        private System.Windows.Forms.GroupBox groupBox8;
        private Guna.UI2.WinForms.Guna2TextBox txtGmail;
        private System.Windows.Forms.GroupBox groupBox7;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picShow;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}