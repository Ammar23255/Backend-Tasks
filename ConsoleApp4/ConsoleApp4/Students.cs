using System;


namespace StudentEvaluationSystem
{
    public class Student
    {
        private static int _nextId = 1;
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Score1 { get; set; }
        public double Score2 { get; set; }
        public double Score3 { get; set; }

        public double Total => Math.Round(Score1 + Score2 + Score3, 2);
        public double Average => Math.Round(Total / 3.0, 2);
        public char Grade => CalculateGrade();

        public Student(string name, int age, double s1, double s2, double s3)
        {
            Id = _nextId++;
            Name = name;
            Age = age;
            Score1 = s1;
            Score2 = s2;
            Score3 = s3;
        }

        private char CalculateGrade()
        {
            var avg = Average;
            if (avg >= 90) return 'A';
            if (avg >= 80) return 'B';
            if (avg >= 70) return 'C';
            if (avg >= 60) return 'D';
            return 'F';
        }

        public override string ToString()
        {
            return $"ID: {Id} | {Name} | Age: {Age} | Scores: [{Score1}, {Score2}, {Score3}] | Total: {Total} | Avg: {Average} | Grade: {Grade}";
        }
    }
}