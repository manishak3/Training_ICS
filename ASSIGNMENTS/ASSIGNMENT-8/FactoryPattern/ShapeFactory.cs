using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public static IShapes ShapeType(string Type)
        {
            IShapes Icc = null;
            if (Type == "Circle")
            {
                Icc = new Circle();
            }
            else if (Type == "Square")
            {
                Icc = new Triangle();
            }
            else if (Type == "Rectangle")
            {
                Icc = new Rectangle();
            }
            return Icc;
        }
    }
}