using System;

namespace DelegatesGenericsDemo
{
    public static class DelegateDemo
    {
        public static void Run()
        {
            Operation add = delegate (int a, int b)
            {
                return a + b;
            };

            Operation multiply = delegate (int a, int b)
            {
                return a * b;
            };

            Console.WriteLine("Addition Result: " + add(5, 3));
            Console.WriteLine("Multiplication Result: " + multiply(5, 3));
        }
    }
}
