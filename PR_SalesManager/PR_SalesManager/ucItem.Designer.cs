using System.Windows.Forms;

namespace PR_SalesManager
{
    partial class ucItem
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnShow = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textPrice = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Pic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.SoldOut = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.SoldOut);
            this.panelMain.Controls.Add(this.btnShow);
            this.panelMain.Controls.Add(this.textPrice);
            this.panelMain.Controls.Add(this.textName);
            this.panelMain.Controls.Add(this.Pic);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(250, 300);
            this.panelMain.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Animated = true;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BorderRadius = 10;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(95)))));
            this.btnShow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.btnShow.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnShow.Location = new System.Drawing.Point(50, 251);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(150, 35);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "THÔNG TIN";
            this.btnShow.UseTransparentBackground = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.Transparent;
            this.textPrice.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.ForeColor = System.Drawing.Color.White;
            this.textPrice.Location = new System.Drawing.Point(0, 216);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(250, 25);
            this.textPrice.TabIndex = 2;
            this.textPrice.Text = "Money";
            this.textPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.Transparent;
            this.textName.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.Color.White;
            this.textName.Location = new System.Drawing.Point(0, 187);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(250, 27);
            this.textName.TabIndex = 1;
            this.textName.Text = "Name Item";
            this.textName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 25;
            this.elipse.TargetControl = this;
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.Transparent;
            this.Pic.FillColor = System.Drawing.Color.Transparent;
            this.Pic.ImageRotate = 0F;
            this.Pic.Location = new System.Drawing.Point(35, 6);
            this.Pic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pic.Name = "Pic";
            this.Pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Pic.Size = new System.Drawing.Size(180, 180);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            this.Pic.UseTransparentBackground = true;
            // 
            // SoldOut
            // 
            this.SoldOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.SoldOut.Font = new System.Drawing.Font("SVN-Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.SoldOut.Location = new System.Drawing.Point(0, 77);
            this.SoldOut.Margin = new System.Windows.Forms.Padding(0);
            this.SoldOut.Name = "SoldOut";
            this.SoldOut.Size = new System.Drawing.Size(250, 38);
            this.SoldOut.TabIndex = 4;
            this.SoldOut.Text = "HẾT HÀNG";
            this.SoldOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SoldOut.Visible = false;
            // 
            // ucItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.Name = "ucItem";
            this.Size = new System.Drawing.Size(250, 300);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label textName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Pic;
        public Guna.UI2.WinForms.Guna2GradientButton btnShow;
        public System.Windows.Forms.Label SoldOut;
    }
}
