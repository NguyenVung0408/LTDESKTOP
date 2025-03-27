namespace Module2BaiSo9_NguyenThanhVung
{
    partial class StepByStep2_7
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
            this.lnkWinForms = new System.Windows.Forms.LinkLabel();
            this.lnkPrograms = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkWinForms
            // 
            this.lnkWinForms.AutoSize = true;
            this.lnkWinForms.Location = new System.Drawing.Point(73, 62);
            this.lnkWinForms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkWinForms.Name = "lnkWinForms";
            this.lnkWinForms.Size = new System.Drawing.Size(253, 16);
            this.lnkWinForms.TabIndex = 0;
            this.lnkWinForms.TabStop = true;
            this.lnkWinForms.Text = "Visit Windows Forms Community Website";
            this.lnkWinForms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWinForms_LinkClicked);
            // 
            // lnkPrograms
            // 
            this.lnkPrograms.AutoSize = true;
            this.lnkPrograms.Location = new System.Drawing.Point(95, 144);
            this.lnkPrograms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkPrograms.Name = "lnkPrograms";
            this.lnkPrograms.Size = new System.Drawing.Size(205, 16);
            this.lnkPrograms.TabIndex = 1;
            this.lnkPrograms.TabStop = true;
            this.lnkPrograms.Text = "Launch Calculator | Open C: Drive";
            this.lnkPrograms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrograms_LinkClicked);
            // 
            // StepByStep2_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 286);
            this.Controls.Add(this.lnkPrograms);
            this.Controls.Add(this.lnkWinForms);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StepByStep2_7";
            this.Text = "LinkLabel Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkWinForms;
        private System.Windows.Forms.LinkLabel lnkPrograms;
    }
}

