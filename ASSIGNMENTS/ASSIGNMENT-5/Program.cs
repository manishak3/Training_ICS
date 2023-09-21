using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Name
    {

        public static void Display(string FirstName, string LastName)
        {
            Console.WriteLine("UPPER CASE");
            Console.WriteLine($"First Name : {FirstName.ToUpper()}");
            Console.WriteLine($"Last Name  :{LastName.ToUpper()}");
        }
         static void Main(string[] args)
        {
          
           Console.WriteLine(" Enter your 1st name");
           String FirstName = Console.ReadLine();

           Console.WriteLine("Enter your 2nd name");
           String LastName = Console.ReadLine();

           Name.Display(FirstName, LastName);

           Console.Read();
        }
    }
}
