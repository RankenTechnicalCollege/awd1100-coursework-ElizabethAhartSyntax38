using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class TestScores
    {
        private string _stats;


        public string Stats
        {
            get { return _stats; }
        }
        public TestScores(string stats)
        {
            _stats = stats;
        }
        public string AddTestScores(string score)
        {
            return score;
        }
    }
}
