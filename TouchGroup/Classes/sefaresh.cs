using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TouchGroup
{

    [Serializable]
    public class sefaresh_show
    {
        int seq;
        int sefaresh_req_count;
        int id;
        public int count;
        public Product2 p;
        string product_name = "";
        double fcost;
        int cost;

        public sefaresh_show(Product2 p, int c, int ID, int sseq)
        {
            seq = sseq;
            this.p = p;
            count = c;
            id = ID;
        }
        public sefaresh_show(string p_name, int c, int fcost, int ID, int sseq)
        {
            seq = sseq;
            this.p = null;
            product_name = p_name;
            count = c;
            id = ID;
            this.fcost = fcost;
            this.cost = ((int)this.fcost / this.count);
        }

        public double Fcost
        {
            get
            {
                if (p != null)
                    return count * p.Cost;

                return fcost;
            }
            set
            {
                fcost = value;
            }

        }



        public int Count
        {
            get
            {
                return count;
            }

        }

        public int Cost
        {
            get
            {
                if (p != null)
                    return (int)p.Cost;

                return cost;
            }

        }

        public string Name
        {
            get
            {
                if (p != null)
                    return p.Name;

                return product_name;
            }

        }


        public int ID
        {
            get
            {
                return id;
            }

        }

        public int SEQ
        {
            get
            {
                return (seq + 1);
            }

        }


    }
    [Serializable]
    public class sefaresh
    {
        public int seq_number = 0;
        public bool bill_req = false;
        public bool userbill_req = false;
        public string table_number;
        public string table_fishcode;
        public ArrayList list_codecstring; //string 5,2  product 5 count 3
        public List<sefaresh_show> list_sefareshshow;

        public double maliat_cost;
        public double service_cost;
        public double total_total_cost;

        public FarsiLibrary.Utils.PersianDate time;
        public double total_cost;

        public double get_total_cost()
        {
            double ad = 0;
            for (int i = 0; i < list_sefareshshow.Count; i++)
            {
                sefaresh_show sef_show2 = (sefaresh_show)list_sefareshshow[i];
                ad += sef_show2.Fcost;
            }
            total_cost = ad;
            return ad;

        }

        public sefaresh(string table, string fish, FarsiLibrary.Utils.PersianDate time, ArrayList food_list)
        {
            table_fishcode = fish;
            table_number = table;
            this.time = time;
            list_codecstring = food_list;
            list_sefareshshow = convert_codeclist_to_sefareshlist(this);


            get_total_cost();
        }

        public sefaresh(string table, string fish, FarsiLibrary.Utils.PersianDate time, List<sefaresh_show> sefaresh_show_list, bool a)
        {
            table_fishcode = fish;
            table_number = table;
            this.time = time;

            list_codecstring = null;
            list_sefareshshow = sefaresh_show_list;

            get_total_cost();
        }

        public List<sefaresh_show> convert_codeclist_to_sefareshlist(sefaresh sef)
        {
            List<sefaresh_show> sefaresh_list = new List<sefaresh_show>();
            sefaresh_show sef_show = null;
            for (int i = 0; i < sef.list_codecstring.Count; i++)
            {
                string a = (string)sef.list_codecstring[i];
                string[] a_array = a.Split(',');

                //Product p = (Product)(frmMain.menu[int.Parse(a_array[0])]);

                //Product2 p2 = new Product2(p.ID, p.Type, p.Name_f, p.Cost, p.Infof, p.Enable, p.Rate.ToString());
                //sef_show = new sefaresh_show(p2, int.Parse(a_array[1]), (i + 1), int.Parse(a_array[2]));
                //sefaresh_list.Add(sef_show);



            }
            return sefaresh_list;
        }
    }
    [Serializable]
    public class waiter_item
    {
        public string info = "none";

        public FarsiLibrary.Utils.PersianDate time;
        public string tablet_code;
        public string table_code;

    }
    public class bill_item
    {
        public string info = "none";

        public FarsiLibrary.Utils.PersianDate time;
        public string tablet_code;
        public string table_code;

        public sefaresh_show sef_show;

    }
}
