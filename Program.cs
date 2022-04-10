using System;
using System.IO;

namespace ConsoleApp // Project name
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter your full name : ");
            string name = Console.ReadLine();
            string filePath;
            do
            {

                try
                {
                    Console.Write("Enter file path : ");
                    filePath = Console.ReadLine();
                    File.ReadAllLines(filePath);
                }
                catch (Exception)
                {
                    // If invalid file path entered .. sets filePath to empty to read input
                    // path again
                    Console.WriteLine("Invalid path name entered");
                    filePath = "";
                }
            } while (filePath.Length == 0);
            string[] data = File.ReadAllLines(filePath);
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                count += data[i].Split(' ').Length;
            }
            Console.WriteLine("The number of words in file are : " + count);
            Console.ReadKey();
        }
    }
}