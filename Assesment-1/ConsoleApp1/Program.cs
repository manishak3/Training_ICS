using System;
using static System.Console;
using System.Collections.Generic;
using System
namespace ConsoleApp1
{
    class Program
    {
         int a, b;
        public static void equal()
        {
            WriteLine(" enter the number1");
            a = Convert.ToInt32(Console.ReadLine());
            WriteLine("enter the number2");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                WriteLine(" equal");
            }
            else
            {
                WriteLine(" not equal");
            }



        }
        public static void negative(params int[] args)
        {
            fo (int i in args)
            {
                if (i < 0)
                {
                    WriteLine($" {i} is negative ");
                }
                else
                {
                    WriteLine($" {i} is positive ");
                }
            }
        }
        public static void operation()
        {
            WriteLine(" enter the values for operation");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int add = a + b;
            int sub = a - b;
            int multiplication = a * b;
            float division = a / b;
            WriteLine($"sum {add} difference {sub} product {multiplication} division {division}");
        }
        static void Main(string[] args)
        {
            equal();
            operation();
            negative(14);
            Read();





        }
    }
}

