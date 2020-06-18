using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrunTakipSistemii
{
    public partial class kayitol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kuladi = TextBox1.Text;
            string sifre = TextBox2.Text;
            string sifretekrar = TextBox3.Text;

            if (kuladi =="" || sifre=="" || sifretekrar=="")
            {
                Response.Write("<script language=javascript>alert('bos bırakmayiniz');</script>");
                
            }
            else if (sifre == "" || sifre != sifretekrar)
            {
                Response.Write("<script language=javascript>alert('sifreler uyusmuyor ');</script>");
            }
            else
            {
                DBIslemleri.JsonKisiEkle(kuladi, sifre);
                TextBox1.Text = "";
                Response.Write("<script language=javascript>alert('BASARIYLA KAYIT YAPTINIZ ::))))');</script>");
                Response.Redirect("giris.aspx");
            }
            
        }
    }
}