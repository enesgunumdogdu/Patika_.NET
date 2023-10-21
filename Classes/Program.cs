using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Public
             * Private
             * Internal
             * Protected
             */

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Enes";
            calisan1.Soyad = "Günümdoğdu";
            calisan1.No = 0213;
            calisan1.Departman = "IT";
            Calisan calisan2 = new Calisan { Ad = "Emre", Soyad = "Başpınar", No = 25441, Departman = "Front-end" };
            Calisan calisan3 = new Calisan ( "Emir", "Günümdoğdu", 83712, "Muhasebe" );
            Calisan calisan4 = new Calisan ("Mehmet", "Kısakol");
            calisan1.CalisanBilgileri();
            Console.WriteLine("\n");
            calisan2.CalisanBilgileri();
            Console.WriteLine("\n");
            calisan3.CalisanBilgileri();
            Console.WriteLine("\n");
            calisan4.CalisanBilgileri();





            Console.ReadLine();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        //Constructor
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı = " +Ad);
            Console.WriteLine("Çalışan Soyadı = " +Soyad);
            Console.WriteLine("Çalışan Numarası = " + No);
            Console.WriteLine("Çalışan Departmanı = " + Departman);
        }
    }
}