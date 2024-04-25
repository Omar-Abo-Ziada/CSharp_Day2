using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal struct Complex
    {
        public int Real;
        public int Img;

        public Complex(int real, int img)
        {
            Real = real;
            Img = img;
        }

        public static Complex operator+(Complex a, Complex b) 
        {
            Complex c;
            c.Real = a.Real + b.Real;
            c.Img = a.Img + b.Img;

            return c;
        }

        public static implicit operator Complex(int num)
        {
            Complex c = new Complex(num , 0);

            return c;
        }

        public static bool operator==(Complex a, Complex b)
        {
            return a.Real == b.Real;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return a.Real != b.Real;
        }

        public static Complex operator++(Complex c)
        {
            c.Real++;
            c.Img++;

            return c;
        }
    }
}
