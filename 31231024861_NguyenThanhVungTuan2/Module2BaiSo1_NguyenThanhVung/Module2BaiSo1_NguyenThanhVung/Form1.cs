﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo1_NguyenThanhVung
{
    public partial class frmSimpleEvent : Form
    {
        public frmSimpleEvent()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was cliked.");
        }

        private void Bai1Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Welcome to C# 2010 programing!");
        }

        private void Bai1Form_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked");
        }
    }
}
