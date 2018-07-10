using System;
using System.Collections.Generic;
using System.IO;
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

            AddGrades(book);
            GetBookName(book);
            WriteResults(book);
            SaveGrades(book);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrades(80);
            book.AddGrades(95.4f);
            book.AddGrades(73);
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average Grade", stats.AverageGrade);
            WriteResult("Highest Grade", stats.HighestGrade);
            WriteResult("Lowest Grade", stats.LowestGrade);
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
