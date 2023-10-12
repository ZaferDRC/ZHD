using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDH
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void clock_Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            label_Clock.Text = now.ToString("HH:mm:ss");
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            clock_Timer.Start();
        }
    }
}
