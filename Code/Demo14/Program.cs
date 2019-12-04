using System;

namespace Demo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo14 - Exceptions");

            // division by zero exception
            try
            {
                int number1 = 100;
                int number2 = 0;
                int result = number1 / number2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero! " + ex.Message);
            }

            //exception in parsing string
            try
            {
                Console.Write("Give a number: ");
                string line = Console.ReadLine();
                int number = int.Parse(line);
                Console.WriteLine("You entered " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a number. " + ex.Message);
            }

            // exception in accessing array
            try
            {
                int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Number is " + numbers[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Wrong index: " + ex.Message);
            }
            
            try
            {
                int result2 = SafeDivision(100, 0);
                Console.WriteLine("result2 is " + result2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero " + ex.Message);
            }

            SomedaySomething();
        }

        public static int SafeDivision(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        public static int SomedaySomething()
        {
            throw new NotImplementedException();
        }
    }
}
