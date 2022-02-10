namespace APP_1.MinAvgTwoSlice
{
    public class Task14
    {
        public static int solution14(int[] A)
        {
            int N = A.Length;
            int[] sum = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                sum[i + 1] = sum[i] + A[i];
            }

            float minAvg = float.MaxValue;
            int minindex = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int i0 = i;
                int i1 = i + 1;
                float avg2 = (sum[i1 + 1] - sum[i0]) / 2.0f;

                if (avg2 < minAvg)
                {
                    minAvg = avg2;
                    minindex = i;
                }

                if (i < N - 2)
                {
                    int i2 = i + 2;
                    float avg3 = (sum[i2 + 1] - sum[i0]) / 3.0f;

                    if (avg3 < minAvg)
                    {
                        minAvg = avg3;
                        minindex = i;
                    }
                }

            }

            return minindex;
        }   
        
    }
}