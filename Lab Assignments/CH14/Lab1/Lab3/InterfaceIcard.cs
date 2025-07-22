using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   
   public class InterfaceIcard
    {
        private string _name;
        private Image _image;
        
        public InterfaceIcard ShowPicture(string Name, Image Image)
        {
            _name = Name;
            _image = Image;
            return this;
        }
        public string Name {  get { return _name; } }
        public Image Image { get { return _image; } }
        public double Value { get; }
    }
}
