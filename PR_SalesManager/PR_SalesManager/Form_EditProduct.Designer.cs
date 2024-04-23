namespace PR_SalesManager
{
    partial class Form_EditProduct
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
            this.rtbDescribe = new System.Windows.Forms.RichTextBox();
            this.gbDescribe = new System.Windows.Forms.GroupBox();
            this.picProduct = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblText = new System.Windows.Forms.Label();
            this.txtNameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MessageYesNo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gbDescribe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
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
            // rtbDescribe
            // 
            this.rtbDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescribe.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescribe.Location = new System.Drawing.Point(2, 19);
            this.rtbDescribe.Name = "rtbDescribe";
            this.rtbDescribe.Size = new System.Drawing.Size(436, 133);
            this.rtbDescribe.TabIndex = 0;
            this.rtbDescribe.Text = "";
            // 
            // gbDescribe
            // 
            this.gbDescribe.Controls.Add(this.rtbDescribe);
            this.gbDescribe.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDescribe.Location = new System.Drawing.Point(251, 229);
            this.gbDescribe.Name = "gbDescribe";
            this.gbDescribe.Size = new System.Drawing.Size(422, 155);
            this.gbDescribe.TabIndex = 53;
            this.gbDescribe.TabStop = false;
            this.gbDescribe.Text = "Thông Tin Sản Phẩm";
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Transparent;
            this.picProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.picProduct.ImageRotate = 0F;
            this.picProduct.Location = new System.Drawing.Point(35, 163);
            this.picProduct.Margin = new System.Windows.Forms.Padding(5);
            this.picProduct.Name = "picProduct";
            this.picProduct.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProduct.Size = new System.Drawing.Size(180, 180);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 51;
            this.picProduct.TabStop = false;
            this.picProduct.Click += new System.EventHandler(this.picProduct_Click);
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BorderThickness = 0;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FocusedColor = System.Drawing.Color.Black;
            this.cmbType.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cmbType.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.ItemHeight = 30;
            this.cmbType.Location = new System.Drawing.Point(1, 17);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 36);
            this.cmbType.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(103, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 35);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(0, 402);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(690, 23);
            this.lblText.TabIndex = 48;
            this.lblText.Text = "Text Warning !!!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BorderThickness = 0;
            this.txtNameProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameProduct.DefaultText = "";
            this.txtNameProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameProduct.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtNameProduct.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtNameProduct.ForeColor = System.Drawing.Color.Black;
            this.txtNameProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtNameProduct.Location = new System.Drawing.Point(1, 17);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.PasswordChar = '\0';
            this.txtNameProduct.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNameProduct.PlaceholderText = "";
            this.txtNameProduct.SelectedText = "";
            this.txtNameProduct.Size = new System.Drawing.Size(200, 35);
            this.txtNameProduct.TabIndex = 40;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.lblTitle;
            this.DragControl.UseTransparentDrag = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(343, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 36);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "THÔNG TIN SẢN PHẨM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnUpdate.Location = new System.Drawing.Point(400, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 35);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "CẬP NHẬT";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 200;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNameProduct);
            this.groupBox1.Location = new System.Drawing.Point(251, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 56);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Location = new System.Drawing.Point(470, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 56);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá Sản Phẩm";
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
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(200, 35);
            this.txtPrice.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num);
            this.groupBox3.Location = new System.Drawing.Point(471, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 57);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số Lượng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbType);
            this.groupBox4.Location = new System.Drawing.Point(251, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 56);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loại Sản Phẩm";
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
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(596, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 58;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(644, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 57;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightGray;
            this.panelRight.Location = new System.Drawing.Point(672, 240);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 143);
            this.panelRight.TabIndex = 59;
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.BorderColor = System.Drawing.Color.Transparent;
            this.num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(1, 18);
            this.num.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(200, 35);
            this.num.TabIndex = 60;
            this.num.UpDownButtonFillColor = System.Drawing.Color.White;
            this.num.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 510);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDescribe);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditProduct";
            this.Load += new System.EventHandler(this.Form_EditProduct_Load);
            this.gbDescribe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.GroupBox gbDescribe;
        private System.Windows.Forms.RichTextBox rtbDescribe;
        public Guna.UI2.WinForms.Guna2CirclePictureBox picProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cmbType;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2TextBox txtNameProduct;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageYesNo;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panelRight;
        private Guna.UI2.WinForms.Guna2NumericUpDown num;
    }
}