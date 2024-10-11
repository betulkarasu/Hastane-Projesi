namespace Hastane_Projesi
{
    partial class Form_HastaKayit
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
            this.txt_sifre1 = new System.Windows.Forms.TextBox();
            this.masked_tc1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_cins = new System.Windows.Forms.ComboBox();
            this.masked_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sifre1
            // 
            this.txt_sifre1.Location = new System.Drawing.Point(145, 160);
            this.txt_sifre1.Name = "txt_sifre1";
            this.txt_sifre1.Size = new System.Drawing.Size(131, 31);
            this.txt_sifre1.TabIndex = 5;
            // 
            // masked_tc1
            // 
            this.masked_tc1.Location = new System.Drawing.Point(145, 86);
            this.masked_tc1.Mask = "00000000000";
            this.masked_tc1.Name = "masked_tc1";
            this.masked_tc1.Size = new System.Drawing.Size(131, 31);
            this.masked_tc1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "SoyAd:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinsiyet:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combo_cins
            // 
            this.combo_cins.FormattingEnabled = true;
            this.combo_cins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.combo_cins.Location = new System.Drawing.Point(145, 200);
            this.combo_cins.Name = "combo_cins";
            this.combo_cins.Size = new System.Drawing.Size(131, 31);
            this.combo_cins.TabIndex = 6;
            // 
            // masked_tel
            // 
            this.masked_tel.Location = new System.Drawing.Point(145, 123);
            this.masked_tel.Mask = "(999) 000-0000";
            this.masked_tel.Name = "masked_tel";
            this.masked_tel.Size = new System.Drawing.Size(131, 31);
            this.masked_tel.TabIndex = 4;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(145, 49);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(131, 31);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(145, 12);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(131, 31);
            this.txt_ad.TabIndex = 1;
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_kayitol.Location = new System.Drawing.Point(145, 251);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(127, 39);
            this.btn_kayitol.TabIndex = 20;
            this.btn_kayitol.Text = "Kayıt Ol";
            this.btn_kayitol.UseVisualStyleBackColor = false;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // Form_HastaKayit
            // 
            this.AcceptButton = this.btn_kayitol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(305, 303);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.masked_tel);
            this.Controls.Add(this.combo_cins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sifre1);
            this.Controls.Add(this.masked_tc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_HastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.Form_HastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sifre1;
        private System.Windows.Forms.MaskedTextBox masked_tc1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_cins;
        private System.Windows.Forms.MaskedTextBox masked_tel;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Button btn_kayitol;
    }
}