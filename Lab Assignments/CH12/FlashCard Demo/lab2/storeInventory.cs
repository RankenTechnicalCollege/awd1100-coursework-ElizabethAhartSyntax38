using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class storeInventory
    {

        private decimal _unitsPerCase;
        private decimal _unitPrice;
        private int _InventoryNumber;
        public string InventoryName { get; set; }


        public Decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        public int InventoryNumber
        {
            get { return _InventoryNumber; }
            set { _InventoryNumber = value; }

        }


        public Decimal UnitsPerCase
        {
            set { _unitsPerCase = 144; }
        }
        

        
         public override string ToString()
        {
            return $"The INVENTORY NUMBER: {InventoryNumber} The Inventory Name is {InventoryName} and The Price Per Unit is {_unitsPerCase}";
        }
    }
}