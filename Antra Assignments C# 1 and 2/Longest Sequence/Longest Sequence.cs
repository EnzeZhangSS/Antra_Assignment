using System;
using System.Linq;
using System.Collections.Generic;

namespace Longest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an array seperated by space:");
            List<string> MyList = Console.ReadLine().Split(' ').ToList();
            List<int> NumList = MyList.Select(int.Parse).ToList();
            Dictionary<int, int> MyDic = new Dictionary<int, int>();
            int curMax = 0;
            int MaxVal = NumList[0];
            int curVal = NumList[0];
            int curCnt = 0;
            for(int i = 0; i < NumList.Count; i++)
            {
                if (NumList[i] == curVal)
                {
                    curCnt++;
                }
                else
                {
                    if (curCnt > curMax)
                    {
                        curMax = curCnt;
                        MaxVal = curVal;
                    }
                    curVal = NumList[i];
                    curCnt = 1;
                }
            }
            if (curCnt > curMax)
            {
                curMax = curCnt;
                MaxVal = curVal;
            }


            Console.WriteLine("The longest sequence of equal elements is:");
            for(int k = 0; k < curMax; k++)
            {
                Console.Write($"{MaxVal} ");
            }

        }
    }
}
