using System;

namespace Demo12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo12 - stack, heap and arrays");

            // these variables memory is allocated from stack
            int number = 60;
            float seconds = 123.5f;
            Console.WriteLine(number);
            Console.WriteLine(seconds);

            // allocate 100 ints from heap
            int[] numbers = new int[100];
            for (int i=0; i < numbers.Length; i++)
            {
                numbers[i] = i * 10;
            }
            PrintNumbers2(numbers);

            // allocate one movie from the heap
            Movie oldie = new Movie("One flew Over the Cuckoo's Nest", "Milos Forman", 1973);
            Console.WriteLine(oldie);

            // allocate 100 movies from the heap
            Movie[] movies = new Movie[100];
            for (int i=0; i<movies.Length; i++)
            {
                ref Movie movie = ref movies[i];

                movie.Title = "Movie " + (i + 1);
                movie.Director = "Director " + (i + 1);
                movie.Year = 1950 + i;
            }

            // use foreach to print all movies
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }

        }

        public static void PrintNumbers(int[] array)
        {
            for (int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void PrintNumbers2(int[] array)
        {
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
