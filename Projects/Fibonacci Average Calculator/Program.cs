using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth;
            Console.WriteLine("Please enter a depth for Fibonacci series:");
            depth = Convert.ToInt32(Console.ReadLine());

            int[] fibonacciNumbers = CalculateFibonacci(depth);
            double average = CalculateAverage(fibonacciNumbers);

            Console.WriteLine("Fibonacci series:");
            foreach (int number in fibonacciNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nAverage of Fibonacci series: " + average);
            Console.ReadLine();
        }

        static int[] CalculateFibonacci(int depth)
        {
            int[] fibonacciNumbers = new int[depth];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            for (int i = 2; i < depth; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            return fibonacciNumbers;
        }

        static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }
    }
}