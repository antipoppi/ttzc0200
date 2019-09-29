using System;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo05 - data types");

            int number = 10;
            double accountBalance = 100.53;
            Console.WriteLine("number is " + number);
            Console.WriteLine("accountbalance is " + accountBalance);

            number = 55;
            int number2 = number;
            // value of number2 is now 55

            {
                int number3 = 1234;
                Console.WriteLine("number3 is " + number3);
            }
            //number3 is not available here anymore
            //number3 = 1235;

            byte v1 = byte.MaxValue;
            Console.Write("v1 value is " + v1 + ". ");
            Console.Write("It takes " + sizeof(byte) + " bytes of memory\n");

            short v2 = short.MinValue;
            Console.Write("v2 value is " + v2 + ". ");
            Console.Write("It takes " + sizeof(short) + " bytes of memory\n");

            ulong v3 = ulong.MaxValue;
            Console.Write("v3 value is " + v3 + ". ");
            Console.Write("It takes " + sizeof(ulong) + " bytes of memory\n");

            float v4 = 3.14159265f;
            Console.Write("v4 value is " + v4 + ". ");
            Console.Write("It takes " + sizeof(float) + " bytes of memory\n");

            double v5 = 3.14159265;
            Console.Write("v5 value is " + v5 + ". ");
            Console.Write("It takes " + sizeof(double) + " bytes of memory\n");

            char v6 = 'A';
            Console.Write("v6 value is " + v6 + ". ");
            Console.Write("It takes " + sizeof(char) + " bytes of memory\n");

            string v7 = "This is an example text";
            Console.Write("v7 value is " + v7 + ". ");
            Console.Write("It takes (at least) " + v7.Length * sizeof(char) + " bytes of memory\n");


            string name = "Tatu";
            string lastName = "Alatalo";
            string fullName = name;

            fullName = name + " " + lastName;
            Console.WriteLine(fullName);

            int age = 32;
            fullName = string.Format("First name: {0}. Last name {1}. Age: {2}",
                name, lastName, age);
            Console.WriteLine(fullName);


            // access characters in string
            string text = "ABC";
            char a = text[0];
            char b = text[1];
            char c = text[2];
            Console.WriteLine("Second char is " + b);

            Console.WriteLine("Text length is " + text.Length + " characters");


            string text2 = "ABD";
            if (text.CompareTo(text2) == 0)
            {
                Console.WriteLine("texts are identical");
            }


            // read from console
            Console.WriteLine("Enter a line of text: ");
            string line = Console.ReadLine();
            Console.WriteLine("You entered " + line);

            // read int from console
            Console.WriteLine("Enter a number: ");
            line = Console.ReadLine();
            int.TryParse(line, out number);
            Console.WriteLine("Number is " + number);


        }
    }
}
