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
            GradeBook book = new GradeBook();

            book.AddGrades(80);
            book.AddGrades(95.4f);
            book.AddGrades(73);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average Grade",stats.AverageGrade);
            WriteResult("Highest Grade",stats.HighestGrade);
            WriteResult("Lowest Grade",stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description} : {result}");
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} : {result:F2}");
        }
    }
}
