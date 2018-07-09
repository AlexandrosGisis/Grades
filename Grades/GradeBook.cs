using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        List<float> grades;
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChanged(_name, value);
                    }
                    _name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged;
        private string _name;

        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }
        
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
    }
}
