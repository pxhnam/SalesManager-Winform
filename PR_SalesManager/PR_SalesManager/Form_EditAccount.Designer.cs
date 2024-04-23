namespace PR_SalesManager
{
    partial class Form_EditAccount
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
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.txtAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.txtPosition = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbFullName = new System.Windows.Forms.GroupBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.cmbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtGmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gbAccount.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.gbFullName.SuspendLayout();
            this.gbSex.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(136, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 36);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "THÔNG TIN CÁ NHÂN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(0, 386);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(495, 23);
            this.lblText.TabIndex = 30;
            this.lblText.Text = "Text Warning !!!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FillColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(265, 427);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 35);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "CẬP NHẬT";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.BorderThickness = 1;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.FillColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(26, 427);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(202, 35);
            this.btnChangePassword.TabIndex = 32;
            this.btnChangePassword.Text = "ĐỔI MẬT KHẨU";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.lblTitle;
            this.DragControl.UseTransparentDrag = true;
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.txtAccount);
            this.gbAccount.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccount.ForeColor = System.Drawing.Color.Black;
            this.gbAccount.Location = new System.Drawing.Point(27, 85);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(202, 56);
            this.gbAccount.TabIndex = 34;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Tài Khoản";
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
            this.txtAccount.ReadOnly = true;
            this.txtAccount.SelectedText = "";
            this.txtAccount.Size = new System.Drawing.Size(200, 35);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.TabStop = false;
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.txtPosition);
            this.gbPosition.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPosition.ForeColor = System.Drawing.Color.Black;
            this.gbPosition.Location = new System.Drawing.Point(266, 85);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(202, 56);
            this.gbPosition.TabIndex = 35;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Chức Vụ";
            // 
            // txtPosition
            // 
            this.txtPosition.BorderThickness = 0;
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosition.DefaultText = "";
            this.txtPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPosition.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPosition.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtPosition.ForeColor = System.Drawing.Color.Black;
            this.txtPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPosition.Location = new System.Drawing.Point(1, 17);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PasswordChar = '\0';
            this.txtPosition.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPosition.PlaceholderText = "";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.SelectedText = "";
            this.txtPosition.Size = new System.Drawing.Size(200, 35);
            this.txtPosition.TabIndex = 0;
            this.txtPosition.TabStop = false;
            // 
            // gbFullName
            // 
            this.gbFullName.Controls.Add(this.txtFullName);
            this.gbFullName.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFullName.ForeColor = System.Drawing.Color.Black;
            this.gbFullName.Location = new System.Drawing.Point(25, 157);
            this.gbFullName.Name = "gbFullName";
            this.gbFullName.Size = new System.Drawing.Size(202, 56);
            this.gbFullName.TabIndex = 3;
            this.gbFullName.TabStop = false;
            this.gbFullName.Text = "Họ Và Tên";
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
            // gbSex
            // 
            this.gbSex.Controls.Add(this.cmbSex);
            this.gbSex.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSex.ForeColor = System.Drawing.Color.Black;
            this.gbSex.Location = new System.Drawing.Point(265, 157);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(202, 56);
            this.gbSex.TabIndex = 36;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Giới Tính";
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
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtGmail);
            this.groupBox8.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(263, 301);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(202, 56);
            this.groupBox8.TabIndex = 40;
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtAddress);
            this.groupBox7.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(25, 301);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(202, 56);
            this.groupBox7.TabIndex = 39;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpDOB);
            this.groupBox6.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(265, 225);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(202, 56);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ngày Sinh";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPhoneNumber);
            this.groupBox5.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(26, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 56);
            this.groupBox5.TabIndex = 37;
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
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(401, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 42;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(449, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 41;
            // 
            // Form_EditAccount
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 500);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.gbFullName);
            this.Controls.Add(this.gbPosition);
            this.Controls.Add(this.gbAccount);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditAccount";
            this.Load += new System.EventHandler(this.Form_EditAccount_Load);
            this.gbAccount.ResumeLayout(false);
            this.gbPosition.ResumeLayout(false);
            this.gbFullName.ResumeLayout(false);
            this.gbSex.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.GroupBox gbPosition;
        private Guna.UI2.WinForms.Guna2TextBox txtPosition;
        private System.Windows.Forms.GroupBox gbAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtAccount;
        private System.Windows.Forms.GroupBox gbFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.GroupBox gbSex;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSex;
        private System.Windows.Forms.GroupBox groupBox8;
        private Guna.UI2.WinForms.Guna2TextBox txtGmail;
        private System.Windows.Forms.GroupBox groupBox7;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}