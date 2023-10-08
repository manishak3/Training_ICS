using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASESTUDY
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public Student(int id, string name, DateTime dateofbirth)
        {
            ID = id;
            Name = name;
            DOB = (dateofbirth);
        }
    }

    class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        public Course(int courseId, string courseName)
        {
            CourseID = courseId;
            CourseName = courseName;
        }
    }


    class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
    }

    class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();

        public void Introduce(Course course)
        {
            courses.Add(course);
        }

        public void Register(Student student)
        {
            students.Add(student);
        }

        public Student[] ListOfStudents()
        {
            return students.ToArray();

        }
        public List<Student> ListofStudents()
        {
            return students;
        }

        public List<Course> ListofCourses()
        {
            return courses;
        }


        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }

        public void Enroll(Student student, Course course)
        {
            enrollments.Add(new Enroll(student, course, DateTime.Now));
        }

        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
        public List<Enroll> ListofEnrollments()
        {
            return enrollments;
        }
    }

    class Info
    {

        public void displayStudent(Student student)
        {
            Console.WriteLine($"studentid: {student.ID} name: {student.Name} dateofbirth: {student.DOB.ToShortDateString()}");

        }
        public void Displaycourse(Course course)
        {
            Console.WriteLine($"CourseId: {course.CourseID}  CourseName:{course.CourseName}");



        }
        public static void DisplayEnrollments(Enroll[] enrollments)
        {
            Console.WriteLine("********");
            foreach (var enrollment in enrollments)
            {
                Console.WriteLine($"Student: {enrollment.Student.Name}, Course: {enrollment.Course.CourseName}, Enrollment Date: {enrollment.EnrollmentDate}");
            }
        }


        public interface IUserInterface
        {
            void ShowFirstScreen();
            void ShowStudentScreen();
            void ShowAdminScreen();
            void ShowAllStudentsScreen();
            void ShowStudentRegistrationScreen();
            void IntroduceNewCourseScreen();
            void ShowAllCoursesScreen();
        }


        public class UserInterface : IUserInterface
        {
            private AppEngine appEngine = new AppEngine();

            public void ShowFirstScreen()
            {
                Console.WriteLine("Welcome to SMS (Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Exit");
                Console.Write("Enter your choice (1, 2, or 3): ");
                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        ShowStudentScreen();
                        break;
                    case 2:
                        ShowAdminScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exit program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        ShowFirstScreen();
                        break;
                }
            }

            public void ShowStudentScreen()
            {
                Console.WriteLine("Student Menu:");
                Console.WriteLine("1. View All Courses");
                Console.WriteLine("2. Register for a Course");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowAllCoursesScreen();
                        break;
                    case 2:
                        ShowStudentRegistrationScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exit Student Menu.");
                        ShowFirstScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                        ShowStudentScreen();
                        break;
                }
            }

            public void ShowAdminScreen()
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Introduce New Course");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        IntroduceNewCourseScreen();
                        break;
                    case 2:
                        ShowAllStudentsScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exit Admin Menu.");
                        ShowFirstScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                        ShowAdminScreen();
                        break;
                }
            }

            public void ShowAllStudentsScreen()
            {
                Console.WriteLine("List of Students:");
                App.scenario1();
                App.scenario2();
                foreach (Student student in appEngine.ListOfStudents())
                {
                    Console.WriteLine($"Student ID: {student.ID}, Name: {student.Name}, Date of Birth: {student.DOB.ToShortDateString()}");
                }
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowAdminScreen();
            }

            public void ShowStudentRegistrationScreen()
            {
                Console.Write("Enter Student ID: ");
                int studentID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student Name: ");
                string studentName = Console.ReadLine();
                Console.Write("Enter Student Date of Birth (yyyy-MM-dd): ");
                DateTime studentDOB = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter cousre Id: ");
                int courseId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter course name: ");
                string courseName = Console.ReadLine();

                appEngine.Register(new Student(studentID, studentName, studentDOB));
                appEngine.Introduce(new Course(courseId, courseName));
                Console.WriteLine("Student registered successfully.");
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowStudentScreen();
            }

            public void IntroduceNewCourseScreen()
            {
                Console.Write("Enter Course ID: ");
                int courseId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Course Name: ");
                string courseName = Console.ReadLine();

               
                appEngine.Introduce(new Course(courseId, courseName));
                Console.WriteLine("Course introduced successfully.");
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowAdminScreen();
            }

            public void ShowAllCoursesScreen()
            {
                Console.WriteLine("List of Courses:");
                App.courses();
                foreach (Course course in appEngine.ListOfCourses())
                {
                    Console.WriteLine($"Course ID: {course.CourseID}, Name: {course.CourseName}");
                }
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowStudentScreen();
            }
        }

        public class App
        {
            public static void scenario1()
            {

                Student obj1 = new Student(786, "Manisha", new DateTime(2000, 11, 01));
                Student obj2 = new Student(723, "Swetha", new DateTime(2000, 05, 13));
                Student obj3 = new Student(755, "usha", new DateTime(2002, 04, 19));
                Info info = new Info();
                info.displayStudent(obj1);
                info.displayStudent(obj2);
                info.displayStudent(obj3);
            }
            public static void scenario2()
            {

                Student[] array = new Student[3];
                array[0] = new Student(726, "Rehana", new DateTime(2002, 06, 29));
                array[1] = new Student(745, "Habidha", new DateTime(2001, 09, 16));
                array[2] = new Student(763, "oshidha", new DateTime(2002, 04, 06));

                Info info = new Info();

                foreach (Student student in array)
                {
                    info.displayStudent(student);


                }
            }
            public static void courses()
            {
                Course course1 = new Course(1, "CSharp");
                Course course2 = new Course(2, "SQL");
                Course course3 = new Course(3, "Java");
                
                Info info = new Info();
                info.Displaycourse(course1);
                info.Displaycourse(course2);
                info.Displaycourse(course3);
              
               
            }
            static void Main(string[] args)
            {

                AppEngine appEngine = new AppEngine();

                Course course1 = new Course(1, "CSharp");
                Course course2 = new Course(2, "SQL");
                appEngine.Introduce(course1);
                appEngine.Introduce(course2);

                Student student1 = new Student(786, "Manisha", new DateTime(2002, 08, 25));
                Student student2 = new Student(723, "Swetha", new DateTime(2001, 12, 26));
                appEngine.Register(student1);
                appEngine.Register(student2);

                appEngine.Enroll(student1, course1);
                appEngine.Enroll(student2, course2);

                Enroll[] enrollments = appEngine.ListOfEnrollments();

                Console.WriteLine("Enrollments:");
                Info.DisplayEnrollments(enrollments);
                Console.WriteLine("\n**********\n");

                new UserInterface().ShowFirstScreen();

            }
        }
    }
}