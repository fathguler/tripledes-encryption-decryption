﻿namespace TripleDESClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHedefIp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBaglantiKes = new System.Windows.Forms.Button();
            this.btnBaglantiKur = new System.Windows.Forms.Button();
            this.richTxtSifreliMetin = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTxtGelenMetin = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTxtMesajEkrani = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtGelenSifreliMetin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMetinCoz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.txtHedefIp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPortNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnBaglantiKes);
            this.panel1.Controls.Add(this.btnBaglantiKur);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 151);
            this.panel1.TabIndex = 53;
            // 
            // txtHedefIp
            // 
            this.txtHedefIp.Location = new System.Drawing.Point(113, 7);
            this.txtHedefIp.Name = "txtHedefIp";
            this.txtHedefIp.Size = new System.Drawing.Size(150, 20);
            this.txtHedefIp.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hedef İp Adresi :";
            // 
            // txtPortNo
            // 
            this.txtPortNo.Location = new System.Drawing.Point(113, 45);
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Size = new System.Drawing.Size(68, 20);
            this.txtPortNo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(4, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Port Numarası :";
            // 
            // btnBaglantiKes
            // 
            this.btnBaglantiKes.BackColor = System.Drawing.Color.DarkRed;
            this.btnBaglantiKes.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBaglantiKes.Location = new System.Drawing.Point(71, 91);
            this.btnBaglantiKes.Name = "btnBaglantiKes";
            this.btnBaglantiKes.Size = new System.Drawing.Size(89, 40);
            this.btnBaglantiKes.TabIndex = 28;
            this.btnBaglantiKes.Text = "Bağlantıyı Kes";
            this.btnBaglantiKes.UseVisualStyleBackColor = false;
            this.btnBaglantiKes.Click += new System.EventHandler(this.btnBaglantiKes_Click);
            // 
            // btnBaglantiKur
            // 
            this.btnBaglantiKur.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBaglantiKur.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBaglantiKur.Location = new System.Drawing.Point(166, 91);
            this.btnBaglantiKur.Name = "btnBaglantiKur";
            this.btnBaglantiKur.Size = new System.Drawing.Size(97, 40);
            this.btnBaglantiKur.TabIndex = 19;
            this.btnBaglantiKur.Text = "Bağlantı Kur";
            this.btnBaglantiKur.UseVisualStyleBackColor = false;
            this.btnBaglantiKur.Click += new System.EventHandler(this.btnBaglantiKur_Click);
            // 
            // richTxtSifreliMetin
            // 
            this.richTxtSifreliMetin.Location = new System.Drawing.Point(402, 221);
            this.richTxtSifreliMetin.Name = "richTxtSifreliMetin";
            this.richTxtSifreliMetin.Size = new System.Drawing.Size(192, 79);
            this.richTxtSifreliMetin.TabIndex = 52;
            this.richTxtSifreliMetin.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(302, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Şifreli Metin :";
            // 
            // richTxtGelenMetin
            // 
            this.richTxtGelenMetin.Location = new System.Drawing.Point(728, 199);
            this.richTxtGelenMetin.Name = "richTxtGelenMetin";
            this.richTxtGelenMetin.Size = new System.Drawing.Size(209, 102);
            this.richTxtGelenMetin.TabIndex = 50;
            this.richTxtGelenMetin.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(637, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Gelen Metin :";
            // 
            // richTxtMesajEkrani
            // 
            this.richTxtMesajEkrani.Location = new System.Drawing.Point(12, 352);
            this.richTxtMesajEkrani.Name = "richTxtMesajEkrani";
            this.richTxtMesajEkrani.Size = new System.Drawing.Size(923, 129);
            this.richTxtMesajEkrani.TabIndex = 48;
            this.richTxtMesajEkrani.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mesaj Ekranı :";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGonder.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGonder.Location = new System.Drawing.Point(514, 307);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(80, 39);
            this.btnGonder.TabIndex = 46;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtGelenSifreliMetin
            // 
            this.txtGelenSifreliMetin.Location = new System.Drawing.Point(726, 80);
            this.txtGelenSifreliMetin.Multiline = true;
            this.txtGelenSifreliMetin.Name = "txtGelenSifreliMetin";
            this.txtGelenSifreliMetin.Size = new System.Drawing.Size(182, 52);
            this.txtGelenSifreliMetin.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(601, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Gelen Şifreli Metin :";
            // 
            // btnMetinCoz
            // 
            this.btnMetinCoz.Location = new System.Drawing.Point(726, 150);
            this.btnMetinCoz.Name = "btnMetinCoz";
            this.btnMetinCoz.Size = new System.Drawing.Size(75, 29);
            this.btnMetinCoz.TabIndex = 45;
            this.btnMetinCoz.Text = "Metni Çöz";
            this.btnMetinCoz.UseVisualStyleBackColor = true;
            this.btnMetinCoz.Click += new System.EventHandler(this.btnMetinCoz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(319, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Metin :";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(402, 80);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(192, 99);
            this.txtMetin.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(463, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Anahtar :";
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(402, 185);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(75, 30);
            this.btnSifrele.TabIndex = 39;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(546, 27);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(174, 20);
            this.txtAnahtar.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTxtSifreliMetin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTxtGelenMetin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTxtMesajEkrani);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtGelenSifreliMetin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMetinCoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtAnahtar);
            this.Name = "Form1";
            this.Text = "3DES CLIENT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHedefIp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPortNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBaglantiKes;
        private System.Windows.Forms.Button btnBaglantiKur;
        private System.Windows.Forms.RichTextBox richTxtSifreliMetin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTxtGelenMetin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTxtMesajEkrani;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtGelenSifreliMetin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMetinCoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.TextBox txtAnahtar;
    }
}

