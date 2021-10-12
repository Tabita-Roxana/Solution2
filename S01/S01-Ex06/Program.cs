using System;

namespace S01_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the first string:");
            var x = Console.ReadLine();
            Console.WriteLine("write the second string:");
            var y = Console.ReadLine();
            Console.WriteLine(Abba.MakeAbba(x, y));
        }
    }
}