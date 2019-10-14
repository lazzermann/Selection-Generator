﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selectionChart
{
    public partial class EquableFillForm : Form
    {
        public bool isNumbs = false;
        public EquableFillForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isNumbs = true;
                Convert.ToInt32(textBox1.Text);
                Convert.ToDouble(textBox2.Text);
                Convert.ToDouble(textBox3.Text);
            }
            catch (FormatException ex)
            {
                textBox1.Text += ex.Message.ToString();
                isNumbs = false;
            }
            Close();
        }
    }
}
