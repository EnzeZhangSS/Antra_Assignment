using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the string to be reversed: ");
            string str = Console.ReadLine();

            // First Way
            char[] chr = str.ToCharArray();
            Array.Reverse(chr);
            Console.WriteLine("First method:");
            foreach(char c in chr)
            {
                Console.Write($"{c}");
            }

            //Second Way
            Console.WriteLine("\nSecond method:");
            for(int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
