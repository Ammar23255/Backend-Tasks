using System;
using System.Collections.Generic;
using System.Linq;

struct Circle
{
    public double Radius;
    public string Color;

    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

struct Car
{
    public string Model;
    public int Year;

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }
}

class Program
{
    static void Main()
    {
        // ---------- PART 1: Circle ----------
        List<Circle> circles = new List<Circle>();

        Console.Write("How many circles do you want to enter? ");
        int circleCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < circleCount; i++)
        {
            Console.WriteLine($"\nCircle #{i + 1}:");

            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            circles.Add(new Circle(radius, color));
        }

        Console.WriteLine("\n--- Circle Details ---");
        foreach (var circle in circles)
        {
            Console.WriteLine($"Color: {circle.Color}");
            Console.WriteLine($"Radius: {circle.Radius}");
            Console.WriteLine($"Area: {circle.Area():F2}");
            Console.WriteLine($"Perimeter: {circle.Perimeter():F2}");
            Console.WriteLine("----------------------");
        }

        // ---------- PART 2: Car ----------
        List<Car> cars = new List<Car>();

        Console.WriteLine("\nEnter data for 3 cars:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nCar #{i + 1}:");

            Console.Write("Enter model: ");
            string model = Console.ReadLine();

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            cars.Add(new Car(model, year));
        }

        // Find newest car
        Car newestCar = cars.OrderByDescending(c => c.Year).First();

        Console.WriteLine("\n--- Newest Car ---");
        Console.WriteLine($"Model: {newestCar.Model}");
        Console.WriteLine($"Year: {newestCar.Year}");
    }
}
