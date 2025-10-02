using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Arithmetic Operators
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum: {a + b}");
            Console.WriteLine($"Difference: {a - b}");
            Console.WriteLine($"Product: {a * b}");
            Console.WriteLine($"Quotient: {(b != 0 ? (a / b).ToString() : "Division by zero")}");

            // 2. Relational Operators
            Console.WriteLine("Enter first number:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(p == m ? "Numbers are Equal" : "Numbers are Not Equal");

            // 3. Logical Operators
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary:");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine(age > 18 && salary > 5000 ? "Condition True" : "Condition False");

            // 4. Assignment Operators
            int x = 10, y = 5;
            Console.WriteLine($"x = y → x = {y}");
            x = 10; y = 5;
            x += y;
            Console.WriteLine($"x += y → x = {x}");

            // 5. Unary Operators
            int num = 5;
            Console.WriteLine($"num++ = {num++}");
            Console.WriteLine($"After increment: {num}");
            Console.WriteLine($"num-- = {num--}");
            Console.WriteLine($"After decrement: {num}");

            // 6. Ternary Operator
            Console.WriteLine("Enter a number to check even/odd:");
            int checkNum = int.Parse(Console.ReadLine());
            Console.WriteLine(checkNum % 2 == 0 ? "Even" : "Odd");

            // 7. Null-Coalescing Operator
            string? name = null;
            Console.WriteLine(name ?? "Default Name"); // ?? 
            name ??= "Assigned Name"; // ??=
            Console.WriteLine(name);

            // 8. String concatenation vs Interpolation
            string first = "Hello", second = "World";
            Console.WriteLine("Concatenation: " + first + " " + second);
            Console.WriteLine($"Interpolation: {first} {second}");

            // 9. Date Formatting
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));

            // 10. Strings are Immutable
            string s1 = "Hello";
            string s2 = s1.Replace("H", "J");
            Console.WriteLine($"s1: {s1}, s2: {s2}");
            Console.WriteLine(Object.ReferenceEquals(s1, s2)); // False, reference changed

            // 11. StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sentence 1.");
            sb.AppendLine("Sentence 2.");
            sb.AppendLine("Sentence 3.");
            Console.WriteLine("Before Remove:");
            Console.WriteLine(sb);
            sb.Replace("Sentence 2.\n", "");
            Console.WriteLine("After Remove:");
            Console.WriteLine(sb);

            // 12. Grade Check
            Console.WriteLine("Enter grade:");
            int grade = int.Parse(Console.ReadLine());
            Console.WriteLine(grade >= 50 ? "Pass" : "Fail");

            // 13. Switch Statement
            Console.WriteLine("Enter number 1–3:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                default: Console.WriteLine("Invalid"); break;
            }

            // 14. Switch Expression
            string result = n switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Invalid"
            };
            Console.WriteLine(result);

            // 15. For Loop
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);

            // 16. Foreach Loop
            string[] students = { "Ali", "Sara", "Omar", "Mona", "Laila" };
            foreach (var student in students)
                Console.WriteLine(student);

            // 17. While Loop (sum until 0)
            int sum = 0, val;
            do
            {
                Console.WriteLine("Enter number (0 to stop):");
                val = int.Parse(Console.ReadLine());
                sum += val;
            } while (val != 0);
            Console.WriteLine($"Sum = {sum}");

            // 18. Do-While Loop (password check)
            string password;
            do
            {
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
            } while (password != "1234");
            Console.WriteLine("Access Granted!");

            // 19. 2D Array
            int[,] matrix = new int[3, 3];
            int counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = counter++;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 20. Shallow Copy vs Deep Copy
            int[] original = { 1, 2, 3 };
            int[] shallow = original; // both reference same array
            int[] deep = (int[])original.Clone(); // deep copy

            shallow[0] = 99;
            Console.WriteLine("Original after shallow copy change: " + original[0]); // affected
            deep[0] = 77;
            Console.WriteLine("Original after deep copy change: " + original[0]); // not affected
        }
    }
}
