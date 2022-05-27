using System;
using LeetCode._0001_0050;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._0001_0050
{
    [TestClass]
    public class _0191_NumberOf1Bits_Test
    {
        [TestMethod]
        public void HammingWeight_00000000000000000000000000001011_Returns_3()
        {
            var solution = new _0191_NumberOf1Bits();
            var result = solution.HammingWeight(Convert.ToUInt32("00000000000000000000000000001011", 2));
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void HammingWeight_00000000000000000000000010000000_Returns_1()
        {
            var solution = new _0191_NumberOf1Bits();
            var result = solution.HammingWeight(Convert.ToUInt32("00000000000000000000000010000000", 2));
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void HammingWeight_11111111111111111111111111111101_Returns_31()
        {
            var solution = new _0191_NumberOf1Bits();
            var result = solution.HammingWeight(Convert.ToUInt32("11111111111111111111111111111101", 2));
            Assert.AreEqual(31, result);
        }
    }
}
