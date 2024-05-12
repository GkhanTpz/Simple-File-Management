using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    interface IPersonDetails
    {
        #region Methods
        void GetPersonData(string Name, string LastName, int Age, string Language, string Country, string Region);
        void WriteToFile(string Name, string LastName, int Age, string Language, string Country, string Region);
        #endregion
    }
}
