using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Circle : IShapes
    {
        public double r = 5;
        public double GetArea()
        {
            return Math.PI*r*r;
        }

        public double GetCircumference()
        {
            return Math.PI*2*r;
        }

        public string ShapeType()
        {
            return "Circle";
        }
    }
}