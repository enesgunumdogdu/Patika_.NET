using System;

namespace DrawATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle();
        }

        static void DrawTriangle()
        {
            Console.Write("Lütfen çizilecek dik üçgenin yüksekliğini girin: \n\n");
            int yukseklik = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}