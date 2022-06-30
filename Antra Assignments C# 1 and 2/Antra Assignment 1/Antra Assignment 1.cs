using System;
namespace Antra_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string clr;
            string month;
            string num;
            Console.WriteLine("Hello, this is a username generator. Please enter your favorite color:");
            clr = Console.ReadLine();
            Console.WriteLine("Great! Please enter your favorite month:");
            month = Console.ReadLine();
            Console.WriteLine("Finally, please enter your favorite number:");
            num = Console.ReadLine();
            Console.WriteLine("Your username is: " + clr + month + num );
        }
    }
}
