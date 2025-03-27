using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Module2BaiSo6_NguyenThanhVung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt con trỏ tại ô Name
            txtName.Focus();

            // Hiển thị hình lớn, ẩn hình nhỏ
            picBig.Visible = true;
            picSmall.Visible = false;

            // Thiết lập tooltip
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picBig, "Click Me");
            toolTip.SetToolTip(picSmall, "Click Me");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Gán nội dung vào lblMessage
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong ô Name và Message
            txtName.Clear();
            txtMessage.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đóng chương trình
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn phím Enter hoặc Esc
            if (e.KeyCode == Keys.Enter)
            {
                btnDisplay.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRed.Checked)
                lblMessage.ForeColor = Color.Red;
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGreen.Checked)
                lblMessage.ForeColor = Color.Green;
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked)
                lblMessage.ForeColor = Color.Blue;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            // Ẩn/hiện lblMessage
            lblMessage.Visible = chkVisible.Checked;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            // Ẩn hình lớn, hiện hình nhỏ
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            // Ẩn hình nhỏ, hiện hình lớn
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
