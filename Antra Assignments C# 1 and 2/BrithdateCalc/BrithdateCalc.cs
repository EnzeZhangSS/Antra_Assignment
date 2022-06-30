using System;

namespace BrithdateCalc
{
    class BrithdateCalc
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your birth year:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your birth month:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your birth date of the month:");
            int d = int.Parse(Console.ReadLine());
            var Bday = new DateTime(y, m, d);
            var Today = DateTime.Now;
            var DayAge = Today - Bday;
            Console.WriteLine("You are {0} days old.",DayAge.Days);
            int daysToNextAnniversary = 10000 - (DayAge.Days % 10000);
            var NewDay = Today.AddDays(daysToNextAnniversary);
            Console.WriteLine("The next 10000 day anniversary will be: {0}",NewDay.ToString("MM/dd/yyyy"));
        }
    }
}
