using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisaKenar = 3;
            dikdortgen.uzunKenar = 4;
            Console.WriteLine("Class alan hesabı = ->" + dikdortgen.AlanHesapla());

            Dikdortgen_struct dikdortgenStruct = new Dikdortgen_struct();

            //Dikdortgen_struct dikdortgenStruct = new Dikdortgen_struct(3,4);
            //Dikdortgen_Struct dikdortgen_Struct;
            dikdortgenStruct.kisaKenar = 5;
            dikdortgenStruct.uzunKenar = 6;
            Console.WriteLine("Struct alan hesaabı = -> " + dikdortgenStruct.AlanHesapla());

            Console.ReadLine();
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen() {
            kisaKenar = 4;
            uzunKenar=8;
        }

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdortgen_struct
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen_struct()
        {
            kisaKenar = 5;
            uzunKenar = 6;
        }

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}