using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{


    public class Matted : Photo
    {
      protected Color _color;
        public override float Price { get { return base.Price+10; } }

        public Matted(float Width, float Height, Color color) : base(Width, Height)
        {
           
            
            _color = color;
          
        }
       
        public override string ToString()
        {  
            return base.ToString()+$"And a Color of {Color}";
        }
        public Color Color { get { return _color; } set{ _color = value; } }

    }
    
}


        
    
        
    
    
    


  
    

    

