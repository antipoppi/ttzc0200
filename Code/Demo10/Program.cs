using System;

namespace Demo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo10 - reference parameters");

            int param = 1;
            Console.WriteLine("Param is " + param);
            Test1(param);
            Console.WriteLine("After call, param is " + param);

            param = 2;
            Console.WriteLine("Param is " + param);
            Test2(ref param);
            Console.WriteLine("After call, param is " + param);

            int param2;
            Test3(out param2);
            Console.WriteLine("After call, param2 is " + param2);


            int number; //number value will be get by input
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("OK: converted to " + number);
            }
            else
            {
                Console.WriteLine("FAIL: cannot convert to int");
            }
            Console.WriteLine("number is " + number);
        }

        public static void Test1(int param)
        {
            param = 101;
        }
        public static void Test2(ref int param) //ref means that param might be changed
        {
            param = 101;
        }
        public static void Test3(out int param) //out is a promise that param will change
        {
            param = 201;
        }
    }
}
