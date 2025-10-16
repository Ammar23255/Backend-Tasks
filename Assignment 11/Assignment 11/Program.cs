using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public struct Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
    public struct Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString() => $"{Day:D2}/{Month:D2}/{Year:D4}";
    }
    public enum MembershipType
    {
        Regular,
        Premium,
        VIP
    }
    public class Member
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public MembershipType Membership { get; private set; }
        public Date JoinDate { get; private set; }
        public Member(int id, string name, MembershipType membership, Date joinDate)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Membership = membership;
            JoinDate = joinDate;
        }
        public override string ToString()
        {
            return $"[#{Id}] {Name} - {Membership} (Joined: {JoinDate})";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Library Management System\n");
            var books = new List<Book>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter details for Book #{i}:");
                Console.Write("Title : ");
                string title = ReadNonEmpty();
                Console.Write("Author: ");
                string author = ReadNonEmpty();
                Console.Write("Price : ");
                double price = ReadPositiveDouble();
                books.Add(new Book(title, author, price));
                Console.WriteLine();
            }

            Console.WriteLine("All book titles:");
            foreach (var b in books)
            {
                Console.WriteLine($"- {b.Title}");
            }

            double averagePrice = books.Average(b => b.Price);
            Console.WriteLine($"\nAverage book price: {averagePrice:F2}");

            var members = new List<Member>
            {
                new Member(
                    id: 1,
                    name: "Sara Ahmed",
                    membership: MembershipType.Regular,
                    joinDate: new Date(5, 1, 2024)
                ),
                new Member(
                    id: 2,
                    name: "Omar Ali",
                    membership: MembershipType.Premium,
                    joinDate: new Date(12, 3, 2024)
                ),
                new Member(
                    id: 3,
                    name: "Mina Youssef",
                    membership: MembershipType.VIP,
                    joinDate: new Date(20, 6, 2025)
                )
            };
            Console.WriteLine("\nMembers:");
            foreach (var m in members)
            {
                Console.WriteLine(m.ToString());
            }
            var vipNames = members
                .Where(m => m.Membership == MembershipType.VIP)
                .Select(m => m.Name)
                .ToList();
            Console.WriteLine("\nVIP Members:");
            if (vipNames.Count == 0)
                Console.WriteLine("- (none)");
            else
                vipNames.ForEach(name => Console.WriteLine($"- {name}"));
            Console.WriteLine("\nDone.");
        }
        private static string ReadNonEmpty()
        {
            while (true)
            {
                string? s = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(s))
                    return s.Trim();
                Console.Write("Please enter a non-empty value: ");
            }
        }
        private static double ReadPositiveDouble()
        {
            while (true)
            {
                string? s = Console.ReadLine();
                if (double.TryParse(s, out double value) && value >= 0)
                    return value;
                Console.Write("Invalid number.Enter a non-negative price: ");
            }
        }
    }
}
