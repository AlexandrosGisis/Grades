using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Test
{
    [TestClass]
    public class GradesTest
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(10);
            book.AddGrades(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(result.HighestGrade, 90);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(80);
            book.AddGrades(95.4f);
            book.AddGrades(73);


            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(result.AverageGrade, 82.8, 0.01);
        }
    }
}
