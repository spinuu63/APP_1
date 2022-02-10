using System.Linq;

namespace APP_1.OddOccurrencesInArray
{
    public class Task3
    {
        
        public static int findUnpairdLINQ(int[] pairsArray)
        {
            return pairsArray.Aggregate(0, (prev, next) => prev ^= next);
        }

        private static int findUnpired(int[] pairsArray)
        {
            int unapairednumber = 0;

            for (int i = 0; i < pairsArray.Length; i++)
            {
                unapairednumber ^= pairsArray[i];
            }

            return unapairednumber;
        }
    }
}