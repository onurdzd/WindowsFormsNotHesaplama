﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ortalamaHesapla_Click(object sender, EventArgs e)
        {
            double toplam = Convert.ToDouble( lbl_birinci_deger.Text )+ Convert.ToDouble(lbl_ikinci_deger.Text);
            lbl_ortalamaSonuc.Text = Convert.ToString(toplam / 2);
        }
    }
}
