using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hot10
{
    public class Occasions
    {
        string _name;

        string[] Styles = new string[] { "InLove", "thankYou", "HappyBirthday" };
        public string Name { get { return _name;}set { _name = value; } }
        public Occasions(string Name) { }
    }
}
