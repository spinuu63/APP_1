using System;

namespace APP_1.MaxSlinceSum
{
    public class Task26
    {
        public static int solution26(int[] A)
        {
            int result = A[0];
            if (A.Length > 1) {
                int a = A[0];
                int b = 0, c = 0;
                for (int i = 0; ++i < A.Length;) {
                    if (A[i] > a && A[i] > A[i] + a) {
                        if ((a = A[c = b = i]) > result)
                            result = a;
                    }
                    else if (A[i] < 0) {
                        ++c;
                        a += A[i];
                    }
                    else {
                        if ((a += A[i]) > result)
                            result = a;
                        c++;
                    }
                }
            }
            return result;
        }
    }
}