using System;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon g�sterir.");
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
            Console.WriteLine("S�r�ngenler s�r�nerek hareket ederler.");
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
            Console.WriteLine("Ku�lar u�ar");
        }
    }

    public class Ordek : Hayvanlar
    {
        public void Yuzmek()
        {
            Console.WriteLine("�rdekler y�zer");
        }
    }
}