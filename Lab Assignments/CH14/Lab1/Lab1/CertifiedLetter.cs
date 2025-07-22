using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
  
    public class CertifiedLetter : Letter
    {
        protected string _trackingNumber;
        
        public string TackingNumber { get { return _trackingNumber; } }

        public override double Price { get { return base.Price+.15; } }
        public override string ToString()
        {
            return base.ToString() + $"{_trackingNumber} is the Set Tracking For This Letter\n";
            
        }  
        public CertifiedLetter(string Recipient, DateTime sendDate,string trackingNumber):base( Recipient,sendDate)
        {
          _trackingNumber = trackingNumber;  

        }

    }


}
