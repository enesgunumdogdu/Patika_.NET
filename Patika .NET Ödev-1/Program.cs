using System;

namespace examples{

class Program{
    static void Main(string[] args){
        
        Console.WriteLine("Soru -1 \n ****************");
        ///Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        
        Console.WriteLine("Lütfen pozitif bir n sayısı giriniz:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen " + n + " adet daha sayı pozitif sayı giriniz:");
        int[] dizi = new int[n];
        for (int i = 0; i < n; i++)
        {
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i =0; i<n; i++){
        Console.WriteLine("**********");
            if((dizi[i]%2 ==0)){
                Console.WriteLine(dizi[i]);
            }
        }


        Console.WriteLine("Soru -2 \n ****************");
        ///Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        Console.WriteLine("Lütfen sırasıyla pozitif n,m değerleri giriniz:");
        int N = Convert.ToInt32(Console.ReadLine());
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen " + N + " adet daha pozitif sayı giriniz:");
        int[] dizi2= new int[N];

        for (int i = 0; i <N; i++)
        {
            dizi2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("**********");
        for(int i=0; i<N; i++){
            if(dizi2[i] == M || dizi2[i]%M ==0){
                Console.WriteLine(dizi2[i]);
            }
        }


        Console.WriteLine("Soru -3 \n ****************");
        ///Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        ///

        Console.WriteLine("Lütfen pozitif bir n sayısı giriniz:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen " + n + " adet kelime giriniz:");
        string[] kelimeler = new string[n];

        for(int i =0; i<n; i++){
            kelimeler[i] = Console.ReadLine();
        }
        Console.WriteLine("\nGirdiğiniz kelimeler sondan başa doğru aşağıdaki şekildedir:");
        for(int i =n-1; i>=0; i--){
            Console.WriteLine(kelimeler[i]);
        }

        Console.WriteLine("Soru -4 \n ****************");
        ///Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        ///

        Console.WriteLine("Lütfen bir cümle giriniz:");
        string cumle = Console.ReadLine();
        string[] kelimeler2 = cumle.Split(" ");
        int kelimeSayisi = kelimeler2.Length;
        int harfSayisi = cumle.Length - (kelimeSayisi -1);

        Console.WriteLine("Girdiğiniz cümledeki kelime sayısı =  " + kelimeSayisi + "\n Girdiğiniz cümledeki harf sayısı= " + harfSayisi); 


    }
}
}