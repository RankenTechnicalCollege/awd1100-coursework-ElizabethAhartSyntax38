using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class videoGame
    {
        private string _games;
        private string _publisher;
        private float _Price;
        public videoGame(string games, string publisher, float price) { }

        public string Games { get { return _games; } set { _games = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public float Price { get { return _Price; } set { _Price = value; } }
    }
}
   
