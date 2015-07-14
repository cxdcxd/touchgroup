using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace TouchGroup
{
    /// <summary>
    /// This is the main form for showing the system log and system information
    /// </summary>
    public partial class frmDebug : Form
    {

        public frmDebug()
        {
            InitializeComponent();
        }

        private string DeviceInformation(string stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            try
            {
                ManagementClass ManagementClass1 = new ManagementClass(stringIn);
                //Create a ManagementObjectCollection to loop through
                ManagementObjectCollection ManagemenobjCol = ManagementClass1.GetInstances();
                //Get the properties in the class
                PropertyDataCollection properties = ManagementClass1.Properties;
                foreach (ManagementObject obj in ManagemenobjCol)
                {
                    foreach (PropertyData property in properties)
                    {
                        try
                        {
                            StringBuilder1.AppendLine(property.Name + ":  " + obj.Properties[property.Name].Value.ToString());
                        }
                        catch
                        {
                            //Add codes to manage more informations
                        }
                    }
                    StringBuilder1.AppendLine();
                }
            }
            catch
            {
                //Win 32 Classes Which are not defined on client system
            }
            return StringBuilder1.ToString();
        }

        private void load_devices()
        {
           //string[] a = DeviceInformation("Win32_Processor").Split('\n');
           //string[] c = DeviceInformation("Win32_VideoController").Split('\n');
           //string[] d = DeviceInformation("Win32_Battery").Split('\n');
           //string[] e = DeviceInformation("Win32_Desktop").Split('\n');
           //string[] f = DeviceInformation("Win32_MemoryDevice").Split('\n');
           //string[] g = DeviceInformation("Win32_MotherboardDevice").Split('\n');
           //string[] h = DeviceInformation("Win32_MotherboardDevice").Split('\n');
           //string[] i = DeviceInformation("Win32_NetworkAdapter").Split('\n');
           //string[] j = DeviceInformation("Win32_PhysicalMemory").Split('\n');
            

        }
        private void load_info()
        {
            lst_information.Items.Clear();
          
            try
            {
                lst_information.Items.Add(Log.OSVersion);
                lst_information.Items.Add(Log.Type);
                lst_information.Items.Add(Log.Pcount);
                lst_information.Items.Add(Log.SDirectory);
                lst_information.Items.Add(Log.UName);
            }
            catch
            {
            }
            
        }
        void load_log()
        {
            lst_log.Items.Clear();
            for ( int i = 0 ; i < Log.main_log.Count ; i++ )
            lst_log.Items.Add(Log.main_log[i]);
        }
        private void frmDebug_Load(object sender, EventArgs e)
        {
            load_log();
            load_info();
            load_devices();
        }
    }
}
