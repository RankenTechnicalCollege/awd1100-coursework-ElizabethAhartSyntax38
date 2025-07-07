using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class CType
    {
        private string _name;
        private string _iPADDRESS;
        private int _Services;
    
    public string Name
        {
            get { return _name; }

        }
        public int Services
        {
            get { return _Services; }
        }
        public string IPAddress
        {
            get { return _iPADDRESS; }

        }
        public CType(string Name, string IPAddress, int Services)
        {
            _name = Name;
            _iPADDRESS = IPAddress;
            _Services = Services;
        }
    }
}
