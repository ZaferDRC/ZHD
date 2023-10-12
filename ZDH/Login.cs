using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ZDH
{
    public partial class Login : Form
    {
        LoginPageOpr loginPageOpr = new LoginPageOpr();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            userName_Txt.TabIndex = 1;
            pass_Txt.TabIndex = 2;
            login_Btn.TabIndex = 3;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);

            this.ActiveControl = null;
            userName_Txt.Text = "Kullanıcı Adı";
            pass_Txt.Text = "Şifre";
            
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Btn.PerformClick();
            }

            if (e.KeyCode == Keys.Tab)
            {
                SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void login_Btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string User_Name = userName_Txt.Text;
                string Pass = pass_Txt.Text;

                if (User_Name == "123" && Pass == "123")
                {
                    Home Home = new Home();
                    Home.Show();
                    this.Hide();
                }

                else if (User_Name == "Kullanıcı Adı" || Pass == "Şifre" || string.IsNullOrEmpty(User_Name) || string.IsNullOrEmpty(Pass) || string.IsNullOrWhiteSpace(User_Name) ||string.IsNullOrWhiteSpace(Pass))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış !!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userName_Txt_Enter(object sender, EventArgs e)
        {

            loginPageOpr.userName_Txt_Enter(userName_Txt);
        }

        private void userName_Txt_Leave(object sender, EventArgs e)
        {

            loginPageOpr.userName_Txt_Leave(userName_Txt);
        }

        private void pass_Txt_Enter(object sender, EventArgs e)
        {

            loginPageOpr.pass_Txt_Enter(pass_Txt);
        }

        private void pass_Txt_Leave(object sender, EventArgs e)
        {
            loginPageOpr.pass_Txt_Leave(pass_Txt);
        }

    }
}
