using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class KullaniciGiris : Form
    {
        BusinessLogicLayer.BLL bll;
        public KullaniciGiris()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
           int kontrol= bll.SistemKONTROL(txt_kullaniciAdi.Text, txt_sifre.Text);
            if(kontrol>0)
            {
                //giriş başarılı
                AnaForm af = new AnaForm();
                af.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre uyumsuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
