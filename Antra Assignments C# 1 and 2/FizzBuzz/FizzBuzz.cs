using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {

            for (int i = 1; i<=100; i++)
            {
                if(i % 3 == 0)
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else
                    {
                        Console.WriteLine("fizz");
                    }
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
