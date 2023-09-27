using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static IShapes GetShapesType(string shapeType)
        {
            IShapes Icc = null;
            if (shapeType == "Circle")
            {
                Icc = new Circle();
            }
            else if (shapeType == "Triangle")
            {
                Icc = new Triangle();
            }
            else if (shapeType == "Rectangle")
            {
                Icc = new Rectangle();
            }
            return Icc;
        }
    }
}