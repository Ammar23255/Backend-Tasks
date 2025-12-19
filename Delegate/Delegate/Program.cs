namespace Delegate
{
    internal class Program
    {
        public static class FilterEngine
        {
            public static List<T> FilterList<T>(List<T> items, Predicate<T> filter)
            {
                List<T> list = new List<T>();
                foreach (T item in items)
                {
                    if (filter(item)) list.Add(item);
                }
                return list;
            }
        }

        public delegate bool Mathcheck(int x);

        public static bool Isposivtive(int x)
        {
            return x > 0;
        }

        public static bool Iseven(int x)
        {
            return x % 2 == 0;
        }

        public static bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) { return false; }
            }
            return true;
        }
        static void Main(string[] args)
        {

            List<int> numbers = Enumerable.Range(0, 10).ToList();

            List<int> evens = FilterEngine.FilterList(numbers, Iseven);
            Console.WriteLine(string.Join(", ", evens));

            //Mathcheck mathcheck;

            //mathcheck = Isposivtive;
            //Console.WriteLine(mathcheck(-5));

            //mathcheck = Iseven;
            //Console.WriteLine(mathcheck(4));

            //mathcheck = IsPrime;
            //Console.WriteLine(mathcheck(2));

        }
    }
}
