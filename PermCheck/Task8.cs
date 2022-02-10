namespace APP_1.PermCheck
{
    public class Task8
    {
        public static int Solution(int[] A)
        {
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A.Length) return 0;
                if (++B[A[i] - 1] > 1) return 0;
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0) return 0;
            }
            return 1;
        }
    }
}