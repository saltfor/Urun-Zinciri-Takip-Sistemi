using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace UrunTakipSistemii
{
    public class DBIslemleri
    {
        public static bool JsonKullaniciGiris(string kadi, string sifre)
        {

            string JsonOkunanData = File.ReadAllText(@"C:\Users\Mahmut ARSLAN\Desktop\kullanici.json");

            List<kullanici> okunanJson = JsonConvert.DeserializeObject<List<kullanici>>(JsonOkunanData);

            foreach (var item in okunanJson)
            {
                if (item.kAdi == kadi && item.sifre == sifre)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool JsonUrunVarmi(int urunkodu)
        {
            string JsonOkunanData = File.ReadAllText(@"C:\Users\Mahmut ARSLAN\Desktop\urunler.json");

            List<urun> okunanJson = JsonConvert.DeserializeObject<List<urun>>(JsonOkunanData);
            bool bayrak = false;
            foreach (var item in okunanJson)
            {
                if (item.urunkodu==urunkodu)
                {
                    bayrak=true;
                }
            }
            return bayrak;
        }
        
        
        public static void JsonKisiEkle(string kadi, string sifre)
        {

            List<kullanici> klist = new List<kullanici>();
            string JsonOkunanData = File.ReadAllText(@"C:\Users\Mahmut ARSLAN\Desktop\kullanici.json");

            List<kullanici> okunanJson = JsonConvert.DeserializeObject<List<kullanici>>(JsonOkunanData);

            foreach (var item in okunanJson)
            {
                klist.Add(item);
            }
            kullanici k1 = new kullanici();
            Random rnd = new Random();
            k1.ID = rnd.Next(1000, 9999);
            k1.kAdi = kadi;
            k1.sifre = sifre;
            klist.Add(k1);
            
            string JsonKullaniciler = JsonConvert.SerializeObject(klist);
            File.WriteAllText(@"C:\Users\Mahmut ARSLAN\Desktop\kullanici.json", JsonKullaniciler);

        }
        
        

        
        public static void JsonUrunEkle(int urunkodu,string cayturu, string toplayan, string ttarihi, string deniz, string yagis, 
            string nem, string sicaklik, string etarih, string eso, string muhafaza, string ftarih, string bozuk, string sso,
            string buharlasma, string kso, string ksure, string fso, string fhava, string rutubet, string kuso, string kuhava,
            string firin, string firinnem, string tso, string nevi, string hso, string volume, string lso, string renk, string koku,
            string aroma, string onay, string gram, string cikistarihi, string raftarihi)
        {

            List<urun> klist = new List<urun>();
            string JsonOkunanData = File.ReadAllText(@"C:\Users\Mahmut ARSLAN\Desktop\urunler.json");

            List<urun> okunanJson = JsonConvert.DeserializeObject<List<urun>>(JsonOkunanData);

            foreach (var item in okunanJson)
            {
                klist.Add(item);
            }
            urun u = new urun();
            Random rnd = new Random();
            u.ID = rnd.Next(1000, 9999);
            u.urunkodu = urunkodu;
            u.cayturu = cayturu;
            u.toplayan=toplayan;
            u.ttarihi = ttarihi;
            u.deniz = deniz;
            u.yagis = yagis;
            u.nem = nem;
            u.sicaklik = sicaklik;
            u.etarih = etarih;
            u.eso = eso;
            u.muhafaza = muhafaza;
            u.ftarih = ftarih;
            u.bozuk = bozuk;
            u.sso = sso;
            u.buharlasma = buharlasma;
            u.kso = kso;
            u.ksure = ksure;
            u.fso = fso;
            u.fhava = fhava;
            u.rutubet = rutubet;
            u.kuso = kuso;
            u.kuhava = kuhava;
            u.firin = firin;
            u.firinnem = firinnem;
            u.tso = tso;
            u.nevi = nevi;
            u.hso = hso;
            u.volume = volume;
            u.lso = lso;
            u.renk = renk;
            u.koku = koku;
            u.aroma = aroma;
            u.onay = onay;
            u.gram = gram;
            u.cikistarihi = cikistarihi;
            u.raftarihi = raftarihi;
            klist.Add(u);

            string JsonKullaniciler = JsonConvert.SerializeObject(klist);
            File.WriteAllText(@"C:\Users\Mahmut ARSLAN\Desktop\urunler.json", JsonKullaniciler);
        }


        public static void JsonUrunGuncelle(int urunkodu, string cayturu, string toplayan, string ttarihi, string deniz, string yagis,
            string nem, string sicaklik, string etarih, string eso, string muhafaza, string ftarih, string bozuk, string sso,
            string buharlasma, string kso, string ksure, string fso, string fhava, string rutubet, string kuso, string kuhava,
            string firin, string firinnem, string tso, string nevi, string hso, string volume, string lso, string renk, string koku,
            string aroma, string onay, string gram, string cikistarihi, string raftarihi)
        {

            List<urun> klist = new List<urun>();
            string JsonOkunanData = File.ReadAllText(@"C:\Users\Mahmut ARSLAN\Desktop\urunler.json");

            List<urun> okunanJson = JsonConvert.DeserializeObject<List<urun>>(JsonOkunanData);

            foreach (var item in okunanJson)
            {
                if (item.urunkodu == urunkodu)
                {
                    item.cayturu = cayturu;
                    item.toplayan = toplayan;
                    item.ttarihi = ttarihi;
                    item.deniz = deniz;
                    item.yagis = yagis;
                    item.nem = nem;
                    item.sicaklik = sicaklik;
                    item.etarih = etarih;
                    item.eso = eso;
                    item.muhafaza = muhafaza;
                    item.ftarih = ftarih;
                    item.bozuk = bozuk;
                    item.sso = sso;
                    item.buharlasma = buharlasma;
                    item.kso = kso;
                    item.ksure = ksure;
                    item.fso = fso;
                    item.fhava = fhava;
                    item.rutubet = rutubet;
                    item.kuso = kuso;
                    item.kuhava = kuhava;
                    item.firin = firin;
                    item.firinnem = firinnem;
                    item.tso = tso;
                    item.nevi = nevi;
                    item.hso = hso;
                    item.volume = volume;
                    item.lso = lso;
                    item.renk = renk;
                    item.koku = koku;
                    item.aroma = aroma;
                    item.onay = onay;
                    item.gram = gram;
                    item.cikistarihi = cikistarihi;
                    item.raftarihi = raftarihi;
                }
                klist.Add(item);
            }

            string JsonKullaniciler = JsonConvert.SerializeObject(klist);
            File.WriteAllText(@"C:\Users\Mahmut ARSLAN\Desktop\urunler.json", JsonKullaniciler);
        }
    }
}