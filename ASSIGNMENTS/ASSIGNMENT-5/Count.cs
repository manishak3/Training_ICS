using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_5
{
    class Count
    {
       public  static void Character()
        {
            Console.WriteLine("Enter the message ");
            string msg = Console.ReadLine();
            Console.WriteLine("Enter the letter to be counted");
            Char C = Char.Parse(Console.ReadLine());
            int count = 0;
            foreach (char c in msg)

                if (c == C)
                {
                    count++;
                }
            Console.WriteLine("Total count:"+count);
        }

       public  static void Main(string[] args)
        {
            Count.Character();
            Console.Read();
        }
    }
}

    

