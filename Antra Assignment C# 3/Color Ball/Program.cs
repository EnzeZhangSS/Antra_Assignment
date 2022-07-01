using System;

namespace Color_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball BB1 = new Ball(30, 20, 44, 100);
            Ball BB2 = new Ball(50, 213, 37, 99);
            Ball BB3 = new Ball(163, 85, 111, 75);
            Ball BB4 = new Ball(95, 74, 231, 150);
            Ball BB5 = new Ball(1000, 40, 78, 200);
            BB1.Throw();
            BB5.Throw();
            BB2.Throw();
            BB1.Throw();
            BB3.Throw();
            BB1.Throw();
            BB4.Throw();
            BB5.Throw();
            BB5.Throw();
            BB3.Throw();
            BB4.Throw();
            BB2.Throw();
            BB5.Throw();
            BB1.Throw();
            Console.WriteLine($"The current throw count for Ball 1 - 5 are: {BB1.ThrowCount()} {BB2.ThrowCount()} {BB3.ThrowCount()} {BB4.ThrowCount()} {BB5.ThrowCount()}");
            BB2.Pop();
            BB1.Throw();
            BB5.Throw();
            BB2.Throw();
            BB1.Throw();
            BB4.Throw();
            BB3.Throw();
            BB1.Throw();
            BB5.Pop();
            BB5.Throw();
            BB5.Throw();
            BB4.Throw();
            BB3.Throw();
            BB2.Throw();
            BB5.Throw();
            BB1.Throw(); 
            BB4.Throw();
            Console.WriteLine(value: $"The current throw count for Ball 1 - 5 are: {BB1.ThrowCount()} {BB2.ThrowCount()} {BB3.ThrowCount()} {BB4.ThrowCount()} {BB5.ThrowCount()}");





        }
    }
}
