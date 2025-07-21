using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class ShortTerm_Loan
    {
        private string _name;
        private int _amount;
        private int _balance;
        private string _type;
        public string Name { get { return _name; } }
        public int Amount { get { return _amount; } }
        public string Type { get { return _type; } }
        public int Balance { set { _balance = _amount; } }
        public virtual string CreateLoanShort(string name, int amount)
        {
            return name + $"Your Loan Amount is Your New Balance{amount}";
        }
    }
}
