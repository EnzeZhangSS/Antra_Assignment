using System;
using System.Collections.Generic;

namespace ToPlayList
{
    class ToPlayList
    {
        static void Main(string[] args)
        {
            List<string> Plist = new List<string>();
            Console.WriteLine("This is a play list. You can add, remove or clear games.");
            while (true)
            {
                Console.WriteLine("Enter command (+ game, - game, or -- to clear)):");
                string cmd = Console.ReadLine();

                if (cmd == "--")
                {
                    Plist.Clear();
                    Console.WriteLine("Play list cleared.");
                }
                else if (cmd.Substring(0,1) == "+"){
                    Plist.Add(cmd.Substring(2));
                    Console.WriteLine($"Game {cmd.Substring(2)} added.");
                }
                else if (cmd.Substring(0,1) == "-")
                {
                    Plist.Remove($"{cmd.Substring(2)}");
                    Console.WriteLine($"Game {cmd.Substring(2)} removed.");
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
                Console.Write($"Current play list: ");
                foreach(string i in Plist)
                {
                    Console.Write($"{i}, ");
                }
                Console.WriteLine("");
            }
        }
    }
}
