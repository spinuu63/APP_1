using System.Linq;

namespace APP_1.PermMissingElem
{
    public class Task5
    {
        public static int Solution(int[] Arr)
        {
            return (int) ((Arr.Length == 0)
                ? 1
                : ((long) (Arr.Length + 1) * (Arr.Length + 2) / 2) - Arr.Sum(x => (long) x));
        }
    }
}