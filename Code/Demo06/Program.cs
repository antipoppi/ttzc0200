using System;

namespace Demo06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo06 - classes and methods");

            Helper.PrintInfo();

            // call a method with a return value
            int number = Helper.PrintAndReturnNumber();
            Console.WriteLine("number is " + number);

            // call method with parameters
            int theSum = Helper.Sum(number, 11);
            Console.WriteLine(theSum);



            // task, read two numbers from the user
            /*
            int number1;
            int number2;

            Console.WriteLine("Enter first number: ");
            string line = Console.ReadLine();
            int.TryParse(line, out number1);

            Console.WriteLine("Enter first number: ");
            line = Console.ReadLine();
            int.TryParse(line, out number2);

            theSum = Helper.Sum(number1, number2);
            Console.WriteLine("Sum is " + theSum);
            */

            int number1 = Helper.AskNumber("Enter first number ");
            int number2 = Helper.AskNumber("Enter second number ");
            Console.WriteLine("Sum is " + Helper.Sum(number1, number2));


        }
    }
}
