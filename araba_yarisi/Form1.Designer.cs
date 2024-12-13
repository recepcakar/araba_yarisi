namespace araba_yarisi
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.bizimaraba = new System.Windows.Forms.PictureBox();
            this.araba3 = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.btn_oyunubaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_yuksekskor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.bizimaraba);
            this.panel1.Controls.Add(this.araba3);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(21, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // carpma
            // 
            this.carpma.Image = global::araba_yarisi.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(217, 345);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(100, 50);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpma.TabIndex = 2;
            this.carpma.TabStop = false;
            // 
            // bizimaraba
            // 
            this.bizimaraba.Image = global::araba_yarisi.Properties.Resources.araba9;
            this.bizimaraba.Location = new System.Drawing.Point(232, 345);
            this.bizimaraba.Name = "bizimaraba";
            this.bizimaraba.Size = new System.Drawing.Size(69, 134);
            this.bizimaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizimaraba.TabIndex = 1;
            this.bizimaraba.TabStop = false;
            // 
            // araba3
            // 
            this.araba3.Image = global::araba_yarisi.Properties.Resources.araba5;
            this.araba3.Location = new System.Drawing.Point(248, 92);
            this.araba3.Name = "araba3";
            this.araba3.Size = new System.Drawing.Size(69, 134);
            this.araba3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba3.TabIndex = 1;
            this.araba3.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::araba_yarisi.Properties.Resources.araba5;
            this.araba2.Location = new System.Drawing.Point(407, 78);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(69, 134);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 1;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::araba_yarisi.Properties.Resources.araba6;
            this.araba1.Location = new System.Drawing.Point(86, 78);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(69, 134);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 1;
            this.araba1.TabStop = false;
            // 
            // yol
            // 
            this.yol.Image = global::araba_yarisi.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(-1, 0);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(513, 775);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            this.yol.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(214, 543);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 27);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Puan:";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(285, 543);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(22, 27);
            this.lbl_puan.TabIndex = 1;
            this.lbl_puan.Text = "0";
            // 
            // btn_oyunubaslat
            // 
            this.btn_oyunubaslat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_oyunubaslat.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunubaslat.Location = new System.Drawing.Point(147, 585);
            this.btn_oyunubaslat.Name = "btn_oyunubaslat";
            this.btn_oyunubaslat.Size = new System.Drawing.Size(280, 68);
            this.btn_oyunubaslat.TabIndex = 2;
            this.btn_oyunubaslat.Text = "Oyunu baslat";
            this.btn_oyunubaslat.UseVisualStyleBackColor = false;
            this.btn_oyunubaslat.Click += new System.EventHandler(this.btn_oyunubaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yüksek skor:";
            // 
            // lbl_yuksekskor
            // 
            this.lbl_yuksekskor.AutoSize = true;
            this.lbl_yuksekskor.Location = new System.Drawing.Point(12, 567);
            this.lbl_yuksekskor.Name = "lbl_yuksekskor";
            this.lbl_yuksekskor.Size = new System.Drawing.Size(14, 16);
            this.lbl_yuksekskor.TabIndex = 3;
            this.lbl_yuksekskor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 677);
            this.Controls.Add(this.lbl_yuksekskor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_oyunubaslat);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Araba Yarisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox bizimaraba;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Button btn_oyunubaslat;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_yuksekskor;
        private System.Windows.Forms.PictureBox araba3;
    }
}

