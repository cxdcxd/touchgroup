namespace TouchGroup
{
    partial class frmLogin
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bnt_lock = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_username = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(197, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = ": کلمه عبور";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(196, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = ": نام کاربری";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.txt_password);
            this.groupControl1.Controls.Add(this.cmb_username);
            this.groupControl1.Controls.Add(this.bnt_lock);
            this.groupControl1.Controls.Add(this.btn_cancel);
            this.groupControl1.Controls.Add(this.btn_ok);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(272, 216);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "ورود";
            // 
            // bnt_lock
            // 
            this.bnt_lock.Image = global::TouchGroup.Properties.Resources._lock;
            this.bnt_lock.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bnt_lock.Location = new System.Drawing.Point(27, 115);
            this.bnt_lock.Name = "bnt_lock";
            this.bnt_lock.Size = new System.Drawing.Size(222, 37);
            this.bnt_lock.TabIndex = 10;
            this.bnt_lock.Text = "قفل";
            this.bnt_lock.Click += new System.EventHandler(this.bnt_lock_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::TouchGroup.Properties.Resources.cancle_mini3;
            this.btn_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(27, 158);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 37);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::TouchGroup.Properties.Resources.accept1;
            this.btn_ok.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(141, 158);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(108, 37);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "تایید";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmb_username
            // 
            this.cmb_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_username.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_username.FormattingEnabled = true;
            this.cmb_username.Location = new System.Drawing.Point(27, 36);
            this.cmb_username.Name = "cmb_username";
            this.cmb_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_username.Size = new System.Drawing.Size(163, 34);
            this.cmb_username.TabIndex = 11;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_password.Location = new System.Drawing.Point(27, 76);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.Size = new System.Drawing.Size(162, 33);
            this.txt_password.TabIndex = 12;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(295, 240);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bnt_lock;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmb_username;
        private System.Windows.Forms.TextBox txt_password;

    }
}