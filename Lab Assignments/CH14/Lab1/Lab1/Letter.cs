using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Letter:System.Object
    {
        private string _recipient;
        private DateOnly _sendDate;
        private double _price;
        
        public string? Recipient {  get; }=null;
        public DateOnly SendDate { get; }
        public virtual double Price {  get;}
        public Letter(string recipient, DateOnly sendDate, double price)
        {
            Recipient = _recipient;
            SendDate = _sendDate;
            Price = _price;
            if(recipient!= null && SendDate != null)
            {
                _price = .50;
                
            }else if (recipient== null|| sendDate==null)
            {
                return;
            }
           
        }


        public override string ToString()
        {
            return $"The {GetType()}. a Recipient of {Recipient} and a Date mailed of {SendDate} with a Price of {Price:c}";
        }
    }
}
