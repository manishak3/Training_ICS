using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public Student(int id, string name, string dob)
        {
            this.Id = id;
            this.Name = name;
            this.DOB = dob;
        }
    }
    class Info
    {
        public void display(Student student)
        {
            Console.WriteLine($"Id:{student.Id},Name:{student.Name},DOB:{student.DOB}");

        }
    }
    class App
    {
        public void scenario1()
        {
            Student student1 = new Student(786, "Manisha", "01-11-2000");
            Student student2 = new Student(654, "Deepika", "25-08-2002");
            Student student3 = new Student(985, "Swetha", "14-05-2000");
            Student student4 = new Student(345, "Usha", "17-06-2002");
            Info info = new Info();
            info.display(student1);
            info.display(student2);
            info.display(student3);
            info.display(student4);

        }
        public void scenario2()
        {
            Student[] arr = new Student[4];
            arr[0] = new Student(1045, "Manishak", "26-11-1995");
            arr[1] = new Student(1026, "Oshidha", "06-06-2002");
            arr[2] = new Student(1045, "Rehana", "21-05-2000");
            arr[3] = new Student(1075, "Abhi", "03-06-2002");

            Info info = new Info();

            foreach (Student student in arr)
            {
                info.display(student);
            }
        }

        static void Main(string[] args)
        {
            App app = new App();
            app.scenario1();
            app.scenario2();
            Console.ReadLine();
        }
    }
}
