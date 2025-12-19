namespace DelegatesGenericsDemo
{
    public class GenericBox<T>
    {
        public T Value { get; set; }
        public GenericBox(T value)
        {
            Value = value;
        }
        public void Display()
        {
            System.Console.WriteLine($"Stored Value: {Value}");
        }
    }
}
