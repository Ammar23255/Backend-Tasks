using System;
using System.Collections.Generic;

enum Major
{
    ComputerScience,
    Engineering,
    Business
}

enum Gender
{
    M,
    F
}

class Student
{
    // Properties
    public int ID { get; set; }
    public string Name { get; set; }
    public Major Major { get; set; }
    public double GPA { get; set; }
    public int EnrollmentYear { get; set; }
    public Gender Gender { get; set; }

    // Constructor
    public Student(int id, string name, Major major, double gpa, int enrollmentYear, Gender gender)
    {
        ID = id;
        Name = name;
        Major = major;
        GPA = gpa;
        EnrollmentYear = enrollmentYear;
        Gender = gender;
    }

    // Override ToString to display formatted info
    public override string ToString()
    {
        return $"ID: {ID}\n" +
               $"Name: {Name}\n" +
               $"Major: {Major}\n" +
               $"GPA: {GPA:F2}\n" +
               $"Enrollment Year: {EnrollmentYear}\n" +
               $"Gender: {Gender}\n";
    }
}

class Program
{
    static void Main()
    {
        // Create a list of 3 students
        List<Student> students = new List<Student>
        {
            new Student(1, "Ali Hassan", Major.ComputerScience, 3.8, 2022, Gender.M),
            new Student(2, "Sara Ahmed", Major.Engineering, 3.5, 2021, Gender.F),
            new Student(3, "Omar Youssef", Major.Business, 3.9, 2023, Gender.M)
        };

        // Display student information
        Console.WriteLine("---- Student Information ----\n");
        foreach (var student in students)
        {
            Console.WriteLine(student);
            Console.WriteLine("-----------------------------");
        }
    }
}
