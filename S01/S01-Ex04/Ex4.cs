using System;

namespace S01_Ex04
{
    public class Ex4
    {
        public int Even(int x)
        {
            
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            return 0;
        }
        
        public int Uneven(int x)
        {
            
            for (int i = 0; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            return 0;
        }
        public int Divisible(int x, int y)
        {
            
            for (int i = 0; i < x; i++)
            {
                if (i % y == 0)
                {
                    Console.WriteLine(i);
                }
            }
            return 0;
        }
    }
}