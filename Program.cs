using MyProjects;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace MyProjects
{    
    class GetData
    {
        public static void CitizenData()
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = currentDirectory + "\\citizen.txt";
                Console.WriteLine(filePath);
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
               
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("--------------------------------");
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
                    sw.WriteLine("--------------------------------");
                    sw.Close();

                    Citizen newCitizen = new Citizen(name, lastName, age, nation, language, region);
                    Console.WriteLine("\n--------------------------------");
                    Console.WriteLine("Name: {0}\nLast Name: {1}\nAge: {2}\nCountry: {3}\nLanguage: {4}\nRegion: {5}",
                        newCitizen.CitizenName, newCitizen.CitizenLastName, newCitizen.CitizenAge, newCitizen.NationName, newCitizen.NationLanguage, newCitizen.Region);
                    Console.WriteLine("\n--------------------------------");
                    Console.ReadLine();
                }
                  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GetData.CitizenData();
        }
    }
}
