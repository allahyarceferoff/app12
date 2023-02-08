using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += BakuTimer_Tick;
            timer.Start();

        }
        Timer timer = new Timer();
        private void BakuTimer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void LondonTime_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }

        private void londonBtn_MouseClick(object sender, MouseEventArgs e)
        {
            timer.Tick += LondonTime_Tick;
            this.BackgroundImage = Properties.Resources.londn;
        }

        private void bakuBtn_Click(object sender, EventArgs e)
        {
            timer.Tick += BakuTimer_Tick;
            this.BackgroundImage = Properties.Resources.Panorama_of_Baku_2022;
        }

        private void timeLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
