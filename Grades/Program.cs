using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook grades = new GradeBook();
            grades.AddGrade(21);
            grades.AddGrade(35.4f);
            grades.AddGrade(34);

            grades.ListGrades();
            GradeStatistics stats = grades.CalculateStatistics();
            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade);
        }
    }
}
