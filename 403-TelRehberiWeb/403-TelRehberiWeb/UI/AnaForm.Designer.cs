namespace UI
{
    partial class AnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_rehber = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_yeniKayit = new System.Windows.Forms.Button();
            this.txt_y_telNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_y_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_y_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.txt_gs_telNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gs_soyisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gs_isim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_rehber);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Listesi";
            // 
            // lst_rehber
            // 
            this.lst_rehber.FormattingEnabled = true;
            this.lst_rehber.Location = new System.Drawing.Point(6, 22);
            this.lst_rehber.Name = "lst_rehber";
            this.lst_rehber.Size = new System.Drawing.Size(188, 303);
            this.lst_rehber.TabIndex = 0;
            this.lst_rehber.DoubleClick += new System.EventHandler(this.lst_rehber_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_yeniKayit);
            this.groupBox2.Controls.Add(this.txt_y_telNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_y_soyisim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_y_isim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(243, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kayıt";
            // 
            // btn_yeniKayit
            // 
            this.btn_yeniKayit.Location = new System.Drawing.Point(26, 124);
            this.btn_yeniKayit.Name = "btn_yeniKayit";
            this.btn_yeniKayit.Size = new System.Drawing.Size(234, 23);
            this.btn_yeniKayit.TabIndex = 4;
            this.btn_yeniKayit.Text = "Yeni Kayıt";
            this.btn_yeniKayit.UseVisualStyleBackColor = true;
            this.btn_yeniKayit.Click += new System.EventHandler(this.btn_yeniKayit_Click);
            // 
            // txt_y_telNo
            // 
            this.txt_y_telNo.Location = new System.Drawing.Point(124, 98);
            this.txt_y_telNo.Name = "txt_y_telNo";
            this.txt_y_telNo.Size = new System.Drawing.Size(136, 20);
            this.txt_y_telNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon Numarası*";
            // 
            // txt_y_soyisim
            // 
            this.txt_y_soyisim.Location = new System.Drawing.Point(124, 56);
            this.txt_y_soyisim.Name = "txt_y_soyisim";
            this.txt_y_soyisim.Size = new System.Drawing.Size(136, 20);
            this.txt_y_soyisim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim*";
            // 
            // txt_y_isim
            // 
            this.txt_y_isim.Location = new System.Drawing.Point(124, 19);
            this.txt_y_isim.Name = "txt_y_isim";
            this.txt_y_isim.Size = new System.Drawing.Size(136, 20);
            this.txt_y_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kayitSil);
            this.groupBox3.Controls.Add(this.btn_kayitGuncelle);
            this.groupBox3.Controls.Add(this.txt_gs_telNo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_gs_soyisim);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_gs_isim);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(244, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 161);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıt Güncelle/Sil";
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.Location = new System.Drawing.Point(148, 124);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(112, 23);
            this.btn_kayitSil.TabIndex = 9;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(26, 124);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(112, 23);
            this.btn_kayitGuncelle.TabIndex = 8;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // txt_gs_telNo
            // 
            this.txt_gs_telNo.Location = new System.Drawing.Point(124, 98);
            this.txt_gs_telNo.Name = "txt_gs_telNo";
            this.txt_gs_telNo.Size = new System.Drawing.Size(136, 20);
            this.txt_gs_telNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon Numarası";
            // 
            // txt_gs_soyisim
            // 
            this.txt_gs_soyisim.Location = new System.Drawing.Point(124, 56);
            this.txt_gs_soyisim.Name = "txt_gs_soyisim";
            this.txt_gs_soyisim.Size = new System.Drawing.Size(136, 20);
            this.txt_gs_soyisim.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyisim";
            // 
            // txt_gs_isim
            // 
            this.txt_gs_isim.Location = new System.Drawing.Point(124, 19);
            this.txt_gs_isim.Name = "txt_gs_isim";
            this.txt_gs_isim.Size = new System.Drawing.Size(136, 20);
            this.txt_gs_isim.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "İsim";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 398);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_rehber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_yeniKayit;
        private System.Windows.Forms.TextBox txt_y_telNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_y_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_y_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.TextBox txt_gs_telNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gs_soyisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gs_isim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_kayitSil;
    }
}