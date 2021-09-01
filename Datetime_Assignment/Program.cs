using System;
using System.IO;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now + "\nPlease pick a number:\n");
            var userInput = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\will2\source\repos\Datetime_Assignment\Datetime_Assignment\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(userInput);
            }

            var text = File.ReadAllText(@"C:\Users\will2\source\repos\Datetime_Assignment\Datetime_Assignment\log.txt");
            Console.WriteLine(text);
        }
    }
}

