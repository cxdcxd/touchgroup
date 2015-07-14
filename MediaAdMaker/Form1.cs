using GifComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        delegate void update(Image img);
        update del_update;

        void up(Image img)
        {
            pictureBox1.Image = img;
        }
        public Form1()
        {
            InitializeComponent();
            del_update = new update(up);
        }
        string[] names;

        private void Form1_Load(object sender, EventArgs e)
        {
            names = Directory.GetFiles(Environment.CurrentDirectory + "\\gif\\");

            for (int i = 0; i < names.Length; i++)
            {
                string[] splita = names[i].Split('\\');

                listBox1.Items.Add(splita[splita.Length - 1]);
            }
        }

        List<Image> image_list;
        List<int> delay_list;

        private void button1_Click(object sender, EventArgs e)
        {
           image_list = new System.Collections.Generic.List<Image>();
           delay_list = new List<int>();

            for (int i = 0; i < names.Length; i++)
            {
                GifDecoder myDecoder = new GifDecoder(names[i]);
                myDecoder.Decode();

                for (int j = 0; j < myDecoder.Frames.Count; j++)
                {
                    image_list.Add(myDecoder.Frames[j].TheImage);
                    delay_list.Add(myDecoder.Frames[j].Delay);
                }
            }

            List<byte> mainad = new System.Collections.Generic.List<byte>();
            string map_str = "";

            for (int i = 0; i < image_list.Count ; i++)
            {
                MemoryStream ms = new MemoryStream();
                image_list[i].Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                byte[] all = ms.ToArray();

                for (int j = 0; j < all.Length; j++)
                {
                    mainad.Add(all[j]);
                }

                if (i != image_list.Count - 1)
                    map_str += all.Length + "|" + delay_list[i] + ",";
                else
                    map_str += all.Length + "|" + delay_list[i];


            }

            string cx = EnCryptDecrypt.CryptorEngine.Encrypt(map_str, false);
            byte[] mapfile = Encoding.UTF8.GetBytes(cx);

            int map_len = mapfile.Length;

            byte[] big_file = new byte[map_len + mainad.Count + 4];

            big_file[0] = (byte)((map_len >> 24) & 0xFF);
            big_file[1] = (byte)((map_len >> 16) & 0xFF);
            big_file[2] = (byte)((map_len >> 8) & 0xFF);
            big_file[3] = (byte)(map_len & 0xFF);

            int index = 4;

            for (int i = 0; i < mapfile.Length; i++)
            {
                big_file[index] = mapfile[i];
                index++;
            }

            for (int i = 0; i < mainad.Count ; i++)
            {
                big_file[index] = mainad[i];
                index++;
            }

            //==============
            //we have map , dely and images !
            FileStream fs3 = new FileStream(Environment.CurrentDirectory + "\\export\\mainadx.big", FileMode.Create);
            fs3.Write(big_file, 0, big_file.Length);
            fs3.Close();


            t = new Thread(new ThreadStart(new_thread));
            t.Start();
        }

        void new_thread()
        {
            for ( int i = 0 ; i < image_list.Count ; i++ )
            {
                //pictureBox1.Image = image_list[i];
                try
                {
                    this.Invoke(del_update, image_list[i]);
                }
                catch
                {

                }
                Thread.Sleep(delay_list[i] * 10); //WOW
            }
        }
        Thread t;
        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ( t  != null )
            {
                t.Abort();
                t.Interrupt();
            }
        }
    }
}
