using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı = " + Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Enes","Günümdoğdu","IT");
            Console.WriteLine("Çalışan sayısı = " + Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu = " + Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu = " + Islemler.Cikar(400, 50));
            Console.ReadLine();

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get =>  calisanSayisi; set => calisanSayisi = value;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Soyisim = soyisim;
            this.Isim = isim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}