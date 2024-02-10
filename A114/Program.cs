using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace weekly_assessment_1st_year
{
    class Program
    {
        struct film
        {
            public string title;
            public int runtime;
            public bool currentOn;
        }
        static void Main(string[] args)
        {
            List<film> filmList = new List<film>();
            int numOfFilms;
            string choice, filename;

            do
            {
                choice = menuchoice();
                switch (choice)
                {
                    case "1":
                        filename = getfilename();
                        filmList = readBinaryFile(filename); 
                        displayList(filmList);
                        break;
                    case "2":
                        filename = getfilename();
                        numOfFilms = getNumOfFilms();
                        filmList = getFilmInfo(numOfFilms);
                        writeBinaryFile(filename, numOfFilms, filmList); 
                        break;
                    case "9":
                        System.Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            } while (true);
        }


        // Add in a function to read from a binary file here. Make sure it is called "readBinaryFile"
        // Instructions for this function are in the assignment.
        // When it is written you can uncomment out the line that calls it in the switch statement above
        static List<film> readBinaryFile(string fileName)
        {
            List<film> list = new List<film>();
            using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open)))
            {
                int numFilms = reader.ReadInt32();
                for (int i = 0; i < numFilms; i++)
                {
                    film currentFilm = new film();
                    currentFilm.title = reader.ReadString();
                    currentFilm.runtime = reader.ReadInt32();
                    currentFilm.currentOn = reader.ReadBoolean();
                    list.Add(currentFilm);
                }
                return list;   
            }
        }
        // Add in a procedure to write to a binary file. Make sure it is called "writeBinaryFile"
        // Instructions for this procedure are in the assignment.
        // When it is written you can uncomment out the line that calls it in the switch statement above
        static void writeBinaryFile(string fileName, int numFilms, List<film> filmList )
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
            {
                writer.Write(numFilms);
                foreach (film film in filmList)
                {
                    writer.Write(film.title);
                    writer.Write(film.runtime);
                    writer.Write(film.currentOn);
                }
            }
        }


        static string getfilename()
        {
            string filename;
            Console.WriteLine("Enter name of file including extension");
            filename = Console.ReadLine();
            return filename;
        }
        static int getNumOfFilms()
        {
            int numOfFilms;
            Console.WriteLine("How many films do you want to enter?");
            numOfFilms = int.Parse(Console.ReadLine());
            return numOfFilms;
        }
        static void displayList(List<film> filmList)
        {
            Console.WriteLine("Title".PadRight(30) + "Run Time".PadLeft(8) + "Current".PadLeft(10));
            for (int i = 0; i < filmList.Count; i++)
            {
                Console.WriteLine(filmList[i].title.PadRight(30) + " " + filmList[i].runtime.ToString().PadLeft(7) + filmList[i].currentOn.ToString().PadLeft(10));
            }
            Console.WriteLine();
        }
        static List<film> getFilmInfo(int numOfFilms)
        {
            List<film> listOfFilms = new List<film>();
            film tempFilm = new film();
            for (int i = 0; i < numOfFilms; i++)
            {
                Console.WriteLine("Enter film title");
                tempFilm.title = Console.ReadLine();
                Console.WriteLine("Enter film running time");
                tempFilm.runtime = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter if film is currently on (true or false)");
                tempFilm.currentOn = bool.Parse(Console.ReadLine());
                listOfFilms.Add(tempFilm);
            }
            return listOfFilms;
        }
        static string menuchoice()
        {
            string choice;
            menu();
            choice = Console.ReadLine();
            return choice;
        }
        static void menu()
        {
            Console.WriteLine("The Barton Cinema Files");
            Console.WriteLine();
            Console.WriteLine("1. Read in film information from a binary file");
            Console.WriteLine("2. Write film information into a binary file");
            Console.WriteLine();
            Console.WriteLine("9. Exit");
            Console.WriteLine();
            Console.WriteLine("Please type in the number of your choice");
        }
    }
}



