namespace APP_1.EquiLeader
{
    public class Task24
    {
        public static int solution24(int[] A)
        {
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
                        return 2;
            }
            return -1;
        }
    }
}