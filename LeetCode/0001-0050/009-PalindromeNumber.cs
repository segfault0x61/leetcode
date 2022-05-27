namespace LeetCode._0001_0050
{
    public class _009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;

            var temp = x;
            var y = 0;

            while (temp != 0)
            {
                var digit = temp % 10;
                y = y * 10 + digit;
                temp /= 10;
            }

            return x == y;
        }
    }
}
