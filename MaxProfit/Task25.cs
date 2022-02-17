using System;

namespace APP_1.MaxProfit
{
    public class Task25
    {
        public static int solution25(int[] A)
        {
            int n = A.Length;
            if (n == 0)
                return 0;
            int minvalue = A[0];
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                minvalue = Math.Min(minvalue, A[i]);
                result = Math.Max(result, A[i] - minvalue);
            }
            return result;
    }
    }
}