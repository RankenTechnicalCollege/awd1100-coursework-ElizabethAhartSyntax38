using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Framed:Photo
    {
        protected Material _material;
        protected Style _style;

        public Framed(float width, float height, Material material, Style style) : base(width, height)
        {
            _material = material;
            _style = style; 
        }
        public override string ToString()
        {
            return base.ToString()+ $" {_material},{_style}";
        }
        public Material Material { get { return _material; }set { _material = value; } }
        public Style Style { get { return _style; } set { _style = value; } }

        public override float Price => base.Price + 25f;


    }
}
