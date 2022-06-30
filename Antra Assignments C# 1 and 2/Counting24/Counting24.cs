using System;

namespace Counting24
{
    class Counting24
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for(int j = 0; j <= 23; j += i)
                {
                    Console.Write("{0}, ",j);
                }
                Console.WriteLine("24");
            }
        }
    }
}
