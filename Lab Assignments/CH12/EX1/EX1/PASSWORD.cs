using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class PASSWORD
    {
        string _Raw;
        string _Hash;

        public string Password { get; }
        public string Hash { get; }
        public PASSWORD(string hash, string passWord)
        {
            _Hash = hash;
            _Raw = passWord;
        }
    }
}
