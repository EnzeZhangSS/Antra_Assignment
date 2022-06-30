using System;

namespace CenturiesConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input the number of centuries:");
            long n = Convert.ToInt64(Console.ReadLine());
            long d = (int)Math.Round(n * 100 * 365.242199);
            long s = d * 24 * 60 * 60;
            Console.Write("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds", n, n * 100, d, d * 24, d * 24 * 60, s);
            Console.Write(" = {0}000 milliseconds = {1}000000 microseconds = {2}000000000 nanoseconds",s,s,s);

        }
    }
}
