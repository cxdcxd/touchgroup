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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bnt_lock_Click(object sender, EventArgs e)
        {
            bnt_lock.Visible = false;
            btn_cancel.Visible = false;

            btn_ok.Size = new Size(220, 37);
           

            cmb_username.Location = new Point(22, 57);
            txt_password.Location = new Point(22, 100);
            labelControl1.Location = new Point(190, 70);
            labelControl2.Location = new Point(190, 110);

            btn_ok.Location = new Point(24, 140);
        }

        bool normal_exit = false;
        protected override void OnClosing(CancelEventArgs e)
        {
            if (normal_exit == false)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cmb_username.SelectedItem == null)
            {
                //error please fill all the blanks
                MBOX mbox = new MBOX("لطفا تمام موارد را پر نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Username = cmb_username.SelectedItem.ToString();
            string Password = txt_password.Text;

            if (Username != "" && Password != "")
            {
                Statics.CurrentUser = DBMS_Linq.get_login(Username, Password);
                if (Statics.CurrentUser == null)
                {
                    MBOX mbox = new MBOX("کلمه عبور نادرست می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //OK Login to Application
                    //1
                    normal_exit = true;
                    Close();
                  
                }
            }
            else
            {
                //error please fill all the blanks
                MBOX mbox = new MBOX("لطفا تمام موارد را پر نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            normal_exit = true;
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            List<User> users = DBMS_Linq.get_users();
            for (int i = 0; i < users.Count; i++)
                cmb_username.Items.Add(users[i].UserName);
        }
    }
}
