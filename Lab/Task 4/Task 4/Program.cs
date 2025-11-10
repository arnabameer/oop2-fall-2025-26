Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine($"After swapping: First number = {a}, Second number = {b}");
