using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problem3
    {
        //Variables
        public List<string> classGrade;

        //Ctor
        public Problem3()
        {
            classGrade = new List<string>() {"80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55"};
        }

        //Expected result is 86.125
        //Methods
        public int GetClassAverage()
        {
            var classAverage = classGrade;
            //make a for loop that goes through each indecies of the list
            var gettingAverage = classAverage.OrderByDescending(n => n).Take(n => n.Count - 1);
            return gettingAverage;

            return 0;
        }
    }
}

