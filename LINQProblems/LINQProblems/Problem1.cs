using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem1
    {
        //Varibales
        public List<string> word;
        

        //ctor
        public Problem1()
        {
            word = new List<string>() {"the", "bike", "this", "it", "tenth", "mathematics" };
        }

        //Methods
        //Using LINQ, write a function that returns all words that contain the substring “th” from a list
        public IEnumerable<string> GetWords()
        {
            var words = word;
            var WordsWithTh = words.Where(w => w.Contains("th"));
            return WordsWithTh;
        }
        


    }
}
