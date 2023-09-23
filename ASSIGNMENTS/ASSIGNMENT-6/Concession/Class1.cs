using System;

namespace Concession
{
    public class ConcessionCalculator
    {
        public const int TotalFare = 500;

        public string Name { get; set; }
        public int Age { get; set; }

        public ConcessionCalculator(string Name, int Age)
        {
           this. Name = Name;
           this. Age = Age;
        }

        public string CalculateConcession()
        {
            if (Age <= 5)
            {
                return $"Little Champs - Free Ticket , Name: {Name}, Age: {Age}";
            }
            else if (Age >= 60)
            {
                double discountedFare = TotalFare * 0.3;
                return $"Senior Citizen Calculated Fare: {discountedFare} , Name: {Name}, Age: {Age}";
            }
            else
            {
                return $"Ticket Booked - Fare: {TotalFare} , Name: {Name}, Age: {Age}";
            }
        }
    }
}