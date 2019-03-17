using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BusinessLogicLayer;

namespace UIweb
{
    public partial class login : System.Web.UI.Page
    {
        BLL bll;
        protected void Page_Load(object sender, EventArgs e)
        {
            bll = new BLL();
            if (Page.IsPostBack)
            {

            }

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {

            if(txt_KullaniciAdi.Text!=string.Empty && txt_sifre.Text!=string.Empty)
            {
              int kontrol=  bll.SistemKONTROL(txt_KullaniciAdi.Text, txt_sifre.Text);
                if(kontrol>0)
                {

                    Response.Redirect("Rehber\\RehberIşlemleri.aspx");
                }
                else
                {
                    mesaj.Text = "Kullanıcı Adı ve Şifre Uyumsuz!";
                }
            }
            else
            {
                mesaj.Text = "Kullanıcı Adı ve Şifre Alanları Boş Geçilemez!";
            }

        }
    }
}