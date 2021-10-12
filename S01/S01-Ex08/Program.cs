using System;

namespace S01_Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the outer:");
            var x = Console.ReadLine();
            Console.WriteLine("write the word:");
            var y = Console.ReadLine();
            Console.WriteLine(SplitString.MakeOutWord(x,y));
        }
    }
}