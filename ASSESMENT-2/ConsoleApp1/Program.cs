using System;
using  static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program

        {

            static int[] a = new int[5];

            public static void input()

            {

                WriteLine("enter the input marks:.........\n ");

                for (int i = 0; i < a.Length; i++)

                {

                    a[i] = Convert.ToInt32(ReadLine());

                }

                WriteLine("array sorted in asending order:.........\n");

                System.Array.Sort(a);

                for (int j = 0; j < a.Length; j++)

                    WriteLine($"    {a[j]}  ");

                WriteLine("array sorted in desending order..............\n");

                System.Array.Reverse(a);

                for (int k = 0; k < a.Length; k++)

                    WriteLine($" {a[k]} ");


            }

            public static void total()

            {

                int tt = 0;

                for (int k = 0; k < a.Length; k++)

                    tt = tt + a[k];

                WriteLine($" total value {tt}");

                WriteLine($" the maximum value={a.Max()}");

                WriteLine($" the minimum value={a.Min()}");

                WriteLine($" the Average of marks={a.Average()}");

            }

            public static void Main(string[] args)

            {


                input()





                WriteLine(" enter the row size of 2d array ");

                int r = Convert.ToInt32(ReadLine());

                Write(" enter the colomn size\n");

                int c = Convert.ToInt32(ReadLine());

                int[,] arr = new int[r, c];

                WriteLine("enter the input values for  ");

                for (int i = 0; i < r; i++)

                {                                   

                    for (int j = 0; j < c; j++)

                    {                             

                        arr[i, j] = Convert.ToInt32(ReadLine());

                    }

                }

                for (int i = 0; i < r; i++)

                {

                    for (int j = 0; j < c; j++)

                    {

                        Write($" { arr[i, j] } ");

                        Write("\n");

                    }

                }

                Read();





            }

        }

    }

