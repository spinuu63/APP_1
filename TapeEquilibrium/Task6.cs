using System;
using System.Linq;

namespace APP_1.TapeEquilibrium
{
    public class Task6
    {
        public static int solution(int[] A)
        {
            var totalSum = A.ToList().Sum();
            var minDif = int.MaxValue;

            var prevSum = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                prevSum += A[i];
                var rest = totalSum - prevSum;
                var dif = Math.Abs(prevSum - rest);
                minDif = dif < minDif ? dif : minDif;
            }

            return minDif;
        }
    }
}