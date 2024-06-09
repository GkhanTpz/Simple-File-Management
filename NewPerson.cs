using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Citizen
{
    class NewPerson : Citizen, IPersonDetails
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=CitizenDB;integrated security=true");

        #region Fields
        private int _id;
        #endregion

        #region Constructors
        public NewPerson(int id)
        {
            _id = id;
        }
        #endregion

        #region Methods
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public override void PrintCitizen()
        {
            Console.Write($"{_id}. Person:\n{Person}\n{Country}\n");
        }

        public override void AddPersonMessage() =>
            Console.WriteLine("New Person has been added.");

        public void PrintPersonData(string Name, string LastName, int Age, string Language, string CountryName, string CountryRegion, int CountryId)
        {
            string ch = new string('-', 25);

            // Prompt user for citizen data.
            Console.WriteLine(ch);
            Person.Name = Name;
            Person.LastName = LastName;
            Person.Age = Age;
            Person.Language = Language;
            Country.CountryId = CountryId;
            Country.CountryName = CountryName;
            Country.CountryRegion = CountryRegion;
            PrintCitizen();
            AddPersonMessage();
            Console.ReadLine();
        }

        public void WriteToFile(string Name, string LastName, int Age, string Language, string CountryName, string CountryRegion, int CountryId)
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

                // Open/Create File and Write data to File.
                FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(ch);
                    sw.WriteLine($"{_id}. Person:");
                    sw.WriteLine($"Full Name: {Name} {LastName}");
                    sw.WriteLine($"Age: {Age}");
                    sw.WriteLine($"Language: {Language}");
                    sw.WriteLine($"Country: {CountryName}");
                    sw.WriteLine($"Region: {CountryRegion}");
                    sw.WriteLine($"Country Id: {CountryId}");
                    sw.WriteLine(ch);
                    sw.Close();
                }
                Console.WriteLine("New Person added to Citizen File.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void AddPersonSql(string Name, string LastName, int Age, string Language, int CountryId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Person values(@Name, @Surname, @Age, @Language, @CountryId)", _connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Surname", LastName);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@Language", Language);
            command.Parameters.AddWithValue("@CountryId", CountryId);
            command.ExecuteNonQuery();
            _connection.Close();
            Console.WriteLine("New Person added to Sql.");
        }
    }
    #endregion
}
