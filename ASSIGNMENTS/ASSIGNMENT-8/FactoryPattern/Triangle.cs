using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Triangle : IShapes
    {
        public int h = 4,b=2;
        public int a = 5, c = 3;

        public double GetArea()
        {
            return 0.5*b*h;
        }

        public double GetCircumference()
        {
            return a+b+c;
        }

        public string ShapeType()
        {
            return "Triangle";
        }
    }
}