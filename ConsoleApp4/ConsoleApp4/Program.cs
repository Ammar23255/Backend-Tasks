using System;

namespace StudentEvaluationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            manager.OnStudentAdded += (student) =>
            {
                Console.WriteLine($"\n[Event] Student Added: {student.Name} (ID: {student.Id})\n");
            };

            bool running = true;

            while (running)
            {
                Console.WriteLine("==============================");
                Console.WriteLine(" Student Evaluation System ");
                Console.WriteLine("==============================");
                Console.WriteLine("1) Add Student");
                Console.WriteLine("2) List Students");
                Console.WriteLine("3) Search Student");
                Console.WriteLine("4) Delete Student");
                Console.WriteLine("5) Reports");
                Console.WriteLine("0) Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddStudentUI(manager);
                        break;

                    case "2":
                        ListStudentsUI(manager);
                        break;

                    case "3":
                        SearchStudentUI(manager);
                        break;

                    case "4":
                        DeleteStudentUI(manager);
                        break;

                    case "5":
                        ReportsUI(manager);
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddStudentUI(StudentManager manager)
        {
            Console.WriteLine("=== Add Student ===");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Score 1: ");
            double s1 = double.Parse(Console.ReadLine());

            Console.Write("Score 2: ");
            double s2 = double.Parse(Console.ReadLine());

            Console.Write("Score 3: ");
            double s3 = double.Parse(Console.ReadLine());

            manager.AddStudent(name, age, s1, s2, s3);
            Console.WriteLine("Student added successfully!\n");
        }
        static void ListStudentsUI(StudentManager manager)
        {
            Console.WriteLine("=== All Students ===");

            foreach (var student in manager.ListAll())
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
        static void SearchStudentUI(StudentManager manager)
        {
            Console.WriteLine("=== Search Student ===");
            Console.WriteLine("1) Search by Name");
            Console.WriteLine("2) Search by ID");
            Console.WriteLine("3) Search by Grade");
            Console.Write("Choose: ");

            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.Write("Enter name part: ");
                    string namePart = Console.ReadLine();
                    var results1 = manager.SearchByName(namePart);
                    foreach (var s in results1) Console.WriteLine(s);
                    break;

                case "2":
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    var results2 = manager.SearchById(id);
                    foreach (var s in results2) Console.WriteLine(s);
                    break;

                case "3":
                    Console.Write("Enter Grade (A-F): ");
                    char grade = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    var results3 = manager.SearchByGrade(grade);
                    foreach (var s in results3) Console.WriteLine(s);
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }
        static void DeleteStudentUI(StudentManager manager)
        {
            Console.WriteLine("=== Delete Student ===");
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            bool deleted = manager.DeleteById(id);
            Console.WriteLine(deleted ? "Deleted successfully!" : "Student not found.");
            Console.WriteLine();
        }
        static void ReportsUI(StudentManager manager)
        {
            Console.WriteLine("=== Reports ===");
            Console.WriteLine("1) Top 3 Students");
            Console.WriteLine("2) Class Average");
            Console.WriteLine("3) Students by Grade");
            Console.Write("Choose: ");

            string r = Console.ReadLine();
            Console.Clear();

            switch (r)
            {
                case "1": Reports.ShowTop3(manager); break;
                case "2": Reports.ShowClassAverage(manager); break;
                case "3": Reports.ShowStudentsByGrade(manager); break;
                default: Console.WriteLine("Invalid option."); break;
            }

            Console.WriteLine();
        }
    }
}