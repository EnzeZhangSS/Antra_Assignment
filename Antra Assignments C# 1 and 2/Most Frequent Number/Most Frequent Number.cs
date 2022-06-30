using System;
using System.Linq;
using System.Collections.Generic;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an array seperated by space:");
            List<string> MyList = Console.ReadLine().Split(' ').ToList();
            List<int> NumList = MyList.Select(int.Parse).ToList();
            Dictionary<int, int> MyDic = new Dictionary<int, int>();
            foreach(int i in NumList)
            {
                if (MyDic.ContainsKey(i))
                {
                    MyDic[i] += 1;
                }
                else
                {
                    MyDic[i] = 1;
                }
            }
            int curMax = 0;
            List<int> AnsList = new List<int>();


            foreach(KeyValuePair<int,int> k in MyDic)
            {
                if (k.Value > curMax)
                {
                    curMax = k.Value;
                    AnsList.Clear();
                    AnsList.Add(k.Key);
                }
                else if (k.Value == curMax)
                {
                    AnsList.Add(k.Key);
                }
            }
            int LeftMost = AnsList[0];
            AnsList.Sort();

            if (AnsList.Count == 1)
            {
                Console.WriteLine($"The number {AnsList[0]} is the most frequent (occurs {curMax} times)");
            }
            else if (AnsList.Count > 1)
            {
                Console.Write("The numbers ");
                if(AnsList.Count > 2)
                {
                    for (int j = 0; j < AnsList.Count - 2; j++)
                    {
                        Console.Write($"{AnsList[j]}, ");
                    }
                }
                Console.Write($"{AnsList[AnsList.Count-2]} and {AnsList[AnsList.Count-1]} have the same maximal frequence (each occurs {curMax} times). ");
                Console.Write($"The leftmost if them is {LeftMost}.\n");
            }
        }
    }
}
