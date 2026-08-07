using System;

namespace ExpenseTrackingModule
{
    // Class to store and display expense details
    class Expense
    {
        public string ExpenseName;
        public double Amount;

        // Constructor to initialize expense name and amount
        public Expense(string name, double amount)
        {
            ExpenseName = name;
            Amount = amount;
        }

        // Method to display expense details
        public void DisplayExpense()
        {
            Console.WriteLine("\nExpense Details");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Expense Name : " + ExpenseName);
            Console.WriteLine("Amount : Rs. " + Amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // try block contains code that may generate an exception
            try
            {
                Console.Write("Enter Expense Name : ");
                string name = Console.ReadLine();

                Console.Write("Enter Amount : ");
                double amount = Convert.ToDouble(Console.ReadLine());

                // Check whether the amount is valid
                if (amount <= 0)
                {
                    throw new Exception("Amount must be greater than zero.");
                }

                // Create an Expense object with valid input
                Expense obj = new Expense(name, amount);
                obj.DisplayExpense();
            }

            // Handles invalid numeric input
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid Input! Please enter numeric value.");
            }

            // Handles other exceptions such as invalid amount
            catch (Exception ex)
            {
                Console.WriteLine("\nError : " + ex.Message);
            }

            // Executes whether an exception occurs or not
            finally
            {
                Console.WriteLine("\nProgram Finished Successfully.");
            }

            Console.ReadKey();
        }
    }
}
