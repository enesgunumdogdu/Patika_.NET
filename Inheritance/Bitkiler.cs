using System;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public void TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla �o�al�r.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public void TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla �o�al�r.");
        }
    }
}