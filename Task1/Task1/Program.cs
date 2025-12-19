namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();
            Console.WriteLine(math.Add(2,5));

            Books books = new Books();
            books.books();

            Books Small = new Small();
            Small.books();
 
        }
    }
}
