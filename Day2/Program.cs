using System.Reflection.Metadata;

namespace Day2
{
    enum Gender
    {
        Male = 0,
        Female = 1,
    }

    [Flags]
    enum Weather
    {
        Normal = 1,
        Sunny = 2,
        Windy = 4,
        Rainy = 8,
        Cloudy = 16,
    }


    enum Color
    {
        Red = 1,
        Green = 2,
        Blue = 4,
    }

    internal class Program
    {
       
        static void Test(int a)
        {
            a = 10;
        }

        static void Test(Person obj)
        {
            //obj = new Person();
            obj.ID = 1;
        }

        static void Main(string[] args)
        {
            #region Ref type
            int x = 3;

            Person p1 = new Person();
            p1.ID = 10;

            Person p2 = new Person();
            p2 = p1;

            Person p3 = p1;

            Person p4 = new Person();

            Test(x);
            Test(p4);
            #endregion

            #region Enums
            gender g = gender.female;
            //g = gender.male;

            weather todayweather = weather.windy | weather.rainy;

            console.writeline(todayweather);

            if ((todayweather & Weather.Rainy) == Weather.Rainy)
            {
            }

            person p = new person();

            p.type = gender.male;

            if (p.type == gender.male)
                console.writeline("male");
            else
                console.writeline("female");
            #endregion

            #region Struct
            Complex c1;
            Complex c2 = new Complex();
            Complex c3 = new Complex(3, 5);

            c1 = c3;

            c1 = c2 + c3; //Complex.operator+(c2, c3);

            Complex c4 = 100;

            c1 = 5 + c2; //Complex.operator+(5, c2);

            if (c1 == c3)
            {

            }

            Complex c5 = c1++;
            Complex c6 = ++c1;

            //c1.Real = 10;
            //c1.Img = 20;

            //Console.WriteLine($"Real = {c1.Real} \t Img = {c1.Img}"); 
            #endregion

            Person p1 = new Person(10);
            Person p2 = new Person(10);

            Person p3 = p2;

            if (p1 == p2)
            {
                Console.WriteLine("Equal");
            }
            else
                Console.WriteLine("Not Equal");

            Console.WriteLine(p.ID);
        }
    }
}