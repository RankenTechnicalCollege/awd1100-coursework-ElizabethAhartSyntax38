using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Account
    {
        private string _Username;
        private string _Password;
        private string _firstName;
        private bool _disabled;
        public Account(string UserName,string Password,string FirstName,bool Disabled) 
        {
            _Username = UserName;
            _Password = Password;
            _firstName = FirstName;
            _disabled = Disabled;
        }
        public string UserName { get { return _Username; } }
        public string Password { get { return _Password; } }
        public string FirstName { get { return _firstName; } }
        public bool isDisabled { get { return _disabled; } }


    }
}
