using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
   

    public class sundae
    {
        private int _toppingCount = 0;
        private double _price;
        const double Base_Price = 4.50;
        const double Topping_Price = 0.50;
        private SundaeToppings[] _toppings;
    

       public void SundaeTopping()
        {
            _toppings = new SundaeToppings[2];
            _price = Base_Price;
            _toppings[0] = SundaeToppings.NONE;
            
        }
        public double Price => _price;
        public SundaeToppings GetTopping(int index)
        {
            return _toppings[index];
        }
        public void AddToppings(SundaeToppings t)
        {
            _toppings[_toppingCount] = t;
            _toppingCount++;
            _price += Topping_Price;


        }
    }
}
    
