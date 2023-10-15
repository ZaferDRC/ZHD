using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDH
{
    internal class LoginPageOpr : Form
    {
        // Login sayfasındaki textboxlar'ın, placeholder ve passwordchar işlemleri için oluşturulmuş sınıf. 

        public void pass_Txt_Enter(TextBox txt)
        {
            if (txt.Text == "Şifre")
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
                txt.PasswordChar = '*';
            }
        }

        public void pass_Txt_Leave(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text) || string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "Şifre";
                txt.ForeColor = Color.Gray;
                txt.PasswordChar = '\0';
            }
        }

        public void userName_Txt_Enter(TextBox txt)
        {
            if (txt.Text == "Kullanıcı Adı")
            {
                txt.Text = "";
            }
        }

        public void userName_Txt_Leave(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text) || string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "Kullanıcı Adı";
                txt.ForeColor = Color.Gray;
            }

        }
    }
}
