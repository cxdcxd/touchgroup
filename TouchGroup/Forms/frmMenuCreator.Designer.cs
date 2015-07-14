namespace TouchGroup
{
    partial class frmMenuCreator
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.progressbar_main = new System.Windows.Forms.ProgressBar();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_delete_product = new DevExpress.XtraEditors.SimpleButton();
            this.btn_down_product = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit_product = new DevExpress.XtraEditors.SimpleButton();
            this.btn_up_product = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new_product = new DevExpress.XtraEditors.SimpleButton();
            this.listBox_foods = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_edit_group = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete_group = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.btn_down_group = new DevExpress.XtraEditors.SimpleButton();
            this.txt_group_name_farsi = new DevExpress.XtraEditors.TextEdit();
            this.btn_up_group = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txt_group_name_english = new DevExpress.XtraEditors.TextEdit();
            this.bnt_new_group = new DevExpress.XtraEditors.SimpleButton();
            this.listBox_groups = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_foods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group_name_farsi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group_name_english.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_groups)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl2.Controls.Add(this.progressbar_main);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.listBox_foods);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Controls.Add(this.listBox_groups);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(703, 533);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "منوی غذا";
            // 
            // progressbar_main
            // 
            this.progressbar_main.Location = new System.Drawing.Point(0, 516);
            this.progressbar_main.Name = "progressbar_main";
            this.progressbar_main.Size = new System.Drawing.Size(703, 12);
            this.progressbar_main.TabIndex = 30;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl3.Controls.Add(this.btn_delete_product);
            this.groupControl3.Controls.Add(this.btn_down_product);
            this.groupControl3.Controls.Add(this.btn_edit_product);
            this.groupControl3.Controls.Add(this.btn_up_product);
            this.groupControl3.Controls.Add(this.btn_new_product);
            this.groupControl3.Location = new System.Drawing.Point(10, 290);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(343, 218);
            this.groupControl3.TabIndex = 29;
            this.groupControl3.Text = "غذا";
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.Image = global::TouchGroup.Properties.Resources.cup_delete;
            this.btn_delete_product.Location = new System.Drawing.Point(5, 169);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(333, 40);
            this.btn_delete_product.TabIndex = 9;
            this.btn_delete_product.Text = "حذف غذا";
            this.btn_delete_product.Click += new System.EventHandler(this.btn_delete_product_Click);
            // 
            // btn_down_product
            // 
            this.btn_down_product.Image = global::TouchGroup.Properties.Resources.d;
            this.btn_down_product.Location = new System.Drawing.Point(44, 27);
            this.btn_down_product.Name = "btn_down_product";
            this.btn_down_product.Size = new System.Drawing.Size(34, 35);
            this.btn_down_product.TabIndex = 9;
            this.btn_down_product.Click += new System.EventHandler(this.btn_down_product_Click);
            // 
            // btn_edit_product
            // 
            this.btn_edit_product.Image = global::TouchGroup.Properties.Resources.cup_edit;
            this.btn_edit_product.Location = new System.Drawing.Point(5, 123);
            this.btn_edit_product.Name = "btn_edit_product";
            this.btn_edit_product.Size = new System.Drawing.Size(333, 40);
            this.btn_edit_product.TabIndex = 8;
            this.btn_edit_product.Text = "ویرایش غذا";
            this.btn_edit_product.Click += new System.EventHandler(this.btn_edit_product_Click);
            // 
            // btn_up_product
            // 
            this.btn_up_product.Image = global::TouchGroup.Properties.Resources.u;
            this.btn_up_product.Location = new System.Drawing.Point(5, 27);
            this.btn_up_product.Name = "btn_up_product";
            this.btn_up_product.Size = new System.Drawing.Size(33, 35);
            this.btn_up_product.TabIndex = 10;
            this.btn_up_product.Click += new System.EventHandler(this.btn_up_product_Click);
            // 
            // btn_new_product
            // 
            this.btn_new_product.Image = global::TouchGroup.Properties.Resources.cup_add;
            this.btn_new_product.Location = new System.Drawing.Point(5, 77);
            this.btn_new_product.Name = "btn_new_product";
            this.btn_new_product.Size = new System.Drawing.Size(333, 40);
            this.btn_new_product.TabIndex = 7;
            this.btn_new_product.Text = "غذای جدید";
            this.btn_new_product.Click += new System.EventHandler(this.btn_new_product_Click);
            // 
            // listBox_foods
            // 
            this.listBox_foods.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBox_foods.Appearance.Options.UseFont = true;
            this.listBox_foods.Appearance.Options.UseTextOptions = true;
            this.listBox_foods.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.listBox_foods.ItemHeight = 30;
            this.listBox_foods.Location = new System.Drawing.Point(10, 30);
            this.listBox_foods.Name = "listBox_foods";
            this.listBox_foods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox_foods.Size = new System.Drawing.Size(343, 254);
            this.listBox_foods.TabIndex = 8;
            this.listBox_foods.DoubleClick += new System.EventHandler(this.listBox_foods_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControl1.Controls.Add(this.btn_edit_group);
            this.groupControl1.Controls.Add(this.btn_delete_group);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.btn_down_group);
            this.groupControl1.Controls.Add(this.txt_group_name_farsi);
            this.groupControl1.Controls.Add(this.btn_up_group);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txt_group_name_english);
            this.groupControl1.Controls.Add(this.bnt_new_group);
            this.groupControl1.Location = new System.Drawing.Point(359, 289);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(336, 219);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "گروه";
            // 
            // btn_edit_group
            // 
            this.btn_edit_group.Image = global::TouchGroup.Properties.Resources.folder_edit;
            this.btn_edit_group.Location = new System.Drawing.Point(7, 134);
            this.btn_edit_group.Name = "btn_edit_group";
            this.btn_edit_group.Size = new System.Drawing.Size(323, 35);
            this.btn_edit_group.TabIndex = 4;
            this.btn_edit_group.Text = "ویرایش گروه";
            this.btn_edit_group.Click += new System.EventHandler(this.btn_edit_group_Click);
            // 
            // btn_delete_group
            // 
            this.btn_delete_group.Image = global::TouchGroup.Properties.Resources.folder_delete;
            this.btn_delete_group.Location = new System.Drawing.Point(7, 174);
            this.btn_delete_group.Name = "btn_delete_group";
            this.btn_delete_group.Size = new System.Drawing.Size(323, 36);
            this.btn_delete_group.TabIndex = 6;
            this.btn_delete_group.Text = "حذف گروه ";
            this.btn_delete_group.Click += new System.EventHandler(this.btn_delete_group_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(264, 111);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(66, 13);
            this.labelControl16.TabIndex = 21;
            this.labelControl16.Text = ": نام انگلیسی";
            // 
            // btn_down_group
            // 
            this.btn_down_group.Image = global::TouchGroup.Properties.Resources.d;
            this.btn_down_group.Location = new System.Drawing.Point(46, 25);
            this.btn_down_group.Name = "btn_down_group";
            this.btn_down_group.Size = new System.Drawing.Size(34, 35);
            this.btn_down_group.TabIndex = 6;
            this.btn_down_group.Click += new System.EventHandler(this.btn_down_group_Click);
            // 
            // txt_group_name_farsi
            // 
            this.txt_group_name_farsi.Location = new System.Drawing.Point(115, 64);
            this.txt_group_name_farsi.Name = "txt_group_name_farsi";
            this.txt_group_name_farsi.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.txt_group_name_farsi.Properties.Appearance.Options.UseFont = true;
            this.txt_group_name_farsi.Properties.MaxLength = 30;
            this.txt_group_name_farsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_group_name_farsi.Size = new System.Drawing.Size(143, 32);
            this.txt_group_name_farsi.TabIndex = 1;
            // 
            // btn_up_group
            // 
            this.btn_up_group.Image = global::TouchGroup.Properties.Resources.u;
            this.btn_up_group.Location = new System.Drawing.Point(7, 25);
            this.btn_up_group.Name = "btn_up_group";
            this.btn_up_group.Size = new System.Drawing.Size(33, 35);
            this.btn_up_group.TabIndex = 7;
            this.btn_up_group.Click += new System.EventHandler(this.btn_up_group_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(264, 73);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(57, 13);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = ": نام فارسی";
            // 
            // txt_group_name_english
            // 
            this.txt_group_name_english.Location = new System.Drawing.Point(115, 103);
            this.txt_group_name_english.Name = "txt_group_name_english";
            this.txt_group_name_english.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_group_name_english.Properties.Appearance.Options.UseFont = true;
            this.txt_group_name_english.Properties.MaxLength = 30;
            this.txt_group_name_english.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_group_name_english.Size = new System.Drawing.Size(143, 26);
            this.txt_group_name_english.TabIndex = 2;
            // 
            // bnt_new_group
            // 
            this.bnt_new_group.Image = global::TouchGroup.Properties.Resources.folder_add;
            this.bnt_new_group.Location = new System.Drawing.Point(7, 64);
            this.bnt_new_group.Name = "bnt_new_group";
            this.bnt_new_group.Size = new System.Drawing.Size(102, 64);
            this.bnt_new_group.TabIndex = 3;
            this.bnt_new_group.Text = "گروه جدید ";
            this.bnt_new_group.Click += new System.EventHandler(this.bnt_new_group_Click);
            // 
            // listBox_groups
            // 
            this.listBox_groups.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBox_groups.Appearance.Options.UseFont = true;
            this.listBox_groups.Appearance.Options.UseTextOptions = true;
            this.listBox_groups.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.listBox_groups.ItemHeight = 30;
            this.listBox_groups.Location = new System.Drawing.Point(359, 29);
            this.listBox_groups.Name = "listBox_groups";
            this.listBox_groups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox_groups.Size = new System.Drawing.Size(336, 255);
            this.listBox_groups.TabIndex = 4;
            this.listBox_groups.SelectedIndexChanged += new System.EventHandler(this.listBox_groups_SelectedIndexChanged);
            // 
            // simpleButton7
            // 
            this.simpleButton7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton7.Image = global::TouchGroup.Properties.Resources.cancle_mini3;
            this.simpleButton7.Location = new System.Drawing.Point(709, 0);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(33, 35);
            this.simpleButton7.TabIndex = 23;
            // 
            // frmMenuCreator
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton7;
            this.ClientSize = new System.Drawing.Size(705, 528);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuCreator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش منو";
            this.Load += new System.EventHandler(this.frmqmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBox_foods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group_name_farsi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group_name_english.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_groups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_down_product;
        private DevExpress.XtraEditors.SimpleButton btn_up_product;
        private DevExpress.XtraEditors.ListBoxControl listBox_foods;
        private DevExpress.XtraEditors.SimpleButton btn_down_group;
        private DevExpress.XtraEditors.SimpleButton btn_up_group;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txt_group_name_farsi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txt_group_name_english;
        private DevExpress.XtraEditors.SimpleButton bnt_new_group;
        private DevExpress.XtraEditors.ListBoxControl listBox_groups;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_delete_product;
        private DevExpress.XtraEditors.SimpleButton btn_edit_product;
        private DevExpress.XtraEditors.SimpleButton btn_new_product;
        private DevExpress.XtraEditors.SimpleButton btn_delete_group;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton btn_edit_group;
        private System.Windows.Forms.ProgressBar progressbar_main;

    }
}