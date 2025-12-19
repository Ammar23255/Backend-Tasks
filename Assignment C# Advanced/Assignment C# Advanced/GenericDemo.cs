namespace DelegatesGenericsDemo
{
    public static class GenericDemo
    {
        public static void Run()
        {
            GenericBox<int> intBox = new GenericBox<int>(100);
            intBox.Display();
            GenericBox<string> stringBox = new GenericBox<string>("Hello Generics");
            stringBox.Display();
        }
    }
}
