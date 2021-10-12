using System;

namespace S01_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write a number");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Write a second 'y' number");
            int y = Int32.Parse(Console.ReadLine());
            Ex4 ex4 = new Ex4();
            Console.WriteLine("The even numbers are: ");
            ex4.Even(x);
            Console.WriteLine("The uneven numbers are: ");
            ex4.Uneven(x);
            Console.WriteLine("The numbers divisible by 'y'  are: ");
            ex4.Divisible(x, y);

        }
    }
}