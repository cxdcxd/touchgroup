using System;
using System.Collections;
using System.Drawing;
using System.IO;

namespace TouchGroup
{
    [Serializable]
    public class food_item
    {
        public int type_index;
        public string food_name;
        public double food_cost;
        public string info;
    }

    public class food_type
    {
        public string type_name_f;
        public string type_name_e;
        public int type_count;
    }

    [Serializable]
    public class Product : ICloneable
    {
        DevExpress.Utils.ImageCollection icol;

        string id_code = "0";
        string calorie;
        public string food_type_str = "";
        string name_f;
        string name_e;
        public double cost = 0;
        public bool enable = true;
        string info_e;
        string info_f;
        int rate = 0;
        public byte[] img;
        Image rate_img;
        public int available;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Product()
        {
        }
        public Product(string id, string type_name, string namef, string namee, double cost, string info, DevExpress.Utils.ImageCollection col, bool enable, string rate_number, Image m_image, string inf, string ine)
        {
            icol = col;
            this.id_code = id;
            this.food_type_str = type_name;

            this.name_f = namef;
            this.name_e = namee;
            this.cost = cost;
            this.info_f = inf;
            this.info_e = ine;
            this.enable = enable;
            rate = int.Parse(rate_number);
            this.Img = m_image;
            available = -1;
        }

        public Image Img
        {
            get
            {
                if (img != null)
                {
                    MemoryStream ms = new MemoryStream(img);
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
                return null;

            }
            set
            {
                if (value != null)
                {
                    MemoryStream ms = new MemoryStream();
                    Image imageIn = value;
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    img = ms.ToArray();
                }
                else
                    img = null;
            }
        }

        public Image Rimg
        {
            get
            {
                try
                {
                    rate_img = icol.Images[rate];
                    return rate_img;
                }
                catch (System.Exception ex)
                {
                    ex = new System.Exception();
                    rate = 0;
                    rate_img = icol.Images[rate];
                    return rate_img;
                }

            }

        }

        public string Calorie
        {
            get { return calorie; }
            set { calorie = value; }
        }
        public string Infof
        {
            get { return info_f; }
            set { info_f = value; }
        }
        public string Infoe
        {
            get { return info_e; }
            set { info_e = value; }
        }

        public string Available
        {
            get
            {
                if (available != -1)
                    return available.ToString();
                else
                    return "-";

            }
            set
            {
                try
                {
                    int vvv = int.Parse(value);
                    if (vvv >= 0 && vvv <= 1000)
                        available = vvv;
                    else
                        if (vvv < 0)
                            available = 0;
                        else
                            available = 1000;
                }
                catch
                {
                    available = 0;
                }
            }
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public bool Enable
        {
            get { return enable; }
            set { enable = value; }
        }

        public double Cost
        {
            get { return cost; }
            set
            {
                double x = value;
                if (x < 100) x = 100;
                if (x > 200000) x = 200000;
                cost = x;
            }
        }

        public string Name_e
        {
            get { return name_e; }
            set
            {

                name_e = value;
            }
        }
        public string Name_f
        {
            get { return name_f; }
            set
            {

                name_f = value;
            }
        }

        public string Type
        {
            get
            {

                return food_type_str;
            }

            set
            {
                food_type_str = value;
            }

        }

        public string ID
        {
            get { return id_code; }
            set { id_code = value; }
        }













    }

    [Serializable]
    public class Product2
    {

        public string food_type_str = "";
        string id_code = "0";

        string name;
        public double cost = 0;
        public bool enable = true;
        string info;
        int rate = 0;


        public Product2(string id, string type, string name, double cost, string info, bool enable, string rate_number)
        {

            this.id_code = id;
            this.food_type_str = type;
            this.name = name;
            this.cost = cost;
            this.info = "خالي";
            this.enable = enable;
            rate = int.Parse(rate_number);
        }



        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public bool Enable
        {
            get { return enable; }
            set { enable = value; }
        }

        public double Cost
        {
            get { return cost; }
            set
            {
                double x = value;
                if (x < 100) x = 100;
                if (x > 200000) x = 200000;
                cost = x;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {

                name = value;
            }
        }


        public string Type
        {
            get
            {

                return food_type_str;
            }

            set
            {
                food_type_str = value;
            }

        }



        public string ID
        {
            get { return id_code; }
            set { id_code = value; }
        }




    }
}