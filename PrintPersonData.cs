using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    class PrintPersonData
    {
        /// <summary>
        /// Get Person Details and Show them on Console.
        /// </summary>
        /// <param name="Name">Get Person's Name</param>
        /// <param name="LastName"> Get Person's Last Name</param>
        /// <param name="Age">Get Person Age</param>
        /// <param name="Language">Get Person's Language</param>
        /// <param name="Country">Get Person's Country</param>
        /// <param name="Region">Get Person's Country Region</param>
        /// <returns>Show Person Details on console</returns>
        public static string PrintPerson(string Name, string LastName, int Age, string Language, string Country, string Region)
        {
            string ch = new string('-', 20);

            // Prompt user for citizen data.
            var person = new NewPerson();
            Console.WriteLine(ch);
            person.Person.Name = Name;
            person.Person.LastName = LastName;
            person.Person.Age = Age;
            person.Person.Language = Language;
            person.Country.CountryName = Country;
            person.Country.Region = Region;
            person.Print();
            person.Added();
            Console.ReadLine();

            return "";

        }

    }
}
