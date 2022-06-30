using System;

namespace GuessNum1to3
{
    class GuessNum1to3
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please guess an integer from 1 to 3:");
            int guessedNumber = int.Parse(Console.ReadLine());
            while (true)
            {
                if (guessedNumber > 3 || guessedNumber < 1)
                {
                    Console.WriteLine("Out of range. Try again:");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("Too low. Please guess again:");
                }
                else if (guessedNumber == correctNumber)
                {
                    Console.WriteLine("Bingo!");
                    break;
                }
                else if (guessedNumber > correctNumber)
                {

                    Console.WriteLine("Too high. Please guess again:");
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again:");
                }
                guessedNumber = int.Parse(Console.ReadLine());
            }
        }
    }
}
