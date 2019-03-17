using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer;
using Entities;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DLL dll;
        public BLL()
        {
            dll = new DLL();
        }
        public int SistemKONTROL(string KullaniciAdi_,string Sifre_)
        {
            if (!string.IsNullOrEmpty(KullaniciAdi_) && !string.IsNullOrEmpty(Sifre_))
            {
                //veritabanından kullanıcıyı kontrol et
                Kullanici K = new Kullanici()
                {
                    KullaniciAdi = KullaniciAdi_,
                    Sifre = Sifre_
                };

                return dll.SistemKontrol(K);
            }
            else
                return -1;    
        }

        public int yeniKAYIT(string Isim_, string Soyisim_, string TelefonNumarasi_)
        {
            if (!string.IsNullOrEmpty(Isim_) && !string.IsNullOrEmpty(Soyisim_) && !string.IsNullOrEmpty(TelefonNumarasi_))
            {
                //veri tabanına gönder
                Rehber R = new Rehber()
                {
                    Isim = Isim_,
                    Soyisim=Soyisim_,
                    TelefonNumarasi=TelefonNumarasi_
                };
                return dll.yeniKayit(R);
            }
            else
                return -1;
        }

        public List<Rehber> tumKayitlariLISTELE()
        {
            List<Rehber> KayitListesi = new List<Rehber>();
            SqlDataReader reader= dll.tumKayitListele();
            try
            {
                while (reader.Read())
                {
                    KayitListesi.Add(new Rehber()
                    {
                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        TelefonNumarasi = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return KayitListesi;
        }

        public int kayitGUNCELLE(Guid gs_deger, string text1, string text2, string text3)
        {
            if (!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3) && gs_deger != Guid.Empty)
            {
                Rehber r = new Rehber()
                {
                    ID = gs_deger,
                    Isim = text1,
                    Soyisim = text2,
                    TelefonNumarasi = text3

                };
               return dll.kayitGuncelle(r);

            }
            return -1;
             
        }

        public int kayitSIL(Guid gs_deger)
        {
            if (gs_deger != Guid.Empty)
            {
                return dll.kayitSil(gs_deger);
            }
            else
                return -1;
        }
    }
}
