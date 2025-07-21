using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Photo:System.Object
    {
        private float _Width;
        private float _Height;
        private float _price;
        public Photo(float Width, float Height)
        {
            _Width = Width;
            _Height = Height;
            if (Width <= 8 && Height <= 10)
            {
                _price = 3.99f;
            }
            else if (Width <= 10 && Height <= 12)
            {
                _price = 5.99f;
            }
            else
            {
                _price = 9.99f;
            }
        
        }
        public float Width { get { return _Width; }set { _Width = value; } }
        public float Height { get { return _Height; }set { _Height = value; } }
     public virtual float Price { get { return _price; }set {_price = value; } }
        public override string ToString()
        {
            return$"The {GetType()} has a Dimension of {Width} and {Height}and a Price of {Price:c}";
        }
    }
}
