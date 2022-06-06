using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    public class AssertHelper
    {
        public static void AssertArray<T>(T[] expected, T[] actual, bool ignoreLength = false)
        {
            if (!ignoreLength)
            {
                Assert.AreEqual(expected.Length, actual.Length, message: "length is not match");
            }

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], message: $"i {i} is not match");
            }
        }

        public static void AssertArray<T>(T[,] expected, T[,] actual)
        {
            var rowCount = expected.GetLength(0);
            var colCount = expected.GetLength(1);

            for (var i = 0; i < rowCount; i++)
            {
                for (var j = 0; j < colCount; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j], message: $"i {i}, j {j} is not match");
                }
            }
        }

        public static void AssertArray<T>(T[][] expected, T[][] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length, message: "length is not match");

            var rowCount = expected.Length;
            var colCount = expected[0].Length;

            for (var i = 0; i < rowCount; i++)
            {
                for (var j = 0; j < colCount; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j], message: $"i {i}, j {j} is not match");
                }
            }
        }


        public static void AssertList<T>(T[] expected, IList<T> actual)
        {
            Assert.AreEqual(expected.Length, actual.Count, message: "length is not match");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], message: $"i {i} is not match");
            }
        }

        public static void AssertList<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, message: "length is not match");

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count, message: $"row {i} length is not match");
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j], message: $"i {i}, j {j} is not match");
                }
            }
        }
    }
}
