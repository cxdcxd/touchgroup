
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchGroup
{
    class Statics
    {
        static int version = 1;
        public static string HardwareId;
        public static User CurrentUser;
        public static Setting CurrentSetting;
        public static string Version;
        public static bool IsActivated;
        public static List<string> ValidTabletsIdList;
       
        public static int debugLevel = 1;
        public static frmSplash frmSplashRef;
        public static frmMain frmMainRef;

        public static bool isConnectionActiveServer = false;
        public static bool isConnectionActiveServer_licesne = false;
        public static FTPserver ftpserver;
        public static string FTPServer_Port_num = "5544";
        public static string Server_Port_num = "6000";
        public static string Server_Port_num_license = "9000";
        public static server_manager_tcp server_manager;
        public static server_manager_license server_manager_license;
        public static string path_menu_sql = "";
        public static string path_menu = "";
        public static int image_size_limitation = 600; //KB
        /// <summary>
        /// use this for image selection last opened directory
        /// </summary>
        public static string last_opend_directory = "";
        public static List<InputBuffer_data> InputBuffer = new List<InputBuffer_data>();
        public static List<InputBuffer_data> OutputBuffer = new List<InputBuffer_data>();
        public static List<Productd> list_products = new List<Productd>();
        public static List<ProductdGroup> list_product_groups = new List<ProductdGroup>();

        public static string checksum;

        /// <summary>
        /// Use this to compute the checksum for sqllite menu to predict the file changes
        /// </summary>
        public static void compute_md5_checksum()
        {
            if (File.Exists(Statics.path_menu_sql) == false) return;
            FileInfo info = new FileInfo(Statics.path_menu_sql);
            Statics.checksum = info.LastWriteTime.Second.ToString() + info.LastWriteTime.Millisecond.ToString();
        }

    }
}
