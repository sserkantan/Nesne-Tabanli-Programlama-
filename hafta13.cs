using System;

namespace ConsoleApp9
{
   class oyuncu
    {
        public string ad;
        public string takim;
        public byte formaNo;
        public void bilgiyaz()
        {
            Console.WriteLine("oyuncu adı: {0} ", ad);
            Console.WriteLine("oyuncu takım: {0}", takim);
            Console.WriteLine("oyuncu forma no: {0}", formaNo);
        }
        public void takimDegis(string yeniTakim)
        {
            takim = yeniTakim;
        }
        public string bilgiVer()
        {
            return string.Format("{0} {1} {2}", formaNo, ad, takim);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            oyuncu o1 = new oyuncu();
            o1.ad = "serkan";
            o1.formaNo = 55;
            o1.takim = "samsun";
            o1.bilgiyaz();
            o1.takimDegis("amasya");
            Console.WriteLine(o1.bilgiVer());
            
            oyuncu o2 = new oyuncu();
            o2.ad = "ali";
            o2.takim = "amasya";
            o2.formaNo = 10;
            o2.bilgiyaz();
        }
    }
}




----------------------------------------------------------------------------------------------

using System;

namespace ConsoleApp9
{
   class oyuncu
    {
        //Yapıcı(constructer) metod
        public oyuncu()
        {
            ad = "serkan";
            takim = "samsun";
            formaNo = 55;
        }
        public oyuncu(string oyuncu_ad,string oyuncu_takim,byte oyuncu_formaNo)
        {
            ad = oyuncu_ad;
            takim = oyuncu_takim;
            formaNo = oyuncu_formaNo;
        }


        public string ad;
        public string takim;
        public byte formaNo;
        public void bilgiyaz()
        {
            Console.WriteLine("oyuncu adı: {0} ", ad);
            Console.WriteLine("oyuncu takım: {0}", takim);
            Console.WriteLine("oyuncu forma no: {0}", formaNo);
        }
        public void takimDegis(string yeniTakim)
        {
            takim = yeniTakim;
        }
        public string bilgiVer()
        {
            return string.Format("{0} {1} {2}", formaNo, ad, takim);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            oyuncu o1 = new oyuncu();
            o1.bilgiyaz();
            oyuncu o2 = new oyuncu("Ali", "amasya", 10);
            o2.bilgiyaz();
        }
    }
}

------------------------------------------------------------------------------------------------------

using System;

namespace ConsoleApp9
{
  class uyekontrol
    {
        private string kullanici_ad;
        private string sifre;
        public string kulanici
        {
            get { return kullanici_ad; }
            set { if (value.Length > 0) kullanici_ad = value; }
        }
        public string kullanici_sifre
        {
            get { return sifre; }
            set { if (value.Length > 0) sifre = value; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            uyekontrol uye = new uyekontrol();
            uye.kulanici = "serkan";
            Console.WriteLine(uye.kulanici);
        }
    }
}

------------------------------------------------------------------------------------------------------

using System;

namespace ConsoleApp9
{
    class ogrenci
    {
        private int _vize;
        private int _final;
        private string ad;
        private string soyad;
        private int numara;
        public int vize
        {
            get { return _vize; }
            set { if ((value >= 0) && (value <= 100)) _vize = value; }
        }
        public int final
        {
            get { return _final; }
            set { if ((value >= 0) && (value <= 100)) _final = value; }
        }
        public void ogrenciBilgi(int no, string isim,string soyisim)
        {
            numara = no;
            ad = isim;
            soyad = soyisim;
        }
        public void ogrenciBilgiVer()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}",numara,ad,soyad,_vize,_final);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr1 = new ogrenci();
            ogr1.vize = 50;
            ogr1.final = 80;
            ogr1.ogrenciBilgi(1234, "Ali", "Can");
        ogr1.ogrenciBilgiVer();
    }}                                                                                                                                                          
}