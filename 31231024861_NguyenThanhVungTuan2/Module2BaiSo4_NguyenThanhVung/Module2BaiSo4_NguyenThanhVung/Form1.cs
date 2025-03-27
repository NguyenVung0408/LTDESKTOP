using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo4_NguyenThanhVung
{
    public partial class ChangeMoneyForm : Form
    {
        private decimal rateVNDtoUSD = 17861;
        private decimal rateVNDtoEUR = 27043;
        public ChangeMoneyForm()
        {
            InitializeComponent();
        }
        private bool ValidateInput(out decimal amount)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(TienQuiDoiTextbox.Text) || !decimal.TryParse(TienQuiDoiTextbox.Text, out amount))
            {
                errorProvider1.SetError(TienQuiDoiTextbox, "Vui lòng nhập số tiền hợp lệ!");
                amount = 0;
                return false;
            }
            return true;
        }

        private void VNDtoUSDButon_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out decimal amount))
            {
                decimal result = Math.Round(amount / rateVNDtoUSD, 2);
                KetQuaTextbox.Text = $"{result} USD";
            }
        }

        private void USDtoVNDButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out decimal amount))
            {
                decimal result = Math.Round(amount / rateVNDtoUSD, 2);
                KetQuaTextbox.Text = $"{result} USD";
            }
        }

        private void VNDtoEURButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out decimal amount))
            {
                decimal result = Math.Round(amount / rateVNDtoEUR, 2);
                KetQuaTextbox.Text = $"{result} EUR";
            }
        }

        private void EURtoVNDButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out decimal amount))
            {
                decimal result = Math.Round(amount * rateVNDtoEUR, 2);
                KetQuaTextbox.Text = $"{result} VND";
            }
        }



        private void ChangeMoneyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TyGiaVNDtoUSDTextbox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TyGiaVNDtoUSDTextbox.Text, out decimal newRate))
            {
                rateVNDtoUSD = newRate;
            }
        }

        private void TyGiaEURtoVNDTextbox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TyGiaEURtoVNDTextbox.Text, out decimal newRate))
            {
                rateVNDtoEUR = newRate;
            }
        }
    }
}
