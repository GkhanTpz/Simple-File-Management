using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    class File
    {
        #region Methods
        /// <summary>
        /// Write Citizen Details to citizen.txt.
        /// </summary
        public static string WriteToFile(string name, string lastName, int age, string language, string country,  string region)
        {
            try
            {
                // Show Path or Citizen File.
                string ch = new string('-', 20);
                string[] currentDirectory = Directory.GetCurrentDirectory().Split('\\');
                string filePath = "";
                for (int i = 0; i <= (currentDirectory.Length) - 3; i++)
                    filePath += currentDirectory[i] + '\\';
                filePath += "citizen.txt";
                Console.WriteLine("File Path: {0}", filePath);

                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(ch);
                    sw.WriteLine(name);
                    sw.WriteLine(lastName);
                    sw.WriteLine(age);
                    sw.WriteLine(language);
                    sw.WriteLine(country);
                    sw.WriteLine(region);
                    sw.WriteLine(ch);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
        #endregion
    }
}
