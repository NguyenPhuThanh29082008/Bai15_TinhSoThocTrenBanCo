﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15_TinhSoThocTrenBanCo
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

        private void button1_Click(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(txtO.Text);
            double tongthoc = 0;

            if (o > 64)
            {
                txtO.Text = "Lỗi! trên bàn thờ chỉ có 0 đến 64 ô thôi!";
            }
            else
            {
                while (o > 64 || o < 0) ;
                for (int i = 0; i < o; i++)
                {
                    tongthoc = tongthoc + Math.Pow(2, i);
                }
            }

            txtTong.Text = tongthoc.ToString();
        }
    }
}
