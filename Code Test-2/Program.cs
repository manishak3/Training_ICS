using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test_2
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var products = new List<Product>();

         
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"Enter the details of the Product {i}:");
                Product product = new Product();
                product.ProductId = i;
                Console.WriteLine("Product Name: ");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("ProductPrice: ");
                product.ProductPrice = double.Parse(Console.ReadLine());
                products.Add(product);
            }
            products.Sort((product1, product2) => product1.ProductPrice.CompareTo(product2.ProductPrice));
            Console.WriteLine("\n Sorted Products based on Price:");
            foreach (var product in products)
            {
             Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.ProductPrice}");
             Console.ReadLine();
            }
        }
    }
}
