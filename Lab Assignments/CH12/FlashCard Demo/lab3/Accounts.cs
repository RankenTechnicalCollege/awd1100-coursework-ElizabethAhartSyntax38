using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3
{
    public class Accounts
    {
        private string _Name;
        private string _AccountNumber;
        private string _PinNumber;
        private Decimal _Balance;
        public Accounts(string Name, string AccountNumber, string PinNumber, Decimal Balance) { }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }

        }
        public string PinNumber
        {
            get { return _PinNumber; }
            set { _PinNumber = value; }
        }
        public Decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
       
    }
}

