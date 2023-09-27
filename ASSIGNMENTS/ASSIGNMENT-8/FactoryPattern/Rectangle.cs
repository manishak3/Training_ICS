using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Rectangle : IShapes
    {
        public double length = 3;
        public double width = 2;
        public double GetArea()
        {
            return length*width;
        }

        public double GetCircumference()
        {
            return 2*(length+width);
        }

        public string ShapeType()
        {
            return "Rectangle";
        }
    }
}