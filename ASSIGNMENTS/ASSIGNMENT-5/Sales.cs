using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_5
{
    class SalesDetails
    {
        double SalesNo, ProductNo, Price, Total_Amount = 0;
        DateTime Date_of_sale;
        int qty;
        SalesDetails(double salesno, double productNo, double price)
        {
            this.SalesNo = salesno;
            this.ProductNo = productNo;
            this.Price = price;

        }

        static public void Sales(int qty, SalesDetails obj)
        {
            Console.WriteLine($"Total amount  {obj.Total_Amount = qty * obj.Price}");
        }
        public static void Main(String[] args)
        {
            SalesDetails obj1 = new SalesDetails(1, 2, 50);
            SalesDetails obj2 = new SalesDetails(2, 3, 250);
            SalesDetails obj3 = new SalesDetails(3, 4, 500);
            SalesDetails obj4 = new SalesDetails(4, 5, 600);
            SalesDetails obj5 = new SalesDetails(5, 6, 800);

            Console.WriteLine(" Enter the product no");
            Console.WriteLine("1.Soaps, 2.cosmetics, 3.Footware ,4.Ricebag , 5.Skincare");

            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Soap price {obj1.Price}");
            Console.WriteLine($"Cosmetics price {obj2.Price}");
            Console.WriteLine($"Footwear price {obj3.Price}");
            Console.WriteLine($"Ricebag price  {obj4.Price}");
            Console.WriteLine($"Skincare price {obj5.Price}");
            Console.WriteLine("enter the quantity");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case '1':
                    Sales(n, obj1);
                    break;
                case '2':
                    Sales(n, obj2);
                    break;
                case '3':
                    Sales(n, obj3);
                    break;
                case '4':
                    Sales(n, obj4);
                    break;
                case '5':
                    Sales(n, obj5);
                    break;
                default:
                    Console.WriteLine("Enter correct option");
                    break;
            }
            Console.Read();

        }

    }
}