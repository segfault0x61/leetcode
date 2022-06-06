using LeetCode._1301_1350;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._1301_1350
{
    [TestClass]
    public class _1342_NumberOfStepsToReduceANumberToZero_Test
    {
        [TestMethod]
        public void NumberOfSteps_14_Returns_6()
        {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(14);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void NumberOfSteps_8_Returns_4()
        {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(8);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void NumberOfSteps_123_Returns_12()
        {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(123);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void NumberOfSteps_0_Returns_0()
        {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(0);
            Assert.AreEqual(0, result);
        }
    }
}
