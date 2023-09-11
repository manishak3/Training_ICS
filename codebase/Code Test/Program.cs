using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Test
{
    class Program



        {

            public static void multiplication()

            {

                Console.WriteLine("Enter the Number");

                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The Multiplication table for the {num} is");

                for (int i = 0; i <= 10; i++)

                {

                    Console.WriteLine($" {num} * {i} ={num * i}");

                }



            }

            public static void positionsChange()

            {

                Console.WriteLine("Removed position strings :");

                string[] inputs = { "Python", "Python", "Python" };

                int[] positions = { 1, 0, 4 };



                for (int i = 0; i < inputs.Length; i++)

                {

                    string s = inputs[i];

                    int position = positions[i];



                    if (position >= 0 && position < s.Length)

                    {

                        string output = s.Remove(position, 1);

                        Console.WriteLine($"{output}");



                    }

                    else

                    {

                        Console.WriteLine("Invalid Position");

                    }

                }

            }

        }

        class test1

        {

            static void Main(string[] args)

            {

                Program.multiplication();

                Program.positionsChange();

                Console.ReadLine();



            }

        }

    }
