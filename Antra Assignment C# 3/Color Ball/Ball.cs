using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Ball
{
    public class Ball : Color
    {
        private int size;
        public int Size
        {
            get { return size; }
            private set { size = value; }
        }

        private int count = 0;
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        public Ball(int s, byte r, byte g, byte b):base(r,g,b)
        {
            Size = s;
            Red = r;
            Blue = b;
            Green = g;
        }

        public void Pop()
        {
            Size = 0;
            Console.WriteLine("Ball poped.");
        }

        public void Throw()
        {
            if(Size == 0)
            {
                Console.WriteLine("This ball has been poped. It can't be throw anymore.");
            }
            else
            {
                Count++;
            }
        }

        public int ThrowCount()
        {
            int C = Count;
            return C;
        }


    }
}
