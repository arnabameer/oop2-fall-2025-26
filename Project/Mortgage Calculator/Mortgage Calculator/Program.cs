using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double salary = 0;
        int creditScore = 0;
        bool criminalRecord = false;
        double P = 0;
        double annualInterestRate = 0;
        int n = 0;

        Console.WriteLine("==Mortgage Calculator==");

        
        while (true)
        {
            Console.Write("Enter your salary: ");
            if (!double.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;
            }
            break; 
        }

        
        while (true)
        {
            Console.Write("Enter your credit score: ");
            if (!int.TryParse(Console.ReadLine(), out creditScore))
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;
            }

            
            if (creditScore <= 300)
            {
                Console.WriteLine("You are not eligible for the loan due to low credit score.");
                return; 
            }
            break; 
        }

        
        while (true)
        {
            Console.Write("Do you have a criminal record? (true/false): ");
            if (!bool.TryParse(Console.ReadLine(), out criminalRecord))
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;
            }

            
            if (criminalRecord)
            {
                Console.WriteLine("You are not eligible for the loan due to criminal record.");
                return; // Exit only if condition fails
            }
            break; 
        }

        
        while (true)
        {
            Console.Write("Enter the loan amount: ");
            if (!double.TryParse(Console.ReadLine(), out P))
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;
            }

            
            if (P > salary * 2)
            {
                Console.WriteLine("You are not eligible for the loan because the loan amount is more than twice your salary.");
                return; 
            }
            break; // Passed eligibility
        }

        
        while (true)
        {
            Console.Write("Enter the annual interest rate (in %): ");
            if (!double.TryParse(Console.ReadLine(), out annualInterestRate))
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;
            }
            break; 
        }

        
        while (true)
        {
            Console.Write("Enter the loan term (in years): ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;
            }
            break; 
        }

        
        double r = annualInterestRate / 100 / 12;
        int N = n * 12;

        double M = P * r * Math.Pow(1 + r, N) / (Math.Pow(1 + r, N) - 1);
        double totalPayment = M * N;
        double totalInterest = totalPayment - P;

        CultureInfo BD = new CultureInfo("bn-BD");

        Console.WriteLine($"\nMonthly Payment: {M.ToString("C", BD)}");
        Console.WriteLine($"Total Payment: {totalPayment.ToString("C", BD)}");
        Console.WriteLine($"Total Interest Paid: {totalInterest.ToString("C", BD)}");
        Console.WriteLine("\nThank you for using the Mortgage Calculator!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
