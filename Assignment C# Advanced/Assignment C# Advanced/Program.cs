using System;

namespace DelegatesGenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates, Generics & Anonymous Features Demo");
            Console.WriteLine("1.Delegate & Anonymous Method Demo");
            Console.WriteLine("2.Generics Demo");
            Console.WriteLine("3.Integrated Example");
            Console.Write("Choose option:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DelegateDemo.Run();
                    break;
                case 2:
                    GenericDemo.Run();
                    break;
                case 3:
                    IntegratedDemo.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
