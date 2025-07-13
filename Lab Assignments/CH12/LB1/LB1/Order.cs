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
        private  sundae _sundae;
        private Soda _soda;
        public string Name=>_name;
        public Soda Soda => _soda;

        //public SundaeToppings Sundae => _sundae;

        public double Price
        {
            get
            {
                return ((double)_sundae.Price) + (double)_soda.Price;
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
           public sundae sundae => _sundae;
        





    }
}
