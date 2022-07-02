using System;

namespace My_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> MyT = new MyStack<int>();
            Console.WriteLine($"The stack has {MyT.Count()} elements now");
            MyT.Push(200);
            MyT.Push(100);
            MyT.Push(50);
            Console.WriteLine($"The stack has {MyT.Count()} elements now");
            Console.WriteLine($"The poped element is {MyT.Pop()}");
            Console.WriteLine($"The stack has {MyT.Count()} elements now");
        }
    }
}
