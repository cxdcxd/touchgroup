using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Management;
using System.Data.OleDb;
using System.Data.SQLite;
using System.IO;

namespace TouchGroup
{
    public partial class frmMenuCreator : DevExpress.XtraEditors.XtraForm
    {
        public frmMenuCreator()
        {
            InitializeComponent();
        }

        void init()
        {
            //Reload products and groups
            DBMS_Linq.reload_products();
            DBMS_Linq.reload_product_groups();

            listBox_groups.Items.Clear();
            listBox_foods.Items.Clear();
            //load groups
           
            for (int i = 0; i < Statics.list_product_groups.Count ; i++)
            {
                int count = 0;

                for (int j = 0; j < Statics.list_products.Count; j++ )
                {
                    if  ( Statics.list_products[j].Category == Statics.list_product_groups[i].NamePersian )
                    {
                        count++;
                    }
                }

                listBox_groups.Items.Add(count + " - " + Statics.list_product_groups[i].NamePersian);
            }

        }
        private void frmqmenu_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btn_new_product_Click(object sender, EventArgs e)
        {
            if ( Statics.list_product_groups.Count == 0 )
            {
                MBOX MB = new MBOX("لطفا ابتدا یک گروه معرفی نمایید ", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string select = listBox_groups.Items[listBox_groups.SelectedIndex].ToString();
            char[] s = new char[1];
            s[0] = '-';
            string[] selecta = select.Split(s);
            string item_group_name = selecta[1];
            item_group_name = item_group_name.Trim();

            frmMenuCreator_add mca = new frmMenuCreator_add(item_group_name);
            mca.ShowDialog();

            if (mca.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                init();
            }
        }

        private void btn_edit_product_Click(object sender, EventArgs e)
        {
            string selected_name = "-1";
            if (listBox_foods.Items.Count > 0)
            {
                int selected_index = listBox_foods.SelectedIndex;
                if (selected_index >= 0)
                {
                    selected_name = listBox_foods.Items[selected_index].ToString();
                }
            }

            if (selected_name != "-1")
            {
                Productd item = null;
                for ( int i = 0 ; i < Statics.list_products.Count ; i++ )
                {
                    if (selected_name == Statics.list_products[i].NamePersian)
                    {
                        item = Statics.list_products[i];
                        break;
                    }
                }

                if (item == null) return;

                frmProductMenu_edit menuform = new frmProductMenu_edit(item);
                menuform.ShowDialog();
                if (menuform.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    init();
                }
            }
            else
            {
                MBOX MB = new MBOX("محصولی برای ویرایش انتخاب نشده است ", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            
        }

        private void bnt_new_group_Click(object sender, EventArgs e)
        {
            string group_farsi = txt_group_name_farsi.Text;
            string group_english = txt_group_name_english.Text;

            try
            {

                if (group_english != "" && group_farsi != "")
                {

                    if (Language.LAN_CHECK(group_english, "english") == false) { MBOX MB = new MBOX("در بخش انگليسي از کاراکتر فارسي نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                    if (Language.LAN_CHECK(group_farsi, "farsi") == false) { MBOX MB = new MBOX("در بخش فارسی از کاراکتر انگلیسی نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }


                    for (int i = 0; i < Statics.list_product_groups.Count ; i++)
                    {
                        ProductdGroup pg = Statics.list_product_groups[i];

                        if (pg.NamePersian == group_farsi)
                        {
                            throw new Exception("نام فارسی گروه مورد نظر قبلا برای گروه دیگری انتخاب شده است");
                        }

                        if (pg.NameEnglish == group_english)
                        {
                            throw new Exception("نام انگلیسی گروه مورد نظر قبلا برای گروه دیگری انتخاب شده است");
                        }

                    }

                    /////////////////////////////////////////////////////////
                    //INSERT

                    ProductdGroup item = new ProductdGroup();
                    item.NamePersian = group_farsi;
                    item.NameEnglish = group_english;

                    bool result = DBMS_Linq.insert_product_group(item);

                    if ( result )
                    {
                        txt_group_name_farsi.Text = "";
                        txt_group_name_english.Text = "";

                        init();
                    }

                }
                else
                {
                    throw new Exception("اطلاعات ورودی صحیح نمی باشد");
                }
            }
            catch (Exception ee)
            {

                MBOX MB = new MBOX(ee.Message);  return;
            }
        }

        private void btn_edit_group_Click(object sender, EventArgs e)
        {
            try
            {
                string group_farsi = txt_group_name_farsi.Text;
                string group_english = txt_group_name_english.Text;
              
                try
                {

                    if (group_english != "" && group_farsi != "")
                    {

                        if (Language.LAN_CHECK(group_english, "english") == false) { MBOX MB = new MBOX("در بخش انگليسي از کاراکتر فارسي نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }
                        if (Language.LAN_CHECK(group_farsi, "farsi") == false) { MBOX MB = new MBOX("در بخش فارسی از کاراکتر انگلیسی نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }


                        for (int i = 0; i < Statics.list_product_groups.Count ; i++)
                        {
                            if (Statics.list_product_groups[i].NamePersian == group_farsi)
                            {
                                throw new Exception("نام فارسی گروه مورد نظر قبلا انتخاب شده است");
                            }

                            if (Statics.list_product_groups[i].NameEnglish == group_english)
                            {
                                throw new Exception("نام انگلیسی گروه مورد نظر قبلا انتخاب شده است");
                            }

                        }

                        /////////////////////////////////////////////////////////
                        //UPDATE TO MENU

                        ProductdGroup oldp = Statics.list_product_groups[listBox_groups.SelectedIndex];
                        ProductdGroup newp = new ProductdGroup();
                        newp.NamePersian = group_farsi;
                        newp.NameEnglish = group_english;

                        bool result1 = DBMS_Linq.update_product_group(oldp, newp);
                       

                        if (result1 )
                        {

                            for ( int i = 0; i < Statics.list_products.Count; i++ )
                            {
                                if ( Statics.list_products[i].Category == oldp.NamePersian )
                                {
                                    Productd pold = Statics.list_products[i];
                                    Productd pnew = Statics.list_products[i];
                                    pnew.Category = newp.NamePersian;

                                    DBMS_Linq.delete_product(pold.NamePersian);
                                    DBMS_Linq.insert_product(pnew);
                                   
                                }
                            }
                               
                            txt_group_name_farsi.Text = "";
                            txt_group_name_english.Text = "";

                            init();
                        }

                    }
                    else
                    {
                        throw new Exception("اطلاعات ورودی صحیح نمی باشد");
                    }
                }
                catch (Exception ee)
                {
                    MBOX MB = new MBOX(ee.Message); return;
                }
            }
            catch
            { }
        }

        private void btn_delete_group_Click(object sender, EventArgs e)
        {
            if (Statics.list_product_groups.Count > 0 )
            {
                string select = listBox_groups.Items[listBox_groups.SelectedIndex].ToString();
                char[] s = new char[1];
                s[0] = '-';
                string[] selecta = select.Split(s);
                string item_group_name = selecta[1];
                item_group_name = item_group_name.Trim();
                MBOX MB = new MBOX(item_group_name + "  حذف شود؟  توجه نمایید که تمام محصولات آن گروه نیز حذف می شوند", "حذف...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
                if (MB.DialogResult == DialogResult.OK)
                {
                    ProductdGroup pg = Statics.list_product_groups[listBox_groups.SelectedIndex];
                    bool result = DBMS_Linq.delete_product_group(pg.NamePersian);

                    if ( result )
                    {
                        //delete products in that group
                        ////////////////////////////////////////////////////////////////

                        List<Productd> delnames = new List<Productd>();

                        for (int i = 0; i < Statics.list_products.Count ; i++)
                        {
                                if (Statics.list_products[i].Category == item_group_name)
                                {
                                    delnames.Add(Statics.list_products[i]);
                                }

                        }

                        for (int i = 0; i < delnames.Count; i++)
                        {
                            bool result2 = DBMS_Linq.delete_product(delnames[i].NamePersian);
                        }

                        init();
                       
                    }
                }
            }
            else
            {
                MBOX MB = new MBOX("حداقل باید یک گروه تعریف شده باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);  return;
            }
        }

        void update_food_names_list()
        {
            try
            {
                listBox_foods.Items.Clear();
                int index = listBox_groups.SelectedIndex;
                if (index != -1)
                {
                    string cat_name = Statics.list_product_groups[index].NamePersian;

                    for (int i = 0; i < Statics.list_products.Count ; i++)
                    {
                        if (Statics.list_products[i].Category == cat_name)
                        {
                            listBox_foods.Items.Add(Statics.list_products[i].NamePersian);
                        }
                    }
                }
            }
            catch
            { }
        }
        private void listBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_food_names_list();
        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {
            if (Statics.server_manager.server.Sessions.Count != 0)
            {
                MBOX MB1 = new MBOX("برای حذف غذا باید تبلتی در سیستم موجود نباشد", "خطا ...", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            string selected_name = "-1";
            if (listBox_foods.Items.Count > 0)
            {
                int selected_index = listBox_foods.SelectedIndex;
                if (selected_index >= 0)
                {
                    selected_name = listBox_foods.Items[selected_index].ToString();
                }
            }

            string group_name = "-1";
            if (listBox_groups.Items.Count > 0)
            {
                int selected_index = listBox_groups.SelectedIndex;
                if (selected_index >= 0)
                {
                    group_name = listBox_groups.Items[selected_index].ToString();
                }
            }

            if (selected_name != "-1" && group_name != "-1")
            {
                string[] xa = group_name.Split('-');
                group_name = xa[1].Trim();

                MBOX MB = new MBOX(selected_name + "  حذف شود؟  ", "حذف...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (MB.DialogResult == DialogResult.OK)
                {
                    bool resut = DBMS_Linq.delete_product(selected_name);
                
                    if ( resut )
                    {
                        init();
                    }
                }
            }
        }

        private void btn_up_group_Click(object sender, EventArgs e)
        {
            if (listBox_groups.Items.Count == 0) return;
            ProductdGroup selected_type = Statics.list_product_groups[listBox_groups.SelectedIndex];
            int index = listBox_groups.SelectedIndex;
            index--;
            if (index != -1)
            {
                ProductdGroup next = Statics.list_product_groups[index];
                ///////////////////////// update database
                //SWAP next and selected
                DBMS_Linq.swap_product_group(selected_type.NamePersian, next.NamePersian);

                init();
                listBox_groups.SelectedIndex = index;

            }
        }

        private void btn_down_group_Click(object sender, EventArgs e)
        {
            if (listBox_groups.Items.Count == 0) return;
            ProductdGroup selected_type = Statics.list_product_groups[listBox_groups.SelectedIndex];
            int index = listBox_groups.SelectedIndex;
            index++;
            if (index != Statics.list_product_groups.Count)
            {
                ProductdGroup next = Statics.list_product_groups[index];

                DBMS_Linq.swap_product_group(selected_type.NamePersian, next.NamePersian);

                init();
                listBox_groups.SelectedIndex = index;
            }
        }

        private void btn_up_product_Click(object sender, EventArgs e)
        {
            int gindex = listBox_groups.SelectedIndex;

            if (listBox_foods.Items.Count == 0) return;
            Productd selected = Statics.list_products[listBox_foods.SelectedIndex];
            int index = listBox_foods.SelectedIndex;
            index--;
            if (index != -1)
            {
                Productd next = Statics.list_products[index];
                ///////////////////////// update database
                //SWAP next and selected
                DBMS_Linq.swap_product(selected.NamePersian, next.NamePersian);

                init();
                listBox_groups.SelectedIndex = gindex;
                listBox_foods.SelectedIndex = index;
               

            }
        }

        private void btn_down_product_Click(object sender, EventArgs e)
        {
            int gindex = listBox_groups.SelectedIndex;

            if (listBox_foods.Items.Count == 0) return;
            Productd selected = Statics.list_products[listBox_foods.SelectedIndex];
            int index = listBox_foods.SelectedIndex;
            index++;
            if (index != Statics.list_products.Count)
            {
                Productd next = Statics.list_products[index];
                ///////////////////////// update database
                //SWAP next and selected
                DBMS_Linq.swap_product(selected.NamePersian, next.NamePersian);

                init();
                listBox_groups.SelectedIndex = gindex;
                listBox_foods.SelectedIndex = index;
                

            }
        }

        private void listBox_foods_DoubleClick(object sender, EventArgs e)
        {
            btn_edit_product_Click(null, null);
        }
    }
}