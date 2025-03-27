using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo9_NguyenThanhVung
{
    public partial class StepByStep2_7 : Form
    {
        public StepByStep2_7()
        {
            InitializeComponent();


            lnkPrograms.Links.Add(0, "Launch Calculator".Length, "calc.exe");


            lnkPrograms.Links.Add(lnkPrograms.Text.IndexOf("Open C: Drive"), "Open C: Drive".Length, "c:\\");


            lnkPrograms.AutoSize = true;
        }

        private void lnkWinForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lnkWinForms.LinkVisited = true;


            Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.windowsforms.net",
                UseShellExecute = true
            });
        }

        private void lnkPrograms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start(e.Link.LinkData.ToString());
        }
    }
}
