using LeetCode._0251_0300;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._0251_0300
{
    [TestClass]
    public class _0268_MissingNumber_Test
    {
        [TestMethod]
        [DataRow(new[] { 3, 0, 1 }, 2)]
        [DataRow(new[] { 0 }, 1)]
        [DataRow(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        public void MissingNumber_ArrayOfNums_ReturnsMissingNumber(int[] given, int expected)
        {
            var solution = new _0268_MissingNumber();
            var result = solution.MissingNumber(given);
            Assert.AreEqual(expected, result);
        }
    }
}
