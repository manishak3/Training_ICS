using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESMENT_4
{
    class student
    {
        public string rollnum;
        public string name;
        public string Class;
        public char semester;
        public string branch;
        public int[] marks = new int[5];


        public student(string rollnum, string name, string Class, char semester, string branch)
        {
            this.rollnum = rollnum;
            this.name = name;
            this.Class = Class;
            this.semester = semester;
            this.branch = branch;

        }
        public void displaydetails()
        {
            Console.WriteLine($"rollnum={rollnum},name={name},Class={Class},semester={semester},branch={branch}");

        }

        public void GetMarks()
        {
            Console.WriteLine("Enter the marks of 5 subjects");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void displayresult()
        {
            double totalMarks = 0;
            foreach (int mark in marks)
            {
                totalMarks += mark;
            }
            double averageMarks = totalMarks / marks.Length;


            if (marks.Any(mark => mark < 35))
            {
                Console.WriteLine("Result: Failed ");
            }
            else if (averageMarks < 50)
            {
                Console.WriteLine("Result: Failed )");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }




        public static void Main()
        {
            student details = new student("786", "manisha", "Btech", '8', "cse");
            details.displaydetails();
            details.GetMarks();
            details.displayresult();
            Console.ReadLine();
        }

    }

}

