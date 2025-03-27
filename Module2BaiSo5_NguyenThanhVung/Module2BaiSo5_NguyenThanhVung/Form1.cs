using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo5_NguyenThanhVung
{
    public partial class Bai5Form : Form
    {
        public Bai5Form()
        {
            InitializeComponent();
        }

        private void Bai6Form_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblLapTrinh.ForeColor = Color.Red;
                    txtNhapTen.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblLapTrinh.ForeColor = Color.Green;
                    txtNhapTen.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblLapTrinh.ForeColor = Color.Blue;
                    txtNhapTen.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lblLapTrinh.ForeColor = Color.Black;
                    txtNhapTen.ForeColor = Color.Black;
                    break;
            }
        }

        private void chkFontStyle_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, style);
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, style);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
