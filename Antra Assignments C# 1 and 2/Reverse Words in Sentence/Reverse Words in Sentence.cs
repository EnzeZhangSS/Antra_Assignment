using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Reverse_Words_in_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text: ");
            string ipt = Console.ReadLine();
            List<string> WordList = ipt.Split(new Char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            WordList.Reverse();
            List<string> PList = new List<string> { ".", ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "\'", "\\", "/", "!", "?", " " };
            List<string> TList = new List<string>();
            List<string> temp = new List<string>();
            int curLen = 0;
            for(int i = 0; i < ipt.Length; i++)
            {
                if (PList.Contains(Char.ToString(ipt[i])))
                {
                    curLen++;
                }
                else
                {
                    if (curLen > 0)
                    {
                        TList.Add(ipt.Substring(i-curLen,curLen));
                        curLen = 0;
                    }
                }

            }
            if (curLen > 0)
            {
                TList.Add(ipt.Substring(ipt.Length - curLen, curLen));
                curLen = 0;
            }

            for (int j = 0; j < WordList.Count; j++)
            {
                Console.Write($"{WordList[j]}");
                Console.Write($"{TList[j]}");
            }





        }
    }
}
