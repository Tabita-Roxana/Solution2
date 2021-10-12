using System;

namespace S01_Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the word:");
            var x = Console.ReadLine();
            Console.WriteLine("write the number:");
            var y = Int32.Parse(Console.ReadLine());
            Console.WriteLine(NTwice.MakeWord(x, y));
        }
    }
}