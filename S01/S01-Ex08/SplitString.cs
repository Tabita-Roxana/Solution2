using System;

namespace S01_Ex08
{
    public class SplitString
    {
        private string outer, word;

        public static string MakeOutWord(string outer, string word)
        {
            char[] array = outer.ToCharArray();
            string final = $"{array[0]} {array[1]} {word} {array[2]} {array[3]}";
            return final;
        }
    }
}