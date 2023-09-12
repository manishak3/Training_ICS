using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESMENT_4
{
    class accounts
    {
        public int accountnum;
        public string CustomerName;
        public string accounttype;



        public accounts(int accountnum, string customerName, string accounttype)
        {
            this.accountnum = accountnum;
            this.CustomerName = customerName;
            this.accounttype = accounttype;

        }
        public void Displaydetails()
        {
            Console.WriteLine($"Account Number :{accountnum}");
            Console.WriteLine($"Your Name :{CustomerName}");
            Console.WriteLine($"Your Account Type:{accounttype}");

        }
        public static void credit()
        {
            Console.WriteLine("Enter the deposited amount:");
            int DepositAmount = Convert.ToInt32(Console.ReadLine());
            int balance = 20000;
            if (DepositAmount <= 0)
            {
                Console.WriteLine("Entered amount is invalid");
            }
            else
            {
                balance = balance + DepositAmount;

                Console.WriteLine("Total Balance is " + balance);
            }
        }
        public static void debit()
        {
            Console.WriteLine("Enter the amount to be debited: ");
            int debitAmount = Convert.ToInt32(Console.ReadLine());
            int balance = 10000;
            if (debitAmount == 0 || debitAmount > 10000)
            {
                Console.WriteLine("Entered amount is invalid");
            }
            else
            {
                balance = balance - debitAmount;

                Console.WriteLine("Total Balance is " + balance);
            }
        }

        class Program
        {

            public static void Main()
            {

                accounts info = new accounts(79845637, "Manisha", "savings account");
                info.Displaydetails();
                Console.WriteLine("Choose Transaction Type: ");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawal");

                Console.WriteLine("Enter your transaction type 1 or 2: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    accounts.credit();
                }
                else if (choice == 2)
                {
                    accounts.debit();
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }

                Console.ReadLine();
            }
        }
    }
}







