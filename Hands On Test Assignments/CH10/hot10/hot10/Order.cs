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
        public string Name => _name;
        public string DescriptionMess => _descriptionMess;
        public Occasions CardOrder => _cardOrder;
        public decimal price { get; set; }
        public Order(string name, bool style,bool cardOrder)
        {
            _name = name;
            if (style == true)
            {
                _envelope = new Style(name, price, Image.FromFile(name));
            }
            if(cardOrder == true)
            {
                _cardOrder = new Occasions(name);
            }
            
        }
    }
}
