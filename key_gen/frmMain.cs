using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace key_gen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
                txt_core.Text = EnCryptDecrypt.CryptorEngine.Encrypt(txt_id.Text, false);
            else
                txt_core.Text = "";

            if (txt_clients.Text != "")
            {
                txt_code.Text = EnCryptDecrypt.CryptorEngine.Encrypt(txt_clients.Text, false);
            }
            else
            {
                txt_code.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_clients.Text = "";
            txt_code.Text = "";
            txt_id.Text = "";
            txt_core.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                if (path.Contains(".txt") == false) path += ".txt";

                FileStream Fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(Fs);

                if (txt_code.Text != "")
                    sw.WriteLine(txt_code.Text);
                else
                    sw.WriteLine("none");

                if (txt_core.Text != "")
                    sw.WriteLine(txt_core.Text);
                else
                    sw.WriteLine("none");

 
                sw.Close();
                Fs.Close();

            }
        }
    }
}
