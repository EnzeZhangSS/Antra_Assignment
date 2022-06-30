using System;

namespace Copying_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oriArr = new int[] {10,9,8,7,6,5,4,3,2,1};
            int[] newArr = new int[oriArr.Length];
            for(int i = 0; i < oriArr.Length; i++)
            {
                newArr[i] = oriArr[i];
            }

            Console.WriteLine("Original Array:");
            foreach(var j in oriArr)
            {
                Console.Write($"{j}, ");
            }
            Console.WriteLine("\nNew Array:");
            foreach(var k in newArr)
            {
                Console.Write($"{k}, ");
            }
        }
    }
}
