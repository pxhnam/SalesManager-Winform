namespace PR_SalesManager
{
    partial class Form_ShowProduct
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
            this.textName = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.textType = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.Label();
            this.rtbDes = new System.Windows.Forms.RichTextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelHide = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
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
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.AutoSize = true;
            this.textName.BackColor = System.Drawing.Color.White;
            this.textName.Font = new System.Drawing.Font("UVF Ventography ", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.Color.Black;
            this.textName.Location = new System.Drawing.Point(369, 81);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(269, 64);
            this.textName.TabIndex = 18;
            this.textName.Text = "Tên Sản Phẩm";
            this.textName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPrice
            // 
            this.textPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPrice.AutoSize = true;
            this.textPrice.BackColor = System.Drawing.Color.White;
            this.textPrice.Font = new System.Drawing.Font("SVN-Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.textPrice.Location = new System.Drawing.Point(374, 138);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(71, 36);
            this.textPrice.TabIndex = 19;
            this.textPrice.Text = "0 VNĐ";
            this.textPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.White;
            this.labelType.Font = new System.Drawing.Font("SVN-Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(375, 174);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(99, 21);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Loại Sản Phẩm: ";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.White;
            this.labelAmount.Font = new System.Drawing.Font("SVN-Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(375, 199);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(70, 21);
            this.labelAmount.TabIndex = 21;
            this.labelAmount.Text = "Số Lượng: ";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDes
            // 
            this.lblDes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDes.AutoSize = true;
            this.lblDes.BackColor = System.Drawing.Color.Transparent;
            this.lblDes.Font = new System.Drawing.Font("SVN-Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(375, 225);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(120, 21);
            this.lblDes.TabIndex = 22;
            this.lblDes.Text = "Chi Tiết Sản Phẩm: ";
            this.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.textName;
            this.DragControl.UseTransparentDrag = true;
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(37, 95);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(300, 300);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(727, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 28;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(774, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 27;
            // 
            // textType
            // 
            this.textType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textType.AutoSize = true;
            this.textType.BackColor = System.Drawing.Color.White;
            this.textType.Font = new System.Drawing.Font("SVN-Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textType.Location = new System.Drawing.Point(468, 174);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(19, 21);
            this.textType.TabIndex = 29;
            this.textType.Text = "...";
            this.textType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAmount
            // 
            this.textAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAmount.AutoSize = true;
            this.textAmount.BackColor = System.Drawing.Color.White;
            this.textAmount.Font = new System.Drawing.Font("SVN-Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAmount.Location = new System.Drawing.Point(439, 199);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(19, 21);
            this.textAmount.TabIndex = 30;
            this.textAmount.Text = "...";
            this.textAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbDes
            // 
            this.rtbDes.BackColor = System.Drawing.Color.White;
            this.rtbDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDes.Location = new System.Drawing.Point(380, 250);
            this.rtbDes.Name = "rtbDes";
            this.rtbDes.ReadOnly = true;
            this.rtbDes.Size = new System.Drawing.Size(430, 145);
            this.rtbDes.TabIndex = 31;
            this.rtbDes.Text = "";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelHide;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelHide
            // 
            this.panelHide.Location = new System.Drawing.Point(793, 250);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(19, 145);
            this.panelHide.TabIndex = 32;
            // 
            // Form_ShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 485);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.rtbDes);
            this.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ShowProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ShowProduct";
            this.Load += new System.EventHandler(this.Form_ShowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label textName;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label textType;
        private System.Windows.Forms.Label textAmount;
        private System.Windows.Forms.RichTextBox rtbDes;
        private System.Windows.Forms.Panel panelHide;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}