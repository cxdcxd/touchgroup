using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Media;

namespace TouchGroup
{
    public partial class MBOX : DevExpress.XtraEditors.XtraForm
    {
        bool aout = false;
        bool ex = false;
        int mode_string;

        SoundPlayer sp_player_good = new SoundPlayer("media\\error.wav");
        SoundPlayer sp_player_bad = new SoundPlayer("media\\ding.wav");
    

        public MBOX(string text, string title, MessageBoxButtons q, MessageBoxIcon q2)
        {

            InitializeComponent();
            labelControl3.Text = text;
            this.Text = title;
            if (q == MessageBoxButtons.OK)
            {
                btn_cancle.Visible = false;
                btn_ok.Location = new Point(89, 82);
                btn_ok.Size = new Size(236, 33);
            }
            if (q2 == MessageBoxIcon.Error)
            {
                pictureBox1.Image = p_e.Image;
                sp_player_bad.Play();

            }
            if (q2 == MessageBoxIcon.Information)
            {
                pictureBox1.Image = p_i.Image;
                sp_player_good.Play();
            }
            if (q2 == MessageBoxIcon.Question)
            {
                pictureBox1.Image = p_q.Image;
                sp_player_good.Play();
            }
            if (q2 == MessageBoxIcon.Warning)
            {
                pictureBox1.Image = p_w.Image;
                sp_player_bad.Play();
            }

            this.ShowDialog();
        }
        public MBOX(string text)
        {
            InitializeComponent();
            if (Language.LAN_CHECK(text, "english") == false) ex = false;
            labelControl3.Text = text;
            if (ex)
            {
                labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                labelControl3.Font = new System.Drawing.Font("Arial", 8, FontStyle.Regular);
            }
            btn_cancle.Visible = false;
            btn_ok.Location = new Point(89, 82);
            btn_ok.Size = new Size(236, 33);

            pictureBox1.Image = p_i.Image;
            sp_player_good.Play();

            this.ShowDialog();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void MBOX_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ( DialogResult != System.Windows.Forms.DialogResult.OK )
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void MBOX_Load(object sender, EventArgs e)
        {

        }
    }
}