using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypesTest
    {
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Alex";
            string name2 = name1;

            name1 = "Tas";
            Assert.AreEqual(name1, name2);
        }

        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;


            g1.Name = "this is a test";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
