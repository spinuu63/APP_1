namespace APP_1.FrogRiverOne
{
    public class Task7
    {
        public static int solution7(int[] A)
        {
            int n = 5, index = 0;
            int[] arr7 = {1, 3, 1, 4, 2, 3, 5, 3};
            for (int i = 0; i < arr7.Length; i++)
            {
                if (arr7[i] == n)
                {
                    index++;
                }
            }
            int t = 0;
            do
            {
                t++;
            } while (arr7[t] < n);

            return t;
        }
    }
}