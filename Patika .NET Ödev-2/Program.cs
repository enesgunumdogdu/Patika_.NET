using System;
using System.Collections;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
                *Negatif ve numeric olmayan girişleri engelleyin.
                *Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                *Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */
            List<int> asallar = new List<int>();
            List<int> sayilar = new List<int>();
            sayilar.Clear();
            asallar.Clear();
            Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz\nSadece pozitif sayı girişi yapabilirsiniz.(Harf ve semboller kabul edilmez.)");
            for (int i = 1; i <= 5;)
            {
                int x = 0;
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0)
                    {
                        sayilar.Add(x);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Negatif giriş yaptınız!");
                        i--;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı giriş yaptınız.");
                }
            }

            for (int i = 0; i < sayilar.Count; i++)
            {
                bool isAsal = true;
                for (int j = 2; j <= Math.Sqrt(sayilar[i]); j++)
                {
                    if (sayilar[i] % j == 0)
                    {
                        isAsal = false;
                        break;
                    }
                }
                if (isAsal)
                {
                    asallar.Add(sayilar[i]);
                }
            }

            for (int i=0; i<asallar.Count; i++)
            {
                sayilar.Remove(asallar[i]);
            }

            Console.WriteLine("\n*******\nAsal sayıların listesi aşağıdaki gibidir:");
            foreach(var asal in asallar)
            {
                Console.WriteLine(asal);
            }


            Console.WriteLine("\n*******\nAsal olmayan sayılar ise aşağıdaki gibidir:");
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            

            
            Console.ReadLine();






            /*
             * Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
             * her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
             * (Array sınıfını kullanarak yazınız.)
            */


            /*
             * Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */

        }
    }
}
