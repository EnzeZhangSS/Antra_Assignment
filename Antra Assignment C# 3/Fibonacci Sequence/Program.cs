using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static int Fibonacci(int i)
        {
            if (i == 1 || i == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(i - 2) + Fibonacci(i - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 numbers of Fibonacci Sequence are: ");
            for(int i = 1; i <= 10; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
        }
    }
}
