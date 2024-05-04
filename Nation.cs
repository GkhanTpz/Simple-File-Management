using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    class Nation
    {
        #region Fields
        private string nationName, nationLanguage, region;
        #endregion

        #region Properties
        public string NationName { get; set; }
        public string NationLanguage { get; set; }
        public string Region { get; set; }
        #endregion

        #region Constructors
        public Nation(string nationName, string nationLanguage, string region)
        {
            NationName = nationName;
            NationLanguage = nationLanguage;
            Region = region;
        }
        #endregion
    }

    class Citizen: Nation
    {
        #region Fields
        private string citizenName, citizenLastName;
        private int citizenAge;
        #endregion

        #region Properties
        public string CitizenName { get; set; }
        public string CitizenLastName { get; set; }
        public int CitizenAge { get; set; }
        #endregion

        #region Constructors
        public Citizen(string citizenName, string citizenLastName, int citizenAge, string nationName, string nationLanguage, string region)
            : base(nationName, nationLanguage, region)
        {
            CitizenName = citizenName;
            CitizenLastName = citizenLastName;
            CitizenAge = citizenAge;
        }
        #endregion
    }

    class GetData
    {
        #region Methods
        /// <summary>
        /// Get and Show Citizen Details.
        /// </summary>
        public static void CitizenData()
        {
            try
            {
                // Show Path or Citizen File.
                string[] currentDirectory = Directory.GetCurrentDirectory().Split('\\');
                string filePath = "";
                for (int i = 0; i <= (currentDirectory.Length) - 3; i++)
                    filePath += currentDirectory[i] + '\\';
                filePath += "citizen.txt";
                Console.WriteLine("File Path: {0}", filePath);
        
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(new String('-',20);
                    Console.Write("Please enter a Citizen Name: ");
                    string name = Console.ReadLine();
                    sw.WriteLine(name);

                    Console.Write("Please enter a Citizen Last Name: ");
                    string lastName = Console.ReadLine();
                    sw.WriteLine(lastName);

                    Console.Write("Please enter a Citizen Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine(age);

                    Console.Write("Please enter a Citizen Nation: ");
                    string nation = Console.ReadLine();
                    sw.WriteLine(nation);

                    Console.Write("Please enter a Citizen Language: ");
                    string language = Console.ReadLine();
                    sw.WriteLine(language);

                    Console.Write("Please enter Region: ");
                    string region = Console.ReadLine();
                    sw.WriteLine(region);
                    sw.WriteLine();
                    sw.Close();

                    Citizen newCitizen = new Citizen(name, lastName, age, nation, language, region);
                    Console.WriteLine(new String('-', 20));
                    Console.WriteLine($"Name: {newCitizen.CitizenName}\n" +
                                      $"Last Name: {newCitizen.CitizenLastName}\n" +
                                      $"Age: {newCitizen.CitizenAge}\n" +
                                      $"Country: {newCitizen.NationName}\n" +
                                      $"Language: {newCitizen.NationLanguage}\n" +
                                      $"Region: {newCitizen.Region}");
                    Console.WriteLine();
                    Console.ReadLine();
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
