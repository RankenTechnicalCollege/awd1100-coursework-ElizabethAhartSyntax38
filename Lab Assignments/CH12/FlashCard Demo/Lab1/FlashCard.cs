using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class FlashCard
    {
        private string _name;
        private string _description;
        private string _year;
        public FlashCard() { }
        public FlashCard(string name, string description, string year)
        {
            _name = name;
            _description = description;
            _year = year;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public override string ToString()
        {
            return $"{_name} is a Definition that means {_description} and has a value Year of{_year}";
        }
    }
}
