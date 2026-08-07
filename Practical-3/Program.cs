using System;

namespace ExpenseTrackingModule
{
    class Expense
    {
        public string ExpenseName;
        public double Amount;

        public Expense(string name, double amount)
        {
            ExpenseName = name;
            Amount = amount;
        }

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
            try
            {
                Console.Write("Enter Expense Name : ");
                string name = Console.ReadLine();

                Console.Write("Enter Amount : ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount <= 0)
                {
                    throw new Exception("Amount must be greater than zero.");
                }

                Expense obj = new Expense(name, amount);
                obj.DisplayExpense();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid Input! Please enter numeric value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram Finished Successfully.");
            }

            Console.ReadKey();
        }
    }
}
