using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class BankForm : Account
    {
        private string _login;
        private string _password;
        private string _userName;
        bool Disabled;
        bool enabled;


        public string BankForm(string UserName, string Password):base(Account(string Login, string Password,bool Disabled))
        {
            _userName = UserName;
            _password = Password;
            Disabled = UserName != null;
            if (UserName != null)
            {
                return $"{_userName,_password,disabled}";
            }

        }
    } }
