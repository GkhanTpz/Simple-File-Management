using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    class Nation
    {
        public string NationName { get; set; }
        public string NationLanguage { get; set; }
        public string Region { get; set; }

        public Nation(string nationName, string nationLanguage, string region)
        {
            NationName = nationName;
            NationLanguage = nationLanguage;
            Region = region;
        }
    }
    class Citizen: Nation
    {
        public string CitizenName { get; set; }
        public string CitizenLastName { get; set; }
        public int CitizenAge { get; set; }

        public Citizen(string citizenName, string citizenLastName, int citizenAge, string nationName, string nationLanguage, string region)
            : base(nationName, nationLanguage, region)
        {
            CitizenName = citizenName;
            CitizenLastName = citizenLastName;
            CitizenAge = citizenAge;
        }
    }
}
