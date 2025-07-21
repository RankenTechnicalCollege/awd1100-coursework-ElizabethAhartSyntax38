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
        private DateTime _sendDate;
        private double _price;
        private double _trackingNumber;
        
        public string? Recipient {  get; }=null;
        public DateTime SendDate { get; }
        public double TrackingNumber { get; } 
       
        public virtual double Price {  get;}
        public Letter(string recipient, DateOnly sendDate, double price)
        {
            Recipient = _recipient;
            SendDate = _sendDate;
            Price = _price;
            TrackingNumber = _trackingNumber;
            if(recipient!= null && SendDate != null)
            {
                _price = .50;
                
            }else if (recipient== null|| sendDate==null&& TrackingNumber!=null )
            {
                _price= .50+.15;

            }
            else
            {
                _price = 0;
            }
           
        }


        public override string ToString()
        {
            return $"The {GetType()}. a Recipient of {Recipient} and a Date mailed of {SendDate} with a Price of {Price:c}";
        }
    }
}
