using System;

namespace Code_Test_4
{
    delegate int CalculatorDelegate(int number1, int number2);

    class Calculator
    {
        public static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
    }

    class result
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation");
            CalculatorDelegate calculatorDelegate = null;

            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Quit");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                if (choice == 4)
                {
                    Console.WriteLine("Quit");
                    break;
                }

                Console.Write("Enter the first number: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        calculatorDelegate = Calculator.Addition;
                        break;
                    case 2:
                        calculatorDelegate = Calculator.Subtraction;
                        break;
                    case 3:
                        calculatorDelegate = Calculator.Multiplication;
                        break;
                }

                if (calculatorDelegate != null)
                {
                    int result = calculatorDelegate(num1, num2);
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please select a valid operation");
                }
                Console.WriteLine();
            }
        }
    }
}

