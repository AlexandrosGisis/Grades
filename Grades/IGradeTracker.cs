using System.IO;

namespace Grades
{
    internal interface IGradeTracker
    {
        void AddGrades(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);

        string Name { get; set; }
    }
}