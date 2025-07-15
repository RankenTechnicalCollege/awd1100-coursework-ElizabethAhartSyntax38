using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Order
    {
        private string _name;
        private sundae _sundae;
        private Soda _soda;
        public string Name=>_name;
        public Soda Soda => _soda;
        public sundae sundae => _sundae;

        //public SundaeToppings Sundae => _sundae;

        public double Price
        {
            get
            {
                double price = 0;
                if (_soda == null)
                {
                    price = _sundae.Price;
                }
                else if (_sundae == null)
                {
                    price = _soda.Price;
                }
                else
                {
                    price = _sundae.Price + _soda.Price;

                }
                return price;
            }
           
        }
        public Order(string name,bool hasSundae,bool hasSoda)
        {
            _name = name;
            if(hasSundae)
            {
                _sundae = new sundae();
            }
            if (hasSoda)
            {
                _soda = new Soda();
            }
        }
          
        





    }
}
