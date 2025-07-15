using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
   

    public class sundae
    {
        const double Base_Price = 4.50;
        const double Topping_Price = 0.50;
        public int _toppingCount = 0;
        public double _price;
        private SundaeToppings[] _toppings;
    

       public sundae()
        {
            _toppingCount = 0;
            _toppings = new SundaeToppings[2];
            _toppings[1] = SundaeToppings.NONE;
            _price = Base_Price;
            _toppings[0] = SundaeToppings.NONE;
           
            
        }
        public double Price => _price;
        public int ToppingCount => _toppingCount;
        

        public SundaeToppings GetTopping(int index)
        {
            return _toppings[index];
        }
        public void AddToppings(SundaeToppings t)
        {
            _toppings[_toppingCount] = t;           
            _price += Topping_Price;
            _toppingCount++;

        }
    }
}
    
