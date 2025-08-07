using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ShinyCard 
    {
        private string _name;
        private Image _image;
        private double _value;
        private ImageEditor _font;
        private ImageEditor _backColor;
        private ImageEditor _foreColor;
        public ShinyCard(string Name, Image Image, double Value,ImageEditor Font, ImageEditor BackColor, ImageEditor ForeColor)
        {
            _name = Name;
            _image = Image;
            _backColor = BackColor;
            _foreColor = ForeColor;
            _font = Font;
            _value = Value;
            _backColor = BackColor;

        }
        public ShinyCard ShowCard(string Name, double value, Image Image)
        {
            _name = Name;
            _image = Image;
            _image = Image;
            return this;


        }
        public string Name { get { return _name; } }
        public double Value { get { return _value; } }
        public Image image { get { return _image; } }

        public int CompareTo(NormalCard? InterfaceIcard)
        {
            return 10;
        }
    }
}
