namespace Module2BaiSo10_NguyenThanhVung
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxFileInfo = new System.Windows.Forms.GroupBox();
            this.lblDateAccessed = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFileInfo.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFileInfo
            // 
            this.groupBoxFileInfo.Controls.Add(this.lblDateAccessed);
            this.groupBoxFileInfo.Controls.Add(this.lblDateModified);
            this.groupBoxFileInfo.Controls.Add(this.lblSize);
            this.groupBoxFileInfo.Location = new System.Drawing.Point(36, 51);
            this.groupBoxFileInfo.Name = "groupBoxFileInfo";
            this.groupBoxFileInfo.Size = new System.Drawing.Size(400, 120);
            this.groupBoxFileInfo.TabIndex = 0;
            this.groupBoxFileInfo.TabStop = false;
            this.groupBoxFileInfo.Text = "File Statistics";
            // 
            // lblDateAccessed
            // 
            this.lblDateAccessed.AutoSize = true;
            this.lblDateAccessed.Location = new System.Drawing.Point(6, 85);
            this.lblDateAccessed.Name = "lblDateAccessed";
            this.lblDateAccessed.Size = new System.Drawing.Size(126, 16);
            this.lblDateAccessed.TabIndex = 2;
            this.lblDateAccessed.Text = "Date last accessed:";
            // 
            // lblDateModified
            // 
            this.lblDateModified.AutoSize = true;
            this.lblDateModified.Location = new System.Drawing.Point(6, 55);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(118, 16);
            this.lblDateModified.TabIndex = 1;
            this.lblDateModified.Text = "Date last modified:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(64, 16);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "File Size: ";
            // 
            // panelImage
            // 
            this.panelImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelImage.AutoScroll = true;
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.pbImage);
            this.panelImage.Location = new System.Drawing.Point(36, 177);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(400, 300);
            this.panelImage.TabIndex = 1;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(-28, -42);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(594, 418);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(331, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 33);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdPicture
            // 
            this.ofdPicture.Title = "Select an Image File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click botton to open a picture file:";
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(510, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.groupBoxFileInfo);
            this.Name = "Form1";
            this.Text = "StepbyStep2_8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFileInfo.ResumeLayout(false);
            this.groupBoxFileInfo.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFileInfo;
        private System.Windows.Forms.Label lblDateAccessed;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.Label label1;
    }
}

