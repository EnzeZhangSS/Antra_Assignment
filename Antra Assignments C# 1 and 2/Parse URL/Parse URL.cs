using System;
using System.Linq;
using System.Collections.Generic;

namespace Parse_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the URL:");
            string ipt = Console.ReadLine();
            List<string> MyList = ipt.Split(new Char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> AnsList = new List<string>() {"","",""};
            if (ipt.Contains("://"))
            {
                AnsList[0] = MyList[0];
                AnsList[1] = MyList[1];
                if (MyList.Count >= 3)
                {
                    AnsList[2] = ipt.Substring(AnsList[0].Length + AnsList[1].Length+4);
                }
            }
            else
            {
                AnsList[1] = MyList[0];
                if(MyList.Count >= 2)
                {
                    AnsList[2] = ipt.Substring(AnsList[1].Length + 1);
                }
            }
            Console.WriteLine($"[protocol] = \"{AnsList[0]}\"");
            Console.WriteLine($"[server] = \"{AnsList[1]}\"");
            Console.WriteLine($"[resource] = \"{AnsList[2]}\"");

        }
    }
}
