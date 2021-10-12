using System;

namespace S01_Ex05
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
        public static int AddArray(int[] x)
        {
            int sum = 0;
            
            foreach (var i in x)
            {
                sum += i;

            }
            return sum;
        }
        public static int Maximum(int x, int y)
        {
            if (x < y)
                return y;
            else
            {
                return x;
            }
        }
    }
}