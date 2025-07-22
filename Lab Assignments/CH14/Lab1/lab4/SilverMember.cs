using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class SilverMember
    {
        private string _pin;
        private string _accountNumber;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }


        public string Pin { get { return _pin; } set { _pin = value; } }
        public SilverMember(string pin, string account)
        {
        }
    }
}
