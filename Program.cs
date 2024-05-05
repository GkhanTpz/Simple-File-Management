using System;
using System.IO;

namespace MyProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = new string('-', 20);
            Console.Write("Please enter a Citizen Name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter a Citizen Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter a Citizen Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a Citizen Nation: ");
            string country = Console.ReadLine();

            Console.Write("Please enter a Citizen Language: ");
            string language = Console.ReadLine();

            Console.Write("Please enter Region: ");
            string region = Console.ReadLine();

            File.WriteFile(name, lastName, age, country, language, region);
            PrintPersonData.PrintPerson(name, lastName, age, country, language, region);
        }
    }
}