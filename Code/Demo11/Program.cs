using System;

namespace Demo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo11 - casting");

            // implicit conversion (cast)
            int num = 21546789;
            long bigNum = num;
            Console.WriteLine("bigNum=" + bigNum);

            // explicit conversion
            double x = 1234.8;
            int a = (int)x;
            //int a = (int)Math.Round(x);
            //int a = (int)(x + 0.5);
            Console.WriteLine("x=" + x + ", a=" + a);

            int number = 12345;
            string line = number.ToString();
            //string line = "" + number; toimii myös
            Console.WriteLine("number " + line);
        }
    }
}
