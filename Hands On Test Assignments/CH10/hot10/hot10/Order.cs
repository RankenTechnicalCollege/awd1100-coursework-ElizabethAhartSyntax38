using System;
using System.Collections.Generic;
using System.Linq;
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
        public double base_price { get; set; }
        public Style  stamp { get; set; }



        public Order(string name, bool style,bool cardOrder)
        {
            base_price = 17;
            _name = name;
            if (style==true)
            {
                _envelope = new Style(name, base_price, Image.FromFile(name));
                base_price = 18;
            }
            if(cardOrder == true)
            {
                _cardOrder = new Occasions(name);
                base_price = 19;
            }
          
                
            
        }
    }
}
