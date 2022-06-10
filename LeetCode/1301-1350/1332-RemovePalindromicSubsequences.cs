namespace LeetCode._1301_1350
{
    public class _1332_RemovePalindromicSubsequences
    {
        public int RemovePalindromeSub(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int lo = 0, hi = s.Length - 1;
            while (lo < hi)
            {
                if (s[lo] != s[hi]) return 2;
                lo++;
                hi--;
            }

            return 1;
        }
    }
}
