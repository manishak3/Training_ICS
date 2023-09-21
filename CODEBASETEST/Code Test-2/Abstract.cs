using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
      abstract class Student
      {
       public string Name;
       public int StudentId;
       public double Grade;
        public abstract Boolean Ispassed(double Grade);
        public void Undergrad(string Name, int StudentId, double Grade)
        {
            this.Name = Name;
            this.StudentId = StudentId;
            this.Grade = Grade;
        }

    }

    class Undergrade : Student
    {

        public override Boolean Ispassed(double grade)
        {
            return grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public override Boolean Ispassed(double grade)
        {
            return grade > 80.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var undergrad = new Undergrade();
            undergrad.Name = "Manisha";
            undergrad.StudentId = 786;
            undergrad.Grade = 8.0;

            var grade = new Graduate();
            grade.Name = "Swetha";
            grade.StudentId = 1055;
            grade.Grade = 9.0;
            Console.WriteLine($"Name:{undergrad.Name},StudentId:{ undergrad.StudentId} passed: {undergrad.Ispassed(undergrad.Grade)}");
            Console.WriteLine($"Name:{grade.Name},StudentId:{grade.StudentId} passed: {grade.Ispassed(grade.Grade)}");

            Console.ReadLine();

        }
    }
}
