using System;

namespace APP_1.Dominator
{
    public class Task23
    {
        public static int solution23(int[] A)
        {
            if (A.Length < 1)
                return -1;
            int index = 0, valoare = 0;
            for (int i = -1; ++i < A.Length;) {
                if (index == 0) {
                    ++index;
                    valoare = A[i];
                }
                else if (valoare != A[i])
                    --index;
                else
                    ++index;
            }
            if (index > 0) {
                int count = 0;
                for (int i = -1; ++i < A.Length;)
                    if (A[i] == valoare && ++count > A.Length / 2)
                        return i;
            }
            return -1;
        }
    }
}