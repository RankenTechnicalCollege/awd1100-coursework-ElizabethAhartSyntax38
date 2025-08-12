using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
   public class JOB
    {
        private string _name;
        private string _description;
        private string _type;
        public JOB(string Name,string Description,Enum _type)
        {
            _description = Description;
            _name = Name;
            _type = INDUSTRY.Matenance;

        }
    }
}
