﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0609
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("堀 朱莉");
            //timer1.Enabled = False;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + (int.Parse(textBox1.Text));
            label1.Top = label1.Top + (int.Parse(textBox2.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ("↓");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = ("→");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = ("←");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("↑");
        }
    }
}
