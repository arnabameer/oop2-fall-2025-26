using System;
using System.Globalization;

Console.WriteLine("Mortgage Calculator");

Console.Write("Enter the loan amount: ");
double P = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the annual interest rate (in %): ");
double annualInterestRate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the loan term (in years): ");
int n = Convert.ToInt32(Console.ReadLine());    

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

