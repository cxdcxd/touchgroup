using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TouchGroup
{
    class Log
    {
        static int version = 1;
        public static List<string> main_log = new List<string>();
        static FileStream fs;
        static StreamWriter sw;
        static string path;

        public static string OSVersion;
        public static string Type;
        public static string SDirectory;
        public static string Pcount;
        public static string UName;
     
        static void load_info()
        {
            try
            {
               OSVersion = "OS : " + Environment.OSVersion.ToString();

                if (Environment.Is64BitOperatingSystem)
                    Type = "64 Bit Operating System";
                else
                    Type = "32 Bit Operating System";

               SDirectory=  Environment.SystemDirectory;
               Pcount = "ProcessorCount:  " + Environment.ProcessorCount;
               UName = "UserName:  " + Environment.UserName;
            }
            catch
            {
            }
        }

        public static void log_info(string message)
        {
            string log_message = SystemTime.get_datetime() + " [INFO] " + message;
            main_log.Add(log_message);
            write_to_file(log_message);
        }

        public static void log_error(string message)
        {
            string log_message = SystemTime.get_datetime() + " [ERROR] " + message;
            main_log.Add(log_message);
            write_to_file(log_message);
        }

        public static void log_warning(string message)
        {
            string log_message = SystemTime.get_datetime().ToShortTimeString() + " [WARNING] " + message;
            main_log.Add(log_message);
            write_to_file(log_message);
        }


        static void write_to_file(string message)
        {
            open();
            if (fs != null && sw != null)
            {
                sw.WriteLine(message);
            }
            close();
        }

        public static void open()
        {
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }

        public static void close()
        {
            if (sw != null)
                sw.Close();
            if (fs != null)
                fs.Close();

            fs = null;
            sw = null;
        }
        public static void init()
        {
            load_info();
            path = Environment.CurrentDirectory + "\\log\\" + SystemTime.get_file_date() + ".txt";
            fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine("App Version = " + Statics.Version);
            sw.WriteLine(OSVersion);
            sw.WriteLine(Type);
            sw.WriteLine(Pcount);
            sw.WriteLine(SDirectory);
            sw.WriteLine(UName);
            sw.WriteLine("============================================");
            sw.Close();
            fs.Close();
        }

        public static void kill()
        {
            close();
        }
    }
}
