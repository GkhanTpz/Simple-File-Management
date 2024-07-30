using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;


namespace Citizen
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;


            while (true)
            {
                string Name, LastName, Language, CountryName, CountryRegion;
                int Age, CountryId;

                // Check if integer variables are correct format or not.
                if (!PromptPersonData(out Name, out LastName, out Age, out Language, out CountryName, out CountryRegion, out CountryId))
                {
                    Console.WriteLine("Invalid input. Please enter the correct format for Age and Country Id.");
                    continue;
                }
               
                NewPerson newPerson = new NewPerson(id);
                newPerson.GetPersonData(Name, LastName, Age, Language, CountryName, CountryRegion, CountryId);
                newPerson.PrintCitizen();
                newPerson.AddPersonMessage();
                SavePersonData(id, Name, LastName, Age, Language, CountryName, CountryRegion, CountryId);

                // It breaks loop.
                Console.WriteLine("Press Enter to continue or type 'exit' to quit.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }

                id++;
            }
        }

        /// <summary>
        /// This function helps getting person informations from Console.
        /// </summary>
        /// <param name="Name">Person's name</param>
        /// <param name="LastName">Person's surname</param>
        /// <param name="Age">Person's age</param>
        /// <param name="Language">Person's native language</param>
        /// <param name="CountryName">Person's country name</param>
        /// <param name="CountryRegion">Region of country</param>
        /// <param name="CountryId">Country id gave by Sql Database</param>
        private static bool PromptPersonData(out string Name, out string LastName, out int Age, out string Language, out string CountryName, out string CountryRegion, out int CountryId)
        {
            Console.Write("Please enter your Name: ");
            Name = Console.ReadLine();

            Console.Write("Please enter your Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("Please enter your Age: ");    
            if (!int.TryParse(Console.ReadLine(), out Age))
            {
                Console.WriteLine("Invalid Age input. Please enter a valid number.");
                CountryId = 0; Language = CountryName = CountryRegion = null;
                return false;
            }

            Console.Write("Please enter your Language: ");
            Language = Console.ReadLine();

            Console.Write("Please enter your Country: ");
            CountryName = Console.ReadLine();

            Console.Write("Please enter your Country Region: ");
            CountryRegion = Console.ReadLine();

            Console.Write("Please enter your Country Id: ");
            if (!int.TryParse(Console.ReadLine(), out CountryId))
            {
                Console.WriteLine("Invalid Country Id input. Please enter a valid number.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// This function holds informations and manages them write to file and add to sql correctly.
        /// </summary>
        /// <param name="id">Person's id</param>
        /// <param name="Name"> Person's name</param>
        /// <param name="LastName">Person's surname</param>
        /// <param name="Age">Person's age</param>
        /// <param name="Language">Person's native language</param>
        /// <param name="CountryName">Person's country</param>
        /// <param name="CountryRegion">Region of country</param>
        /// <param name="CountryId">Country id gave by Sql Database</param>
        private static void SavePersonData(int id, string Name, string LastName, int Age, string Language, string CountryName, string CountryRegion, int CountryId)
        {
            IPersonLogger logger = new BaseLogger();

            try
            {
                // Write to File.
                logger.WriteToFile(id, Name, LastName, Age, Language, CountryName, CountryRegion, CountryId);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }

            try
            {
                // Add to SQL.
                logger.AddPersonSql(Name, LastName, Age, Language, CountryId);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while accessing the database: " + ex.Message);
            }
        }
    }
}