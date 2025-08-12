using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10_LAB1_SUPERHERODATABASE
{
  public class SUPERHERO
    {
        private string _name;
        private string _description;
        private string _year;

        public string Name {  get { return _name; } }
        public string Description { get { return _description; } }
        public string Year { get { return _year; } }
         public SUPERHERO(string Name, string Description,string Year)
        {
            Name = Name;
            Description = Description;
            Year=Year;
            return;
        }  

    }
}
