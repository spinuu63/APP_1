using System;
using System.Linq;

namespace APP_1.Distinct
{
    public class Task15
    {
        public static int solution15(int[] A)
        {
            int a1, a2, a3, a4, a5, a6, a7, a8 ,a9, a0;
            a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = a0 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                {
                    a1++;
                } else if (A[i] == 2)
                {
                    a2++;
                }else if (A[i] == 3)
                {
                    a3++;
                }else if (A[i] == 4)
                {
                    a4++;
                }else if (A[i] == 5)
                {
                    a5++;
                }
                else if (A[i] == 6)
                {
                    a6++;
                }
                else if (A[i] == 7)
                {
                    a7++;
                }
                else if (A[i] == 8)
                {
                    a8++;
                }
                else if (A[i] == 9)
                {
                    a9++;
                }
                else if (A[i] == 0)
                {
                    a0++;
                }
                else
                {
                    Console.Write("Nu avem soluti potrivite pentru aceasta problema! ");
                }
            }
            
            int[] B = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            B[0] = a1;
            B[1] = a2;
            B[2] = a3;
            B[3] = a4;
            B[4] = a5;
            B[5] = a6;
            B[6] = a7;
            B[7] = a8;
            B[8] = a9;
            B[9] = a0;
            Console.WriteLine();
            int result = B.Max();

            return result;
        }
    }
}