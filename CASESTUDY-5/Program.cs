using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

    namespace CaseStudy_5
    {
    public class Student
    {
        public int stdID { get; set; }
        public string stdName { get; set; }
        public string stdDOB { get; set; }
    }

    public class Course
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
    }
    public class Enrollment
    {
        public Student student { get; set; }
        public Course course { get; set; }
        public string EnrollDate { get; set; }
    }

    class Program
    {

        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlCommand cmd;
        static SqlConnection Getconnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-H8RSBN3;Initial Catalog=CaseStudy;" +
                "integrated Security=true");
            con.Open();
            return con;
        }

        static void selectS()
        {
            con = Getconnection();
            cmd = new SqlCommand("Select *from student", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("student id:" + dr[0]);
                Console.WriteLine("Student name:" + dr[1]);
                Console.WriteLine("Student dob:" + dr[2]);

            }
        }
        static void selectC()
        {
            con =Getconnection();
            cmd = new SqlCommand("Select *from course", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("course id:" + dr[0]);
                Console.WriteLine("course name:" + dr[1]);


            }
        }
        static void selectE()
        {
            con =Getconnection();
            cmd = new SqlCommand("Select *from Enrollment", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("student id:" + dr[0]);
                Console.WriteLine("course id:" + dr[1]);
                Console.WriteLine("Student name:" + dr[2]);
                Console.WriteLine("Student dob:" + dr[3]);
                Console.WriteLine("course name:" + dr[4]);
                Console.WriteLine("Enrollment date:" + dr[5]);

            }
        }
        static void InsertStd()
        {
            con =Getconnection();
            try
            {
                int stdID;
                string stdName;
                string stdDOB;
                Console.WriteLine("Enter stdID,stdName,stdDOB:");
                stdID = Convert.ToInt32(Console.ReadLine());
                stdName = Console.ReadLine();
                stdDOB = Console.ReadLine();
                cmd = new SqlCommand("insert into student values(@stdID,@stdName,@stdDOB)", con);
                cmd.Parameters.AddWithValue("@stdID", stdID);
                cmd.Parameters.AddWithValue("@stdName", stdName);
                cmd.Parameters.AddWithValue("@stdDOB", stdDOB);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data Inserted");
                else
                    Console.WriteLine("Error Occured");

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        static void InsertC()
        {
            con =Getconnection();
            try
            {
                int Cid;
                string Cname;
                Console.WriteLine("Enter Cid,cname:");
                Cid = Convert.ToInt32(Console.ReadLine());
               Cname = Console.ReadLine();
                cmd = new SqlCommand("insert into course values(@Cid,@Cname)", con);
                cmd.Parameters.AddWithValue("@Cid", Cid);
                cmd.Parameters.AddWithValue("@Cname",Cname);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data Inserted");
                else
                    Console.WriteLine("Error Occured");

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        static void InsertEnroll()
        {
            con =Getconnection();
            try
            {
                int stdID;
                int Cid;
                string stdName;
                string stdDOB;
                string Cname;
                string EnrollDate;

                Console.WriteLine("Enter stdID,Cid,stdName,stdDOB,cname,EnrollDate:");
                stdID = Convert.ToInt32(Console.ReadLine());
                Cid = Convert.ToInt32(Console.ReadLine());
                stdName = Console.ReadLine();
                stdDOB = Console.ReadLine();
               Cname = Console.ReadLine();
                EnrollDate = Console.ReadLine();
                cmd = new SqlCommand("insert into Enrollment values(@stdID,@Cid,@stdName,@stdDOB,@cname,@EnrollDate)", con);
                cmd.Parameters.AddWithValue("@stdID", stdID);
                cmd.Parameters.AddWithValue("@Cid", Cid);
                cmd.Parameters.AddWithValue("@stdName", stdName);
                cmd.Parameters.AddWithValue("@stdDOB", stdDOB);
                cmd.Parameters.AddWithValue("@cname",Cname);
                cmd.Parameters.AddWithValue("@EnrollDate", EnrollDate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data Inserted");
                else
                    Console.WriteLine("Error Occured");

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static void ShowFirstScreen()
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
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    ShowFirstScreen();
                    break;
            }
        }

        public static void ShowStudentScreen()
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
                    Console.WriteLine("Exiting Student Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                    ShowStudentScreen();
                    break;
            }
        }

        public static void ShowAdminScreen()
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
                    Console.WriteLine("Exiting Admin Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                    ShowAdminScreen();
                    break;
            }
        }
        public static void ShowAllStudentsScreen()
        {
            Console.WriteLine("List of Students:");
            selectS();

            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowAdminScreen();
        }

        public static void ShowStudentRegistrationScreen()
        {
            InsertStd();
            InsertEnroll();
            Console.WriteLine("Student registered successfully.");
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowStudentScreen();
        }

        public static void IntroduceNewCourseScreen()
        {



            InsertC();
            Console.WriteLine("Course introduced successfully.");
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowAdminScreen();
        }

        public static void ShowAllCoursesScreen()
        {
            Console.WriteLine("List of Courses:");
            selectC();
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowStudentScreen();
        }



        static void Main()
        {

            ShowFirstScreen();
            Console.Read();
        }
    }
}
