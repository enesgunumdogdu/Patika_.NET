using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci.Isim = "Enes";
            ogrenci.Soyisim = "Günümdoğdu";
            ogrenci.OgrNo = 29351;
            ogrenci.Sinif = 9;
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.sinifAtlat();
            ogrenci.sinifAtlat();
            ogrenci.sinifDusur();
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.sinifDusur();
            ogrenci1.sinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrNo { get => ogrNo; set => ogrNo = value; }
        public int Sinif { 
            get => sinif;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrNo, int sinif){
            Isim = isim;
            Soyisim = soyisim;
            Sinif = sinif;
            OgrNo = ogrNo;
        }

        public Ogrenci()
        {}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı = " + this.Isim);
            Console.WriteLine("Öğrenci Soyadı = " + this.Soyisim);
            Console.WriteLine("Öğrenci Sınıfı = " + this.Sinif);
            Console.WriteLine("Öğrenci Numarası = " + this.OgrNo);
        }

        public void sinifAtlat()
        {
            this.Sinif += 1;
        }

        public void sinifDusur()
        {
            this.Sinif -= 1;
        }
    }


}