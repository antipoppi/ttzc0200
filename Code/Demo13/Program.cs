using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo 13 - Collections");

            // declare list of ints
            Console.WriteLine("Testing List<int>");
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(5);
            list.Add(16);
            list.Insert(1, 7); // lisää numeron seitsemän listaan paikalle kaksi
            list.Remove(10);

            foreach (int value in list)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Average: " + list.Average());
            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Max: " + list.Max());
            Console.WriteLine("Sum: " + list.Sum());
            Console.WriteLine("Count: " + list.Count());
            Console.WriteLine("list[0]: " + list[0]);

            list.Sort();
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }

            // declare stack of strings
            Console.WriteLine("Testing Stack<string>");
            Stack<string> stack = new Stack<string>();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            Console.WriteLine("Peek: " + stack.Peek());

            foreach (string text in stack)
            {
                Console.WriteLine(text);
            }
            string temp = stack.Pop(); // päällimmäinen pois
            Console.WriteLine("temp is: " + temp);
            Console.WriteLine("Count is: " + stack.Count);
            stack.Clear();

            // declare a queue of string
            Console.WriteLine("Testing Queue<string>");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("John (1)");
            queue.Enqueue("Mary (2)");
            queue.Enqueue("Kerry (3)");

            Console.WriteLine("First in queue is " + queue.Peek());
            Console.WriteLine("Count is " + queue.Count());
            string first = queue.Dequeue();
            Console.WriteLine("Dequeued " + first);
            Console.WriteLine("First in queue is " + queue.Peek());
            Console.WriteLine("Count is " + queue.Count());

            // declare a movie collection
            Console.WriteLine("Testing Dictionary<string, Movies>");
            Dictionary<string, Movie> movies = new Dictionary<string, Movie>();

            Movie movie1 = new Movie("E.T The Extra Terrestrial", "Steven Spielber", 1982);
            Movie movie2 = new Movie("MadMax: FuryRoad", "George Miller", 2015);
            Movie movie3 = new Movie("Gravity", "Alfonso Cuaron", 2013);

            movies.Add(movie1.Title, movie1);
            movies.Add(movie2.Title, movie2);
            movies.Add(movie3.Title, movie3);

            // find movie with a key
            string title = "MadMax: FuryRoad";
            if (movies.ContainsKey(title))
            {
                Console.WriteLine("Movie " + title + " found.");
                Console.WriteLine("Its director is " + movies[title].Director +".");
            }
            else
            {
                Console.WriteLine("Movie " + title + " not found");
            }

            if (movies.ContainsKey("Gravity"))
            {
                movies.Remove("Gravity");
            }

            Console.WriteLine("Collection size is " + movies.Count);

            // go thru all keys
            Console.WriteLine("Keys:");
            foreach (string key in movies.Keys)
            {
                Console.WriteLine(key);
            }
            // go thru all values
            Console.WriteLine("Values:");
            foreach (Movie movie in movies.Values)
            {
                Console.WriteLine(movie);
            }
            // go thru all keys and values with KeyValuePair
            Console.WriteLine("Keys and values:");
            foreach (KeyValuePair<string, Movie> kvp in movies)
            {
                Console.WriteLine("Key " + kvp.Key);
                Console.WriteLine("Key " + kvp.Value);
            }
        }
    }
}


