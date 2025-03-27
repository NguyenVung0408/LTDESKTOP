using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo8_NguyenThanhVung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            bool isValidA = double.TryParse(txtA.Text, out _);
            bool isValidB = double.TryParse(txtB.Text, out _);

            if (!isValidA)
            {
                errorProvider.SetError(txtA, "Vui lòng nhập số hợp lệ cho A");
            }
            else
            {
                errorProvider.SetError(txtA, string.Empty);
            }

            if (!isValidB)
            {
                errorProvider.SetError(txtB, "Vui lòng nhập số hợp lệ cho B");
            }
            else
            {
                errorProvider.SetError(txtB, string.Empty);
            }


            btnCalculate.Enabled = isValidA && isValidB;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (a == 0)
            {
                if (b == 0)
                {
                    lblResult.Text = "Phương trình có vô số nghiệm.";
                }
                else
                {
                    lblResult.Text = "Phương trình vô nghiệm.";
                }
            }
            else
            {
                double x = -b / a;
                lblResult.Text = $"Phương trình có nghiệm: x = {x:F2}";
            }

            btnCalculate.Enabled = false;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtA.Clear();
            txtB.Clear();
            lblResult.Text = string.Empty;


            txtA.Focus();


            btnClear.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
