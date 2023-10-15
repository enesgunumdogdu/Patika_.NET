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


            


            /*
             * Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
             * her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
             * (Array sınıfını kullanarak yazınız.)
            */

            
            int[] sayilar = new int[20];
            Console.WriteLine("Lütfen 20 adet sayı giriniz.\n->Negatif sayı girişi yapabilirsiniz.");
            int enkucuk = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 20; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = x;
            }
            Array.Sort(sayilar);
            float buyukort = (sayilar[19] + sayilar[18] + sayilar[17])/3;
            float kucukort = (sayilar[0] + sayilar[1] + sayilar[2]) / 3;
            Console.WriteLine("Girilen en küçük sayı = " + sayilar[0] + ", ve en büyük sayı = " + sayilar[19]);
            Console.WriteLine("\nGirilen En büyük üç sayı sırasıyla-> " + sayilar[19] + "," + sayilar[18] + "," + sayilar[17]);
            Console.WriteLine("\nGirilen en küçük üç sayı sırasıyla-> " + sayilar[0] + "," + sayilar[1] + "," + sayilar[2]);
            Console.WriteLine("\n En küçük üç sayının ortalaması = -> " + kucukort);
            Console.WriteLine("\n En büyük üç sayının ortalaması = -> " + buyukort);
            Console.WriteLine("\n Ortalama toplamları  = -> "+ (buyukort + kucukort));
            


            /*
             * Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */
            //String[] cumle = new string[];
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string cumle = Console.ReadLine().ToUpper();
            char[] sesliHarfler = { 'A', 'E', 'U', 'Ü', 'O', 'Ö', 'I', 'İ' };
            char[] sesliHarfDizi = new char[cumle.Length];
            int index = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                char karakter = cumle[i];
                if (Array.Exists(sesliHarfler, harf => harf == karakter))
                {
                    sesliHarfDizi[index] = karakter;
                    index++;
                }
            }

            Array.Resize(ref sesliHarfDizi, index);
            Array.Sort(sesliHarfDizi);

            Console.WriteLine("Cümledeki sesli harfler aşağıdaki gibidir:");
            foreach (char harf in sesliHarfDizi)
            {
                Console.Write(harf + " ");
            }

            Console.ReadLine();
        }
    }
}
