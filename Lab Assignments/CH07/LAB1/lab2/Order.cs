using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Order
    {
        short _itemNumber;
        byte _quantity;
        byte _estimatedDeliveryDays;
        public Order(short ItemNumber, byte Quantity, byte EstimatedDeliveryDays)
        {
            _itemNumber = ItemNumber;
            _quantity = Quantity;
            _estimatedDeliveryDays = EstimatedDeliveryDays;
        }
       public short itemNumber { get { return _itemNumber; } set { _itemNumber = value; } }
        public byte quantity { get { return _quantity; } set { _quantity = value; } }
        public byte estimatedDeliveryDays { get { return _estimatedDeliveryDays; }set { _estimatedDeliveryDays = value; } }
    }
} 
