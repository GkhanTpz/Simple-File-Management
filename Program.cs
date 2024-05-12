using System;
using System.IO;

namespace MyProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your Name: ");
            string Name = Console.ReadLine();

            Console.Write("Please enter your Last Name: ");
            string LastName = Console.ReadLine();

            Console.Write("Please enter your Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your Language: ");
            string Language = Console.ReadLine();

            Console.Write("Please enter your Country: ");
            string Country = Console.ReadLine();

            Console.Write("Please enter your Country Region: ");
            string Region = Console.ReadLine();          
        }
    }
}