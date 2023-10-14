using System;
using System.Collections.Generic;

namespace collectionGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(5);
            sayiListesi.Add(12);
            sayiListesi.Add(5);
            sayiListesi.Add(21);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Kırmızı");

            // Count
            Console.WriteLine("Sayı Listesi Eleman Sayısı: " + sayiListesi.Count);
            Console.WriteLine("Renk Listesi Eleman Sayısı: " + renkListesi.Count);

            // Foreach ve List foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Remove
            renkListesi.Remove("Mavi");
            sayiListesi.Remove(21);
            sayiListesi.RemoveAt(0);

            // Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("Başarılı");
            }

            // Eleman ile index arama
            int turuncuIndex = renkListesi.IndexOf("Turuncu");
            if (turuncuIndex != -1)
            {
                Console.WriteLine("Turuncu rengi indeksi: " + turuncuIndex);
            }
            else
            {
                Console.WriteLine("Turuncu renk bulunamadı.");
            }

            // Diziyi listeye çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // Listeyi temizleme
            hayvanlarListesi.Clear();

            // List içerisinde class oluşturmak
            List<Kullanici> kullaniciListesi = new List<Kullanici>();
            Kullanici kullanici1 = new Kullanici
            {
                Isim = "Ayşe",
                Soyisim = "Yılmaz",
                Yas = 26
            };
            Kullanici kullanici2 = new Kullanici
            {
                Isim = "Özcan",
                Soyisim = "Çalışkan",
                Yas = 31
            };

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            kullaniciListesi.Add(new Kullanici
            {
                Isim = "Deniz",
                Soyisim = "Başarır",
                Yas = 24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı: " + kullanici.Isim + "\nKullanıcı soyadı: " + kullanici.Soyisim + "\nKullanıcı yaşı: " + kullanici.Yas + "\n");
            }

            Console.ReadLine();
        }
    }

    public class Kullanici
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
    }
}
