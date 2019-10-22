using System;

namespace Demo08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo08 - Hello Debugger!");

            Random rand = new Random();

            int number1 = 10;
            int number2 = rand.Next(101);

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Step();

            StepWithParams(number1, number2);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static void Step()
        {
            Console.WriteLine("Inside Step");
        }

        public static void StepWithParams(int param1, int param2)
        {
            if (param1 > param2)
            {
                Console.WriteLine("param1 is larger than param2");
            }
            else
            {
                Console.WriteLine("param1 is smaller or equal to param2");
            }

            param1 += param2;
            param2 += param2;
        }
    }
}
