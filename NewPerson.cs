using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjects
{
    public class NewPerson : Citizen
    {
        #region Methods
        public override void Print() =>
            Console.Write($"Person:\n" +
                $"{Person}\n{Country}");

        public override void Added() =>
            Console.WriteLine("New Person has been added.");
        #endregion

    }
}
