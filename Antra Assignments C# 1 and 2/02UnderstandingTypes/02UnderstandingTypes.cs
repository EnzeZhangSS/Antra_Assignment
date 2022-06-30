using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] Types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};
            int[] MemUse = { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 16};
            string [] MinVal = { "-128", "0", "-32,768", "0", "-2,147,483,648", "0", "-9,223,372,036,854,775,808", "0", "-3.4e38", "-1.7e308", "-7.9e28" };
            string[] MaxVal = { "127", "255", "32,767", "65,535", "2,147,483,647", "4,294,967,295", "9,223,372,036,854,775,807", "18,446,744,073,709,551,615", "3.4e38", "1.7e308", "7.9e28" };
            
            Console.WriteLine("{0,-10} {1,30} {2,30} {3,30} \n", "Types", "Memory Usage by Byte", "Max Values", "Min Values");
            for(int i = 0; i< Types.Length; i++)
            {
                Console.WriteLine("{0,-10} {1,30} {2,30} {3,30} \n", Types[i], MemUse[i], MaxVal[i], MinVal[i]);
            }
        }
    }
}
