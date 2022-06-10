namespace LeetCode._0151_0200
{
    public class _0167_TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;
            while (i < j)
            {
                int compare = (numbers[i] + numbers[j]).CompareTo(target);
                if (compare == 0) return new[] {i + 1, j + 1};
                else if (compare > 0) j--;
                else i++;
            }

            return new int[] { };
        }
    }
}
