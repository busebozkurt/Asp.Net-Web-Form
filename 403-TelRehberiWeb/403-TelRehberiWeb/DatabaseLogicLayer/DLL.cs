using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;

namespace DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection con;//c# ile sql arasındaki bağlantıyı sağlar
        SqlCommand cmd;//connection sayesinde açılan connection ile sql sorgularını yapmamızı sağlar
        SqlDataReader reader;//sql den gelen dataları c# tarafında kullanabilmemizi sağlar
        int ReturnValues;//etkilenen satır sayısını tutabilmek için tanımladık

        public DLL()
        {
            con = new SqlConnection("data source=BOZKURT\\SQLEXPRESS;initial catalog=TelefonRehberi;trusted_connection=true;");
        }
        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
                con.Close();
        }

        public int SistemKontrol(Kullanici K)
        {
            try
            {
                cmd = new SqlCommand("select count(*) from Kullanici where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", con);
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = K.KullaniciAdi;
                cmd.Parameters.AddWithValue("@Sifre", K.Sifre);
                BaglantiAyarla();
                ReturnValues = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public int yeniKayit(Rehber r)
        {
            try
            {
                cmd = new SqlCommand("insert into Rehber (ID, Isim,Soyisim,TelefonNumarasi) values (@ID, @Isim,@Soyisim,@TelefonNumarasi)",con);
                cmd.Parameters.AddWithValue("@ID", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@Isim", r.Isim);
                cmd.Parameters.AddWithValue("@Soyisim", r.Soyisim);
                cmd.Parameters.AddWithValue("@TelefonNumarasi", r.TelefonNumarasi);
                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }
        public SqlDataReader tumKayitListele()
        {
            cmd = new SqlCommand("select *from Rehber order by Isim ", con);
            BaglantiAyarla();
           return cmd.ExecuteReader();
        }

        public int kayitGuncelle(Rehber r)
        {
            try
            {
                cmd = new SqlCommand("update  Rehber set Isim=@Isim,Soyisim=@Soyisim,TelefonNumarasi=@TelefonNumarasi where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", r.ID);
                cmd.Parameters.AddWithValue("@Isim", r.Isim);
                cmd.Parameters.AddWithValue("@Soyisim", r.Soyisim);
                cmd.Parameters.AddWithValue("@TelefonNumarasi", r.TelefonNumarasi);
                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;      

        }

        public int kayitSil(Guid gs_deger)
        {
            try
            {
                cmd = new SqlCommand("Delete from Rehber where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", gs_deger);
                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;

        }

    }
}
