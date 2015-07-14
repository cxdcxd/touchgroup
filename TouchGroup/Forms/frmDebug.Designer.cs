namespace TouchGroup
{
    partial class frmDebug
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lst_log = new System.Windows.Forms.ListBox();
            this.lst_info = new System.Windows.Forms.TabPage();
            this.lst_information = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.lst_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.lst_info);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lst_log);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lst_log
            // 
            this.lst_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_log.FormattingEnabled = true;
            this.lst_log.Location = new System.Drawing.Point(3, 3);
            this.lst_log.Name = "lst_log";
            this.lst_log.Size = new System.Drawing.Size(691, 344);
            this.lst_log.TabIndex = 0;
            // 
            // lst_info
            // 
            this.lst_info.Controls.Add(this.lst_information);
            this.lst_info.Location = new System.Drawing.Point(4, 22);
            this.lst_info.Name = "lst_info";
            this.lst_info.Padding = new System.Windows.Forms.Padding(3);
            this.lst_info.Size = new System.Drawing.Size(697, 350);
            this.lst_info.TabIndex = 1;
            this.lst_info.Text = "System Information";
            this.lst_info.UseVisualStyleBackColor = true;
            // 
            // lst_information
            // 
            this.lst_information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_information.FormattingEnabled = true;
            this.lst_information.Location = new System.Drawing.Point(3, 3);
            this.lst_information.Name = "lst_information";
            this.lst_information.Size = new System.Drawing.Size(691, 344);
            this.lst_information.TabIndex = 0;
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 400);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDebug";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Touch Group Debug";
            this.Load += new System.EventHandler(this.frmDebug_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.lst_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage lst_info;
        private System.Windows.Forms.ListBox lst_log;
        private System.Windows.Forms.ListBox lst_information;
    }
}