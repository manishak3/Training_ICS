using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Code_Test
{
    //Using Ado.net classes/methods, insert employee record in the table by invoking the procedure



    class Program
    {

        public static SqlConnection con;
        public static SqlDataReader rread;
        public static SqlCommand cmd;
        static SqlConnection Makeconnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-H8RSBN3;Initial Catalog=Code_Test;" +
                "integrated Security=true");
            con.Open();
            return con;
        }

        static void DataSelect()
        {
            con = Makeconnection();
            cmd = new SqlCommand("Select *from Code_Employee", con);
                    rread = cmd.ExecuteReader();
            while (rread.Read())
            {
                Console.WriteLine("Empno:" + rread[0]);
                Console.WriteLine("Empname:" + rread[1]);
                Console.WriteLine("Empsalary:" + rread[2]);
                Console.WriteLine("Emptype:" + rread[3]);
            }
        }
        static void Insertion()
        {
            con = Makeconnection();
            try
            {
                int empno;
                string empname;
                float empsal;
                string emptype;
                Console.WriteLine("Enter empno,empname,salary,emptype:");
                empno = Convert.ToInt32(Console.ReadLine());
                empname = Console.ReadLine();
                empsal = Convert.ToSingle(Console.ReadLine());
                emptype = Console.ReadLine();
                cmd = new SqlCommand("insert into Code_employee values(@empno,@empname,@empsal,@emptype)", con);
                cmd.Parameters.AddWithValue("@empno", empno);
                cmd.Parameters.AddWithValue("@empname", empname);
                cmd.Parameters.AddWithValue("@empsal", empsal);
                cmd.Parameters.AddWithValue("@emptype", emptype);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("data inserted");
                else
                    Console.WriteLine("error occured");

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            Display();

            Console.ReadLine();
        }
        static void Display()
        {
            con = Makeconnection();
            cmd = new SqlCommand("SELECT * FROM Code_Employee", con);

            SqlDataReader rread = cmd.ExecuteReader();

            Console.WriteLine("Employee Records:");
            while (rread.Read())

            {

                Console.WriteLine($"Employee ID: {rread["empno"]}, Name: {rread["empname"]}, Salary: {rread["empsal"]}, Type: {rread["emptype"]}");

            }

        }





        static void Main()
        {
            DataSelect();
            Insertion();
            Console.Read();
        }
    }

}