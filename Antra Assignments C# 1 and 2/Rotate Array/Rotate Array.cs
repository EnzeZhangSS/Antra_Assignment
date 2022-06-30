using System;
using System.Linq;
using System.Collections.Generic;

namespace Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array seperated by space : ");
            List<string> MyList = Console.ReadLine().Split(' ').ToList();
            List<int> NumList = MyList.Select(int.Parse).ToList();
            int n = NumList.Count;
            Console.WriteLine("Please enter how many times you want to rotate:");
            int k = int.Parse(Console.ReadLine());
            List<int> SumList = new List<int>();
            for (int m = 0; m < n; m++)
            {
                SumList.Add(0);
            }
            for(int r = 1; r <= k; r++)
            {
                for(int i = 0; i < n; i++)
                {
                    SumList[i] += NumList[(n+(i-r))%n];
                }
            }
            
            Console.WriteLine("The sum array will be:");
            foreach(int i in SumList)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
