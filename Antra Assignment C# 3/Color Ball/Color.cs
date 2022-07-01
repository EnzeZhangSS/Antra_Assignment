using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Ball
{
    public class Color
    {
        private byte red;
        public byte Red
        {
            get { return red; }
            set { red = value; }
        }

        private byte green;
        public byte Green
        {
            get { return green; }
            set { green = value; }
        }

        private byte blue;
        public byte Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        private byte alpha;
        public byte Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public Color(byte r, byte g, byte b, byte a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }

        public Color(byte r, byte g, byte b)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
        }

        public int Grayscale()
        {
            return (Red + Blue + Green) / 3; 
        }

    }
}
