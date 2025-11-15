using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double salary = 0;
        int creditScore = 0;
        bool criminalRecord = false;

        Console.WriteLine("==Mortgage Calculator==");

        
        Console.Write("Enter your salary: ");
        if (!double.TryParse(Console.ReadLine(), out salary))
        {
            Console.WriteLine("Invalid input! Try again.");
            return;
        }

        
        Console.Write("Enter your credit score: ");
        if (!int.TryParse(Console.ReadLine(), out creditScore))
        {
            Console.WriteLine("Invalid input! Try again.");
            return;
        }

        
        if (creditScore <= 300)
        {
            Console.WriteLine("You are not eligible for the loan due to low credit score.");
            return;
        }

        
        Console.Write("Do you have a criminal record? (true/false): ");
        if (!bool.TryParse(Console.ReadLine(), out criminalRecord))
        {
            Console.WriteLine("Invalid input! Try again.");
            return;
        }

        
        if (criminalRecord == true)
        {
            Console.WriteLine("You are not eligible for the loan due to criminal record.");
            return;
        }

        
        Console.Write("Enter the loan amount: ");
        if (!double.TryParse(Console.ReadLine(), out double P))
        {
            Console.WriteLine("Invalid input! Try again.");
            return;
        }

        
        if (P > salary * 2)
        {
            Console.WriteLine("You are not eligible for the loan because the loan amount is more than twice your salary.");
            return;
        }

        
        Console.Write("Enter the annual interest rate (in %): ");
        if (!double.TryParse(Console.ReadLine(), out double annualInterestRate))
        {
            Console.WriteLine("Invalid input! Try again.");
            return;
        }

        
        Console.Write("Enter the loan term (in years): ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Invalid input! Try again.");
            return;
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
    }
}
