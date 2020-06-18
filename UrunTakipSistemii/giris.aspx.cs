using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using System.Net;


namespace UrunTakipSistemii
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mesaj = Request.QueryString["msg"];
            Response.Write(mesaj);
        }

       
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string kadi = TextBox1.Text;
            string sifre = TextBox2.Text;
            bool sonuc = DBIslemleri.JsonKullaniciGiris(kadi, sifre);
            if (sonuc == false) Response.Write("<script language=javascript>alert('yanlış kullanıcı ve/veya şifre');</script>");
            else
            {
                Session["giris"] = true;
                Session["kadi"] = kadi;
                Response.Redirect("anasayfa.aspx");
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("kayitol.aspx");
        }
    }
}