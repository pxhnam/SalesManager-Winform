using System.Windows.Forms;

namespace PR_SalesManager
{
    partial class Form_Main
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
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumberMoney = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNumberProduct = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumberBill = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.Line = new Guna.UI2.WinForms.Guna2Separator();
            this.lblStatistical = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timerProduct = new System.Windows.Forms.Timer(this.components);
            this.timerBill = new System.Windows.Forms.Timer(this.components);
            this.timerCustomer = new System.Windows.Forms.Timer(this.components);
            this.timerStatistical = new System.Windows.Forms.Timer(this.components);
            this.timerManager = new System.Windows.Forms.Timer(this.components);
            this.tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.AnimationInterval = 300;
            this.BorderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.BorderlessForm.BorderRadius = 5;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // DragControl1
            // 
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.TargetControl = this.panelTop;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.guna2ControlBox3);
            this.panelTop.Controls.Add(this.guna2ControlBox4);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.lblNumberMoney);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.lblNumberProduct);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.lblNumberBill);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.panelTop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 160);
            this.panelTop.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1186, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 26;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(1234, 0);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHi);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 36);
            this.panel1.TabIndex = 25;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.BackColor = System.Drawing.Color.Transparent;
            this.lblHi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHi.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.ForeColor = System.Drawing.Color.White;
            this.lblHi.Location = new System.Drawing.Point(0, 0);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(135, 36);
            this.lblHi.TabIndex = 11;
            this.lblHi.Text = "Xin chào, ...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(600, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Doanh Thu Cá Nhân";
            // 
            // lblNumberMoney
            // 
            this.lblNumberMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberMoney.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberMoney.ForeColor = System.Drawing.Color.White;
            this.lblNumberMoney.Location = new System.Drawing.Point(600, 70);
            this.lblNumberMoney.Name = "lblNumberMoney";
            this.lblNumberMoney.Size = new System.Drawing.Size(172, 25);
            this.lblNumberMoney.TabIndex = 23;
            this.lblNumberMoney.Text = "0 VNĐ";
            this.lblNumberMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(345, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sản Phẩm Bán Ra";
            // 
            // lblNumberProduct
            // 
            this.lblNumberProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberProduct.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberProduct.ForeColor = System.Drawing.Color.White;
            this.lblNumberProduct.Location = new System.Drawing.Point(345, 70);
            this.lblNumberProduct.Name = "lblNumberProduct";
            this.lblNumberProduct.Size = new System.Drawing.Size(154, 25);
            this.lblNumberProduct.TabIndex = 21;
            this.lblNumberProduct.Text = "0";
            this.lblNumberProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(120, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Số Lượng Đơn";
            // 
            // lblNumberBill
            // 
            this.lblNumberBill.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberBill.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberBill.ForeColor = System.Drawing.Color.White;
            this.lblNumberBill.Location = new System.Drawing.Point(120, 70);
            this.lblNumberBill.Name = "lblNumberBill";
            this.lblNumberBill.Size = new System.Drawing.Size(124, 25);
            this.lblNumberBill.TabIndex = 19;
            this.lblNumberBill.Text = "0";
            this.lblNumberBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.Transparent;
            this.lblBill.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.Silver;
            this.lblBill.Location = new System.Drawing.Point(226, 179);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(103, 22);
            this.lblBill.TabIndex = 11;
            this.lblBill.Text = "ĐƠN HÀNG";
            this.lblBill.Click += new System.EventHandler(this.lblBill_Click);
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.Color.Silver;
            this.lblProd.Location = new System.Drawing.Point(40, 179);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(101, 22);
            this.lblProd.TabIndex = 11;
            this.lblProd.Text = "SẢN PHẨM";
            this.lblProd.Click += new System.EventHandler(this.lblProd_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.White;
            this.Line.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.Line.FillThickness = 2;
            this.Line.Location = new System.Drawing.Point(46, 207);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(0, 5);
            this.Line.TabIndex = 12;
            // 
            // lblStatistical
            // 
            this.lblStatistical.AutoSize = true;
            this.lblStatistical.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistical.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistical.ForeColor = System.Drawing.Color.Silver;
            this.lblStatistical.Location = new System.Drawing.Point(612, 179);
            this.lblStatistical.Name = "lblStatistical";
            this.lblStatistical.Size = new System.Drawing.Size(98, 22);
            this.lblStatistical.TabIndex = 11;
            this.lblStatistical.Text = "THỐNG KÊ";
            this.lblStatistical.Click += new System.EventHandler(this.lblStatistical_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Silver;
            this.lblCustomer.Location = new System.Drawing.Point(406, 179);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(126, 22);
            this.lblCustomer.TabIndex = 13;
            this.lblCustomer.Text = "KHÁCH HÀNG";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.BackColor = System.Drawing.Color.Transparent;
            this.lblManager.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.Color.Silver;
            this.lblManager.Location = new System.Drawing.Point(786, 179);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(85, 22);
            this.lblManager.TabIndex = 14;
            this.lblManager.Text = "QUẢN LÝ";
            this.lblManager.Click += new System.EventHandler(this.lblManager_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.ForeColor = System.Drawing.Color.Black;
            this.panelMain.Location = new System.Drawing.Point(45, 223);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1185, 450);
            this.panelMain.TabIndex = 15;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.panel1;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // timerProduct
            // 
            this.timerProduct.Interval = 20;
            this.timerProduct.Tick += new System.EventHandler(this.timerProduct_Tick);
            // 
            // timerBill
            // 
            this.timerBill.Interval = 20;
            this.timerBill.Tick += new System.EventHandler(this.timerBill_Tick);
            // 
            // timerCustomer
            // 
            this.timerCustomer.Interval = 20;
            this.timerCustomer.Tick += new System.EventHandler(this.timerCustomer_Tick);
            // 
            // timerStatistical
            // 
            this.timerStatistical.Interval = 20;
            this.timerStatistical.Tick += new System.EventHandler(this.timerStatistical_Tick);
            // 
            // timerManager
            // 
            this.timerManager.Interval = 20;
            this.timerManager.Tick += new System.EventHandler(this.timerManager_Tick);
            // 
            // tip
            // 
            this.tip.AllowLinksHandling = true;
            this.tip.Font = new System.Drawing.Font("DVN-Poppins", 8F);
            this.tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.tip.TitleFont = new System.Drawing.Font("DVN-Poppins", 8F);
            this.tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            // 
            // btnLogOut
            // 
            this.btnLogOut.Animated = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnLogOut.CheckedState.BorderColor = System.Drawing.Color.LightGray;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.LightGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogOut.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Image = global::PR_SalesManager.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(1092, 677);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.Transparent;
            this.btnLogOut.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnLogOut.Size = new System.Drawing.Size(138, 35);
            this.btnLogOut.TabIndex = 29;
            this.btnLogOut.Text = "ĐĂNG XUẤT";
            this.btnLogOut.UseTransparentBackground = true;
            this.btnLogOut.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Image = global::PR_SalesManager.Properties.Resources.user_profile1;
            this.btnEdit.ImageRotate = 0F;
            this.btnEdit.Location = new System.Drawing.Point(997, 115);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 64);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEdit.TabIndex = 27;
            this.btnEdit.TabStop = false;
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.lblStatistical);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblBill);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblBill;
        private Guna.UI2.WinForms.Guna2Separator Line;
        private System.Windows.Forms.Label lblStatistical;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2GradientPanel panelTop;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumberMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumberProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumberBill;
        private Guna.UI2.WinForms.Guna2PictureBox btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Timer timerProduct;
        private System.Windows.Forms.Timer timerBill;
        private System.Windows.Forms.Timer timerCustomer;
        private System.Windows.Forms.Timer timerStatistical;
        private System.Windows.Forms.Timer timerManager;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tip;
    }
}