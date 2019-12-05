using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Demo15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo15 - files");

            Console.WriteLine("Writing demo15.txt to 'exe' folder");
            StreamWriter outputfile = new StreamWriter("demo15.txt");
            outputfile.WriteLine("Demo15, making files happen");
            outputfile.Close();

            /* C:n juureen ei ole oikeutta kirjoittaa.
             * 
            Console.WriteLine("Writing demo15.txt to C drive root");
            StreamWriter outputfile2 = new StreamWriter("C:\\demo15.txt");
            outputfile.WriteLine("This will not work...");
            outputfile.Close();

            */

            const string folder = "Demo15";
            TestCreateFile("C:\\Demo15.txt");
            TestMyDocs(folder, "demo15.txt");
            WriteAllLinesMyDocs(folder, "WriteAllLines.txt");

            ReadFromMyDocs(folder, "demo15.txt");
            ReadFromMyDocs2(folder, "demo15.txt");

            // create a list of movies
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("E.T The Extra Terrestrial", "Steven Spielber", 1982));
            movies.Add(new Movie("MadMax: FuryRoad", "George Miller", 2015));
            movies.Add(new Movie("Gravity", "Alfonso Cuaron", 2013));

            // safe to file
            SaveMoviesMyDocs(movies, folder, "movies.bin");

            // load movies from the file
            List<Movie> moviesFromFile = LoadMoviesMyDocs(folder, "movies.bin");
            Console.WriteLine(moviesFromFile.Count + " movies loaded from movies.bin");
            foreach (Movie movie in moviesFromFile)
            {
                Console.WriteLine(movie);
            }

        }

        public static List<Movie> LoadMoviesMyDocs(string folderName, string fileName)
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myDocPath = Path.Combine(myDocPath, folderName);

            try
            {
                Stream readStream = new FileStream(myDocPath + "\\" + fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                return (List<Movie>)formatter.Deserialize(readStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine("LoadMovies exception: " + ex.Message);
                return new List<Movie>();
            }
        }

        public static void SaveMoviesMyDocs(List<Movie> movies, string folderName, string fileName)
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myDocPath = Path.Combine(myDocPath, folderName);
            Directory.CreateDirectory(myDocPath);

            Stream writeStream = new FileStream(myDocPath + "\\" + fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, movies); // tyypin pitää olla serialisoitavissa [serialize] tyypin alussa (movies)
            writeStream.Close();

            Console.WriteLine(movies.Count + " movies saved to " + fileName);
        }

        public static void ReadFromMyDocs(string folderName, string fileName) // luetaan tiedoston sisältö
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myDocPath = Path.Combine(myDocPath, folderName);
            try
            {
                string contents = File.ReadAllText(myDocPath + "\\" + fileName);
                Console.WriteLine("\nContents of file " + fileName + ":\n" + contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
        }

        public static void ReadFromMyDocs2(string folderName, string fileName) // luetaan tiedoston sisältö taulukkona
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myDocPath = Path.Combine(myDocPath, folderName);
            try
            {
                string[] lines = File.ReadAllLines(myDocPath + "\\" + fileName);
                Console.WriteLine("\nContents of file " + fileName + ":\n" + fileName);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
        }

        public static void WriteAllLinesMyDocs(string folderName, string fileName)
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myDocPath = Path.Combine(myDocPath, folderName);
            Directory.CreateDirectory(myDocPath);

            string[] lines = { "First line", "Second line", "Third line" };
            File.WriteAllLines(myDocPath + "\\" + fileName, lines); // luo uuden tiedoston, lisää tiedot taulukkoon ja sulkee sen.

        }
        public static void TestMyDocs(string folderName, string fileName)
        {
            StreamWriter outputFile = null;
            try 
            {
                string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                myDocPath = Path.Combine(myDocPath, folderName);
                Directory.CreateDirectory(myDocPath);

                string[] lines = { "First line", "Second line", "Third line" };
                outputFile = new StreamWriter(myDocPath + "\\" + fileName);
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to write to MyDocuments: " + ex.Message);
            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }

        public static void TestCreateFile(string path)
        {
            StreamWriter outputfile = null;
            try
            {
                outputfile = new StreamWriter(path);
                outputfile.Write("Here is a sample text to a file.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally // riippumaton siitä, tuleeko poikkeusta tai ei. Tämä toteutuu.
            {
                if (outputfile != null)
                {
                    outputfile.Close(); // näin varmistetaan, että tiedosto suljetaan aina.
                }
            }
        }
    }
}
