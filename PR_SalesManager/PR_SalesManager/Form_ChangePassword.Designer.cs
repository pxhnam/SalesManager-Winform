using System.Windows.Forms;

namespace PR_SalesManager
{
    partial class Form_ChangePassword
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
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ToggleSwitch3 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(93, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 36);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Đổi Mật Khẩu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.BorderRadius = 1;
            this.btnChangePassword.BorderThickness = 1;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.White;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.FillColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(69, 361);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(202, 35);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Xác Nhận";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ToggleSwitch1
            // 
            this.ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.Black;
            this.ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch1.Location = new System.Drawing.Point(161, 26);
            this.ToggleSwitch1.Name = "ToggleSwitch1";
            this.ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.ToggleSwitch1.TabIndex = 16;
            this.ToggleSwitch1.TabStop = false;
            this.ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch1.CheckedChanged += new System.EventHandler(this.ToggleSwitch1_CheckedChanged);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(0, 329);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(340, 23);
            this.lblText.TabIndex = 22;
            this.lblText.Text = "Text Warning !!!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToggleSwitch1);
            this.groupBox1.Controls.Add(this.txtOldPass);
            this.groupBox1.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(69, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật Khẩu Hiện Tại";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BorderThickness = 0;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.DefaultText = "";
            this.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtOldPass.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtOldPass.ForeColor = System.Drawing.Color.Black;
            this.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtOldPass.Location = new System.Drawing.Point(1, 17);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '×';
            this.txtOldPass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtOldPass.PlaceholderText = "Mật Khẩu Hiện Tại";
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.Size = new System.Drawing.Size(200, 35);
            this.txtOldPass.TabIndex = 0;
            this.txtOldPass.TextChanged += new System.EventHandler(this.txtOldPass_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ToggleSwitch2);
            this.groupBox2.Controls.Add(this.txtNewPass);
            this.groupBox2.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(69, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mật Khẩu Mới";
            // 
            // ToggleSwitch2
            // 
            this.ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.Black;
            this.ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch2.Location = new System.Drawing.Point(161, 26);
            this.ToggleSwitch2.Name = "ToggleSwitch2";
            this.ToggleSwitch2.Size = new System.Drawing.Size(35, 20);
            this.ToggleSwitch2.TabIndex = 16;
            this.ToggleSwitch2.TabStop = false;
            this.ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch2.CheckedChanged += new System.EventHandler(this.ToggleSwitch2_CheckedChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderThickness = 0;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtNewPass.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtNewPass.Location = new System.Drawing.Point(1, 17);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '×';
            this.txtNewPass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNewPass.PlaceholderText = "Mật Khẩu Mới";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(200, 35);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ToggleSwitch3);
            this.groupBox3.Controls.Add(this.txtConfirmPass);
            this.groupBox3.Font = new System.Drawing.Font("DVN-Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(69, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xác Nhận Mật Khẩu";
            // 
            // ToggleSwitch3
            // 
            this.ToggleSwitch3.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.ToggleSwitch3.CheckedState.FillColor = System.Drawing.Color.Black;
            this.ToggleSwitch3.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch3.Location = new System.Drawing.Point(161, 26);
            this.ToggleSwitch3.Name = "ToggleSwitch3";
            this.ToggleSwitch3.Size = new System.Drawing.Size(35, 20);
            this.ToggleSwitch3.TabIndex = 16;
            this.ToggleSwitch3.TabStop = false;
            this.ToggleSwitch3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch3.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch3.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch3.CheckedChanged += new System.EventHandler(this.ToggleSwitch3_CheckedChanged);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderThickness = 0;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.DefaultText = "";
            this.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmPass.Font = new System.Drawing.Font("DVN-Poppins", 9.75F);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(1, 17);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '×';
            this.txtConfirmPass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtConfirmPass.PlaceholderText = "Xác Nhận Mật Khẩu";
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.Size = new System.Drawing.Size(200, 35);
            this.txtConfirmPass.TabIndex = 2;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(246, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 24;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(294, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 23;
            // 
            // Form_ChangePassword
            // 
            this.AcceptButton = this.btnChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 420);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ChangePassword";
            this.Load += new System.EventHandler(this.Form_ChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch3;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch2;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPass;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}