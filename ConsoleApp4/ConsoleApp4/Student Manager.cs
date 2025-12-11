using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentEvaluationSystem
{
    public class StudentManager
    {
        private readonly List<Student> _students = new List<Student>();

        // Bonus: Event triggered when a student is added
        public event Action<Student>? OnStudentAdded;

        public Student AddStudent(string name, int age, double s1, double s2, double s3)
        {
            var student = new Student(name, age, s1, s2, s3);
            _students.Add(student);
            OnStudentAdded?.Invoke(student);
            return student;
        }
        public IEnumerable<Student> ListAll()
        {
            return _students;
        }
        public IEnumerable<Student> SearchByName(string namePart)
        {
            return _students.Where(s => s.Name.IndexOf(namePart, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        public IEnumerable<Student> SearchById(int id)
        {
            return _students.Where(s => s.Id == id);
        }
        public IEnumerable<Student> SearchByGrade(char grade)
        {
            grade = char.ToUpper(grade);
            return _students.Where(s => s.Grade == grade);
        }
        public bool DeleteById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return false;
            _students.Remove(student);
            return true;
        }
        public IEnumerable<Student> TopNByAverage(int n)
        {
            return _students.OrderByDescending(s => s.Average).Take(n);
        }
        public double ClassAverage()
        {
            if (!_students.Any()) return 0.0;
            return Math.Round(_students.Average(s => s.Average), 2);
        }
        public ILookup<char, Student> GroupByGrade()
        {
            return _students.ToLookup(s => s.Grade);
        }
    }
}
