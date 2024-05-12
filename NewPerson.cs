using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    public class NewPerson : Citizen, IPersonDetails
    {
        #region Methods
        public override void Print() =>
            Console.Write($"Person:\n" +
                $"{Person}\n{Country}");

        public override void Added() =>
            Console.WriteLine("New Person has been added.");

        public void GetPersonData(string Name, string LastName, int Age, string Language, string Country, string Region)
        {
            string ch = new string('-', 25);

            // Prompt user for citizen data.
            Console.WriteLine(ch);
            Person.Name = Name;
            Person.LastName = LastName;
            Person.Age = Age;
            Person.Language = Language;
            this.Country.CountryName = Country;
            this.Country.Region = Region;
            Print();
            Added();
            Console.ReadLine();
        }

        public void WriteToFile(string Name, string LastName, int Age, string Language, string Country, string Region)
        {
            try
            {
                // Show Path or Citizen File.
                string ch = new string('-', 25);
                string[] currentDirectory = Directory.GetCurrentDirectory().Split('\\');
                string filePath = "";
                for (int i = 0; i <= (currentDirectory.Length) - 3; i++)
                    filePath += currentDirectory[i] + '\\';
                filePath += "citizen.txt";
                Console.WriteLine("File Path: {0}", filePath);

                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(ch);
                    sw.WriteLine("Person:");
                    sw.WriteLine($"Full Name: {Name} {LastName}");
                    sw.WriteLine($"Age: {Age}");
                    sw.WriteLine($"Language: {Language}");
                    sw.WriteLine($"Country: {Country}");
                    sw.WriteLine($"Region: {Region}");
                    sw.WriteLine(ch);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}