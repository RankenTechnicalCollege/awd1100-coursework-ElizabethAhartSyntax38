using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Photo
    {
        protected float _Width;
        protected float _Height;

       
        public Photo(float Width, float Height)
        {
            _Width = Width;
            _Height = Height;
            if (Width == 8 && Height == 10)
            {
                Price = 3.99f;
            }
            else if (Width == 10 && Height == 12)
            {
                Price = 5.99f;
            }
            else
            {
                Price = 9.99f;
            }
        
        }
        public float Width { get { return _Width; }set { _Width = value; } }
        public float Height { get { return _Height; }set { _Height = value; } }
     public virtual float Price { get; }
        public override string ToString()
        {
            return$"The {GetType()} has a Dimension of {Width} and {Height}and a Price of {Price:c}";
        }
    }
}
