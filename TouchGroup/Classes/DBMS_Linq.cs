using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TouchGroup
{
   
    class DBMS_Linq
    {
        static int version = 1;

        #region main
      
        public static bool detach()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=(localdb)\\v11.0;Integrated Security=true;");
                SqlCommand cmd = new SqlCommand("", conn);

                string path = Environment.CurrentDirectory;

                cmd.CommandText = "exec sys.sp_detach_db dbmain";

                conn.Open();

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Dispose();
            }
            catch (Exception r)
            {
                MessageBox.Show("error : " + r.Message);
            }
            return true;
        }
        
        public static bool attach()
        {
            //Init Linq Connection Or Attach the mdf database for first time
            try
            {
                SqlConnection conn = new SqlConnection("Server=(localdb)\\v11.0;Integrated Security=true;");
                SqlCommand cmd = new SqlCommand("", conn);
                string path = Environment.CurrentDirectory;

                cmd.CommandText = "exec sys.sp_attach_db dbmain, '" + path + "\\data\\dbmain.mdf'";
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Dispose();

                //===========================================
               
            }
            catch (Exception r)
            {
                //MessageBox.Show("error : " + r.Message);
            }

            return true;
        }
      
        public static void reload_products()
        {
            Statics.list_products = get_products();
            if (Statics.list_products == null) Statics.list_products = new List<Productd>();
        }

        public static void reload_product_groups()
        {
            Statics.list_product_groups = get_porduct_groups();
            if (Statics.list_product_groups == null) Statics.list_product_groups = new List<ProductdGroup>();
        }
        
        #endregion

        #region setting
        public static Setting get_setting()
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            int a = contex.Settings.Count();

            if (a == 1)
            {
                return contex.Settings.First();
            }
            else
            {
                return null;
            }

        }
        public static bool set_setting()
        {
            LinqDataDataContext contex = new LinqDataDataContext();

            if (contex.Settings.Count() > 0)
            {
                contex.Settings.DeleteOnSubmit(contex.Settings.First());
                contex.Settings.InsertOnSubmit(Statics.CurrentSetting);

                contex.SubmitChanges();
            }
            else
            {
                return false;
            }

            return true;
        }

        #endregion 

        #region users
        public static List<User> get_users()
        {
            //get all users
            LinqDataDataContext contex = new LinqDataDataContext();
            int a = contex.Users.Count();

            if (a > 0)
            {
                var data = from o in contex.Users
                           select o;
                return data.ToList<User>();
            }
            else
            {
                return null;
            }
        }
        public static User get_login(string UserName, string Password)
        {
            //get all users
            LinqDataDataContext contex = new LinqDataDataContext();
            int a = contex.Users.Count();

            if (a > 0)
            {
                var data = from o in contex.Users
                           where (o.UserName == UserName && o.Password == Password)
                           select o;

                if (data.Count() == 1)
                    return data.First();
                else
                    return null;
            }
            else
            {
                return null;
            }
        }
      
        #endregion

        #region product

        public static List<Productd> get_products()
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            int a = contex.Productds.Count();

            if (a > 0)
            {
                var data = from o in contex.Productds
                           orderby o.Category
                           select o;
                return data.ToList<Productd>();
            }
            else
            {
                return null;
            }
        }
        public static bool insert_product(Productd p)
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            
            try
            {
                contex.Productds.InsertOnSubmit(p);
                contex.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool delete_product(string key)
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            
            try
            {
                var items = from x in contex.Productds where x.NamePersian == key select x;
                contex.Productds.DeleteOnSubmit(items.FirstOrDefault());
                contex.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool update_product(Productd p_current,Productd p_new)
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            var items = from x in contex.Productds where x.NamePersian == p_current.NamePersian select x;
            Productd p = items.FirstOrDefault();
            //oh
            p.Calories = p_new.Calories;
            p.Category = p_new.Category;
            p.Enable = p_new.Enable;
            p.Image = p_new.Image;
            p.InfoEnglish = p_new.InfoEnglish;
            p.InfoPersian = p_new.InfoPersian;
            p.NameEnglish = p_new.NameEnglish;
            p.NamePersian = p_new.NamePersian;
            p.Price = p_new.Price;
            p.Rate = p_new.Rate;
            p.Stock = p_new.Stock;
            //
            contex.SubmitChanges();
            return true;
         
        }
        public static bool swap_product(string a, string b)
        {
            LinqDataDataContext contex = new LinqDataDataContext();

            var item1 = from o in contex.Productds
                        where o.NamePersian == a
                        select o;

            var item2 = from o in contex.Productds
                        where o.NamePersian == b
                        select o;

            Productd da = item1.FirstOrDefault();
            Productd db = item2.FirstOrDefault();
            Productd dc = new Productd();

            //1
            dc.NameEnglish = da.NameEnglish;
            dc.NamePersian = da.NamePersian;
            dc.Calories = da.Calories;
            dc.Category = da.Category;
            dc.Enable = da.Enable;
            dc.Image = da.Image;
            dc.InfoEnglish = da.InfoEnglish;
            dc.InfoPersian = da.InfoPersian;
            dc.Price = da.Price;
            dc.Rate = da.Rate;
            dc.Stock = da.Stock;
            
            //2
            da.NameEnglish = db.NameEnglish;
            da.NamePersian = db.NamePersian;
            da.Calories = db.Calories;
            da.Category = db.Category;
            da.Enable = db.Enable;
            da.Image = db.Image;
            da.InfoEnglish = db.InfoEnglish;
            da.InfoPersian = db.InfoPersian;
            da.Price = db.Price;
            da.Rate = db.Rate;
            da.Stock = db.Stock;

            //3
            db.NameEnglish = dc.NameEnglish;
            db.NamePersian = dc.NamePersian;
            db.Calories = dc.Calories;
            db.Category = dc.Category;
            db.Enable = dc.Enable;
            db.Image = dc.Image;
            db.InfoEnglish = dc.InfoEnglish;
            db.InfoPersian = dc.InfoPersian;
            db.Price = dc.Price;
            db.Rate = dc.Rate;
            db.Stock = dc.Stock;

            try
            {
                contex.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;

        }
        #endregion

        #region product_group
        public static List<ProductdGroup> get_porduct_groups()
        {
            //get all groups
            LinqDataDataContext contex = new LinqDataDataContext();
            int a = contex.ProductdGroups.Count();

            if (a > 0)
            {
                var data = from o in contex.ProductdGroups
                           select o;
                return data.ToList<ProductdGroup>();
            }
            else
            {
                return null;
            }
        }
        public static bool insert_product_group(ProductdGroup pg)
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            
            try
            {
                contex.ProductdGroups.InsertOnSubmit(pg);
                contex.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool delete_product_group(string key)
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            
            try
            {
                var items = from x in contex.ProductdGroups where x.NamePersian == key select x;
                contex.ProductdGroups.DeleteOnSubmit(items.FirstOrDefault());
                contex.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool update_product_group(ProductdGroup p_current,ProductdGroup p_new)
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            var items = from x in contex.ProductdGroups where x.NamePersian == p_current.NamePersian select x;
            ProductdGroup p = items.FirstOrDefault();

            //oh
            p.NameEnglish = p_new.NameEnglish;
            p.NamePersian = p_new.NamePersian;
            //
          
            try
            {
                contex.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool swap_product_group(string a, string b)
        {
            LinqDataDataContext contex = new LinqDataDataContext();
            var item1 = from o in contex.ProductdGroups
                        where o.NamePersian == a
                        select o;
            var item2 = from o in contex.ProductdGroups
                        where o.NamePersian == b
                        select o;

            ProductdGroup da = item1.FirstOrDefault();
            ProductdGroup db = item2.FirstOrDefault();
            ProductdGroup dc = new ProductdGroup();

            //1
            dc.NameEnglish = da.NameEnglish;
            dc.NamePersian = da.NamePersian;
            
            //2
            da.NameEnglish = db.NameEnglish;
            da.NamePersian = db.NamePersian;

            //3
            db.NameEnglish = dc.NameEnglish;
            db.NamePersian = dc.NamePersian;
            
            try
            {
                contex.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;

        }
        
        #endregion

        #region

        #endregion

    }
}
