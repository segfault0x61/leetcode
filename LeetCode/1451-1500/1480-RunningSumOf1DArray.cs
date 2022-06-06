namespace LeetCode._1451_1500
{
    public class _1480_RunningSumOf1DArray
    {
        public int[] RunningSum(int[] nums)
        {
            var sum = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }

            return nums;
        }
    }
}
