using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            while (true)
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

                Console.Write("Please enter your Country Id: ");
                int CountryId = Convert.ToInt32(Console.ReadLine());

                IPersonDetails person = new NewPerson(id);
                person.WriteToFile(Name, LastName, Age, Language, Country, Region, CountryId);
                person.PrintPersonData(Name, LastName, Age, Language, Country, Region, CountryId);
                person.AddPersonSql(Name, LastName, Age, Language, CountryId);
                id++;
            }  
        }  
    }
}