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
        public double base_price { get { return base_price; } }
        public Style  stamp { get; set; }



        public Order(string name, bool style,bool cardOrder,double price)
        {
           
            _name = name;
            if (style)
            {
                _envelope = new Style(name, base_price, Image.FromFile(name));
               
            }
            if(cardOrder)
            {
                _cardOrder = new Occasions(name);
               
            }
           
          
                
            
        }

        public void AddOrder(Order MyOrder)
        {

        }
    }
}
