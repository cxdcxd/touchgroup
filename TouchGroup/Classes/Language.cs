using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TouchGroup
{
    class Language
    {
        static int version = 1;
        public static bool has_farsi_char(int a)
        {
            if ((a >= 0 && a <= 6) || (a >= 8 && a <= 36) || a == 48 || a == 49 || a == 78 || a == 84 || (a >= 87 && a <= 246))
                return true;

            return false;
        }

        public static bool has_english_char(int a)
        {
            if (a >= 250 && a <= 301) return true;

            return false;
        }
     
        public static bool LAN_CHECK(string X, string mode)
        {
            Font my_font = new Font();
            if (mode == "farsi")
            {
                //FARSI CHECK
                for (int i = 0; i < X.Length; i++)
                {
                    int j = 0;
                    for (; j < my_font.font_unicods.GetLength(0); j++)
                    {
                        if (X[i].ToString() == my_font.font_unicods[j, 0])
                        {
                            break;
                        }
                    }


                    if (has_english_char(j) == true)
                    {
                        return false;
                    }

                }
                return true;
            }
            if (mode == "english")
            {
                for (int i = 0; i < X.Length; i++)
                {
                    int j = 0;
                    for (; j < my_font.font_unicods.GetLength(0); j++)
                    {
                        if (X[i].ToString() == my_font.font_unicods[j, 0])
                        {
                            break;
                        }
                    }


                    if (has_farsi_char(j) == true)
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;
        }
    }
}
