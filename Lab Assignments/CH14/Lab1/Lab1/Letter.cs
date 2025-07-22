using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Letter:System.Object
    {
       protected string _recipient;
       protected DateTime _sendDate;
        
        
        public string Recipient { get { return _recipient; } }
        public DateTime SendDate { get { return _sendDate; } }


        public virtual double Price { get; } = .5;
        public Letter(string recipient, DateTime sendDate)
        {
            _recipient = recipient;
            _sendDate = sendDate;
           
           
        }


        public override string ToString()
        {
            return $" a Recipient of {_recipient} and a Date mailed of {_sendDate} with a Price of {Price:c}\n";
        }
    }
}
