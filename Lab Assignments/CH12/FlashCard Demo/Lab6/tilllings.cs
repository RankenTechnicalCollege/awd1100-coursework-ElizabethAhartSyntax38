using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class tilllings
    {
        string _name;
        int _length;
        int _width;
        int _area;
        int _boxes;
        public tilllings() { }
        public tilllings(string name, int length, int width, int area, int boxes)
        {
            _name = name;
            _length = length;
            _width = width;
            _area = area;
            _boxes = boxes;

        }
        public string Name
        {
            get { return _name; }
        }
        public int Length
        {
            get { return _length; }

        }
        public int Width
        {
            get { return _width; }

        }
        public int Area
        {
            get { return _area; }

        }
        public int Boxes
        {
            set { _boxes = Area / 12 + 2; }
        }
        public override string ToString()
        {
            return $"{Area} is this many {boxes}";
           
        }
        private int _Area(int length, int width)
        {
            _area = length * width;
            return length * width;
        }
        private int boxes(int area)
        {
            return (area / 12) + 2;
        }
    }
}




