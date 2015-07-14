using System;
using System.Text;

class Font
{
    static int version = 1;
    public string[,] font_unicods = new string[313, 5];

    public Font()
    {
        font_unicods[0, 0] = "ش";
        font_unicods[0, 1] = "0078";
        font_unicods[0, 2] = "007B";
        font_unicods[0, 3] = "007A";
        font_unicods[0, 4] = "0079";

        font_unicods[1, 0] = "س";
        font_unicods[1, 1] = "0074";
        font_unicods[1, 2] = "0077";
        font_unicods[1, 3] = "0076";
        font_unicods[1, 4] = "0075";

        font_unicods[2, 0] = "ب";
        font_unicods[2, 1] = "004A";
        font_unicods[2, 2] = "004D";
        font_unicods[2, 3] = "004C";
        font_unicods[2, 4] = "004B";

        font_unicods[3, 0] = "پ";
        font_unicods[3, 1] = "004E";
        font_unicods[3, 2] = "0051";
        font_unicods[3, 3] = "0050";
        font_unicods[3, 4] = "004F";

        font_unicods[4, 0] = "ت";
        font_unicods[4, 1] = "0052";
        font_unicods[4, 2] = "0055";
        font_unicods[4, 3] = "0054";
        font_unicods[4, 4] = "0053";

        font_unicods[5, 0] = "ث";
        font_unicods[5, 1] = "0056";
        font_unicods[5, 2] = "0059";
        font_unicods[5, 3] = "0058";
        font_unicods[5, 4] = "0057";

        font_unicods[6, 0] = "ج";
        font_unicods[6, 1] = "005A";
        font_unicods[6, 2] = "005D";
        font_unicods[6, 3] = "005C";
        font_unicods[6, 4] = "005B";

        font_unicods[7, 0] = " ";
        font_unicods[7, 1] = "0020";
        font_unicods[7, 2] = "-1";
        font_unicods[7, 3] = "-1";
        font_unicods[7, 4] = "-1";

        font_unicods[8, 0] = "چ";
        font_unicods[8, 1] = "005E";
        font_unicods[8, 2] = "0061";
        font_unicods[8, 3] = "0060";
        font_unicods[8, 4] = "005F";

        font_unicods[9, 0] = "ح";
        font_unicods[9, 1] = "0062";
        font_unicods[9, 2] = "0065";
        font_unicods[9, 3] = "0064";
        font_unicods[9, 4] = "0063";

        font_unicods[10, 0] = "خ";
        font_unicods[10, 1] = "0066";
        font_unicods[10, 2] = "0069";
        font_unicods[10, 3] = "0068";
        font_unicods[10, 4] = "0067";

        font_unicods[11, 0] = "ص";
        font_unicods[11, 1] = "007C";
        font_unicods[11, 2] = "201A";
        font_unicods[11, 3] = "007E";
        font_unicods[11, 4] = "007D";

        font_unicods[12, 0] = "ک";
        font_unicods[12, 1] = "00A5";
        font_unicods[12, 2] = "00A8";
        font_unicods[12, 3] = "00A7";
        font_unicods[12, 4] = "00A6";

        font_unicods[13, 0] = "م";
        font_unicods[13, 1] = "00B3";
        font_unicods[13, 2] = "00B6";
        font_unicods[13, 3] = "00B5";
        font_unicods[13, 4] = "00B4";

        font_unicods[14, 0] = "ن";
        font_unicods[14, 1] = "00B7";
        font_unicods[14, 2] = "00BA";
        font_unicods[14, 3] = "00B9";
        font_unicods[14, 4] = "00B8";

        font_unicods[15, 0] = "گ";
        font_unicods[15, 1] = "00A9";
        font_unicods[15, 2] = "00AC";
        font_unicods[15, 3] = "00AB";
        font_unicods[15, 4] = "00AA";

        font_unicods[16, 0] = "ه";
        font_unicods[16, 1] = "00BD";
        font_unicods[16, 2] = "00C0";
        font_unicods[16, 3] = "00BF";
        font_unicods[16, 4] = "00BE";

        font_unicods[17, 0] = "ی";
        font_unicods[17, 1] = "00C1";
        font_unicods[17, 2] = "00C4";
        font_unicods[17, 3] = "00C3";
        font_unicods[17, 4] = "00C2";

        font_unicods[18, 0] = "غ";
        font_unicods[18, 1] = "2014";
        font_unicods[18, 2] = "0161";
        font_unicods[18, 3] = "2122";
        font_unicods[18, 4] = "02DC";

        font_unicods[19, 0] = "ق";
        font_unicods[19, 1] = "00A1";
        font_unicods[19, 2] = "00A4";
        font_unicods[19, 3] = "00A3";
        font_unicods[19, 4] = "00A2";

        font_unicods[20, 0] = "ل";
        font_unicods[20, 1] = "00CF";
        font_unicods[20, 2] = "00B2";
        font_unicods[20, 3] = "00B1";
        font_unicods[20, 4] = "00AE";

        font_unicods[21, 0] = "ض";
        font_unicods[21, 1] = "0192";
        font_unicods[21, 2] = "2020";
        font_unicods[21, 3] = "2026";
        font_unicods[21, 4] = "201E";

        font_unicods[22, 0] = "ط";
        font_unicods[22, 1] = "2021";
        font_unicods[22, 2] = "2021";
        font_unicods[22, 3] = "2030";
        font_unicods[22, 4] = "2030";

        font_unicods[23, 0] = "ظ";
        font_unicods[23, 1] = "2039";
        font_unicods[23, 2] = "00CB";
        font_unicods[23, 3] = "00CA";
        font_unicods[23, 4] = "0152";

        font_unicods[24, 0] = "ع";
        font_unicods[24, 1] = "201C";
        font_unicods[24, 2] = "2013";
        font_unicods[24, 3] = "2022";
        font_unicods[24, 4] = "201D";

        font_unicods[25, 0] = "ف";
        font_unicods[25, 1] = "203A";
        font_unicods[25, 2] = "00CE";
        font_unicods[25, 3] = "0178";
        font_unicods[25, 4] = "0153";

        font_unicods[26, 0] = "أ";
        font_unicods[26, 1] = "0043";
        font_unicods[26, 2] = "0047";
        font_unicods[26, 3] = "0046";
        font_unicods[26, 4] = "0044";

        font_unicods[27, 0] = "ر";
        font_unicods[27, 1] = "006E";
        font_unicods[27, 2] = "-1";
        font_unicods[27, 3] = "-1";
        font_unicods[27, 4] = "006F";

        font_unicods[28, 0] = "ز";
        font_unicods[28, 1] = "0070";
        font_unicods[28, 2] = "-1";
        font_unicods[28, 3] = "-1";
        font_unicods[28, 4] = "0071";

        font_unicods[29, 0] = "ژ";
        font_unicods[29, 1] = "0072";
        font_unicods[29, 2] = "-1";
        font_unicods[29, 3] = "-1";
        font_unicods[29, 4] = "0073";

        font_unicods[30, 0] = "د";
        font_unicods[30, 1] = "006A";
        font_unicods[30, 2] = "-1";
        font_unicods[30, 3] = "-1";
        font_unicods[30, 4] = "006B";

        font_unicods[31, 0] = "ذ";
        font_unicods[31, 1] = "006C";
        font_unicods[31, 2] = "-1";
        font_unicods[31, 3] = "-1";
        font_unicods[31, 4] = "006D";

        font_unicods[32, 0] = "و";
        font_unicods[32, 1] = "00BB";
        font_unicods[32, 2] = "-1";
        font_unicods[32, 3] = "-1";
        font_unicods[32, 4] = "00BC";

        font_unicods[33, 0] = "ا";
        font_unicods[33, 1] = "0048";
        font_unicods[33, 2] = "-1";
        font_unicods[33, 3] = "-1";
        font_unicods[33, 4] = "0049";

        font_unicods[34, 0] = "لا";
        font_unicods[34, 1] = "00AF";
        font_unicods[34, 2] = "-1";
        font_unicods[34, 3] = "-1";
        font_unicods[34, 4] = "00B0";

        font_unicods[35, 0] = "ء";
        font_unicods[35, 1] = "0045";
        font_unicods[35, 2] = "0047";
        font_unicods[35, 3] = "0046";
        font_unicods[35, 4] = "0044";

        font_unicods[36, 0] = "آ";
        font_unicods[36, 1] = "0041";
        font_unicods[36, 2] = "-1";
        font_unicods[36, 3] = "-1";
        font_unicods[36, 4] = "-1";

        //--------------------------------------

        font_unicods[37, 0] = "0";
        font_unicods[37, 1] = "0030";
        font_unicods[37, 2] = "-1";
        font_unicods[37, 3] = "-1";
        font_unicods[37, 4] = "-1";

        font_unicods[38, 0] = "1";
        font_unicods[38, 1] = "0031";
        font_unicods[38, 2] = "-1";
        font_unicods[38, 3] = "-1";
        font_unicods[38, 4] = "-1";


        font_unicods[39, 0] = "2";
        font_unicods[39, 1] = "0032";
        font_unicods[39, 2] = "-1";
        font_unicods[39, 3] = "-1";
        font_unicods[39, 4] = "-1";


        font_unicods[40, 0] = "3";
        font_unicods[40, 1] = "0033";
        font_unicods[40, 2] = "-1";
        font_unicods[40, 3] = "-1";
        font_unicods[40, 4] = "-1";

        font_unicods[41, 0] = "4";
        font_unicods[41, 1] = "0034";
        font_unicods[41, 2] = "-1";
        font_unicods[41, 3] = "-1";
        font_unicods[41, 4] = "-1";

        font_unicods[42, 0] = "5";
        font_unicods[42, 1] = "0035";
        font_unicods[42, 2] = "-1";
        font_unicods[42, 3] = "-1";
        font_unicods[42, 4] = "-1";

        font_unicods[43, 0] = "6";
        font_unicods[43, 1] = "0036";
        font_unicods[43, 2] = "-1";
        font_unicods[43, 3] = "-1";
        font_unicods[43, 4] = "-1";

        font_unicods[44, 0] = "7";
        font_unicods[44, 1] = "0037";
        font_unicods[44, 2] = "-1";
        font_unicods[44, 3] = "-1";
        font_unicods[44, 4] = "-1";

        font_unicods[45, 0] = "8";
        font_unicods[45, 1] = "0038";
        font_unicods[45, 2] = "-1";
        font_unicods[45, 3] = "-1";
        font_unicods[45, 4] = "-1";

        font_unicods[46, 0] = "9";
        font_unicods[46, 1] = "0039";
        font_unicods[46, 2] = "-1";
        font_unicods[46, 3] = "-1";
        font_unicods[46, 4] = "-1";

        font_unicods[47, 0] = "/";
        font_unicods[47, 1] = "002F";
        font_unicods[47, 2] = "-1";
        font_unicods[47, 3] = "-1";
        font_unicods[47, 4] = "-1";

        font_unicods[48, 0] = "ئ";
        font_unicods[48, 1] = "0045";
        font_unicods[48, 2] = "0047";
        font_unicods[48, 3] = "0046";
        font_unicods[48, 4] = "0044";

        font_unicods[49, 0] = "ي";
        font_unicods[49, 1] = "00C1";
        font_unicods[49, 2] = "00C4";
        font_unicods[49, 3] = "00C3";
        font_unicods[49, 4] = "00C2";

        //-------------------------------------- new chars

        font_unicods[50, 0] = "!";
        font_unicods[50, 1] = "0021";
        font_unicods[50, 2] = "-1";
        font_unicods[50, 3] = "-1";
        font_unicods[50, 4] = "-1";

        font_unicods[51, 0] = '"'.ToString();
        font_unicods[51, 1] = "0022";
        font_unicods[51, 2] = "-1";
        font_unicods[51, 3] = "-1";
        font_unicods[51, 4] = "-1";

        font_unicods[52, 0] = "#";
        font_unicods[52, 1] = "0023";
        font_unicods[52, 2] = "-1";
        font_unicods[52, 3] = "-1";
        font_unicods[52, 4] = "-1";

        font_unicods[53, 0] = "%";
        font_unicods[53, 1] = "0025";
        font_unicods[53, 2] = "-1";
        font_unicods[53, 3] = "-1";
        font_unicods[53, 4] = "-1";

        font_unicods[54, 0] = "(";
        font_unicods[54, 1] = "0028";
        font_unicods[54, 2] = "-1";
        font_unicods[54, 3] = "-1";
        font_unicods[54, 4] = "-1";

        font_unicods[55, 0] = ")";
        font_unicods[55, 1] = "0029";
        font_unicods[55, 2] = "-1";
        font_unicods[55, 3] = "-1";
        font_unicods[55, 4] = "-1";

        font_unicods[56, 0] = "*";
        font_unicods[56, 1] = "002A";
        font_unicods[56, 2] = "-1";
        font_unicods[56, 3] = "-1";
        font_unicods[56, 4] = "-1";

        font_unicods[57, 0] = "+";
        font_unicods[57, 1] = "002B";
        font_unicods[57, 2] = "-1";
        font_unicods[57, 3] = "-1";
        font_unicods[57, 4] = "-1";

        font_unicods[58, 0] = ",";
        font_unicods[58, 1] = "002C";
        font_unicods[58, 2] = "-1";
        font_unicods[58, 3] = "-1";
        font_unicods[58, 4] = "-1";

        font_unicods[59, 0] = "-";
        font_unicods[59, 1] = "002D";
        font_unicods[59, 2] = "-1";
        font_unicods[59, 3] = "-1";
        font_unicods[59, 4] = "-1";

        font_unicods[60, 0] = ".";
        font_unicods[60, 1] = "002E";
        font_unicods[60, 2] = "-1";
        font_unicods[60, 3] = "-1";
        font_unicods[60, 4] = "-1";

        font_unicods[61, 0] = @"\";
        font_unicods[61, 1] = "002F";
        font_unicods[61, 2] = "-1";
        font_unicods[61, 3] = "-1";
        font_unicods[61, 4] = "-1";

        font_unicods[62, 0] = ":";
        font_unicods[62, 1] = "003A";
        font_unicods[62, 2] = "-1";
        font_unicods[62, 3] = "-1";
        font_unicods[62, 4] = "-1";

        font_unicods[63, 0] = ";";
        font_unicods[63, 1] = "003B";
        font_unicods[63, 2] = "-1";
        font_unicods[63, 3] = "-1";
        font_unicods[63, 4] = "-1";

        font_unicods[64, 0] = "<";
        font_unicods[64, 1] = "003C";
        font_unicods[64, 2] = "-1";
        font_unicods[64, 3] = "-1";
        font_unicods[64, 4] = "-1";

        font_unicods[65, 0] = "=";
        font_unicods[65, 1] = "003D";
        font_unicods[65, 2] = "-1";
        font_unicods[65, 3] = "-1";
        font_unicods[65, 4] = "-1";

        font_unicods[66, 0] = ">";
        font_unicods[66, 1] = "003E";
        font_unicods[66, 2] = "-1";
        font_unicods[66, 3] = "-1";
        font_unicods[66, 4] = "-1";

        font_unicods[67, 0] = "?";
        font_unicods[67, 1] = "003F";
        font_unicods[67, 2] = "-1";
        font_unicods[67, 3] = "-1";
        font_unicods[67, 4] = "-1";

        font_unicods[68, 0] = "_";
        font_unicods[68, 1] = "0040";
        font_unicods[68, 2] = "-1";
        font_unicods[68, 3] = "-1";
        font_unicods[68, 4] = "-1";

        font_unicods[69, 0] = "÷";
        font_unicods[69, 1] = "002D";
        font_unicods[69, 2] = "-1";
        font_unicods[69, 3] = "-1";
        font_unicods[69, 4] = "-1";


        font_unicods[70, 0] = "~";
        font_unicods[70, 1] = "002D";
        font_unicods[70, 2] = "-1";
        font_unicods[70, 3] = "-1";
        font_unicods[70, 4] = "-1";

        font_unicods[71, 0] = "`";
        font_unicods[71, 1] = "00D1";
        font_unicods[71, 2] = "-1";
        font_unicods[71, 3] = "-1";
        font_unicods[71, 4] = "-1";


        font_unicods[72, 0] = "|";
        font_unicods[72, 1] = "002F";
        font_unicods[72, 2] = "-1";
        font_unicods[72, 3] = "-1";
        font_unicods[72, 4] = "-1";

        font_unicods[73, 0] = "×";
        font_unicods[73, 1] = "002A";
        font_unicods[73, 2] = "-1";
        font_unicods[73, 3] = "-1";
        font_unicods[73, 4] = "-1";

        font_unicods[74, 0] = "@";
        font_unicods[74, 1] = "00C5";
        font_unicods[74, 2] = "-1";
        font_unicods[74, 3] = "-1";
        font_unicods[74, 4] = "-1";

        font_unicods[75, 0] = "$";
        font_unicods[75, 1] = "0024";
        font_unicods[75, 2] = "-1";
        font_unicods[75, 3] = "-1";
        font_unicods[75, 4] = "-1";

        font_unicods[76, 0] = "^";
        font_unicods[76, 1] = "00F0";
        font_unicods[76, 2] = "-1";
        font_unicods[76, 3] = "-1";
        font_unicods[76, 4] = "-1";

        font_unicods[77, 0] = "&";
        font_unicods[77, 1] = "0026";
        font_unicods[77, 2] = "-1";
        font_unicods[77, 3] = "-1";
        font_unicods[77, 4] = "-1";

        font_unicods[78, 0] = "ًٌٍريال";
        font_unicods[78, 1] = "00F0";
        font_unicods[78, 2] = "-1";
        font_unicods[78, 3] = "-1";
        font_unicods[78, 4] = "-1";

        font_unicods[79, 0] = "،";
        font_unicods[79, 1] = "002C"; //===================
        font_unicods[79, 2] = "-1";
        font_unicods[79, 3] = "-1";
        font_unicods[79, 4] = "-1";

        font_unicods[80, 0] = "[";
        font_unicods[80, 1] = "0028";
        font_unicods[80, 2] = "-1";
        font_unicods[80, 3] = "-1";
        font_unicods[80, 4] = "-1";

        font_unicods[81, 0] = "]";
        font_unicods[81, 1] = "0029";
        font_unicods[81, 2] = "-1";
        font_unicods[81, 3] = "-1";
        font_unicods[81, 4] = "-1";

        font_unicods[82, 0] = "{";
        font_unicods[82, 1] = "0028";
        font_unicods[82, 2] = "-1";
        font_unicods[82, 3] = "-1";
        font_unicods[82, 4] = "-1";

        font_unicods[83, 0] = "}";
        font_unicods[83, 1] = "0029";
        font_unicods[83, 2] = "-1";
        font_unicods[83, 3] = "-1";
        font_unicods[83, 4] = "-1";

        font_unicods[84, 0] = "ۀ";
        font_unicods[84, 1] = "00BD";
        font_unicods[84, 2] = "00C0";
        font_unicods[84, 3] = "00BF";
        font_unicods[84, 4] = "00BE";

        font_unicods[85, 0] = "»";
        font_unicods[85, 1] = "003E";
        font_unicods[85, 2] = "-1";
        font_unicods[85, 3] = "-1";
        font_unicods[85, 4] = "-1";

        font_unicods[86, 0] = "«";
        font_unicods[86, 1] = "-1";
        font_unicods[86, 2] = "-1";
        font_unicods[86, 3] = "-1";
        font_unicods[86, 4] = "-1";

        font_unicods[87, 0] = "ة";
        font_unicods[87, 1] = "00BD";
        font_unicods[87, 2] = "00C0";
        font_unicods[87, 3] = "00BF";
        font_unicods[87, 4] = "00BE";

       
        font_unicods[88, 0] = "ؤ";
        font_unicods[88, 1] = "00BB";
        font_unicods[88, 2] = "-1";
        font_unicods[88, 3] = "-1";
        font_unicods[88, 4] = "00BC";

        font_unicods[89, 0] = "؟";
        font_unicods[89, 1] = "003F";
        font_unicods[89, 2] = "-1";
        font_unicods[89, 3] = "-1";
        font_unicods[89, 4] = "-1";

        font_unicods[90, 0] = "إ";
        font_unicods[90, 1] = "0048";
        font_unicods[90, 2] = "-1";
        font_unicods[90, 3] = "-1";
        font_unicods[90, 4] = "0049";

        font_unicods[91, 0] = "أ";
        font_unicods[91, 1] = "0048";
        font_unicods[91, 2] = "-1";
        font_unicods[91, 3] = "-1";
        font_unicods[91, 4] = "0049";

        font_unicods[92, 0] = "ًٌٍَََُِّ";
        font_unicods[92, 1] = "00DF";
        font_unicods[92, 2] = "-1";
        font_unicods[92, 3] = "-1";
        font_unicods[92, 4] = "-1";

        font_unicods[93, 0] = "ك";
        font_unicods[93, 1] = "00A5";
        font_unicods[93, 2] = "00A8";
        font_unicods[93, 3] = "00A7";
        font_unicods[93, 4] = "00A6";

        font_unicods[94, 0] = "ٱ";
        font_unicods[94, 1] = "0048";
        font_unicods[94, 2] = "-1";
        font_unicods[94, 3] = "-1";
        font_unicods[94, 4] = "0049";

        font_unicods[95, 0] = "ٲ";
        font_unicods[95, 1] = "0048";
        font_unicods[95, 2] = "-1";
        font_unicods[95, 3] = "-1";
        font_unicods[95, 4] = "0049";

        font_unicods[96, 0] = "ٵ";
        font_unicods[96, 1] = "0048";
        font_unicods[96, 2] = "-1";
        font_unicods[96, 3] = "-1";
        font_unicods[96, 4] = "0049";

        font_unicods[97, 0] = "ٷ";
        font_unicods[97, 1] = "00BB";
        font_unicods[97, 2] = "-1";
        font_unicods[97, 3] = "-1";
        font_unicods[97, 4] = "00BC";

        font_unicods[98, 0] = "ٸ";
        font_unicods[98, 1] = "00C1";
        font_unicods[98, 2] = "00C4";
        font_unicods[98, 3] = "00C3";
        font_unicods[98, 4] = "00C2";

        font_unicods[99, 0] = "ک";
        font_unicods[99, 1] = "00A5";
        font_unicods[99, 2] = "00A8";
        font_unicods[99, 3] = "00A7";
        font_unicods[99, 4] = "00A6";

        font_unicods[100, 0] = "ڪ";
        font_unicods[100, 1] = "00A5";
        font_unicods[100, 2] = "00A8";
        font_unicods[100, 3] = "00A7";
        font_unicods[100, 4] = "00A6";

        font_unicods[101, 0] = "ۀ";
        font_unicods[101, 1] = "00BD";
        font_unicods[101, 2] = "00C0";
        font_unicods[101, 3] = "00BF";
        font_unicods[101, 4] = "00BE";

        font_unicods[102, 0] = "ۂ";
        font_unicods[102, 1] = "00BD";
        font_unicods[102, 2] = "00C0";
        font_unicods[102, 3] = "00BF";
        font_unicods[102, 4] = "00BE";

        font_unicods[103, 0] = "ﺔ";
        font_unicods[103, 1] = "00BD";
        font_unicods[103, 2] = "00C0";
        font_unicods[103, 3] = "00BF";
        font_unicods[103, 4] = "00BE";

        font_unicods[104, 0] = "ﻰ";
        font_unicods[104, 1] = "00C1";
        font_unicods[104, 2] = "00C4";
        font_unicods[104, 3] = "00C3";
        font_unicods[104, 4] = "00C2";

        //--------------------------------- arabic fonts part -------------------

        //پ
        font_unicods[105, 0] = "ﭙ";
        font_unicods[105, 1] = "004E";
        font_unicods[105, 2] = "0051";
        font_unicods[105, 3] = "0050";
        font_unicods[105, 4] = "004F";

        font_unicods[106, 0] = "ﭘ";
        font_unicods[106, 1] = "004E";
        font_unicods[106, 2] = "0051";
        font_unicods[106, 3] = "0050";
        font_unicods[106, 4] = "004F";

        font_unicods[107, 0] = "ﭗ";
        font_unicods[107, 1] = "004E";
        font_unicods[107, 2] = "0051";
        font_unicods[107, 3] = "0050";
        font_unicods[107, 4] = "004F";

        font_unicods[108, 0] = "ﭖ";
        font_unicods[108, 1] = "004E";
        font_unicods[108, 2] = "0051";
        font_unicods[108, 3] = "0050";
        font_unicods[108, 4] = "004F";

        //ژ

        font_unicods[109, 0] = "ﮋ";
        font_unicods[109, 1] = "0072";
        font_unicods[109, 2] = "-1";
        font_unicods[109, 3] = "-1";
        font_unicods[109, 4] = "0073";

        font_unicods[110, 0] = "ﮊ";
        font_unicods[110, 1] = "0072";
        font_unicods[110, 2] = "-1";
        font_unicods[110, 3] = "-1";
        font_unicods[110, 4] = "0073";

        //چ
        font_unicods[111, 0] = "ﭽ";
        font_unicods[111, 1] = "005E";
        font_unicods[111, 2] = "0061";
        font_unicods[111, 3] = "0060";
        font_unicods[111, 4] = "005F";

        font_unicods[112, 0] = "ﭼ";
        font_unicods[112, 1] = "005E";
        font_unicods[112, 2] = "0061";
        font_unicods[112, 3] = "0060";
        font_unicods[112, 4] = "005F";

        font_unicods[113, 0] = "ﭻ";
        font_unicods[113, 1] = "005E";
        font_unicods[113, 2] = "0061";
        font_unicods[113, 3] = "0060";
        font_unicods[113, 4] = "005F";

        font_unicods[114, 0] = "ﭺ";
        font_unicods[114, 1] = "005E";
        font_unicods[114, 2] = "0061";
        font_unicods[114, 3] = "0060";
        font_unicods[114, 4] = "005F";

        //

        font_unicods[115, 0] = "ﮕ";
        font_unicods[115, 1] = "00A9";
        font_unicods[115, 2] = "00AC";
        font_unicods[115, 3] = "00AB";
        font_unicods[115, 4] = "00AA";

        font_unicods[116, 0] = "ﮔ";
        font_unicods[116, 1] = "00A9";
        font_unicods[116, 2] = "00AC";
        font_unicods[116, 3] = "00AB";
        font_unicods[116, 4] = "00AA";

        font_unicods[117, 0] = "ﮓ";
        font_unicods[117, 1] = "00A9";
        font_unicods[117, 2] = "00AC";
        font_unicods[117, 3] = "00AB";
        font_unicods[117, 4] = "00AA";

        font_unicods[118, 0] = "ﮒ";
        font_unicods[118, 1] = "00A9";
        font_unicods[118, 2] = "00AC";
        font_unicods[118, 3] = "00AB";
        font_unicods[118, 4] = "00AA";

        //

        font_unicods[119, 0] = "ﮑ";
        font_unicods[119, 1] = "00A5";
        font_unicods[119, 2] = "00A8";
        font_unicods[119, 3] = "00A7";
        font_unicods[119, 4] = "00A6";

        font_unicods[120, 0] = "ﮐ";
        font_unicods[120, 1] = "00A5";
        font_unicods[120, 2] = "00A8";
        font_unicods[120, 3] = "00A7";
        font_unicods[120, 4] = "00A6";

        font_unicods[121, 0] = "ﮏ";
        font_unicods[121, 1] = "00A5";
        font_unicods[121, 2] = "00A8";
        font_unicods[121, 3] = "00A7";
        font_unicods[121, 4] = "00A6";

        font_unicods[122, 0] = "ﮎ";
        font_unicods[122, 1] = "00A5";
        font_unicods[122, 2] = "00A8";
        font_unicods[122, 3] = "00A7";
        font_unicods[122, 4] = "00A6";

        //

        font_unicods[123, 0] = "ﮭ";
        font_unicods[123, 1] = "00BD";
        font_unicods[123, 2] = "00C0";
        font_unicods[123, 3] = "00BF";
        font_unicods[123, 4] = "00BE";

        font_unicods[124, 0] = "ﮬ";
        font_unicods[124, 1] = "00BD";
        font_unicods[124, 2] = "00C0";
        font_unicods[124, 3] = "00BF";
        font_unicods[124, 4] = "00BE";

        font_unicods[125, 0] = "ﮫ";
        font_unicods[125, 1] = "00BD";
        font_unicods[125, 2] = "00C0";
        font_unicods[125, 3] = "00BF";
        font_unicods[125, 4] = "00BE";

        font_unicods[126, 0] = "ﮪ";
        font_unicods[126, 1] = "00BD";
        font_unicods[126, 2] = "00C0";
        font_unicods[126, 3] = "00BF";
        font_unicods[126, 4] = "00BE";

        //

        font_unicods[127, 0] = "ﯾ";
        font_unicods[127, 1] = "00C1";
        font_unicods[127, 2] = "00C4";
        font_unicods[127, 3] = "00C3";
        font_unicods[127, 4] = "00C2";

        font_unicods[128, 0] = "ﯽ";
        font_unicods[128, 1] = "00C1";
        font_unicods[128, 2] = "00C4";
        font_unicods[128, 3] = "00C3";
        font_unicods[128, 4] = "00C2";

        font_unicods[129, 0] = "ﯼ";
        font_unicods[129, 1] = "00C1";
        font_unicods[129, 2] = "00C4";
        font_unicods[129, 3] = "00C3";
        font_unicods[129, 4] = "00C2";

        font_unicods[130, 0] = "ﯧ";
        font_unicods[130, 1] = "00C1";
        font_unicods[130, 2] = "00C4";
        font_unicods[130, 3] = "00C3";
        font_unicods[130, 4] = "00C2";

        font_unicods[131, 0] = "ﯥ";
        font_unicods[131, 1] = "00C1";
        font_unicods[131, 2] = "00C4";
        font_unicods[131, 3] = "00C3";
        font_unicods[131, 4] = "00C2";

        font_unicods[132, 0] = "ﯤ";
        font_unicods[132, 1] = "00C1";
        font_unicods[132, 2] = "00C4";
        font_unicods[132, 3] = "00C3";
        font_unicods[132, 4] = "00C2";

        font_unicods[133, 0] = "ﯤ";
        font_unicods[133, 1] = "00C1";
        font_unicods[133, 2] = "00C4";
        font_unicods[133, 3] = "00C3";
        font_unicods[133, 4] = "00C2";

        font_unicods[134, 0] = "ﯿ";
        font_unicods[134, 1] = "00C1";
        font_unicods[134, 2] = "00C4";
        font_unicods[134, 3] = "00C3";
        font_unicods[134, 4] = "00C2";

        //

        font_unicods[135, 0] = "ﺞ";
        font_unicods[135, 1] = "005A";
        font_unicods[135, 2] = "005D";
        font_unicods[135, 3] = "005C";
        font_unicods[135, 4] = "005B";

        font_unicods[136, 0] = "ﺝ";
        font_unicods[136, 1] = "005A";
        font_unicods[136, 2] = "005D";
        font_unicods[136, 3] = "005C";
        font_unicods[136, 4] = "005B";

        font_unicods[137, 0] = "ﺟ";
        font_unicods[137, 1] = "005A";
        font_unicods[137, 2] = "005D";
        font_unicods[137, 3] = "005C";
        font_unicods[137, 4] = "005B";

        font_unicods[138, 0] = "ﺠ";
        font_unicods[138, 1] = "005A";
        font_unicods[138, 2] = "005D";
        font_unicods[138, 3] = "005C";
        font_unicods[138, 4] = "005B";

        //

        font_unicods[139, 0] = "ﺜ";
        font_unicods[139, 1] = "0056";
        font_unicods[139, 2] = "0059";
        font_unicods[139, 3] = "0058";
        font_unicods[139, 4] = "0057";

        font_unicods[140, 0] = "ﺛ";
        font_unicods[140, 1] = "0056";
        font_unicods[140, 2] = "0059";
        font_unicods[140, 3] = "0058";
        font_unicods[140, 4] = "0057";

        font_unicods[141, 0] = "ﺚ";
        font_unicods[141, 1] = "0056";
        font_unicods[141, 2] = "0059";
        font_unicods[141, 3] = "0058";
        font_unicods[141, 4] = "0057";

        font_unicods[142, 0] = "ﺙ";
        font_unicods[142, 1] = "0056";
        font_unicods[142, 2] = "0059";
        font_unicods[142, 3] = "0058";
        font_unicods[142, 4] = "0057";

        //

        font_unicods[143, 0] = "ﺘ";
        font_unicods[143, 1] = "0052";
        font_unicods[143, 2] = "0055";
        font_unicods[143, 3] = "0054";
        font_unicods[143, 4] = "0053";

        font_unicods[144, 0] = "ﺗ";
        font_unicods[144, 1] = "0052";
        font_unicods[144, 2] = "0055";
        font_unicods[144, 3] = "0054";
        font_unicods[144, 4] = "0053";

        font_unicods[145, 0] = "ﺖ";
        font_unicods[145, 1] = "0052";
        font_unicods[145, 2] = "0055";
        font_unicods[145, 3] = "0054";
        font_unicods[145, 4] = "0053";

        font_unicods[146, 0] = "ﺕ";
        font_unicods[146, 1] = "0052";
        font_unicods[146, 2] = "0055";
        font_unicods[146, 3] = "0054";
        font_unicods[146, 4] = "0053";

        //

        font_unicods[147, 0] = "ﺔ";
        font_unicods[147, 1] = "00BD";
        font_unicods[147, 2] = "00C0";
        font_unicods[147, 3] = "00BF";
        font_unicods[147, 4] = "00BE";

        font_unicods[148, 0] = "ﺓ";
        font_unicods[148, 1] = "00BD";
        font_unicods[148, 2] = "00C0";
        font_unicods[148, 3] = "00BF";
        font_unicods[148, 4] = "00BE";

        //

        font_unicods[149, 0] = "ﺒ";
        font_unicods[149, 1] = "004A";
        font_unicods[149, 2] = "004D";
        font_unicods[149, 3] = "004C";
        font_unicods[149, 4] = "004B";

        font_unicods[150, 0] = "ﺑ";
        font_unicods[150, 1] = "004A";
        font_unicods[150, 2] = "004D";
        font_unicods[150, 3] = "004C";
        font_unicods[150, 4] = "004B";

        font_unicods[151, 0] = "ﺐ";
        font_unicods[151, 1] = "004A";
        font_unicods[151, 2] = "004D";
        font_unicods[151, 3] = "004C";
        font_unicods[151, 4] = "004B";

        font_unicods[152, 0] = "ﺏ";
        font_unicods[152, 1] = "004A";
        font_unicods[152, 2] = "004D";
        font_unicods[152, 3] = "004C";
        font_unicods[152, 4] = "004B";

        //

        font_unicods[153, 0] = "ﺎ";
        font_unicods[153, 1] = "0048";
        font_unicods[153, 2] = "-1";
        font_unicods[153, 3] = "-1";
        font_unicods[153, 4] = "0049";

        font_unicods[154, 0] = "ﺍ";
        font_unicods[154, 1] = "0048";
        font_unicods[154, 2] = "-1";
        font_unicods[154, 3] = "-1";
        font_unicods[154, 4] = "0049";

        //

        font_unicods[155, 0] = "ﺌ";
        font_unicods[155, 1] = "0045";
        font_unicods[155, 2] = "0047";
        font_unicods[155, 3] = "0046";
        font_unicods[155, 4] = "0044";

        font_unicods[156, 0] = "ﺋ";
        font_unicods[156, 1] = "0045";
        font_unicods[156, 2] = "0047";
        font_unicods[156, 3] = "0046";
        font_unicods[156, 4] = "0044";

        font_unicods[157, 0] = "ﺀ";
        font_unicods[157, 1] = "0045";
        font_unicods[157, 2] = "0047";
        font_unicods[157, 3] = "0046";
        font_unicods[157, 4] = "0044";

        font_unicods[158, 0] = "ﺌ";
        font_unicods[158, 1] = "0045";
        font_unicods[158, 2] = "0047";
        font_unicods[158, 3] = "0046";
        font_unicods[158, 4] = "0044";

        //

        font_unicods[159, 0] = "ﺲ";
        font_unicods[159, 1] = "0074";
        font_unicods[159, 2] = "0077";
        font_unicods[159, 3] = "0076";
        font_unicods[159, 4] = "0075";

        font_unicods[160, 0] = "ﺱ";
        font_unicods[160, 1] = "0074";
        font_unicods[160, 2] = "0077";
        font_unicods[160, 3] = "0076";
        font_unicods[160, 4] = "0075";

        font_unicods[161, 0] = "ﺳ";
        font_unicods[161, 1] = "0074";
        font_unicods[161, 2] = "0077";
        font_unicods[161, 3] = "0076";
        font_unicods[161, 4] = "0075";

        font_unicods[162, 0] = "ﺴ";
        font_unicods[162, 1] = "0074";
        font_unicods[162, 2] = "0077";
        font_unicods[162, 3] = "0076";
        font_unicods[162, 4] = "0075";

        //

        font_unicods[163, 0] = "ﺰ";
        font_unicods[163, 1] = "0070";
        font_unicods[163, 2] = "-1";
        font_unicods[163, 3] = "-1";
        font_unicods[163, 4] = "0071";

        font_unicods[164, 0] = "ﺯ";
        font_unicods[164, 1] = "0070";
        font_unicods[164, 2] = "-1";
        font_unicods[164, 3] = "-1";
        font_unicods[164, 4] = "0071";

        //

        font_unicods[165, 0] = "ﺮ";
        font_unicods[165, 1] = "006E";
        font_unicods[165, 2] = "-1";
        font_unicods[165, 3] = "-1";
        font_unicods[165, 4] = "006F";

        font_unicods[166, 0] = "ﺭ";
        font_unicods[166, 1] = "006E";
        font_unicods[166, 2] = "-1";
        font_unicods[166, 3] = "-1";
        font_unicods[166, 4] = "006F";

        //

        font_unicods[167, 0] = "ﺬ";
        font_unicods[167, 1] = "006C";
        font_unicods[167, 2] = "-1";
        font_unicods[167, 3] = "-1";
        font_unicods[167, 4] = "006D";

        font_unicods[168, 0] = "ﺫ";
        font_unicods[168, 1] = "006C";
        font_unicods[168, 2] = "-1";
        font_unicods[168, 3] = "-1";
        font_unicods[168, 4] = "006D";

        //

        font_unicods[169, 0] = "ﺪ";
        font_unicods[169, 1] = "006A";
        font_unicods[169, 2] = "-1";
        font_unicods[169, 3] = "-1";
        font_unicods[169, 4] = "006B";

        font_unicods[170, 0] = "ﺩ";
        font_unicods[170, 1] = "006A";
        font_unicods[170, 2] = "-1";
        font_unicods[170, 3] = "-1";
        font_unicods[170, 4] = "006B";

        //

        font_unicods[171, 0] = "ﺨ";
        font_unicods[171, 1] = "0066";
        font_unicods[171, 2] = "0069";
        font_unicods[171, 3] = "0068";
        font_unicods[171, 4] = "0067";

        font_unicods[172, 0] = "ﺧ";
        font_unicods[172, 1] = "0066";
        font_unicods[172, 2] = "0069";
        font_unicods[172, 3] = "0068";
        font_unicods[172, 4] = "0067";

        font_unicods[173, 0] = "ﺦ";
        font_unicods[173, 1] = "0066";
        font_unicods[173, 2] = "0069";
        font_unicods[173, 3] = "0068";
        font_unicods[173, 4] = "0067";

        font_unicods[174, 0] = "ﺥ";
        font_unicods[174, 1] = "0066";
        font_unicods[174, 2] = "0069";
        font_unicods[174, 3] = "0068";
        font_unicods[174, 4] = "0067";

        //

        font_unicods[175, 0] = "ﺤ";
        font_unicods[175, 1] = "0062";
        font_unicods[175, 2] = "0065";
        font_unicods[175, 3] = "0064";
        font_unicods[175, 4] = "0063";

        font_unicods[176, 0] = "ﺣ";
        font_unicods[176, 1] = "0062";
        font_unicods[176, 2] = "0065";
        font_unicods[176, 3] = "0064";
        font_unicods[176, 4] = "0063";

        font_unicods[177, 0] = "ﺢ";
        font_unicods[177, 1] = "0062";
        font_unicods[177, 2] = "0065";
        font_unicods[177, 3] = "0064";
        font_unicods[177, 4] = "0063";

        font_unicods[178, 0] = "ﺡ";
        font_unicods[178, 1] = "0062";
        font_unicods[178, 2] = "0065";
        font_unicods[178, 3] = "0064";
        font_unicods[178, 4] = "0063";

        //

        font_unicods[179, 0] = "ﺞ";
        font_unicods[179, 1] = "005A";
        font_unicods[179, 2] = "005D";
        font_unicods[179, 3] = "005C";
        font_unicods[179, 4] = "005B";

        font_unicods[180, 0] = "ﺝ";
        font_unicods[180, 1] = "005A";
        font_unicods[180, 2] = "005D";
        font_unicods[180, 3] = "005C";
        font_unicods[180, 4] = "005B";

        font_unicods[181, 0] = "ﺟ";
        font_unicods[181, 1] = "005A";
        font_unicods[181, 2] = "005D";
        font_unicods[181, 3] = "005C";
        font_unicods[181, 4] = "005B";

        font_unicods[182, 0] = "ﺠ";
        font_unicods[182, 1] = "005A";
        font_unicods[182, 2] = "005D";
        font_unicods[182, 3] = "005C";
        font_unicods[182, 4] = "005B";

        //

        font_unicods[183, 0] = "ﻆ";
        font_unicods[183, 1] = "2039";
        font_unicods[183, 2] = "00CB";
        font_unicods[183, 3] = "00CA";
        font_unicods[183, 4] = "0152";

        font_unicods[184, 0] = "ﻅ";
        font_unicods[184, 1] = "2039";
        font_unicods[184, 2] = "00CB";
        font_unicods[184, 3] = "00CA";
        font_unicods[184, 4] = "0152";

        font_unicods[185, 0] = "ﻇ";
        font_unicods[185, 1] = "2039";
        font_unicods[185, 2] = "00CB";
        font_unicods[185, 3] = "00CA";
        font_unicods[185, 4] = "0152";

        font_unicods[186, 0] = "ﻈ";
        font_unicods[186, 1] = "2039";
        font_unicods[186, 2] = "00CB";
        font_unicods[186, 3] = "00CA";
        font_unicods[186, 4] = "0152";

        //

        font_unicods[187, 0] = "ﻄ";
        font_unicods[187, 1] = "2021";
        font_unicods[187, 2] = "2021";
        font_unicods[187, 3] = "2030";
        font_unicods[187, 4] = "2030";

        font_unicods[188, 0] = "ﻃ";
        font_unicods[188, 1] = "2021";
        font_unicods[188, 2] = "2021";
        font_unicods[188, 3] = "2030";
        font_unicods[188, 4] = "2030";

        font_unicods[189, 0] = "ﻂ";
        font_unicods[189, 1] = "2021";
        font_unicods[189, 2] = "2021";
        font_unicods[189, 3] = "2030";
        font_unicods[189, 4] = "2030";

        font_unicods[190, 0] = "ﻁ";
        font_unicods[190, 1] = "2021";
        font_unicods[190, 2] = "2021";
        font_unicods[190, 3] = "2030";
        font_unicods[190, 4] = "2030";

        //

        font_unicods[191, 0] = "ﻀ";
        font_unicods[191, 1] = "0192";
        font_unicods[191, 2] = "2020";
        font_unicods[191, 3] = "2026";
        font_unicods[191, 4] = "201E";

        font_unicods[192, 0] = "ﺿ";
        font_unicods[192, 1] = "0192";
        font_unicods[192, 2] = "2020";
        font_unicods[192, 3] = "2026";
        font_unicods[192, 4] = "201E";

        font_unicods[193, 0] = "ﺾ";
        font_unicods[193, 1] = "0192";
        font_unicods[193, 2] = "2020";
        font_unicods[193, 3] = "2026";
        font_unicods[193, 4] = "201E";

        font_unicods[194, 0] = "ﺽ";
        font_unicods[194, 1] = "0192";
        font_unicods[194, 2] = "2020";
        font_unicods[194, 3] = "2026";
        font_unicods[194, 4] = "201E";

        //

        font_unicods[195, 0] = "ﺼ";
        font_unicods[195, 1] = "007C";
        font_unicods[195, 2] = "201A";
        font_unicods[195, 3] = "007E";
        font_unicods[195, 4] = "007D";

        font_unicods[196, 0] = "ﺻ";
        font_unicods[196, 1] = "007C";
        font_unicods[196, 2] = "201A";
        font_unicods[196, 3] = "007E";
        font_unicods[196, 4] = "007D";

        font_unicods[197, 0] = "ﺺ";
        font_unicods[197, 1] = "007C";
        font_unicods[197, 2] = "201A";
        font_unicods[197, 3] = "007E";
        font_unicods[197, 4] = "007D";

        font_unicods[198, 0] = "ﺹ";
        font_unicods[198, 1] = "007C";
        font_unicods[198, 2] = "201A";
        font_unicods[198, 3] = "007E";
        font_unicods[198, 4] = "007D";

        //

        font_unicods[199, 0] = "ﺸ";
        font_unicods[199, 1] = "0078";
        font_unicods[199, 2] = "007B";
        font_unicods[199, 3] = "007A";
        font_unicods[199, 4] = "0079";

        font_unicods[200, 0] = "ﺷ";
        font_unicods[200, 1] = "0078";
        font_unicods[200, 2] = "007B";
        font_unicods[200, 3] = "007A";
        font_unicods[200, 4] = "0079";

        font_unicods[201, 0] = "ﺶ";
        font_unicods[201, 1] = "0078";
        font_unicods[201, 2] = "007B";
        font_unicods[201, 3] = "007A";
        font_unicods[201, 4] = "0079";

        font_unicods[202, 0] = "ﺵ";
        font_unicods[202, 1] = "0078";
        font_unicods[202, 2] = "007B";
        font_unicods[202, 3] = "007A";
        font_unicods[202, 4] = "0079";

        //

        font_unicods[203, 0] = "ﻚ";
        font_unicods[203, 1] = "00A5";
        font_unicods[203, 2] = "00A8";
        font_unicods[203, 3] = "00A7";
        font_unicods[203, 4] = "00A6";

        font_unicods[204, 0] = "ﻙ";
        font_unicods[204, 1] = "00A5";
        font_unicods[204, 2] = "00A8";
        font_unicods[204, 3] = "00A7";
        font_unicods[204, 4] = "00A6";

        font_unicods[205, 0] = "ﻛ";
        font_unicods[205, 1] = "00A5";
        font_unicods[205, 2] = "00A8";
        font_unicods[205, 3] = "00A7";
        font_unicods[205, 4] = "00A6";

        font_unicods[206, 0] = "ﻜ";
        font_unicods[206, 1] = "00A5";
        font_unicods[206, 2] = "00A8";
        font_unicods[206, 3] = "00A7";
        font_unicods[206, 4] = "00A6";

        //

        font_unicods[207, 0] = "ﻘ";
        font_unicods[207, 1] = "00A1";
        font_unicods[207, 2] = "00A4";
        font_unicods[207, 3] = "00A3";
        font_unicods[207, 4] = "00A2";

        font_unicods[208, 0] = "ﻗ";
        font_unicods[208, 1] = "00A1";
        font_unicods[208, 2] = "00A4";
        font_unicods[208, 3] = "00A3";
        font_unicods[208, 4] = "00A2";

        font_unicods[209, 0] = "ﻖ";
        font_unicods[209, 1] = "00A1";
        font_unicods[209, 2] = "00A4";
        font_unicods[209, 3] = "00A3";
        font_unicods[209, 4] = "00A2";

        font_unicods[210, 0] = "ﻕ";
        font_unicods[210, 1] = "00A1";
        font_unicods[210, 2] = "00A4";
        font_unicods[210, 3] = "00A3";
        font_unicods[210, 4] = "00A2";

        //

        font_unicods[211, 0] = "ﻔ";
        font_unicods[211, 1] = "203A";
        font_unicods[211, 2] = "00CE";
        font_unicods[211, 3] = "0178";
        font_unicods[211, 4] = "0153";

        font_unicods[212, 0] = "ﻓ";
        font_unicods[212, 1] = "203A";
        font_unicods[212, 2] = "00CE";
        font_unicods[212, 3] = "0178";
        font_unicods[212, 4] = "0153";

        font_unicods[213, 0] = "ﻒ";
        font_unicods[213, 1] = "203A";
        font_unicods[213, 2] = "00CE";
        font_unicods[213, 3] = "0178";
        font_unicods[213, 4] = "0153";

        font_unicods[214, 0] = "ﻑ";
        font_unicods[214, 1] = "203A";
        font_unicods[214, 2] = "00CE";
        font_unicods[214, 3] = "0178";
        font_unicods[214, 4] = "0153";

        //

        font_unicods[215, 0] = "ﻐ";
        font_unicods[215, 1] = "2014";
        font_unicods[215, 2] = "0161";
        font_unicods[215, 3] = "2122";
        font_unicods[215, 4] = "02DC";

        font_unicods[216, 0] = "ﻏ";
        font_unicods[216, 1] = "2014";
        font_unicods[216, 2] = "0161";
        font_unicods[216, 3] = "2122";
        font_unicods[216, 4] = "02DC";

        font_unicods[217, 0] = "ﻎ";
        font_unicods[217, 1] = "2014";
        font_unicods[217, 2] = "0161";
        font_unicods[217, 3] = "2122";
        font_unicods[217, 4] = "02DC";

        font_unicods[218, 0] = "ﻍ";
        font_unicods[218, 1] = "2014";
        font_unicods[218, 2] = "0161";
        font_unicods[218, 3] = "2122";
        font_unicods[218, 4] = "02DC";

        //

        font_unicods[219, 0] = "ﻌ";
        font_unicods[219, 1] = "201C";
        font_unicods[219, 2] = "2013";
        font_unicods[219, 3] = "2022";
        font_unicods[219, 4] = "201D";

        font_unicods[220, 0] = "ﻋ";
        font_unicods[220, 1] = "201C";
        font_unicods[220, 2] = "2013";
        font_unicods[220, 3] = "2022";
        font_unicods[220, 4] = "201D";

        font_unicods[221, 0] = "ﻊ";
        font_unicods[221, 1] = "201C";
        font_unicods[221, 2] = "2013";
        font_unicods[221, 3] = "2022";
        font_unicods[221, 4] = "201D";

        font_unicods[222, 0] = "ﻉ";
        font_unicods[222, 1] = "201C";
        font_unicods[222, 2] = "2013";
        font_unicods[222, 3] = "2022";
        font_unicods[222, 4] = "201D";

        //

        font_unicods[223, 0] = "ﻮ";
        font_unicods[223, 1] = "00BB";
        font_unicods[223, 2] = "-1";
        font_unicods[223, 3] = "-1";
        font_unicods[223, 4] = "00BC";

        font_unicods[224, 0] = "ﻭ";
        font_unicods[224, 1] = "00BB";
        font_unicods[224, 2] = "-1";
        font_unicods[224, 3] = "-1";
        font_unicods[224, 4] = "00BC";

        //

        font_unicods[225, 0] = "ﻬ";
        font_unicods[225, 1] = "00BD";
        font_unicods[225, 2] = "00C0";
        font_unicods[225, 3] = "00BF";
        font_unicods[225, 4] = "00BE";

        font_unicods[226, 0] = "ﻫ";
        font_unicods[226, 1] = "00BD";
        font_unicods[226, 2] = "00C0";
        font_unicods[226, 3] = "00BF";
        font_unicods[226, 4] = "00BE";

        font_unicods[227, 0] = "ﻪ";
        font_unicods[227, 1] = "00BD";
        font_unicods[227, 2] = "00C0";
        font_unicods[227, 3] = "00BF";
        font_unicods[227, 4] = "00BE";

        font_unicods[228, 0] = "ﻩ";
        font_unicods[228, 1] = "00BD";
        font_unicods[228, 2] = "00C0";
        font_unicods[228, 3] = "00BF";
        font_unicods[228, 4] = "00BE";

        //

        font_unicods[229, 0] = "ﻨ";
        font_unicods[229, 1] = "00B7";
        font_unicods[229, 2] = "00BA";
        font_unicods[229, 3] = "00B9";
        font_unicods[229, 4] = "00B8";

        font_unicods[230, 0] = "ﻧ";
        font_unicods[230, 1] = "00B7";
        font_unicods[230, 2] = "00BA";
        font_unicods[230, 3] = "00B9";
        font_unicods[230, 4] = "00B8";

        font_unicods[231, 0] = "ﻦ";
        font_unicods[231, 1] = "00B7";
        font_unicods[231, 2] = "00BA";
        font_unicods[231, 3] = "00B9";
        font_unicods[231, 4] = "00B8";

        font_unicods[232, 0] = "ﻥ";
        font_unicods[232, 1] = "00B7";
        font_unicods[232, 2] = "00BA";
        font_unicods[232, 3] = "00B9";
        font_unicods[232, 4] = "00B8";

        //

        font_unicods[233, 0] = "ﻤ";
        font_unicods[233, 1] = "00B3";
        font_unicods[233, 2] = "00B6";
        font_unicods[233, 3] = "00B5";
        font_unicods[233, 4] = "00B4";

        font_unicods[234, 0] = "ﻣ";
        font_unicods[234, 1] = "00B3";
        font_unicods[234, 2] = "00B6";
        font_unicods[234, 3] = "00B5";
        font_unicods[234, 4] = "00B4";

        font_unicods[235, 0] = "ﻢ";
        font_unicods[235, 1] = "00B3";
        font_unicods[235, 2] = "00B6";
        font_unicods[235, 3] = "00B5";
        font_unicods[235, 4] = "00B4";

        font_unicods[236, 0] = "ﻡ";
        font_unicods[236, 1] = "00B3";
        font_unicods[236, 2] = "00B6";
        font_unicods[236, 3] = "00B5";
        font_unicods[236, 4] = "00B4";

        //

        font_unicods[237, 0] = "ﻠ";
        font_unicods[237, 1] = "00AD";
        font_unicods[237, 2] = "00B2";
        font_unicods[237, 3] = "00B1";
        font_unicods[237, 4] = "00AE";

        font_unicods[238, 0] = "ﻟ";
        font_unicods[238, 1] = "00AD";
        font_unicods[238, 2] = "00B2";
        font_unicods[238, 3] = "00B1";
        font_unicods[238, 4] = "00AE";

        font_unicods[239, 0] = "ﻞ";
        font_unicods[239, 1] = "00AD";
        font_unicods[239, 2] = "00B2";
        font_unicods[239, 3] = "00B1";
        font_unicods[239, 4] = "00AE";

        font_unicods[240, 0] = "ﻝ";
        font_unicods[240, 1] = "00AD";
        font_unicods[240, 2] = "00B2";
        font_unicods[240, 3] = "00B1";
        font_unicods[240, 4] = "00AE";

        //

        font_unicods[241, 0] = "ﻴ";
        font_unicods[241, 1] = "00C1";
        font_unicods[241, 2] = "00C4";
        font_unicods[241, 3] = "00C3";
        font_unicods[241, 4] = "00C2";

        font_unicods[242, 0] = "ﻳ";
        font_unicods[242, 1] = "00C1";
        font_unicods[242, 2] = "00C4";
        font_unicods[242, 3] = "00C3";
        font_unicods[242, 4] = "00C2";

        font_unicods[243, 0] = "ﻲ";
        font_unicods[243, 1] = "00C1";
        font_unicods[243, 2] = "00C4";
        font_unicods[243, 3] = "00C3";
        font_unicods[243, 4] = "00C2";

        font_unicods[244, 0] = "ﻱ";
        font_unicods[244, 1] = "00C1";
        font_unicods[244, 2] = "00C4";
        font_unicods[244, 3] = "00C3";
        font_unicods[244, 4] = "00C2";

        font_unicods[245, 0] = "ﻰ";
        font_unicods[245, 1] = "00C1";
        font_unicods[245, 2] = "00C4";
        font_unicods[245, 3] = "00C3";
        font_unicods[245, 4] = "00C2";

        font_unicods[246, 0] = "ﻯ";
        font_unicods[246, 1] = "00C1";
        font_unicods[246, 2] = "00C4";
        font_unicods[246, 3] = "00C3";
        font_unicods[246, 4] = "00C2";

        //------------------------------------------- some other -------------------------------

        font_unicods[247, 0] = "@";
        font_unicods[247, 1] = "00C5";
        font_unicods[247, 2] = "-1";
        font_unicods[247, 3] = "-1";
        font_unicods[247, 4] = "-1";

        font_unicods[248, 0] = "$";
        font_unicods[248, 1] = "0024";
        font_unicods[248, 2] = "-1";
        font_unicods[248, 3] = "-1";
        font_unicods[248, 4] = "-1";

        font_unicods[249, 0] = "&";
        font_unicods[249, 1] = "0026";
        font_unicods[249, 2] = "-1";
        font_unicods[249, 3] = "-1";
        font_unicods[249, 4] = "-1";

        //------------------------------------------- English part -------------------------------

        font_unicods[250, 0] = "A";
        font_unicods[250, 1] = "00E6";
        font_unicods[250, 2] = "-1";
        font_unicods[250, 3] = "-1";
        font_unicods[250, 4] = "-1";

        font_unicods[251, 0] = "B";
        font_unicods[251, 1] = "00E7";
        font_unicods[251, 2] = "-1";
        font_unicods[251, 3] = "-1";
        font_unicods[251, 4] = "-1";

        font_unicods[252, 0] = "C";
        font_unicods[252, 1] = "00E8";
        font_unicods[252, 2] = "-1";
        font_unicods[252, 3] = "-1";
        font_unicods[252, 4] = "-1";

        font_unicods[253, 0] = "D";
        font_unicods[253, 1] = "00E9";
        font_unicods[253, 2] = "-1";
        font_unicods[253, 3] = "-1";
        font_unicods[253, 4] = "-1";

        font_unicods[254, 0] = "E";
        font_unicods[254, 1] = "00EA";
        font_unicods[254, 2] = "-1";
        font_unicods[254, 3] = "-1";
        font_unicods[254, 4] = "-1";

        font_unicods[255, 0] = "F";
        font_unicods[255, 1] = "00EB";
        font_unicods[255, 2] = "-1";
        font_unicods[255, 3] = "-1";
        font_unicods[255, 4] = "-1";

        font_unicods[256, 0] = "G";
        font_unicods[256, 1] = "00EC";
        font_unicods[256, 2] = "-1";
        font_unicods[256, 3] = "-1";
        font_unicods[256, 4] = "-1";

        font_unicods[257, 0] = "H";
        font_unicods[257, 1] = "00ED";
        font_unicods[257, 2] = "-1";
        font_unicods[257, 3] = "-1";
        font_unicods[257, 4] = "-1";

        font_unicods[258, 0] = "I";
        font_unicods[258, 1] = "00EE";
        font_unicods[258, 2] = "-1";
        font_unicods[258, 3] = "-1";
        font_unicods[258, 4] = "-1";


        font_unicods[259, 0] = "J";
        font_unicods[259, 1] = "00EF";
        font_unicods[259, 2] = "-1";
        font_unicods[259, 3] = "-1";
        font_unicods[259, 4] = "-1";

        font_unicods[260, 0] = "K";
        font_unicods[260, 1] = "00F0";
        font_unicods[260, 2] = "-1";
        font_unicods[260, 3] = "-1";
        font_unicods[260, 4] = "-1";

        font_unicods[261, 0] = "L";
        font_unicods[261, 1] = "00F1";
        font_unicods[261, 2] = "-1";
        font_unicods[261, 3] = "-1";
        font_unicods[261, 4] = "-1";

        font_unicods[262, 0] = "M";
        font_unicods[262, 1] = "00F2";
        font_unicods[262, 2] = "-1";
        font_unicods[262, 3] = "-1";
        font_unicods[262, 4] = "-1";

        font_unicods[263, 0] = "N";
        font_unicods[263, 1] = "00F3";
        font_unicods[263, 2] = "-1";
        font_unicods[263, 3] = "-1";
        font_unicods[263, 4] = "-1";

        font_unicods[264, 0] = "O";
        font_unicods[264, 1] = "00F4";
        font_unicods[264, 2] = "-1";
        font_unicods[264, 3] = "-1";
        font_unicods[264, 4] = "-1";

        font_unicods[265, 0] = "P";
        font_unicods[265, 1] = "00F5";
        font_unicods[265, 2] = "-1";
        font_unicods[265, 3] = "-1";
        font_unicods[265, 4] = "-1";

        font_unicods[266, 0] = "Q";
        font_unicods[266, 1] = "00F6";
        font_unicods[266, 2] = "-1";
        font_unicods[266, 3] = "-1";
        font_unicods[266, 4] = "-1";

        font_unicods[267, 0] = "R";
        font_unicods[267, 1] = "00F7";
        font_unicods[267, 2] = "-1";
        font_unicods[267, 3] = "-1";
        font_unicods[267, 4] = "-1";

        font_unicods[268, 0] = "S";
        font_unicods[268, 1] = "00F8";
        font_unicods[268, 2] = "-1";
        font_unicods[268, 3] = "-1";
        font_unicods[268, 4] = "-1";

        font_unicods[269, 0] = "T";
        font_unicods[269, 1] = "00F9";
        font_unicods[269, 2] = "-1";
        font_unicods[269, 3] = "-1";
        font_unicods[269, 4] = "-1";

        font_unicods[270, 0] = "U";
        font_unicods[270, 1] = "00FA";
        font_unicods[270, 2] = "-1";
        font_unicods[270, 3] = "-1";
        font_unicods[240, 4] = "-1";

        font_unicods[271, 0] = "V";
        font_unicods[271, 1] = "00FB";
        font_unicods[271, 2] = "-1";
        font_unicods[271, 3] = "-1";
        font_unicods[271, 4] = "-1";

        font_unicods[272, 0] = "W";
        font_unicods[272, 1] = "00FC";
        font_unicods[272, 2] = "-1";
        font_unicods[272, 3] = "-1";
        font_unicods[272, 4] = "-1";

        font_unicods[273, 0] = "X";
        font_unicods[273, 1] = "00FD";
        font_unicods[273, 2] = "-1";
        font_unicods[273, 3] = "-1";
        font_unicods[273, 4] = "-1";

        font_unicods[274, 0] = "Y";
        font_unicods[274, 1] = "00FE";
        font_unicods[274, 2] = "-1";
        font_unicods[274, 3] = "-1";
        font_unicods[274, 4] = "-1";

        font_unicods[275, 0] = "Z";
        font_unicods[275, 1] = "00FF";
        font_unicods[275, 2] = "-1";
        font_unicods[275, 3] = "-1";
        font_unicods[275, 4] = "-1";

        //==

        font_unicods[276, 0] = "a";
        font_unicods[276, 1] = "0100";
        font_unicods[276, 2] = "-1";
        font_unicods[276, 3] = "-1";
        font_unicods[276, 4] = "-1";

        font_unicods[277, 0] = "b";
        font_unicods[277, 1] = "0101";
        font_unicods[277, 2] = "-1";
        font_unicods[277, 3] = "-1";
        font_unicods[277, 4] = "-1";

        font_unicods[278, 0] = "c";
        font_unicods[278, 1] = "0102";
        font_unicods[278, 2] = "-1";
        font_unicods[278, 3] = "-1";
        font_unicods[278, 4] = "-1";

        font_unicods[279, 0] = "d";
        font_unicods[279, 1] = "0103";
        font_unicods[279, 2] = "-1";
        font_unicods[279, 3] = "-1";
        font_unicods[279, 4] = "-1";

        font_unicods[280, 0] = "e";
        font_unicods[280, 1] = "0104";
        font_unicods[280, 2] = "-1";
        font_unicods[280, 3] = "-1";
        font_unicods[280, 4] = "-1";

        font_unicods[281, 0] = "f";
        font_unicods[281, 1] = "0105";
        font_unicods[281, 2] = "-1";
        font_unicods[281, 3] = "-1";
        font_unicods[281, 4] = "-1";

        font_unicods[282, 0] = "g";
        font_unicods[282, 1] = "0106";
        font_unicods[282, 2] = "-1";
        font_unicods[282, 3] = "-1";
        font_unicods[282, 4] = "-1";

        font_unicods[283, 0] = "h";
        font_unicods[283, 1] = "0107";
        font_unicods[283, 2] = "-1";
        font_unicods[283, 3] = "-1";
        font_unicods[283, 4] = "-1";

        font_unicods[284, 0] = "i";
        font_unicods[284, 1] = "0108";
        font_unicods[284, 2] = "-1";
        font_unicods[284, 3] = "-1";
        font_unicods[284, 4] = "-1";

        font_unicods[285, 0] = "j";
        font_unicods[285, 1] = "0109";
        font_unicods[285, 2] = "-1";
        font_unicods[285, 3] = "-1";
        font_unicods[285, 4] = "-1";

        font_unicods[286, 0] = "k";
        font_unicods[286, 1] = "010A";
        font_unicods[286, 2] = "-1";
        font_unicods[286, 3] = "-1";
        font_unicods[286, 4] = "-1";

        font_unicods[287, 0] = "l";
        font_unicods[287, 1] = "010B";
        font_unicods[287, 2] = "-1";
        font_unicods[287, 3] = "-1";
        font_unicods[287, 4] = "-1";

        font_unicods[288, 0] = "m";
        font_unicods[288, 1] = "010C";
        font_unicods[288, 2] = "-1";
        font_unicods[288, 3] = "-1";
        font_unicods[288, 4] = "-1";

        font_unicods[289, 0] = "n";
        font_unicods[289, 1] = "010D";
        font_unicods[289, 2] = "-1";
        font_unicods[289, 3] = "-1";
        font_unicods[289, 4] = "-1";

        font_unicods[290, 0] = "o";
        font_unicods[290, 1] = "010E";
        font_unicods[290, 2] = "-1";
        font_unicods[290, 3] = "-1";
        font_unicods[290, 4] = "-1";

        font_unicods[291, 0] = "p";
        font_unicods[291, 1] = "010F";
        font_unicods[291, 2] = "-1";
        font_unicods[291, 3] = "-1";
        font_unicods[291, 4] = "-1";

        font_unicods[292, 0] = "q";
        font_unicods[292, 1] = "0110";
        font_unicods[292, 2] = "-1";
        font_unicods[292, 3] = "-1";
        font_unicods[292, 4] = "-1";

        font_unicods[293, 0] = "r";
        font_unicods[293, 1] = "0111";
        font_unicods[293, 2] = "-1";
        font_unicods[293, 3] = "-1";
        font_unicods[293, 4] = "-1";

        font_unicods[294, 0] = "s";
        font_unicods[294, 1] = "0112";
        font_unicods[294, 2] = "-1";
        font_unicods[294, 3] = "-1";
        font_unicods[294, 4] = "-1";

        font_unicods[295, 0] = "t";
        font_unicods[295, 1] = "0113";
        font_unicods[295, 2] = "-1";
        font_unicods[295, 3] = "-1";
        font_unicods[295, 4] = "-1";

        font_unicods[296, 0] = "u";
        font_unicods[296, 1] = "0114";
        font_unicods[296, 2] = "-1";
        font_unicods[296, 3] = "-1";
        font_unicods[296, 4] = "-1";

        font_unicods[297, 0] = "v";
        font_unicods[297, 1] = "0115";
        font_unicods[297, 2] = "-1";
        font_unicods[297, 3] = "-1";
        font_unicods[297, 4] = "-1";

        font_unicods[298, 0] = "w";
        font_unicods[298, 1] = "0116";
        font_unicods[298, 2] = "-1";
        font_unicods[298, 3] = "-1";
        font_unicods[298, 4] = "-1";

        font_unicods[299, 0] = "x";
        font_unicods[299, 1] = "0117";
        font_unicods[299, 2] = "-1";
        font_unicods[299, 3] = "-1";
        font_unicods[299, 4] = "-1";

        font_unicods[300, 0] = "y";
        font_unicods[300, 1] = "0118";
        font_unicods[300, 2] = "-1";
        font_unicods[300, 3] = "-1";
        font_unicods[300, 4] = "-1";

        font_unicods[301, 0] = "z";
        font_unicods[301, 1] = "0119";
        font_unicods[301, 2] = "-1";
        font_unicods[301, 3] = "-1";
        font_unicods[301, 4] = "-1";

        //--------------------- en numbers 

        font_unicods[302, 0] = "1";
        font_unicods[302, 1] = "011B";
        font_unicods[302, 2] = "-1";
        font_unicods[302, 3] = "-1";
        font_unicods[302, 4] = "-1";

        font_unicods[303, 0] = "2";
        font_unicods[303, 1] = "011C";
        font_unicods[303, 2] = "-1";
        font_unicods[303, 3] = "-1";
        font_unicods[303, 4] = "-1";

        font_unicods[304, 0] = "3";
        font_unicods[304, 1] = "011D";
        font_unicods[304, 2] = "-1";
        font_unicods[304, 3] = "-1";
        font_unicods[304, 4] = "-1";

        font_unicods[305, 0] = "4";
        font_unicods[305, 1] = "011E";
        font_unicods[305, 2] = "-1";
        font_unicods[305, 3] = "-1";
        font_unicods[305, 4] = "-1";

        font_unicods[306, 0] = "5";
        font_unicods[306, 1] = "011F";
        font_unicods[306, 2] = "-1";
        font_unicods[306, 3] = "-1";
        font_unicods[306, 4] = "-1";

        font_unicods[307, 0] = "6";
        font_unicods[307, 1] = "0120";
        font_unicods[307, 2] = "-1";
        font_unicods[307, 3] = "-1";
        font_unicods[307, 4] = "-1";

        font_unicods[308, 0] = "7";
        font_unicods[308, 1] = "0121";
        font_unicods[308, 2] = "-1";
        font_unicods[308, 3] = "-1";
        font_unicods[308, 4] = "-1";

        font_unicods[309, 0] = "8";
        font_unicods[309, 1] = "0122";
        font_unicods[309, 2] = "-1";
        font_unicods[309, 3] = "-1";
        font_unicods[309, 4] = "-1";

        font_unicods[310, 0] = "9";
        font_unicods[310, 1] = "0123";
        font_unicods[310, 2] = "-1";
        font_unicods[310, 3] = "-1";
        font_unicods[310, 4] = "-1";

        font_unicods[311, 0] = "0";
        font_unicods[311, 1] = "011A";
        font_unicods[311, 2] = "-1";
        font_unicods[311, 3] = "-1";
        font_unicods[311, 4] = "-1";

        font_unicods[312, 0] = "ى";
        font_unicods[312, 1] = "00C1";
        font_unicods[312, 2] = "00C4";
        font_unicods[312, 3] = "00C3";
        font_unicods[312, 4] = "00C2";
        //---------------------------------------------------------------------------------------------

       

    }
}

