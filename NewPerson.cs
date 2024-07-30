using System;


namespace Citizen
{

    internal class NewPerson : Citizen
    {
        #region Fields
        private int _id;
        #endregion

        #region Constructors
        public NewPerson(int id)
        {
            _id = id; // The id is given each new person.
        }
        #endregion

        #region Methods
        public void GetPersonData(string Name, string LastName, int Age, string Language, string CountryName, string CountryRegion, int CountryId)
        {
            // get Person informations for citizen data.
            Person.Name = Name;
            Person.LastName = LastName;
            Person.Age = Age;
            Person.Language = Language;
            Country.CountryId = CountryId;
            Country.CountryName = CountryName;
            Country.CountryRegion = CountryRegion;
        }

        // Print Citizen information to Console.
        public override void PrintCitizen()
        {
            Console.WriteLine("---------------------");
            Console.Write($"{_id}. Person:\n{Person}\n{Country}\n");
        }

        // Show a message that Person's been added correctly.
        public override void AddPersonMessage() =>
            Console.WriteLine("New Person's been added."); 
    }  
    #endregion
}
