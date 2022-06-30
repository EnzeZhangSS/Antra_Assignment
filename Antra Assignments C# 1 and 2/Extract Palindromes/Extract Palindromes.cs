using System;
using System.Linq;
using System.Collections.Generic;

namespace Extract_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text: ");
            List<string> MyList = Console.ReadLine().Split(new Char[] { '.',',',':',';','=', '(', ')', '&', '[', ']' ,'"', '\'', '\\','/','!','?',' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> AnsList = new List<string>();
            foreach(string s in MyList)
            {
                int l, r;
                bool Pckr = true;
                if(s.Length % 2 == 1)
                {
                    l = s.Length / 2;
                    r = s.Length / 2;
                }
                else
                {
                    l = s.Length / 2 - 1;
                    r = s.Length / 2;
                }
                while(l >= 0)
                {
                    if (s[l] != s[r])
                    {
                        Pckr = false;
                        break;
                    }
                    l--;
                    r++;
                }
                if(Pckr == true)
                {
                    if (AnsList.Contains(s)==false)
                    {
                        AnsList.Add(s);
                    }
                }


            }

            AnsList.Sort();
            var ans = String.Join(", ", AnsList.ToArray());
            Console.WriteLine($"Palindromes are the followings: \n{ans}");
        }
    }
}
