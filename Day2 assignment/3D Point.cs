using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_assignment
{
    internal struct _3DPoint
    {
       int x , y , z ;
        public _3DPoint(int _x , int _y , int _z)
        {
            x = _x ;
            y = _y ;
            z = _z ;
        }
        public void Display()
        {
            Console.WriteLine($"x = {x} \t  y = {y} \t  z = {z} ");
        }
        
        public static bool operator==( _3DPoint p1, _3DPoint p2)
        {
            if (p1.x == p2.x && p1.y == p2.y && p1.z == p2.z)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            if (p1.x != p2.x || p1.y != p2.y || p1.z != p2.z)
            {
                return true;
            }
            return false;
        }
        public void ChangeCoordinates(int newX, int newY, int newZ)
        {
            x = newX ;
            y = newY ;
            z = newZ ;
        }

    }
}
