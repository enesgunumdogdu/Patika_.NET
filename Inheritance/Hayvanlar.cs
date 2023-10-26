using System;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon gösterir.");
        }
    }

    public class Surungenler:Hayvanlar
    {
        public void Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Surunmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public void Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuþlar uçar");
        }
    }

    public class Ordek : Hayvanlar
    {
        public void Yuzmek()
        {
            Console.WriteLine("Ördekler yüzer");
        }
    }
}