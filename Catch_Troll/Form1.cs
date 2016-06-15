using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_Troll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zaman; //saniye 
      
        Random rast = new Random();
        int ilk, son;
        int score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            zaman = 0;
            sure.Text = Convert.ToString(zaman);
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 850;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            zaman = zaman + 1;
            sure.Text = Convert.ToString(zaman);
           
        }

        private void target_Click(object sender, EventArgs e)
        {
            score++;
            skor.Text = Convert.ToString(score);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ANA_SAYFA ana = new ANA_SAYFA();
            ana.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ilk = rast.Next(600);
            son = rast.Next(350);
            target.Location = new System.Drawing.Point(ilk, son);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
