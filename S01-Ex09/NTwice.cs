using System;
using System.Collections;

namespace S01_Ex09
{
    public class NTwice
    {

        public static string MakeWord(string word, int number)
        {
            string a = word.Substring(0,number);
            string b = word.Substring(word.Length-number, number);

            return a+b;
        }
    }
}  