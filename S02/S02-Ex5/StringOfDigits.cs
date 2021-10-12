using System;

namespace S02_Ex5
{
    public class StringOfDigits
    {

        public static string Method(string stringggg)
        {
            char[] chars = stringggg.ToCharArray();
            
            for (int i = 0; i < chars.Length-3; i++)
            {
                int a = Int32.Parse(chars[i] + " ");
                int b = Int32.Parse(chars[i + 1] + " ");
                int c = Int32.Parse(chars[i + 2] + " ");
                int d = Int32.Parse(chars[i + 3] + " ");
                
                if (a*b*c*d == 5832)
                {
                   return a +" " + b +" "+ c +" " +d;
                }
                
            }

            return "nimic";

        }
    }
}