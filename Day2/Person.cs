using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Person
    {
        public int ID;
        public Gender Type;
        public string Name;

        public Person()
        {
            
        }

        public Person(int id)
        {

        }

        public static bool operator==(Person a, Person b)
        {
            return a.ID == b.ID;
        }

        public static bool operator !=(Person a, Person b)
        {
            return a.ID != b.ID;
        }
    }
}
