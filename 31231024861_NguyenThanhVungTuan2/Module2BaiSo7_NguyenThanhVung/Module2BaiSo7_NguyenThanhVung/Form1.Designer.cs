namespace Module2BaiSo7_NguyenThanhVung
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picTurnOff = new System.Windows.Forms.PictureBox();
            this.picTurnOn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDesignedBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHienThi.Location = new System.Drawing.Point(125, 327);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(266, 18);
            this.lblHienThi.TabIndex = 2;
            this.lblHienThi.Text = "Name. Tunrn On/Off the Light, please!";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(150, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(397, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name: ";
            // 
            // picTurnOff
            // 
            this.picTurnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picTurnOff.Image = global::Module2BaiSo7_NguyenThanhVung.Properties.Resources.LightOff;
            this.picTurnOff.Location = new System.Drawing.Point(156, 102);
            this.picTurnOff.Name = "picTurnOff";
            this.picTurnOff.Size = new System.Drawing.Size(200, 200);
            this.picTurnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTurnOff.TabIndex = 1;
            this.picTurnOff.TabStop = false;
            this.picTurnOff.Click += new System.EventHandler(this.picTurnOff_Click);
            // 
            // picTurnOn
            // 
            this.picTurnOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picTurnOn.Image = global::Module2BaiSo7_NguyenThanhVung.Properties.Resources.LightOn;
            this.picTurnOn.Location = new System.Drawing.Point(156, 102);
            this.picTurnOn.Name = "picTurnOn";
            this.picTurnOn.Size = new System.Drawing.Size(200, 200);
            this.picTurnOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTurnOn.TabIndex = 0;
            this.picTurnOn.TabStop = false;
            this.picTurnOn.Click += new System.EventHandler(this.picTurnOn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Designed by: ";
            // 
            // lblDesignedBy
            // 
            this.lblDesignedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDesignedBy.AutoSize = true;
            this.lblDesignedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignedBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDesignedBy.Location = new System.Drawing.Point(192, 359);
            this.lblDesignedBy.Name = "lblDesignedBy";
            this.lblDesignedBy.Size = new System.Drawing.Size(127, 16);
            this.lblDesignedBy.TabIndex = 7;
            this.lblDesignedBy.Text = "------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblDesignedBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.picTurnOff);
            this.Controls.Add(this.picTurnOn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmLight";
            this.Load += new System.EventHandler(this.FrmLightSwitcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTurnOn;
        private System.Windows.Forms.PictureBox picTurnOff;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDesignedBy;
    }
}

