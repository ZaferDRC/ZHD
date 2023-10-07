using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZHD
{
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
            sifre_Txt.Text = "Şifre";
            sifre_Txt.ForeColor = Color.Gray;
            kullAd_Txt.Text = "Kullanıcı Adı";
            kullAd_Txt.ForeColor = Color.Gray;
        }

        private void Logincs_Load(object sender, EventArgs e)
        {

        }

        private void kullAd_Txt_Enter(object sender, EventArgs e)
        {
            if (kullAd_Txt.Text == "Kullanıcı Adı")
            {
                kullAd_Txt.Text = "";
                kullAd_Txt.ForeColor = Color.Black;
            }
        }

        private void kullAd_Txt_Leave(object sender, EventArgs e)
        {
            if (kullAd_Txt.Text == "")
            {
                kullAd_Txt.Text = "Kullanıcı Adı";
                kullAd_Txt.ForeColor = Color.Gray;
            }
        }

        private void sifre_Txt_Enter(object sender, EventArgs e)
        {
            if (sifre_Txt.Text == "Şifre")
            {
                sifre_Txt.Text = "";
                sifre_Txt.ForeColor = Color.Black;
            }
        }

        private void sifre_Txt_Leave(object sender, EventArgs e)
        {
            if (sifre_Txt.Text == "")
            {
                sifre_Txt.Text = "Şifre";
                sifre_Txt.ForeColor = Color.Gray;
            }

  
        }
    }
}
