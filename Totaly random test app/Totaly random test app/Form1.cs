﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Totaly_random_test_app
{
    public partial class Form1 : Form
    {
        Form2 frm2;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstEverFunction();
            frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }
        public void FirstEverFunction()
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
