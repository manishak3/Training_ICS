using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_5
{
    class Customer
    {
        private string CustomerID;
        private string Name;
        private int Age;
        private string Phone;
        private string City;


        public Customer()
        {

            this.CustomerID = "";
            this.Name = "";
            this.Age = 0;
            this.Phone = "";
            this.City = "";
        }


        public Customer(string customerID, string name, int age, string phone, string city)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Age = age;
            this.Phone = phone;
            this.City = city;
        }


        public void DisplayCustomer()
        {
            Console.WriteLine("Customer ID: " + this.CustomerID);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Phone: " + this.Phone);
            Console.WriteLine("City: " + this.City);
        }


        ~Customer()
        {

            Console.WriteLine("Customer object deleted.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer("786", "Manisha", 23, "0123456789", "Vizag");


            customer1.DisplayCustomer();


            Customer customer2 = new Customer();


            customer2.DisplayCustomer();
            Console.ReadLine();

        }
    }
}
    

