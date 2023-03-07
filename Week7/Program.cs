using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Please enter your full name : ");
            string name = Console.ReadLine();
            string filePath;
            do
            {

                try
                {
                    Console.Write("Please enter file path : ");
                    filePath = Console.ReadLine();
                    File.ReadAllLines(filePath);
                }
                catch (Exception)
                {
                   
                    Console.WriteLine("Invalid path name entered. Please try again!");
                    filePath = "";
                }
            } while (filePath.Length == 0);
            string[] data = File.ReadAllLines(filePath);
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                count += data[i].Split(' ').Length;
            }
            Console.WriteLine("The number of words the file contains are : " + count);
            Console.ReadKey();
        }
    }
}
