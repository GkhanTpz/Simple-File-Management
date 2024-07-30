namespace Citizen
{
    interface IPersonLogger
    {
        #region Methods
        void WriteToFile(int id, string Name, string LastName, int Age, string Language, string CountryName, string CountryRegion, int CountryId);
        void AddPersonSql(string Name, string LastName, int Age, string Language, int CountryId);
        #endregion
    }
}
