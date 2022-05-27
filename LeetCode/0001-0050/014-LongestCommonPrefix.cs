﻿namespace LeetCode._0001_0050
{
    public class _014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;
            if (strs.Length == 1) return strs[0];

            var index = 0;
            bool isSame = true;
            var firstString = strs[0];
            for (index = 0; index < firstString.Length; index++)
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i].Length <= index || strs[i][index] != firstString[index])
                    {
                        isSame = false;
                        break;
                    }
                }

                if (!isSame)
                {
                    break;
                }
            }

            return firstString.Substring(0, index);
        }
    }
}
