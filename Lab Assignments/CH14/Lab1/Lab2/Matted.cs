using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{


    public class Matted:Photo 
    {
        private float _Width;
        private float _Height;
        private float _price;

        public float Price { get { return _price; } }

        public Matted(float Width, float Height, string Color, float Price) : base(Width, Height)
        {
           
            Width = Width;
            Height = Height;
            Color = Color;
            float _price = base.Price + 10;
        }
        public string Color { get; set; }
        public override string ToString()
        {  
            return base.ToString()+$"And a Color of {Color}";
        }
        
    }
    
}


        
    
        
    
    
    


  
    

    

