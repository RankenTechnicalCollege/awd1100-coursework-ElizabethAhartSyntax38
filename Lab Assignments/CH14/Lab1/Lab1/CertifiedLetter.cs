using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
  
    public class CertifiedLetter : Letter
    {
        private string _trackingNumber;
        
        public string TackingNumber { get { return _trackingNumber; } }
       
        public string? TrackingNumber{ get; set; } = null;
        public override string ToString()
        {
            return base.ToString() + $"{TrackingNumber} is the Set Tracking For This Letter";
            ;
        }  
        public CertifiedLetter(string Recipient, DateOnly sendDate,double Price):base( Recipient,sendDate, Price)
        {
            

        }

    }


}
