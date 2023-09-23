using System;
using Concession;

namespace Concession_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter your Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Concession.ConcessionCalculator concessionCalculator = new Concession.ConcessionCalculator(Name, Age);
            string result = concessionCalculator.CalculateConcession();

            Console.WriteLine("Result:");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}