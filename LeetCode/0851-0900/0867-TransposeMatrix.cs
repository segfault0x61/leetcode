namespace LeetCode._0851_0900
{
    public class _0867_TransposeMatrix
    {
        public int[][] Transpose(int[][] matrix)
        {
            var row = matrix.Length;
            var col = matrix[0].Length;

            var result = new int[col][];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    if (i == 0)
                        result[j] = new int[row];
                    result[j][i] = matrix[i][j];
                }

            return result;
        }
    }
}
