﻿namespace StokTakip
{
    partial class FrmGiris
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGiris = new Button();
            txtAd = new TextBox();
            txtYetki = new TextBox();
            txtMail = new TextBox();
            txtŞifre = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(372, 42);
            label2.TabIndex = 1;
            label2.Text = "Giriş Formu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(64, 31);
            label3.TabIndex = 2;
            label3.Text = "Ad";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 4;
            label5.Text = "Mail";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 5;
            label6.Text = "Şifre";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(141, 333);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(100, 93);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(248, 27);
            txtAd.TabIndex = 7;
            // 
            // txtYetki
            // 
            txtYetki.Location = new Point(100, 186);
            txtYetki.Name = "txtYetki";
            txtYetki.Size = new Size(248, 27);
            txtYetki.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(100, 234);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(248, 27);
            txtMail.TabIndex = 10;
            // 
            // txtŞifre
            // 
            txtŞifre.Location = new Point(100, 282);
            txtŞifre.Name = "txtŞifre";
            txtŞifre.Size = new Size(248, 27);
            txtŞifre.TabIndex = 11;
            // 
            // label7
            // 
            label7.Location = new Point(14, 188);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 12;
            label7.Text = "Yetki";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(14, 145);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 13;
            label4.Text = "Soyad";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(100, 145);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(248, 27);
            txtSoyad.TabIndex = 14;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 450);
            Controls.Add(txtSoyad);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtŞifre);
            Controls.Add(txtMail);
            Controls.Add(txtYetki);
            Controls.Add(txtAd);
            Controls.Add(btnGiris);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGiris";
            Text = "FrmGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnGiris;
        private TextBox txtAd;
        private TextBox txtYetki;
        private TextBox txtMail;
        private TextBox txtŞifre;
        private Label label7;
        private Label label4;
        private TextBox txtSoyad;
    }
}