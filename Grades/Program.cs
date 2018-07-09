﻿using System;
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
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.Name = "Alex";
           

            Console.WriteLine(book.Name);
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average Grade",stats.AverageGrade);
            WriteResult("Highest Grade",stats.HighestGrade);
            WriteResult("Lowest Grade",(int)stats.LowestGrade);
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"{existingName} changed to {newName}");
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
