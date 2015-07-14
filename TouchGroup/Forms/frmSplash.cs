using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchGroup
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            Statics.frmSplashRef = this;
            InitializeComponent();
        }

        public void Kill()
        {
            //1 kill log
            Log.kill();

            Application.Exit();
        }
        void Init()
        {
            //0
            Statics.path_menu_sql = Environment.CurrentDirectory + "\\data\\menu.db";
            Statics.path_menu = Environment.CurrentDirectory + "\\data\\menu.db";
            Statics.path_menu = Statics.path_menu.Replace(":", "");
            Statics.path_menu = "/" + Statics.path_menu.Replace("\\", "/");

            //1 get system serial number
            txt_serial.Text = FingerPrint.Value();
            Statics.HardwareId = txt_serial.Text;

            //2 get application version
            lbl_version.Text = "Version : " + Application.ProductVersion + "\nAll Rights Reserved Sadena International Co.";
            Statics.Version = Application.ProductVersion;

            //3 attach mdf to SQL local db
            DBMS_Linq.attach();

            //4 get setting
            Statics.CurrentSetting = DBMS_Linq.get_setting();

            //5 check for licensing
            Statics.IsActivated = Licensing.Activate();

           
            if (Statics.IsActivated)
            {
                btn_activation.Enabled = false;
                btn_login.Enabled = true;
            }
            else
            {
                btn_activation.Enabled = true;
                btn_login.Enabled = false;
            }


            //6 show all users in combobox
            List<User> users = DBMS_Linq.get_users();
            for (int i = 0; i < users.Count; i++)
                cmb_username.Items.Add(users[i].UserName);

            //7 Init Log
            Log.init();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cmb_username.SelectedItem == null)
            {
                //error please fill all the blanks
                MBOX mbox = new MBOX("لطفا تمام موارد را پر نمایید","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                    this.Hide();

                    //2
                    Statics.frmMainRef = new frmMain();
                    Statics.frmMainRef.Show();
                }
            }
            else
            {
                //error please fill all the blanks
                MBOX mbox = new MBOX("لطفا تمام موارد را پر نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_activation_Click(object sender, EventArgs e)
        {
            bool r = Licensing.SelectActivationFile();
            if (r)
            {
                Statics.IsActivated = Licensing.Activate();
                if (Statics.IsActivated)
                {
                    btn_activation.Enabled = false;
                    btn_login.Enabled = true;
                }
                else
                {
                    btn_activation.Enabled = true;
                    btn_login.Enabled = false;
                }
                if (Statics.IsActivated)
                {
                    MBOX mbox = new MBOX("فعالسازی با موفقیت انجام شد");
                }
                else
                {
                    MBOX mbox = new MBOX("فعالسازی با مشکل مواجه گردید","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            Init();
            Log.log_info("Splash Started");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kill();
        }

        private void frmSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kill();
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            frmDebug d = new frmDebug();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAbout a = new frmAbout();
            a.ShowDialog();
        }

     
    }
}
