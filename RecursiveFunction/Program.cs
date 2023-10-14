using System;
using System.Runtime.CompilerServices;

namespace Recursive{



class Program{
    static void Main(String[] args){
        //Recursive
        //3^4= 3*3*3*3

        int result =1;
        for(int i=1; i<5; i++){
            result = result *3;
        }
        Console.WriteLine(result);
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3,4));

        //Extension Metotlar
        string ifade = "Abdullah Enes Günümdoğdu";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if(sonuc)
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi = {9,3,5,15,2,1,6};
        dizi.SortArray();
        dizi.EkranaYazdir();

    }
}




    public class Islemler{
        public int  Expo(int sayi, int us){
            if(us<2){
                return sayi;
            }
            return Expo(sayi,us-1)*sayi;
        }
    }

    public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        } 

        public static String RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }       

        public static String MakeUpperCase(this string param){
            return param.ToUpper(); 
        } 

        public static String MakeLowerCase(this string param){
            return param.ToLower(); 
        }     

        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param){
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }
    }
}