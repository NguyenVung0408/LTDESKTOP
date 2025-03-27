using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Module2BaiSo10_NguyenThanhVung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Set filters for graphics files
            ofdPicture.Filter = "Image Files (BMP, GIF, JPEG, etc.)|" +
                                "*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|" +
                                "BMP Files (*.bmp)|*.bmp|" +
                                "GIF Files (*.gif)|*.gif|" +
                                "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                "PNG Files (*.png)|*.png|" +
                                "TIF Files (*.tif;*.tiff)|*.tif;*.tiff|" +
                                "All Files (*.*)|*.*";

            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                // Get file information
                FileInfo file = new FileInfo(ofdPicture.FileName);
                lblSize.Text = $"File Size: {file.Length} Bytes";
                lblDateModified.Text = $"Date last modified: {file.LastWriteTime.ToLongDateString()}";
                lblDateAccessed.Text = $"Date last accessed: {file.LastAccessTime.ToLongDateString()}";

                // Load the file contents in the PictureBox
                pbImage.Image = new Bitmap(ofdPicture.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
