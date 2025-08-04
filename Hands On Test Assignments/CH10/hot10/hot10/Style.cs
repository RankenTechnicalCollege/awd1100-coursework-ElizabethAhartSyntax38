using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hot10
{
    public class Style:Occasions
    {
      private string _name;
      private double _price;
      private Image _image;
      public string Name { get { return _name; } set { _name = value; } }
      public double Price { get { return _price; } set { _price = value; } }
      public Image Image { get { return _image; } }

        public Style(string Name, double Price, Image Image) : base(Name) 
        {
            _name=Name;
            _price=Price;
            _image=Image;
            Price = 17;
        }

    }
}
