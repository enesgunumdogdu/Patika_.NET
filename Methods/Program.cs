using System;

namespace Methods
{
    class Program
    {
        static void Main (string[] args)
        {
            /*
            erişim_belirteci  geri_dönüş_tipi  metot_adi(parametreListesi/arguman){
             //komutlar
            }
            */
            int a =2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            
            int sonuc2 = ornek.ArttirveTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));

            /////////////////////////
            //out parametreler
            /////////////////////////
            string sayi = "999";

            bool sonucOut = int.TryParse(sayi, out int outSayi);
            if(sonucOut){
                Console.WriteLine("Başarılı " + outSayi);
            }
            else{
                Console.WriteLine("Başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(41,23, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot aşırı yükleme
            int ifade = 1234;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Enes","Günümdoğdu");

        }
        static int Topla(int deger1,int deger2){
            return(deger1+deger2);
        }
    }

    class Metotlar{
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1,ref int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }

        public void Topla(int a, int b, out int toplam){
    toplam = a+b;
        }

        public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2){
            Console.WriteLine(veri1 + veri2);
        }
    }
}   