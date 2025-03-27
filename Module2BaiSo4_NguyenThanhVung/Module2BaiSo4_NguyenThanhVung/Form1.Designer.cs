namespace Module2BaiSo4_NguyenThanhVung
{
    partial class ChangeMoneyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DoiTienlable = new System.Windows.Forms.Label();
            this.TienQuiDoiLabel = new System.Windows.Forms.Label();
            this.KetQuaLabel = new System.Windows.Forms.Label();
            this.TienQuiDoiTextbox = new System.Windows.Forms.TextBox();
            this.KetQuaTextbox = new System.Windows.Forms.TextBox();
            this.VNDtoUSDButon = new System.Windows.Forms.Button();
            this.VNDtoEURButton = new System.Windows.Forms.Button();
            this.USDtoVNDButton = new System.Windows.Forms.Button();
            this.EURtoVNDButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TyGiaVNDtoUSDTextbox = new System.Windows.Forms.TextBox();
            this.TyGiaEURtoVNDTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoiTienlable
            // 
            this.DoiTienlable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DoiTienlable.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoiTienlable.ForeColor = System.Drawing.Color.DarkOrange;
            this.DoiTienlable.Location = new System.Drawing.Point(214, 21);
            this.DoiTienlable.Name = "DoiTienlable";
            this.DoiTienlable.Size = new System.Drawing.Size(153, 44);
            this.DoiTienlable.TabIndex = 0;
            this.DoiTienlable.Text = "Đổi Tiền";
            // 
            // TienQuiDoiLabel
            // 
            this.TienQuiDoiLabel.AutoSize = true;
            this.TienQuiDoiLabel.Location = new System.Drawing.Point(83, 101);
            this.TienQuiDoiLabel.Name = "TienQuiDoiLabel";
            this.TienQuiDoiLabel.Size = new System.Drawing.Size(83, 16);
            this.TienQuiDoiLabel.TabIndex = 1;
            this.TienQuiDoiLabel.Text = "Tiền qui đổi: ";
            // 
            // KetQuaLabel
            // 
            this.KetQuaLabel.AutoSize = true;
            this.KetQuaLabel.Location = new System.Drawing.Point(108, 226);
            this.KetQuaLabel.Name = "KetQuaLabel";
            this.KetQuaLabel.Size = new System.Drawing.Size(58, 16);
            this.KetQuaLabel.TabIndex = 2;
            this.KetQuaLabel.Text = "Kết quả: ";
            // 
            // TienQuiDoiTextbox
            // 
            this.TienQuiDoiTextbox.Location = new System.Drawing.Point(204, 101);
            this.TienQuiDoiTextbox.Name = "TienQuiDoiTextbox";
            this.TienQuiDoiTextbox.Size = new System.Drawing.Size(163, 22);
            this.TienQuiDoiTextbox.TabIndex = 3;
            // 
            // KetQuaTextbox
            // 
            this.KetQuaTextbox.Location = new System.Drawing.Point(204, 226);
            this.KetQuaTextbox.Name = "KetQuaTextbox";
            this.KetQuaTextbox.ReadOnly = true;
            this.KetQuaTextbox.Size = new System.Drawing.Size(163, 22);
            this.KetQuaTextbox.TabIndex = 4;
            // 
            // VNDtoUSDButon
            // 
            this.VNDtoUSDButon.Location = new System.Drawing.Point(35, 162);
            this.VNDtoUSDButon.Name = "VNDtoUSDButon";
            this.VNDtoUSDButon.Size = new System.Drawing.Size(95, 23);
            this.VNDtoUSDButon.TabIndex = 5;
            this.VNDtoUSDButon.Text = "VNDtoUSD";
            this.VNDtoUSDButon.UseVisualStyleBackColor = true;
            this.VNDtoUSDButon.Click += new System.EventHandler(this.VNDtoUSDButon_Click);
            // 
            // VNDtoEURButton
            // 
            this.VNDtoEURButton.Location = new System.Drawing.Point(168, 162);
            this.VNDtoEURButton.Name = "VNDtoEURButton";
            this.VNDtoEURButton.Size = new System.Drawing.Size(95, 23);
            this.VNDtoEURButton.TabIndex = 6;
            this.VNDtoEURButton.Text = "VNDtoEUR";
            this.VNDtoEURButton.UseVisualStyleBackColor = true;
            this.VNDtoEURButton.Click += new System.EventHandler(this.VNDtoEURButton_Click);
            // 
            // USDtoVNDButton
            // 
            this.USDtoVNDButton.Location = new System.Drawing.Point(303, 162);
            this.USDtoVNDButton.Name = "USDtoVNDButton";
            this.USDtoVNDButton.Size = new System.Drawing.Size(95, 23);
            this.USDtoVNDButton.TabIndex = 7;
            this.USDtoVNDButton.Text = "USDtoVND";
            this.USDtoVNDButton.UseVisualStyleBackColor = true;
            this.USDtoVNDButton.Click += new System.EventHandler(this.USDtoVNDButton_Click);
            // 
            // EURtoVNDButton
            // 
            this.EURtoVNDButton.Location = new System.Drawing.Point(437, 162);
            this.EURtoVNDButton.Name = "EURtoVNDButton";
            this.EURtoVNDButton.Size = new System.Drawing.Size(95, 23);
            this.EURtoVNDButton.TabIndex = 8;
            this.EURtoVNDButton.Text = "EURtoVND";
            this.EURtoVNDButton.UseVisualStyleBackColor = true;
            this.EURtoVNDButton.Click += new System.EventHandler(this.EURtoVNDButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TyGiaVNDtoUSDTextbox
            // 
            this.TyGiaVNDtoUSDTextbox.Location = new System.Drawing.Point(63, 278);
            this.TyGiaVNDtoUSDTextbox.Name = "TyGiaVNDtoUSDTextbox";
            this.TyGiaVNDtoUSDTextbox.Size = new System.Drawing.Size(130, 22);
            this.TyGiaVNDtoUSDTextbox.TabIndex = 9;
            this.TyGiaVNDtoUSDTextbox.Text = "VNDtoUSD: 17861";
            this.TyGiaVNDtoUSDTextbox.TextChanged += new System.EventHandler(this.TyGiaVNDtoUSDTextbox_TextChanged);
            // 
            // TyGiaEURtoVNDTextbox
            // 
            this.TyGiaEURtoVNDTextbox.Location = new System.Drawing.Point(328, 278);
            this.TyGiaEURtoVNDTextbox.Name = "TyGiaEURtoVNDTextbox";
            this.TyGiaEURtoVNDTextbox.Size = new System.Drawing.Size(132, 22);
            this.TyGiaEURtoVNDTextbox.TabIndex = 10;
            this.TyGiaEURtoVNDTextbox.Text = "VNDtoEUR: 27043";
            this.TyGiaEURtoVNDTextbox.TextChanged += new System.EventHandler(this.TyGiaEURtoVNDTextbox_TextChanged);
            // 
            // ChangeMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 373);
            this.Controls.Add(this.TyGiaEURtoVNDTextbox);
            this.Controls.Add(this.TyGiaVNDtoUSDTextbox);
            this.Controls.Add(this.EURtoVNDButton);
            this.Controls.Add(this.USDtoVNDButton);
            this.Controls.Add(this.VNDtoEURButton);
            this.Controls.Add(this.VNDtoUSDButon);
            this.Controls.Add(this.KetQuaTextbox);
            this.Controls.Add(this.TienQuiDoiTextbox);
            this.Controls.Add(this.KetQuaLabel);
            this.Controls.Add(this.TienQuiDoiLabel);
            this.Controls.Add(this.DoiTienlable);
            this.Name = "ChangeMoneyForm";
            this.Text = "Change Money";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeMoneyForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DoiTienlable;
        private System.Windows.Forms.Label TienQuiDoiLabel;
        private System.Windows.Forms.Label KetQuaLabel;
        private System.Windows.Forms.TextBox TienQuiDoiTextbox;
        private System.Windows.Forms.TextBox KetQuaTextbox;
        private System.Windows.Forms.Button VNDtoUSDButon;
        private System.Windows.Forms.Button VNDtoEURButton;
        private System.Windows.Forms.Button USDtoVNDButton;
        private System.Windows.Forms.Button EURtoVNDButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TyGiaEURtoVNDTextbox;
        private System.Windows.Forms.TextBox TyGiaVNDtoUSDTextbox;
    }
}

