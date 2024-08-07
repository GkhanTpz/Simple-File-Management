using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Citizen
{
    abstract class Citizen
    {
        #region Properties
        public Person Person { get; } = new Person();
        public Country Country { get; } = new Country();
        #endregion


        #region Methods
        public abstract void PrintCitizen();
        public abstract void AddPersonMessage();
        #endregion
    }

    sealed class Person
    {
        #region Properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Language { get; set; }

        #endregion

        #region Methods
        public override string ToString() =>
            $"Full Name: {Name} {LastName}\n" +
            $"Age: {Age}\n" +
            $"language: {Language}";
        #endregion
    }

    sealed class Country
    {
        #region Properties  
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryRegion { get; set; }
        #endregion

        #region Methods
        public override string ToString() =>
            $"Country Name: {CountryName}\n" +
            $"Region: {CountryRegion}\n" +
            $"Country Id: {CountryId}";
        #endregion
    }
}
