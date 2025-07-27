using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class TestStatistics
    {
        public int _count;
        public float _sum;
        public float _avg;
        public float _min;
        public float _max;
    
    public TestStatistics(int count,float sum,float min,float max,float Average) { }
   public int Count { get { return _count; } }
        public float Sum { get { return _sum; } }
        public float Min { get { return _min; } }
        public float Max { get { return _max; } }
        public float Average { get { return _avg; } }
      
        
    }
}
