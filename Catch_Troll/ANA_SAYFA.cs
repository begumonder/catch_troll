﻿using System;
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
    public partial class ANA_SAYFA : Form
    {
        public ANA_SAYFA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 kolay = new Form1();
            kolay.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zor zor = new zor();
            zor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yeni eklenen buton");
        }
    }
}
