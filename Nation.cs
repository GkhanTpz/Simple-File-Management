using System;
using System.Collections.Generic;
using System.IO;
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

        #region Methods
        public virtual void Added() =>
             Console.WriteLine("Nation has been added.");
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

        #region Methods
        public override void Added() =>
            Console.WriteLine("New Citizen has been added.");
        #endregion
    }
}
