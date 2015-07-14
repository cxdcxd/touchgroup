using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchGroup
{
    public partial class frmAbout : XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lbl_version.Text = "Version : " + Application.ProductVersion + "\nAll Rights Reserved Sadena International ® Co.";
            
            for ( int i = 0 ; i < Statics.ValidTabletsIdList.Count ; i++)
            {
                lst_tablets.Items.Add(" [" + (i+1) + "] " + Statics.ValidTabletsIdList[i]);
            }
        
        }
    }
}
