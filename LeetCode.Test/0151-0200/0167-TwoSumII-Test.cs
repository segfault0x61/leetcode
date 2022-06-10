using System;
using LeetCode._0151_0200;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._0151_0200
{
    [TestClass]
    public class _0167_TwoSumII_Test
    {
        [TestMethod]
        public void TwoSumTest_1()
        {
            var solution = new _0167_TwoSumII();
            var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            AssertHelper.AssertArray(new[] { 1, 2 }, result);
        }

        [TestMethod]
        public void TwoSumTest_2()
        {
            var solution = new _0167_TwoSumII();
            var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 10);
            AssertHelper.AssertArray(Array.Empty<int>(), result);
        }
    }
}
