namespace LeetCode._0151_0200
{
    public class _0191_NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            var num = 0;
            while (n > 0)
            {
                n &= n - 1;
                num++;
            }

            return num;
        }
    }
}
