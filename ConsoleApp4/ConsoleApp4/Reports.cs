using System;
using System.Linq;

namespace StudentEvaluationSystem
{
    public static class Reports
    {
        public static void ShowTop3(StudentManager manager)
        {
            var top = manager.TopNByAverage(3);
            Console.WriteLine("\n=== Top 3 Students by Average ===");

            foreach (var s in top)
            {
                Console.WriteLine(s);
            }
        }
        public static void ShowClassAverage(StudentManager manager)
        {
            Console.WriteLine("\n=== Class Average ===");
            Console.WriteLine($"Class Average Score: {manager.ClassAverage()}");
        }
        public static void ShowStudentsByGrade(StudentManager manager)
        {
            var groups = manager.GroupByGrade();
            Console.WriteLine("\n=== Students Grouped by Grade ===");

            foreach (var group in groups.OrderBy(g => g.Key))
            {
                Console.WriteLine($"\nGrade {group.Key}:");
                foreach (var s in group)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}