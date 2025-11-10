using System;
 
class Program
{
    static void Main()
    {
        double num1, num2, result = 0;
        int choice;
        char again;

        do
        {
            Console.WriteLine("===== Simple Calculator =====");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Choose a calculation method (1-4): ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select between 1-4.");
                    break;
            }

            Console.Write("\nDo you want to perform another calculation? (y/n): ");
            again = Convert.ToChar(Console.ReadLine());
            Console.Clear();

        } while (again == 'y' || again == 'Y');

     
    }
}