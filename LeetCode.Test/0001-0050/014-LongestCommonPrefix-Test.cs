using System;
using LeetCode._0001_0050;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._0001_0050
{
    [TestClass]
    public class _014_LongestCommonPrefix_Test
    {
        [TestMethod]
        public void LongestCommonPrefix_Empty_ReturnsEmptyString()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(Array.Empty<string>());
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void LongestCommonPrefix_OneString_ReturnsThatString()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new[] {"abc"});
            Assert.AreEqual("abc", result);
        }

        [TestMethod]
        public void LongestCommonPrefix_HavePrefix_ReturnsCorrectPrefix()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new[] { "aa", "a" });
            Assert.AreEqual("a", result);

            result = solution.LongestCommonPrefix(new[] { "a", "aa" });
            Assert.AreEqual("a", result);

            result = solution.LongestCommonPrefix(new[] { "abcd", "abc", "abd" });
            Assert.AreEqual("ab", result);
        }

        [TestMethod]
        public void LongestCommonPrefix_NoPrefix_ReturnsEmptyString()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new[] { "abc", "abd", "bcd" });
            Assert.AreEqual(string.Empty, result);
        }
    }
}
