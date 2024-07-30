using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Citizen
{
    internal class BaseLogger : IPersonLogger
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=CitizenDB;integrated security=true");

        #region Methods

        // Check connecting to SQL
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        /// <summary>
        /// Write to Person's datas to txt file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Name"></param>
        /// <param name="LastName"></param>
        /// <param name="Age"></param>
        /// <param name="Language"></param>
        /// <param name="CountryName"></param>
        /// <param name="CountryRegion"></param>
        /// <param name="CountryId"></param>
        public void WriteToFile(int id, string Name, string LastName, int  Age, string Language, string CountryName, string CountryRegion, int CountryId)
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

                // Open-Create File and Write data to File.
                FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(ch);
                    sw.WriteLine($"{id}. Person:");
                    sw.WriteLine($"Full Name: {Name} {LastName}");
                    sw.WriteLine($"Age: {Age}");
                    sw.WriteLine($"Language: {Language}");
                    sw.WriteLine($"Country: {CountryName}");
                    sw.WriteLine($"Region: {CountryRegion}");
                    sw.WriteLine($"Country Id: {CountryId}");
                    sw.WriteLine(ch);
                    sw.Close();
                }
                Console.WriteLine("New Person's been added to Citizen File.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Person taken information has been added to Sql.
        /// </summary>
        /// <param name="Name">Person's name</param>
        /// <param name="LastName">Person's surname</param>
        /// <param name="Age">Person's age</param>
        /// <param name="Language">Person's nativelanguage</param>
        /// <param name="CountryId">Country id gave by Sql Database</param>
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
            Console.WriteLine("New Person's been added to Sql.");
        }
        #endregion
    }
}

    

    

