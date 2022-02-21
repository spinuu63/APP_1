using System;


namespace APP_1.CountFactors
{
    public class Task28
    {
        public static int solution28(int N)
        {

            int i = 1;
            int cntFactor = 0;
        
            while (i * i < N) {
                if (N % i == 0)
                    cntFactor += 2;
                i++;
            }
        
            if (i * i == N)
                cntFactor++;
            
            return cntFactor;
        }
    }
}