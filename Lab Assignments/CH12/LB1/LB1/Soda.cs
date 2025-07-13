using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
   
    public class Soda
    {
        public const double Base_Price = 1.75;
        public const double Flavor_Price = .15;
        private sodaFlavor _Flavor;
        private double _Price;
        public sodaFlavor Flavor
        {
            get { return _Flavor; }
        }
        public double Price=> Price;
        public Soda()
        {
            _Flavor = sodaFlavor.NONE;
            _Price += Base_Price;
        }
        public void AddFlavor(sodaFlavor f)
        {
            _Flavor = f;
        }
       
    }
}
