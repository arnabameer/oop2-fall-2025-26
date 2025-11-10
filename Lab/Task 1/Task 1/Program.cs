Console.Write("Enter first score: ");
int score1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second score: ");
int score2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third score: ");
int score3 = Convert.ToInt32(Console.ReadLine());
double average = (score1 + score2 + score3) / 3.0;
Console.WriteLine($"The average score is: {average}");
