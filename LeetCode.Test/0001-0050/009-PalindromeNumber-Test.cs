using LeetCode._0001_0050;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test._0001_0050
{
    [TestClass]
    public class _009_PalindromeNumber_Test
    {
        [TestMethod] //MethodName_Should_DoTheThing
        public void IsPalindrome_SingleDigit_ReturnsTrue()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(0);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_NegativeNumber_ReturnsFalse()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_MultipleDigit_ReturnsTrueOrFalse()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(11);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(121);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(1231);
            Assert.IsFalse(result);
        }
    }
}
