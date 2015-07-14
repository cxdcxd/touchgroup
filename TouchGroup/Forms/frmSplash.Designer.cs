namespace TouchGroup
{
    partial class frmSplash
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
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_username = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_debug = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_activation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_serial
            // 
            this.txt_serial.BackColor = System.Drawing.Color.White;
            this.txt_serial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_serial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serial.ForeColor = System.Drawing.Color.Black;
            this.txt_serial.Location = new System.Drawing.Point(15, 13);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.ReadOnly = true;
            this.txt_serial.Size = new System.Drawing.Size(308, 22);
            this.txt_serial.TabIndex = 6;
            this.txt_serial.TabStop = false;
            this.txt_serial.Text = "0000-0000-0000";
            this.txt_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(329, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "شماره سریال :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(329, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "نام کاربری :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(329, 101);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "کلمه عبور :";
            // 
            // cmb_username
            // 
            this.cmb_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_username.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_username.FormattingEnabled = true;
            this.cmb_username.Location = new System.Drawing.Point(12, 52);
            this.cmb_username.Name = "cmb_username";
            this.cmb_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_username.Size = new System.Drawing.Size(311, 34);
            this.cmb_username.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_password.Location = new System.Drawing.Point(12, 98);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.Size = new System.Drawing.Size(311, 33);
            this.txt_password.TabIndex = 11;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(12, 312);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(40, 13);
            this.lbl_version.TabIndex = 14;
            this.lbl_version.Text = "0.0.0.0";
            // 
            // btn_debug
            // 
            this.btn_debug.Location = new System.Drawing.Point(339, 303);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(75, 23);
            this.btn_debug.TabIndex = 16;
            this.btn_debug.Text = "Debug";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Image = global::TouchGroup.Properties.Resources.exit_mini;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_login
            // 
            this.btn_login.Enabled = false;
            this.btn_login.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_login.Image = global::TouchGroup.Properties.Resources.accept1;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(12, 199);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(402, 46);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "ورود";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_activation
            // 
            this.btn_activation.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_activation.Image = global::TouchGroup.Properties.Resources.key;
            this.btn_activation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_activation.Location = new System.Drawing.Point(12, 147);
            this.btn_activation.Name = "btn_activation";
            this.btn_activation.Size = new System.Drawing.Size(402, 46);
            this.btn_activation.TabIndex = 12;
            this.btn_activation.Text = "فعال سازی";
            this.btn_activation.UseVisualStyleBackColor = true;
            this.btn_activation.Click += new System.EventHandler(this.btn_activation_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(427, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_debug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_activation);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.cmb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_serial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSplash_FormClosed);
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_activation;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_debug;
        private System.Windows.Forms.Button button2;
    }
}

