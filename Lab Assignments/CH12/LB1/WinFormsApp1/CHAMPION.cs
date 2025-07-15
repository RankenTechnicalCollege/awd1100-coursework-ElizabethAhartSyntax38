using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class CHAMPION
    {
        private string _name;
        private Champion_Type _type;
        private Ability _leftMouse;
        private Ability _rightMouse;
        private Ability _q;
        private Ability _f;
        private Ability _e;

        public CHAMPION(string name, Champion_Type type, Ability leftMouse, Ability rightMouse, Ability q, Ability f, Ability e)
        {
            _name = name;
            _type = type;  
            _leftMouse = leftMouse;
            _rightMouse = rightMouse;
            _q = q;
            _f = f;
            _e = e;


        }
        public string Name { get { return _name; } }
        public Champion_Type Type { get { return _type; } }
       
        public Ability LeftMouse { get { return _leftMouse; } }
        public Ability RightMouse { get { return _rightMouse; } }
        public Ability Q { get { return _q; } }
        public Ability F { get { return _f; } }
        public Ability E { get { return _e; } }
        



    }

}

