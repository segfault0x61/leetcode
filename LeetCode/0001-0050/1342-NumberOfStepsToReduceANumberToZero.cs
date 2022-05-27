namespace LeetCode._0001_0050
{
    public class _1342_NumberOfStepsToReduceANumberToZero
    {
        public int NumberOfSteps(int num)
        {
            var step = 0;
            while (num > 0)
            {
                if ((num & 1) == 1)
                    step++;
                num /= 2;
                step++;
            }

            return step > 0 ? step - 1 : 0;
        }
    }
}
