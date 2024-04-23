using System.Windows.Forms;

namespace PR_SalesManager
{
    partial class Form_AddCustomer
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gbNameCustomer = new System.Windows.Forms.GroupBox();
            this.txtNameCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbNumberPhone = new System.Windows.Forms.GroupBox();
            this.txtNumberPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbGmail = new System.Windows.Forms.GroupBox();
            this.txtGmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblText = new System.Windows.Forms.Label();
            this.gbNameCustomer.SuspendLayout();
            this.gbNumberPhone.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbGmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.AnimationInterval = 200;
            this.BorderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.BorderlessForm.BorderRadius = 15;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(349, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(302, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(90, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 36);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "THÊM KHÁCH HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // gbNameCustomer
            // 
            this.gbNameCustomer.Controls.Add(this.txtNameCustomer);
            this.gbNameCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.gbNameCustomer.Location = new System.Drawing.Point(96, 86);
            this.gbNameCustomer.Name = "gbNameCustomer";
            this.gbNameCustomer.Size = new System.Drawing.Size(202, 60);
            this.gbNameCustomer.TabIndex = 0;
            this.gbNameCustomer.TabStop = false;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.BorderThickness = 0;
            this.txtNameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCustomer.DefaultText = "";
            this.txtNameCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCustomer.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtNameCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtNameCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtNameCustomer.Location = new System.Drawing.Point(1, 17);
            this.txtNameCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNameCustomer.PlaceholderText = "Tên Khách Hàng";
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.Size = new System.Drawing.Size(200, 35);
            this.txtNameCustomer.TabIndex = 0;
            this.txtNameCustomer.TextChanged += new System.EventHandler(this.txtNameCustomer_TextChanged);
            // 
            // gbNumberPhone
            // 
            this.gbNumberPhone.Controls.Add(this.txtNumberPhone);
            this.gbNumberPhone.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumberPhone.ForeColor = System.Drawing.Color.Black;
            this.gbNumberPhone.Location = new System.Drawing.Point(96, 166);
            this.gbNumberPhone.Name = "gbNumberPhone";
            this.gbNumberPhone.Size = new System.Drawing.Size(202, 60);
            this.gbNumberPhone.TabIndex = 1;
            this.gbNumberPhone.TabStop = false;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.BorderThickness = 0;
            this.txtNumberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPhone.DefaultText = "";
            this.txtNumberPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtNumberPhone.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtNumberPhone.ForeColor = System.Drawing.Color.Black;
            this.txtNumberPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtNumberPhone.Location = new System.Drawing.Point(1, 17);
            this.txtNumberPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.PasswordChar = '\0';
            this.txtNumberPhone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNumberPhone.PlaceholderText = "Số Điện Thoại";
            this.txtNumberPhone.SelectedText = "";
            this.txtNumberPhone.Size = new System.Drawing.Size(200, 35);
            this.txtNumberPhone.TabIndex = 1;
            this.txtNumberPhone.TextChanged += new System.EventHandler(this.txtNumberPhone_TextChanged);
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.txtAddress);
            this.gbAddress.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddress.ForeColor = System.Drawing.Color.Black;
            this.gbAddress.Location = new System.Drawing.Point(96, 246);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(202, 60);
            this.gbAddress.TabIndex = 2;
            this.gbAddress.TabStop = false;
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
            this.txtAddress.PlaceholderText = "Địa Chỉ";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(200, 35);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // gbGmail
            // 
            this.gbGmail.Controls.Add(this.txtGmail);
            this.gbGmail.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGmail.ForeColor = System.Drawing.Color.Black;
            this.gbGmail.Location = new System.Drawing.Point(96, 326);
            this.gbGmail.Name = "gbGmail";
            this.gbGmail.Size = new System.Drawing.Size(202, 60);
            this.gbGmail.TabIndex = 3;
            this.gbGmail.TabStop = false;
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
            this.txtGmail.PlaceholderText = "Gmail";
            this.txtGmail.SelectedText = "";
            this.txtGmail.Size = new System.Drawing.Size(200, 35);
            this.txtGmail.TabIndex = 3;
            this.txtGmail.TextChanged += new System.EventHandler(this.txtGmail_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BorderRadius = 1;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(96, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(0, 399);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(395, 23);
            this.lblText.TabIndex = 23;
            this.lblText.Text = "Text Warning !!!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.lblTitle;
            this.DragControl.UseTransparentDrag = true;
            // 
            // Form_AddCustomer
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 500);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbGmail);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.gbNumberPhone);
            this.Controls.Add(this.gbNameCustomer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddCustomer";
            this.Load += new System.EventHandler(this.Form_AddCustomer_Load);
            this.gbNameCustomer.ResumeLayout(false);
            this.gbNumberPhone.ResumeLayout(false);
            this.gbAddress.ResumeLayout(false);
            this.gbGmail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.GroupBox gbNameCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtNameCustomer;
        private System.Windows.Forms.GroupBox gbNumberPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberPhone;
        private System.Windows.Forms.GroupBox gbAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.GroupBox gbGmail;
        private Guna.UI2.WinForms.Guna2TextBox txtGmail;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}