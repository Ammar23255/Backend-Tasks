using System;
using System.Collections.Generic;

namespace DelegatesGenericsDemo
{
    public static class IntegratedDemo
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Func<int, bool> filterEven = delegate (int n) {return n % 2 == 0;};
            foreach (var num in numbers)
            {
                if (filterEven(num))
                {
                    var result = new
                    {
                        Number = num,
                        Square = num * num
                    };
                    Console.WriteLine($"Number: {result.Number}, Square: {result.Square}");
                }
            }
        }
    }
}
