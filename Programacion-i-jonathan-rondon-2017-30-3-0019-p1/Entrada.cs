﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_i_jonathan_rondon_2017_30_3_0019_p1
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 _ver = new Form1();
            _ver.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 _ver = new Form2();
            _ver.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnentrada3_Click(object sender, EventArgs e)
        {
            Form3 _ver = new Form3();
            _ver.Show();
        }
    }
}
