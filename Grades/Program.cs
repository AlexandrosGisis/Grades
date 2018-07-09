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
            book.NameChanged += OnNameChanged;
            book.Name = "Alex";
            book.Name = "Scott";

            Console.WriteLine(book.Name);
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average Grade",stats.AverageGrade);
            WriteResult("Highest Grade",stats.HighestGrade);
            WriteResult("Lowest Grade",(int)stats.LowestGrade);
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"{args.ExistingName} changed to {args.NewName}");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine($"{description} : {result:F2}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} : {result:F2}");
        }
    }
}
