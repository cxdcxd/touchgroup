using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Net.Sockets;
using System.Threading;

namespace TouchGroup
{
    public class my_server_license
    {
        public string name;
        TcpClient client;
      
        public void disconnect()
        {
            client.Close();
        }

        public my_server_license(string name, TcpClient tcpclient)
        {
            this.name = name;
            client = tcpclient;

            Thread clientThread = new Thread(new ThreadStart(HandleClientComm));
            clientThread.Start();
        }

        void read_recive(string msg)
        {
            string[] array = msg.Split(',');

            if ( array.Length == 2 )
            {
                if ( array[0] == "License")
                {
                    if (Statics.ValidTabletsIdList.Contains(array[1]))
                    {
                        string packet = "";
                        packet = CryptorEngine.Encrypt(array[1]);
                        write_send(packet);
                    }
                    else
                    {
                        write_send("notvalid");
                    }
                }
            }
            else
            {
                write_send("notvalid");
            }
        }

        public void write_send(string msg)
        {
            //MSG IS THE MESSAGE TO SEND TO CLIENT
            //////////////////////////////////////
            NetworkStream clientStream = client.GetStream();
            byte[] buffer = Encoding.Default.GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }

        private void HandleClientComm()
        {
            TcpClient tcpClient = client;

            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead = 0;

            try
            {
                //wait for request from that client
                bytesRead = clientStream.Read(message, 0, 4096);
                ASCIIEncoding encoder = new ASCIIEncoding();
                string read_str = encoder.GetString(message, 0, bytesRead);
                read_recive(read_str);
            }
            catch
            {

            }

            tcpClient.Close();
        }
    }
}