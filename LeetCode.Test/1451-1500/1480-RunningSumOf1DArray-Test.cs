using LeetCode._1451_1500;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._1451_1500
{
    [TestClass]
    public class _1480_RunningSumOf1DArray_Test
    {
        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
        [DataRow(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
        [DataRow(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
        public void RunningSum_ArrayOfNums_ReturnsRunningSum(int[] given, int[] expected)
        {
            var solution = new _1480_RunningSumOf1DArray();
            var result = solution.RunningSum(given);
            AssertHelper.AssertArray(expected, result);
        }
    }
}
