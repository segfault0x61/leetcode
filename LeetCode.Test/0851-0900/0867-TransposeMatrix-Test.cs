using LeetCode._0851_0900;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._0851_0900
{
    [TestClass]
    public class _0867_TransposeMatrix_Test
    {
        [TestMethod]
        public void Transpose_3x3_ReturnsTransposedMatrix()
        {
            var solution = new _0867_TransposeMatrix();
            var result = solution.Transpose(
                new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 },
                });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 4, 7 },
                    new int[] { 2, 5, 8 },
                    new int[] { 3, 6, 9 }
                }, result);
        }

        [TestMethod]
        public void Transpose_3x2_ReturnsTransposedMatrix()
        {
            var solution = new _0867_TransposeMatrix();
            var result = solution.Transpose(
                new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 }
                });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 4 },
                    new int[] { 2, 5 },
                    new int[] { 3, 6 }
                }, result);
        }
    }
}
