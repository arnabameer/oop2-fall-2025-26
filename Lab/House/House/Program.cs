using System;

public class House
{
    private int yearBuilt;
    private double size;

    
    public House(int yearBuilt, double size)
    {
        this.yearBuilt = yearBuilt;
        this.size = size;
    }

    
    public int YearBuilt
    {
        get { return yearBuilt; }
        private set { yearBuilt = value; }
    }

    public double Size
    {
        get { return size; }
        private set { size = value; }
    }

    
    public int GetHouseAge()
    {
        return DateTime.Now.Year - yearBuilt;
    }

    
    public bool CanBeSold()
    {
        return GetHouseAge() > 15;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the year the house was built: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of the house: ");
        double size = double.Parse(Console.ReadLine());

        House house = new House(year, size);

        int age = house.GetHouseAge();
        Console.WriteLine($"\nThe house is {age} years old.");

        if (house.CanBeSold())
            Console.WriteLine("The house can be sold.");
        else
            Console.WriteLine("The house cannot be sold.");
    }
}

