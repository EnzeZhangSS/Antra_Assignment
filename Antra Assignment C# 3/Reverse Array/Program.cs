using System;
using System.Collections.Generic;

namespace Reverse_Array
{
    class Program
    {
        static int [] GenerateNumbers()
        {
            Console.WriteLine("Please enter the length of array:");
            int len = int.Parse(Console.ReadLine());
            List<int> rList = new List<int>();
            Random rnd = new Random();
            for(int i = 0; i < len; i++)
            {
                rList.Add(rnd.Next());
            }

            return rList.ToArray();


        }

        static void Reverse(int [] num)
        {
            int temp;
            for (int i = 0, j = num.Length - 1; i < j; i++,j--)
            {
                temp = num[j];
                num[j] = num[i];
                num[i] = temp;
            }
        }


        static void PrintNumbers(int [] num)
        {
            Console.WriteLine(String.Join(",",num ));
        }

        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Console.WriteLine("Original Array:");
            PrintNumbers(numbers);
            Reverse(numbers);
            Console.WriteLine("Reversed Array:");
            PrintNumbers(numbers);
        }
    }
}
