using System.Windows.Forms;

namespace PR_SalesManager
{
    partial class Form_AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddProduct));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.addImage = new System.Windows.Forms.PictureBox();
            this.picProduct = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gbDescribe = new System.Windows.Forms.GroupBox();
            this.rtbDescribe = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.gbDescribe.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(367, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 36);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "THÊM SẢN PHẨM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.lblTitle;
            this.DragControl.UseTransparentDrag = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(103, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(0, 403);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(690, 23);
            this.lblText.TabIndex = 34;
            this.lblText.Text = "Text Warning !!!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FillColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(400, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addImage
            // 
            this.addImage.Image = ((System.Drawing.Image)(resources.GetObject("addImage.Image")));
            this.addImage.Location = new System.Drawing.Point(35, 164);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(180, 180);
            this.addImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addImage.TabIndex = 38;
            this.addImage.TabStop = false;
            this.addImage.Click += new System.EventHandler(this.picProduct_Click);
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Transparent;
            this.picProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.picProduct.ImageRotate = 0F;
            this.picProduct.Location = new System.Drawing.Point(35, 164);
            this.picProduct.Margin = new System.Windows.Forms.Padding(5);
            this.picProduct.Name = "picProduct";
            this.picProduct.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProduct.Size = new System.Drawing.Size(180, 180);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 37;
            this.picProduct.TabStop = false;
            this.picProduct.Click += new System.EventHandler(this.picProduct_Click);
            // 
            // gbDescribe
            // 
            this.gbDescribe.Controls.Add(this.panelRight);
            this.gbDescribe.Controls.Add(this.rtbDescribe);
            this.gbDescribe.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDescribe.Location = new System.Drawing.Point(251, 230);
            this.gbDescribe.Name = "gbDescribe";
            this.gbDescribe.Size = new System.Drawing.Size(422, 155);
            this.gbDescribe.TabIndex = 4;
            this.gbDescribe.TabStop = false;
            this.gbDescribe.Text = "Thông Tin Sản Phẩm";
            // 
            // rtbDescribe
            // 
            this.rtbDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescribe.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescribe.Location = new System.Drawing.Point(3, 23);
            this.rtbDescribe.Name = "rtbDescribe";
            this.rtbDescribe.Size = new System.Drawing.Size(436, 129);
            this.rtbDescribe.TabIndex = 4;
            this.rtbDescribe.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbType);
            this.groupBox4.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(251, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 56);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loại Sản Phẩm";
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
            this.cmbType.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num);
            this.groupBox3.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(471, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số Lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNameProduct);
            this.groupBox1.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(251, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên Sản Phẩm";
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
            this.txtNameProduct.TabIndex = 0;
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
            this.guna2ControlBox2.TabIndex = 40;
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
            this.guna2ControlBox1.TabIndex = 39;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightGray;
            this.panelRight.Location = new System.Drawing.Point(421, 12);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 143);
            this.panelRight.TabIndex = 60;
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
            this.num.TabIndex = 43;
            this.num.UpDownButtonFillColor = System.Drawing.Color.White;
            this.num.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.txtPrice.TabIndex = 1;
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(690, 510);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbDescribe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddProduct";
            this.Load += new System.EventHandler(this.Form_AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.gbDescribe.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        public Guna.UI2.WinForms.Guna2CirclePictureBox picProduct;
        private System.Windows.Forms.PictureBox addImage;
        private System.Windows.Forms.GroupBox gbDescribe;
        private System.Windows.Forms.RichTextBox rtbDescribe;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNameProduct;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panelRight;
        private Guna.UI2.WinForms.Guna2NumericUpDown num;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
    }
}