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
        public static string PrintPerson(string name, string lastName, int age, string country, string language, string region)
        {
            string ch = new string('-', 20);

            // Prompt user for citizen data.
            var newPerson = new Citizen(name, lastName, age, country, language, region);
            Console.WriteLine(ch);
            Console.WriteLine($"Name: {newPerson.CitizenName}\n" +
                              $"Last Name: {newPerson.CitizenLastName}\n" +
                              $"Age: {newPerson.CitizenAge}\n" +
                              $"Country: {newPerson.NationName}\n" +
                              $"Language: {newPerson.NationLanguage}\n" +
                              $"Region: {newPerson.Region}\n");
            Console.WriteLine(ch);
            newPerson.Added();
            Console.ReadLine();

            return "";

        }

    }
}
