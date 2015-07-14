using DevExpress.XtraEditors;
using LumiSoft.Net.TCP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchGroup
{
    public partial class frmMain : XtraForm
    {

        private ContextMenu listboxContextMenu;

        public frmMain()
        {
            InitializeComponent();
        }
        void kill()
        {
            timer_main.Stop();
            stop_servers();
            Statics.frmSplashRef.Kill();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            MBOX MB = new MBOX("آيا مايليد از نرم افزار خارج شويد ؟", "سيستم...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            DialogResult result = MB.DialogResult;

            if (result != DialogResult.Cancel)
            {
                e.Cancel = false;
                try
                {
                    kill();
                }
                catch
                {
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        void update_splitter()
        {
            splitContainerControl.SplitterPosition = Width - 300; 
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            init();
        }

        public void InitGrid2()
        {

        }
        public void start_servers()
        {
            Statics.server_manager = new server_manager_tcp();
            Statics.server_manager_license = new server_manager_license();
            Statics.server_manager.updateplayer += server_manager_updateplayer;
            Statics.server_manager.start_server();
            Statics.server_manager_license.init();
            Statics.ftpserver = new FTPserver();
        }
        void server_manager_updateplayer(TCPEventArgs args)
        {
            //Update Client List
            Log.log_info("TCP Update Players");
        }
        public void stop_servers()
        {
            try
            {
                TCP_Session[] array = Statics.server_manager.server.Sessions.ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    try
                    {
                        array[i].Disconnect();
                    }
                    catch
                    {

                    }
                }

            }
            catch
            {

            }

            if (Statics.server_manager != null)
            {
                Statics.server_manager.stop_server();
                Statics.server_manager = null;
            }

            if (Statics.server_manager_license != null)
            {
                Statics.server_manager_license.kill();
                Statics.server_manager_license = null;
            }

            if (Statics.ftpserver != null)
            {
                Statics.ftpserver.kill();
                Statics.ftpserver = null;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            update_splitter();
        }
        void create_contex()
        {
            //1
            listboxContextMenu = new ContextMenu();
            listboxContextMenu.MenuItems.Add("ثبت");
            listboxContextMenu.MenuItems.Add("حذف");
            listboxContextMenu.MenuItems.Add("چاپ");

            listboxContextMenu.MenuItems[0].Click += frmMain_Clickok;
            listboxContextMenu.MenuItems[1].Click += frmMain_Clickdel;
            listboxContextMenu.MenuItems[2].Click += frmMain_Clickprint;

            listboxContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            imageListBoxtable.ContextMenu = listboxContextMenu;

            //2
            listboxContextMenu = new ContextMenu();
            listboxContextMenu.MenuItems.Add("پذیرش");
            listboxContextMenu.MenuItems[0].Click += frmMain_Clickgarsonok;
            listboxContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            imageListBoxgarson.ContextMenu = listboxContextMenu;

            //3
            listboxContextMenu = new ContextMenu();
            listboxContextMenu.MenuItems.Add("صدای جستجو");
            listboxContextMenu.MenuItems.Add("حذف از شبکه");

            listboxContextMenu.MenuItems[0].Click += frmMain_Clicktabletsound;
            listboxContextMenu.MenuItems[1].Click += frmMain_Clicktabletdisconnect;
            listboxContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            imageListBoxwifi.ContextMenu = listboxContextMenu;
        }

        void frmMain_Clicktabletdisconnect(object sender, EventArgs e)
        {
          
        }
        void frmMain_Clicktabletsound(object sender, EventArgs e)
        {
           
        }
        void frmMain_Clickgarsonok(object sender, EventArgs e)
        {
           
        }
        void frmMain_Clickok(object sender, EventArgs e)
        {
           
        }
        void frmMain_Clickdel(object sender, EventArgs e)
        {
            

        }
        void frmMain_Clickprint(object sender, EventArgs e)
        {
            
        }
        void init()
        {
            //1
            timer_main.Enabled = true;

            //2 
            start_servers();

            //3
            update_splitter();

            //4
            create_contex();

            //5
            DBMS_Linq.reload_products();
            DBMS_Linq.reload_product_groups();
           
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAbout a = new frmAbout();
            a.ShowDialog();
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin l = new frmLogin();
            l.ShowDialog();
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            //Main Form Timer
            txt_date.Caption = SystemTime.get_persian_date().ToWritten();
            txt_time.Caption = SystemTime.get_time();

            if (Statics.CurrentUser != null)
                txt_user.Caption = "کاربر :" + Statics.CurrentUser.UserName + "    " + "نام و نام خانوادگي  :" + Statics.CurrentUser.Info + "    " + "سمت :" + Statics.CurrentUser.Type;
            else
                txt_user.Caption = "";

            ribbonStatusBar.Refresh();
        }

        private void bntHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDebug d = new frmDebug();
            d.ShowDialog();
        }

        private void btnPosOrdering_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnMenuCreator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMenuCreator mc = new frmMenuCreator();
            mc.ShowDialog();
        }

       
    }
}
