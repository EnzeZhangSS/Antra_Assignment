using System;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            var CurTime = DateTime.Now.TimeOfDay;

            switch (CurTime.Hours)
            {
                case < 4:
                    Console.WriteLine("Good Night");
                    break;
                case < 12:
                    Console.WriteLine("Good Morning");
                    break;
                case < 18:
                    Console.WriteLine("Good Afternoon");
                    break;
                case < 22:
                    Console.WriteLine("Good Evening");
                    break;
                case < 24:
                    Console.WriteLine("Good Night");
                    break;
            }
        }
    }
}
