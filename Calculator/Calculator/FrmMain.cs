﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(textBox1.Text);
            var y = Convert.ToInt32(textBox2.Text);
            var c = new Calc();
            int r = c.Somar(x, y);
            textBox3.Text = r.ToString();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
