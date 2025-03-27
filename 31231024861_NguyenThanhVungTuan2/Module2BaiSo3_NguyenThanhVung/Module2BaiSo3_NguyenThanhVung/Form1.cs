using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo3_NguyenThanhVung
{
    public partial class frmBaiTapHoTen : Form
    {
        public frmBaiTapHoTen()
        {
            InitializeComponent();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            btnHo.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            btnTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = string.Empty;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
