using System;
using System.Linq;
using System.Collections.Generic;

namespace Testing_Field
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the URL:");
            string ipt = Console.ReadLine();
            List<string> MyList = ipt.Split(new Char[] { ':', '/' }).ToList();
            foreach(string s in MyList)
            {
                Console.WriteLine($"{s}");
            }

        }
    }
}
