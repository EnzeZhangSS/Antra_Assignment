using System;
using System.Collections.Generic;

namespace Prime_Numbers
{
    class Program
    {
        static int[] FindPrimesInRange(int startNum,int endNum)
        {
            if(startNum < 2)
            {
                startNum = 2;
            }
            List<int> AList = new List<int>();
            bool Pchecker = true;
            for(int i = startNum; i <= endNum; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Pchecker = false;
                        break;
                    }
                }
                if(Pchecker == true)
                {
                    AList.Add(i);
                }
                Pchecker = true;
            }
            return AList.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is a prime number printer.");
            Console.WriteLine("Please enter the starting number:");
            int st = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the ending number:");
            int ed = int.Parse(Console.ReadLine());
            int[] AnswerArr = FindPrimesInRange(st, ed);

            Console.WriteLine($"The prime list will be:");
            foreach(int k in AnswerArr)
            {
                Console.Write($"{k}, ");
            }
        }
    }
}
