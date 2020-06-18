using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace UrunTakipSistemii
{
    class kullanici
    {
        public int ID { get; set; }
        public string kAdi { get; set; }
        public string sifre { get; set; }
    }
    class urun
    {
        public int ID { get; set; }
        public int urunkodu { get; set; }
        public string cayturu { get; set; }
        public string toplayan { get; set; }
        public string ttarihi { get; set; }
        public string deniz { get; set; }
        public string yagis { get; set; }
        public string nem { get; set; }
        public string sicaklik { get; set; }
        public string etarih { get; set; }
        public string eso { get; set; }
        public string muhafaza { get; set; }
        public string ftarih { get; set; }
        public string bozuk { get; set; }
        public string sso { get; set; }
        public string buharlasma { get; set; }
        public string kso { get; set; }
        public string ksure { get; set; }
        public string fso { get; set; }
        public string fhava { get; set; }
        public string rutubet { get; set; }
        public string kuso { get; set; }
        public string kuhava { get; set; }
        public string firin { get; set; }
        public string firinnem { get; set; }
        public string tso { get; set; }
        public string nevi { get; set; }
        public string hso { get; set; }
        public string volume { get; set; }
        public string lso { get; set; }
        public string renk { get; set; }
        public string koku { get; set; }
        public string aroma { get; set; }
        public string onay { get; set; }
        public string gram { get; set; }
        public string cikistarihi { get; set; }
        public string raftarihi { get; set; }
    }
}