using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class BMI
    {
        private float _weightInPounds;
        private float _heightInInches;
        private float _bmi;
        private WeightCategory _weightCategory;
        public BMI(float Weight, float Height, float BMI, WeightCategory WeightCategory)
        {
            _weightInPounds = Weight;
            _heightInInches = Height;
            _bmi = BMI;
            _weightCategory = WeightCategory;
        }
        public float Weight { get { return _weightInPounds; } }
        public float Height { get { return _heightInInches; } }
        public float Bmi { get { return _bmi; } }
        public WeightCategory WeightCategory { get { return _weightCategory; } }
       

    }
}
