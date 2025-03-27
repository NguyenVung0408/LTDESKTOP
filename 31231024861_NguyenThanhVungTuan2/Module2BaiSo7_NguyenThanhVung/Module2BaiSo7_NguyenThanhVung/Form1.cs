using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Module2BaiSo7_NguyenThanhVung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FrmLightSwitcher_Load(object sender, EventArgs e)
        {

            txtName.Text = "Jack";
            lblHienThi.Text = txtName.Text + " Turn Off the Light, please!";




            toolTip1.SetToolTip(picTurnOn, "Click me to Turn OFF the Light!");
            toolTip1.SetToolTip(picTurnOff, "Click me to Turn ON the Light!");


            picTurnOn.Visible = true;
            picTurnOff.Visible = false;
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;
            lblHienThi.Text = txtName.Text + " Turn On the Light, please!";
            lblDesignedBy.Text = txtName.Text;
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            picTurnOff.Visible = false;
            picTurnOn.Visible = true;
            lblHienThi.Text = txtName.Text + " Turn Off the Light, please!";
            lblDesignedBy.Text = txtName.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
