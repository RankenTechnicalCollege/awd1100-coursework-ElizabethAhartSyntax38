using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hot10
{
    public class Order
    {
        private string _name;
        private string _descriptionMess;
       private Occasions _cardOrder;
        private Style _envelope;
        private Style _stamp;
      



        public string Name => _name;
        public string DescriptionMess => _descriptionMess;
        public Occasions CardOrder => _cardOrder;
        public double base_price {  get; set; }
        public Style  stamp { get; set; }



        public Order(string name, bool style, bool cardOrder, double price)
        {
            base_price = price;
            _name = name;
            style = true;
            cardOrder = true;
            if (cardOrder == true)
            {
               base_price = base_price + .50;
            }
            else if (style = true)
            {
               base_price= base_price + 2.5;
            }
            else
            {
              base_price=base_price;
            }
        
           
          
                
            
        }

        
    }
}
