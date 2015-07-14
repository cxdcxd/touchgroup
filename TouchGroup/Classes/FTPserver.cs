using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mooftpserv;
using System.Net;
using System.Threading;

namespace TouchGroup
{
    class FTPserver
    {
        static int version = 1;
        Server ftpserver;
        
        void Run()
        {
            Log.log_info("FTP Server Started");
            ftpserver.Run();
        }
        public FTPserver()
        {
            ftpserver = new Server();
            ftpserver.LocalEndPoint = new System.Net.IPEndPoint(IPAddress.Any, int.Parse(Statics.FTPServer_Port_num));
            ftpserver.LogHandler = new DefaultLogHandler(false);
            Thread clientThread = new Thread(new ThreadStart(Run));
            clientThread.Start();
        }

        public void kill()
        {
            ftpserver.Stop();
            ftpserver = null;
            Log.log_info("FTP Server Stoped");
        }
    }
}
