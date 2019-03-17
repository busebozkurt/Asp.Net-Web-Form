using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace UI
{
    public partial class AnaForm : Form
    {
        Guid gs_deger = Guid.Empty;
        BusinessLogicLayer.BLL bll;
        public AnaForm()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void btn_yeniKayit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_y_isim.Text) && !string.IsNullOrEmpty(txt_y_soyisim.Text) && !string.IsNullOrEmpty(txt_y_telNo.Text))
            {
                //
                txt_y_isim.BackColor = Color.White;
                txt_y_soyisim.BackColor = Color.White;
                txt_y_telNo.BackColor = Color.White;

                int sonuc = bll.yeniKAYIT(txt_y_isim.Text, txt_y_soyisim.Text, txt_y_telNo.Text);
                if (sonuc > 0)
                {
                    MessageBox.Show("Yeni kayıt başarılı bir şekilde eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Yeni kayıt eklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                txt_y_isim.BackColor = Color.White;
                txt_y_soyisim.BackColor = Color.White;
                txt_y_telNo.BackColor = Color.White;
                MessageBox.Show("Tüm Alanlar dolu olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txt_y_isim.Text == string.Empty)
                {
                    txt_y_isim.BackColor = Color.Yellow;
                }
                if (txt_y_soyisim.Text == string.Empty)
                {
                    txt_y_soyisim.BackColor = Color.Yellow;
                }
                if (txt_y_telNo.Text == string.Empty)
                {
                    txt_y_telNo.BackColor = Color.Yellow;
                }
            }
            listeDoldur();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            listeDoldur();
            //List<Rehber> RehberKayitlari= bll.tumKayitlariLISTELE();
        }
        private void listeDoldur()
        {
            List<Rehber> RehberKayitlari = new List<Rehber>();
            RehberKayitlari = bll.tumKayitlariLISTELE();
            if (RehberKayitlari != null && RehberKayitlari.Count > 0)
            {
                lst_rehber.DataSource = RehberKayitlari;
            }
        }

        private void lst_rehber_DoubleClick(object sender, EventArgs e)
        {
            //seçili değeri silme ve güncelleme alanında göstereceğiz
            ListBox lb = (ListBox)sender;
            Rehber secilenKisi = (Rehber)lb.SelectedItem;
            gs_deger = secilenKisi.ID;
            txt_gs_isim.Text = secilenKisi.Isim;
            txt_gs_soyisim.Text = secilenKisi.Soyisim;
            txt_gs_telNo.Text = secilenKisi.TelefonNumarasi;
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_gs_isim.Text) && !string.IsNullOrEmpty(txt_gs_soyisim.Text) && !string.IsNullOrEmpty(txt_gs_telNo.Text) && gs_deger != Guid.Empty)
            {
                int sonuc = bll.kayitGUNCELLE(gs_deger, txt_gs_isim.Text, txt_gs_soyisim.Text, txt_gs_telNo.Text);
                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listeDoldur();
                    txt_gs_isim.Text = string.Empty;
                    txt_gs_soyisim.Text = string.Empty;
                    txt_gs_telNo.Text = string.Empty;
                    gs_deger = Guid.Empty;
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //ilgili alanlar boş geçilemez
                txt_gs_isim.BackColor = Color.White;
                txt_gs_soyisim.BackColor = Color.White;
                txt_gs_telNo.BackColor = Color.White;
                MessageBox.Show("Tüm Alanlar dolu olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txt_gs_isim.Text == string.Empty)
                {
                    txt_gs_isim.BackColor = Color.Yellow;
                }
                if (txt_gs_soyisim.Text == string.Empty)
                {
                    txt_gs_soyisim.BackColor = Color.Yellow;
                }
                if (txt_gs_telNo.Text == string.Empty)
                {
                    txt_gs_telNo.BackColor = Color.Yellow;
                }

            }

        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp1 = MessageBox.Show("Silmek istediğinize emin misiniz? ", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp1 == DialogResult.Yes)
            {
                //veriyi metin 2 alanına aktar
                int sonuc = bll.kayitSIL(gs_deger);
                if (sonuc > 0)
                {
                     MessageBox.Show("Silme işlemi gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listeDoldur();
                    txt_gs_isim.Text = string.Empty;
                    txt_gs_soyisim.Text = string.Empty;
                    txt_gs_telNo.Text = string.Empty;
                    gs_deger = Guid.Empty;

                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
