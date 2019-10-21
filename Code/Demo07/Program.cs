using System;

namespace Demo07
{
    class Program
    {
        public static int AskNumber(string title)
        {
            int number;
            Console.WriteLine(title);
            string line = Console.ReadLine();
            int.TryParse(line, out number);
            return number;
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Demo07 - conditions and loops");

            int number = AskNumber("Gimme a number ");

            // try some basic conditions
            if (number == 10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number < 10)
            {
                Console.WriteLine("number is less than 10");
            }
            else if (number >= 20)
            {
                Console.WriteLine("number is equal or greater than 10");
            }
            else
            {
                Console.WriteLine("number is in between 11 and 19");
            }

            number = AskNumber("Enter another number: ");
            if (number > 0 && number < 10)
            {
                Console.WriteLine("number is in between 1 and 9");
            }
            else if (number >= 10 || number == 0)
            {
                Console.WriteLine("number is 10 or greater, or number is 0");
            }


            char grade = 'e';
            switch (grade)
            {
                case 'e':
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'g':
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 's':
                case 'S':
                    Console.WriteLine("Satisfactory");
                    break;
                case 'p':
                case 'P':
                    Console.WriteLine("Poor");
                    break;
                default:
                    Console.WriteLine("Unknown :(");
                    break;
            }

            /*
            // all this code...
            bool isLarger;
            if (number > 10)
            {
                isLarger = true;
            }
            else
            {
                isLarger = false;
            }
            */

            // ..can be replaced by this
            bool isLarger = (number > 10) ? true : false;


            // loops

            // while loop
            Console.WriteLine("Running while loop");
            number = 10;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            // do-while loop
            Console.WriteLine("Running a do-while loop");
            do
            {
                number = AskNumber("Enter a number (0 to exit loop)");
                Console.WriteLine("You entered: " + number);
            } while (number != 0);

            // for loop
            // for (init; condition; update)
            Console.WriteLine("Running for loop");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Looping " + i);
            }


            Console.WriteLine("Running do-while loop with break and continue");
            number = 0;
            do
            {
                number = AskNumber("Enter a number (0 to exit, 100 ignored) ");
                if (number == 100)
                {
                    Console.WriteLine("Ignored");
                    continue;
                }
                
                if (number == 0)
                {
                    break;
                }

                Console.WriteLine("You entered: " + number);
            } while (true);
        }
    }
}
