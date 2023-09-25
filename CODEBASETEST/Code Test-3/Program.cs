using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test_3
{
    class Cricket
    {
        public void Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int sum = 0;

            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score of the match {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine());
                sum += scores[i];
            }

            double average = (double)sum / no_of_matches;

            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average of scores: {average}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of matches: ");
            int no_of_matches = int.Parse(Console.ReadLine());

            Cricket score = new Cricket();
            score.Pointscalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}