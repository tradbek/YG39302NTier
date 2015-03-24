namespace NTire.UI.WinForms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbxOgrenciler = new System.Windows.Forms.ListBox();
            this.pnlOgrenciBilgi = new System.Windows.Forms.Panel();
            this.txtAd = new Ba.CustomControls.ValidatedTextBox();
            this.txtOgrenciNo = new Ba.CustomControls.ValidatedTextBox();
            this.txtYas = new Ba.CustomControls.ValidatedTextBox();
            this.txtSinif = new Ba.CustomControls.ValidatedTextBox();
            this.pnlOgrenciBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sınıf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ogrenci No";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(81, 216);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbxOgrenciler
            // 
            this.lbxOgrenciler.FormattingEnabled = true;
            this.lbxOgrenciler.Location = new System.Drawing.Point(321, 13);
            this.lbxOgrenciler.Name = "lbxOgrenciler";
            this.lbxOgrenciler.Size = new System.Drawing.Size(150, 290);
            this.lbxOgrenciler.TabIndex = 9;
            // 
            // pnlOgrenciBilgi
            // 
            this.pnlOgrenciBilgi.Controls.Add(this.txtAd);
            this.pnlOgrenciBilgi.Controls.Add(this.txtOgrenciNo);
            this.pnlOgrenciBilgi.Controls.Add(this.txtYas);
            this.pnlOgrenciBilgi.Controls.Add(this.txtSinif);
            this.pnlOgrenciBilgi.Location = new System.Drawing.Point(69, 11);
            this.pnlOgrenciBilgi.Name = "pnlOgrenciBilgi";
            this.pnlOgrenciBilgi.Size = new System.Drawing.Size(132, 199);
            this.pnlOgrenciBilgi.TabIndex = 14;
            // 
            // txtAd
            // 
            this.txtAd.BosGecilemez = true;
            this.txtAd.Location = new System.Drawing.Point(3, 3);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 11;
            this.txtAd.YalnızcaSayi = false;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.BosGecilemez = true;
            this.txtOgrenciNo.Location = new System.Drawing.Point(3, 141);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciNo.TabIndex = 13;
            this.txtOgrenciNo.YalnızcaSayi = false;
            // 
            // txtYas
            // 
            this.txtYas.BosGecilemez = true;
            this.txtYas.Location = new System.Drawing.Point(3, 46);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 10;
            this.txtYas.YalnızcaSayi = true;
            // 
            // txtSinif
            // 
            this.txtSinif.BosGecilemez = true;
            this.txtSinif.Location = new System.Drawing.Point(3, 94);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(100, 20);
            this.txtSinif.TabIndex = 12;
            this.txtSinif.YalnızcaSayi = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 326);
            this.Controls.Add(this.pnlOgrenciBilgi);
            this.Controls.Add(this.lbxOgrenciler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlOgrenciBilgi.ResumeLayout(false);
            this.pnlOgrenciBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbxOgrenciler;
        private Ba.CustomControls.ValidatedTextBox txtYas;
        private Ba.CustomControls.ValidatedTextBox txtAd;
        private Ba.CustomControls.ValidatedTextBox txtSinif;
        private Ba.CustomControls.ValidatedTextBox txtOgrenciNo;
        private System.Windows.Forms.Panel pnlOgrenciBilgi;
    }
}