using Microsoft.VisualStudio.TestTools.UnitTesting;
using testsUnitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsUnitaires.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            int result = MyMath.Addition(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest()
        {
            double result = MyMath.Division(3, 0);
        }

        [TestMethod()]
        public void SuperieurTest()
        {
            bool result = MyMath.Superieur(3, 2);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void phraseTest()
        {
            Fortune f = new Fortune();
            string s = f.phrase(1);

            StringAssert.StartsWith(s, "phrase");
        }

        [TestMethod()]
        public void MultiplicationTest()
        {

        }
    }
}