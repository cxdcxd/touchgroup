using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Sockets;
using System.Threading;
using System.Net;
using LumiSoft.Net.TCP;
using LumiSoft.Net;

namespace TouchGroup
{
  
    class InputBuffer_data
    {
        public string command;
        public  TCP_Session client;
    }

    public class client_object
    {
        TCP_Session target;

        public client_object(TCP_Session t)
        {
            target = t;
            begin_read_server();
        }

        void begin_read_server()
        {
            byte[] buffer = new byte[4096];
            LumiSoft.Net.IO.SmartStream.ReadLineAsyncOP op = new LumiSoft.Net.IO.SmartStream.ReadLineAsyncOP(buffer, LumiSoft.Net.IO.SizeExceededAction.ThrowException);
            op.Completed += op_Completed;
            target.TcpStream.ReadLine(op, true);
        }

        void op_Completed(object sender, EventArgs<LumiSoft.Net.IO.SmartStream.ReadLineAsyncOP> e)
        {
            string g = e.Value.LineUtf8;
            if (g == null || g == "")
            {
                try
                {
                    target.Disconnect();
                    Statics.server_manager.update_player();
                    server_manager_tcp.o = null;
                    GC.Collect();
                }
                catch
                {

                }

                return;
            }

            //we have message here
            //===================================
            InputBuffer_data data = new InputBuffer_data();
            data.command = g;
            data.client = target;
            //===================================
            Statics.InputBuffer.Add(data);
            begin_read_server();
        }
    }

    public class TCPEventArgs
    {
        public string message;
    }

    public class server_manager_tcp
    {
        public TCP_Server<TCP_ServerSession> server;
        public event TCPEventHandler updateplayer;
        public delegate void TCPEventHandler(TCPEventArgs args);

        public void update_player()
        {
            TCPEventArgs mes = new TCPEventArgs();
            mes.message = "update_player";
           
            if (updateplayer != null)
                updateplayer(mes);
        
        }

        public void start_server()
        {
            server = new TCP_Server<TCP_ServerSession>();
            server.SessionCreated += server_SessionCreated;
            IPBindInfo x = new IPBindInfo("server", BindInfoProtocol.TCP, System.Net.IPAddress.Any, 8787);
            server.Bindings = new IPBindInfo[] { x };
            server.Start();
            Log.log_info("TCP Server Started");
        }

        public void stop_server()
        {
            if ( server == null ) return;

            server.Stop();

            TCP_ServerSession[] array =  server.m_pSessions.ToArray();

            for ( int i = 0 ; i < array.Length ; i++ )
            {
                array[i].Disconnect();
            }

            Log.log_info("TCP Server Stoped");
        }

        public static client_object o;
        void server_SessionCreated(object sender, TCP_ServerSessionEventArgs<TCP_ServerSession> e)
        {
           //new client accepted
           e.Session.time = DateTime.Now;
           o = new client_object(e.Session);
        }
    }
}