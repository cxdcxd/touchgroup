using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace TouchGroup
{
	public class server_manager_license
	{
        private TcpListener tcpListener;
        private Thread listenThread;

        public bool init()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, int.Parse(Statics.Server_Port_num_license));
                listenThread = new Thread(new ThreadStart(ListenForClients));
                Statics.isConnectionActiveServer_licesne = true;
                listenThread.Start();
                Log.log_info("License Server Started");
            }
            catch
            {
                Statics.isConnectionActiveServer_licesne = false;
                return false;
            }

            return true;
        }
      
        private void ListenForClients()
        {
            this.tcpListener.Start();

            while (Statics.isConnectionActiveServer_licesne)
            {
                try
                {
                    TcpClient client = this.tcpListener.AcceptTcpClient();
                    my_server_license myclient = new my_server_license("none", client);
                }
                catch (System.Exception ex)
                {
                    break;
                }
            }

            tcpListener.Stop();
        }
      
        public void kill()
        {
            Statics.isConnectionActiveServer_licesne = false;
            tcpListener.Stop();
            Log.log_info("License Server Stoped");
        }
      
	}
}