namespace LeetCode._0251_0300
{
    public class _0268_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; ++i)
                result += (i + 1) - nums[i];

            return result;
        }
    }
}
