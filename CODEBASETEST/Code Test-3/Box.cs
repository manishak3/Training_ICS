using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test_3
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box Add(Box box1, Box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;
            return new Box(sumLength, sumBreadth);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

    class BoxTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Box 1: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of Box 1: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of Box 2: ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of Box 2: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            Box box3 = Box.Add(box1, box2);

            Console.WriteLine("Details of Box 1:");
            box1.DisplayDetails();

            Console.WriteLine("Details of Box 2:");
            box2.DisplayDetails();

            Console.WriteLine("Details of Box 3 (Sum of Box 1 and Box 2):");
            box3.DisplayDetails();
            Console.ReadLine();
        }
    }
}
