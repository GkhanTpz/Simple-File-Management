using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Citizen
{
    interface IPersonDetails
    {
        #region Methods
        void PrintPersonData(string Name, string LastName, int Age, string Language, string CountryName, string CountryRegion, int CountryId);
        void WriteToFile(string Name, string LastName, int Age, string Language, string CountryName, string CountryRegion, int CountryId);
        void AddPersonSql(string Name, string LastName, int Age, string Language, int CountryId);
        #endregion
    }
}
