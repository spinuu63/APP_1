namespace APP_1.FrogJmp
{
    public class Task4
    {
        public static int sol(int x, int y, int d)
        {
            int distance = y - x;
            int steps = distance / d;
            if (distance % d != 0)
            {
                steps += 1;
            }

            return steps;
        }
    }
}