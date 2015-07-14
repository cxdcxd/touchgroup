using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FarsiLibrary.Utils;

namespace TouchGroup
{
    class SystemTime
    {
        static int version = 1;
        public static int get_minute()
        {
            return DateTime.Now.Minute;
        }

        public static int get_second()
        {
            return DateTime.Now.Second;
        }
      
        public static int get_hour()
        {
            return DateTime.Now.Hour;
        }
     
        public static string get_time()
        {
            string m = DateTime.Now.Minute.ToString();
            if (m.Length != 2) m = "0" + m;

            string h = DateTime.Now.Hour.ToString();
            if (h.Length != 2) h = "0" + h;

            return (h + ":" + m);
        }

        public static PersianDate get_persian_date()
        {
            return PersianDate.Now;
        }

        public static DateTime get_datetime()
        {
            return DateTime.Now;
        }
        /// <summary>
        /// Generate a string date for log files
        /// </summary>
        /// <returns></returns>
        public static string get_file_date()
        {
            DateTime t = DateTime.Now;
            string y = t.Year.ToString();
            string m = t.Month.ToString(); if (m.Length < 2) m = "0" + m;
            string d = t.Day.ToString(); if (d.Length < 2) d = "0" + d;
            string h = t.Hour.ToString(); if (h.Length < 2) h = "0" + h;
            string mi = t.Minute.ToString(); if (mi.Length < 2) mi = "0" + mi;
            string s = t.Second.ToString(); if (s.Length < 2) s = "0" + s;

            return y + m + d + h + mi + s;
        }
      
        public static DateTime convert_persian_to_english(PersianDate pd)
        {
           return FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(pd);
        }

        public static PersianDate convert_english_to_persion(DateTime t)
        {
            return new PersianDate(t);
        }
    }
}
