using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchGroup
{
    class Licensing
    {
        static int version = 1;
        public static bool Activate()
        {
            FileStream fs = new FileStream("license.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                StreamReader sr = new StreamReader(fs);
                string a = sr.ReadLine();
                string b = sr.ReadLine();

                a = CryptorEngine.Decrypt(a);
                b = CryptorEngine.Decrypt(b);

                sr.Close();
                fs.Close();

                string[] tabs = a.Split('\n');

                Statics.ValidTabletsIdList = new List<string>();

                for (int i = 0; i < tabs.Length; i++)
                    Statics.ValidTabletsIdList.Add(tabs[i]);

                if (b == Statics.HardwareId)
                    return true;
                else
                    return false;
            }
            catch
            {
                fs.Close();
                return false;
            }
        }

        public static bool SelectActivationFile()
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt license file|*.txt";
            openFileDialog1.Title = "فعالسازی";

            DialogResult r = openFileDialog1.ShowDialog();

            try
            {

                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    File.Copy(openFileDialog1.FileName, Environment.CurrentDirectory + "\\license.txt", true);
                    return true;
                }
            }
            catch
            {
                MBOX mbox = new MBOX("مشکل در انتقال فایل ، لطفا تمامی برنامه های جانبی را ببندید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
