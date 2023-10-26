using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.Beslenme();
            tohumluBitki.Bosaltim();
            tohumluBitki.Solunum();
            tohumluBitki.FotosentezYapmak();
            tohumluBitki.TohumlaCogalma();
            tohumluBitki.Beslenme();

            Kuslar marti = new Kuslar();
            marti.Beslenme();
            marti.Bosaltim();
           

            Ordek ordek = new Ordek();
            ordek.Solunum();
            ordek.Beslenme();
            ordek.Bosaltim();
            ordek.SuruHalindeHareket();
            ordek.Yuzmek();







            Console.ReadLine();
        }
    }
}