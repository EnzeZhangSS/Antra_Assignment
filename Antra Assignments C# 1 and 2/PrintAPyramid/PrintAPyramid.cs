using System;

namespace PrintAPyramid
{
    class PrintAPyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height of the pyramid:");
            int h = int.Parse(Console.ReadLine());
            for(int i = 1; i <= h; i++)
            {
                for(int j = h - i; j>0; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k < (2*i); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
