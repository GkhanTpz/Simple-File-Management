using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    public abstract class Citizen
    {
        #region Properties
        public Person Person { get; } = new Person();
        public Country Country { get; } = new Country();
        #endregion

        #region Constructors
        public Citizen()
        {
            Console.WriteLine("\nAdded New Citizen having details below.");
        }
        #endregion

        #region Methods
        public virtual void Print() =>
            Console.Write($"Citizen:\n" +
                $"{Person}\n{Country}\n");
        public virtual void Added() =>
            Console.WriteLine("New Citizen has been added.");
        #endregion
    }

    public sealed class Person
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

    public sealed class Country
    {
        #region Properties
        public string CountryName { get; set; }
        public string Region { get; set; }
        #endregion

        #region Methods
        public override string ToString() =>
            $"Country Name: {CountryName}\n" +
            $"Region: {Region}\n";
        #endregion
    }
}
