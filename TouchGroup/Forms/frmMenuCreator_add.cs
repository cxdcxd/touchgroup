using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchGroup
{
    public partial class frmMenuCreator_add : XtraForm
    {
        string selected_group;
        void init()
        {
            lbl_info_max.Text = "Max ( " + Statics.image_size_limitation.ToString() + " KB )";
            List<ProductdGroup> groups = DBMS_Linq.get_porduct_groups();
            for ( int i = 0 ; i < groups.Count ; i++)
            {
                cmb_category.Properties.Items.Add(groups[i].NamePersian);
            }

            cmb_category.SelectedItem = selected_group;
        }
        public frmMenuCreator_add(string group_name)
        {
            selected_group = group_name;
            InitializeComponent();
        }

        private void frmProductMenu_add_Load(object sender, EventArgs e)
        {
           
            init();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string food_calorie = txt_calorie.Text;
            int food_calorie_int = 0;
            string food_name_persian = txt_name_persian.Text;
            string food_name_english = txt_name_english.Text;
            string food_price = txt_price.Text;
            int food_price_int = 0;
            if (cmb_category.SelectedItem == null)
            {
                //error please fill all the blanks
                MBOX mbox = new MBOX("لطفا گروه بندی را انتخاب نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string food_type = cmb_category.SelectedItem.ToString();
            string food_info_farsi = memo_info_persian.Text;
            string food_info_english = memo_info_english.Text;
            Image food_image = pic_product.Image;
            bool food_enable = check_enable.Checked;

            try
            {
                if (food_price != "" && food_name_english != "" && food_name_persian != "" && food_info_farsi != "" && food_info_english != "")
                {

                    if (Language.LAN_CHECK(food_name_english, "english") == false) {MBOX MB = new MBOX("در بخش انگليسي از کاراکتر فارسي نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }
                    if (Language.LAN_CHECK(food_name_persian, "farsi") == false) { MBOX MB = new MBOX("در بخش فارسی از کاراکتر انگلیسی نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning);  return; }
                    if (Language.LAN_CHECK(food_info_english, "english") == false) { MBOX MB = new MBOX("در بخش انگليسي از کاراکتر فارسي نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                    if (Language.LAN_CHECK(food_info_farsi, "farsi") == false) { MBOX MB = new MBOX("در بخش فارسی از کاراکتر انگلیسی نمي توانيد استفاده نماييد", "ارسال...", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    if (int.TryParse(food_price, out food_price_int) == false) throw new Exception("قیمت نادرست وارد شده است");
                    if (int.TryParse(food_calorie, out food_calorie_int) == false) throw new Exception("کالری نادرست وارد شده است");
                    if (food_image == null) throw new Exception("انتخاب تصویر کالا الزامی است");

                    for (int i = 0; i < Statics.list_products.Count ; i++)
                    {
                        Productd p = Statics.list_products[i];
                        if (p.NamePersian == food_name_persian)
                        {
                            throw new Exception("نام کالای فارسی مورد نظر قبلا برای کالای دیگری انتخاب شده است");
                        }
                        if (p.NameEnglish == food_name_english)
                        {
                            throw new Exception("نام کالای انگلیسی مورد نظر قبلا برای کالای دیگری انتخاب شده است");
                        }
                    }

                    Productd ToEdit_item = new Productd();

                    ToEdit_item.Image = Timage.imageToByteArray(food_image);
                    ToEdit_item.NameEnglish = food_name_english;
                    ToEdit_item.NamePersian = food_name_persian;
                    ToEdit_item.InfoPersian = food_info_farsi;
                    ToEdit_item.InfoEnglish = food_info_english;
                    ToEdit_item.Price = food_price_int;
                    ToEdit_item.Enable = food_enable;
                    ToEdit_item.Category = food_type;
                    ToEdit_item.Calories = food_calorie_int;

                    bool resut = DBMS_Linq.insert_product(ToEdit_item);
                    /////////////////////////////////////////////////////////
                    //INSERT TO MENU

                    MBOX MBB;

                    if ( resut )
                       MBB = new MBOX("محصول جديد با موفقيت ثبت شد", "سیستم...", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    else
                       MBB = new MBOX("خطا در ثبت غذای جدید", "سیستم...", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    
                }
                else
                {
                    throw new Exception("اطلاعات ورودی کامل نمی باشد");
                }

            }
            catch (Exception ee)
            {

               MBOX MB = new MBOX(ee.Message);  return;
            }

            DialogResult = DialogResult.OK;
          
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string INIT_DIR = @"C:\";

            if (File.Exists(Statics.last_opend_directory) == true)
            {
                INIT_DIR = Statics.last_opend_directory;
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = INIT_DIR;
            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Statics.last_opend_directory = dlg.FileName;

                try
                {
                    FileInfo fi = new FileInfo(dlg.FileName);

                    if (fi.Length >= Statics.image_size_limitation * 1000)
                    {
                        MBOX MB = new MBOX(" حجم تصوير انتخاب شده باید زیر " + Statics.image_size_limitation + " کیلو بایت باشد ", "ذخيره عکس...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BitMiracle.LibJpeg.JpegImage ji = new BitMiracle.LibJpeg.JpegImage(dlg.FileName);
                    MemoryStream MS2 = new MemoryStream();
                    ji.WriteJpeg(MS2);
                    Image X = Image.FromStream(MS2);
                    byte[] array = MS2.ToArray();
                    pic_product.Image = X;
                    lbl_info.Text = (float)array.Length / 1000 + " KB";

                }
                catch (System.Exception ex)
                {
                    ex = new System.Exception();

                    MBOX MB = new MBOX("مشکل در بارگذاری تصویر", "خطا...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
    }
}
