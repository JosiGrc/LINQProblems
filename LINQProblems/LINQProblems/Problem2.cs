using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem2
    {
        //Variables
        public List<string> name;

        //Ctor
        public Problem2()
        {
            name = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        }

        //Methods
        //Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates
        public IEnumerable<string> GetNames()
        {
            var names = name;
            var noDuplicates = names.Distinct();
            return noDuplicates;
        }
    }
}
