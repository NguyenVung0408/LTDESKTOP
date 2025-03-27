namespace Module2BaiSo6_NguyenThanhVung
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioBlack = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.MistyRose;
            this.txtName.Location = new System.Drawing.Point(184, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(434, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.MistyRose;
            this.txtMessage.Location = new System.Drawing.Point(184, 50);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(434, 22);
            this.txtMessage.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Salmon;
            this.btnDisplay.Location = new System.Drawing.Point(40, 134);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 48);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Location = new System.Drawing.Point(40, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Salmon;
            this.btnExit.Location = new System.Drawing.Point(40, 80);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.MistyRose;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMessage.Location = new System.Drawing.Point(0, 433);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(705, 43);
            this.lblMessage.TabIndex = 5;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisible.Location = new System.Drawing.Point(259, 184);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(145, 20);
            this.chkVisible.TabIndex = 6;
            this.chkVisible.Text = "Message Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRed.ForeColor = System.Drawing.Color.Red;
            this.radioRed.Location = new System.Drawing.Point(48, 26);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(57, 20);
            this.radioRed.TabIndex = 7;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGreen.ForeColor = System.Drawing.Color.Green;
            this.radioGreen.Location = new System.Drawing.Point(48, 62);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(70, 20);
            this.radioGreen.TabIndex = 8;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioGreen_CheckedChanged);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBlue.ForeColor = System.Drawing.Color.Navy;
            this.radioBlue.Location = new System.Drawing.Point(47, 99);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(59, 20);
            this.radioBlue.TabIndex = 9;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
            // 
            // picBig
            // 
            this.picBig.Image = ((System.Drawing.Image)(resources.GetObject("picBig.Image")));
            this.picBig.Location = new System.Drawing.Point(240, 219);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(205, 181);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 10;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // picSmall
            // 
            this.picSmall.Image = ((System.Drawing.Image)(resources.GetObject("picSmall.Image")));
            this.picSmall.Location = new System.Drawing.Point(290, 256);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(115, 108);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmall.TabIndex = 11;
            this.picSmall.TabStop = false;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 100);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Name and Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.radioBlack);
            this.panel2.Controls.Add(this.radioRed);
            this.panel2.Controls.Add(this.radioGreen);
            this.panel2.Controls.Add(this.radioBlue);
            this.panel2.Location = new System.Drawing.Point(33, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 193);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btnDisplay);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Location = new System.Drawing.Point(495, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 193);
            this.panel3.TabIndex = 14;
            // 
            // radioBlack
            // 
            this.radioBlack.AutoSize = true;
            this.radioBlack.BackColor = System.Drawing.Color.MistyRose;
            this.radioBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBlack.Location = new System.Drawing.Point(47, 142);
            this.radioBlack.Name = "radioBlack";
            this.radioBlack.Size = new System.Drawing.Size(67, 20);
            this.radioBlack.TabIndex = 10;
            this.radioBlack.TabStop = true;
            this.radioBlack.Text = "Black";
            this.radioBlack.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(50, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(507, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Action";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "CDROM App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.PictureBox picBig;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioBlack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

