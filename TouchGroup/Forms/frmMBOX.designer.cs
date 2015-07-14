namespace TouchGroup
{
    partial class MBOX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBOX));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancle = new DevExpress.XtraEditors.SimpleButton();
            this.p_q = new System.Windows.Forms.PictureBox();
            this.p_i = new System.Windows.Forms.PictureBox();
            this.p_w = new System.Windows.Forms.PictureBox();
            this.p_e = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "warning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "info";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(89, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(299, 0);
            this.labelControl3.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "ques";
            // 
            // btn_ok
            // 
            this.btn_ok.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Appearance.Options.UseFont = true;
            this.btn_ok.Image = global::TouchGroup.Properties.Resources.accept1;
            this.btn_ok.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_ok.Location = new System.Drawing.Point(238, 84);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(115, 33);
            this.btn_ok.TabIndex = 87;
            this.btn_ok.Text = "تایید";
            this.btn_ok.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancle.Appearance.Options.UseFont = true;
            this.btn_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancle.Image = global::TouchGroup.Properties.Resources.cancle_mini3;
            this.btn_cancle.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_cancle.Location = new System.Drawing.Point(117, 84);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(115, 33);
            this.btn_cancle.TabIndex = 88;
            this.btn_cancle.Text = "انصراف";
            this.btn_cancle.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // p_q
            // 
            this.p_q.Image = global::TouchGroup.Properties.Resources.question1;
            this.p_q.Location = new System.Drawing.Point(94, 146);
            this.p_q.Name = "p_q";
            this.p_q.Size = new System.Drawing.Size(64, 64);
            this.p_q.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_q.TabIndex = 97;
            this.p_q.TabStop = false;
            // 
            // p_i
            // 
            this.p_i.Image = global::TouchGroup.Properties.Resources.gtk_info;
            this.p_i.Location = new System.Drawing.Point(238, 146);
            this.p_i.Name = "p_i";
            this.p_i.Size = new System.Drawing.Size(64, 64);
            this.p_i.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_i.TabIndex = 94;
            this.p_i.TabStop = false;
            // 
            // p_w
            // 
            this.p_w.Image = global::TouchGroup.Properties.Resources.dialog_warning;
            this.p_w.Location = new System.Drawing.Point(168, 146);
            this.p_w.Name = "p_w";
            this.p_w.Size = new System.Drawing.Size(64, 64);
            this.p_w.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_w.TabIndex = 91;
            this.p_w.TabStop = false;
            // 
            // p_e
            // 
            this.p_e.Image = global::TouchGroup.Properties.Resources.dialog_error;
            this.p_e.Location = new System.Drawing.Point(24, 146);
            this.p_e.Name = "p_e";
            this.p_e.Size = new System.Drawing.Size(64, 64);
            this.p_e.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_e.TabIndex = 90;
            this.p_e.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // MBOX
            // 
            this.AcceptButton = this.btn_ok;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancle;
            this.ClientSize = new System.Drawing.Size(406, 129);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_q);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p_i);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_w);
            this.Controls.Add(this.p_e);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MBOX";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MBOX_FormClosed);
            this.Load += new System.EventHandler(this.MBOX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

				private DevExpress.XtraEditors.SimpleButton btn_cancle;
				private DevExpress.XtraEditors.SimpleButton btn_ok;
				private System.Windows.Forms.PictureBox pictureBox1;
				private System.Windows.Forms.PictureBox p_e;
				private System.Windows.Forms.PictureBox p_w;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.PictureBox p_i;
				private DevExpress.XtraEditors.LabelControl labelControl3;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.PictureBox p_q;

		}
}