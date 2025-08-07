using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class NormalCard 
    {
        private string _name;
        private Image _image;
        private double _value;
        public NormalCard(string Name, Image Image, double Value)
        {
            _name = Name;
            _image = Image;
            _value = Value;
        }

        public NormalCard ShowCard(string Name, double Value, Image Image)
        {
            return new NormalCard(Name, Image, Value);
        }



        public string Name { get { return _name; } }
        public double Value { get { return _value; } }
        public Image Image { get { return _image; } }



       


        }
    }
