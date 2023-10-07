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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MasaIslemlerics yeniForm = new MasaIslemlerics();

            yeniForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MasaIslemlerics yeniForm = new MasaIslemlerics();

            yeniForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MasaIslemlerics yeniForm = new MasaIslemlerics();

            yeniForm.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MasaIslemlerics yeniForm = new MasaIslemlerics();

            yeniForm.Show();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbl_Saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
