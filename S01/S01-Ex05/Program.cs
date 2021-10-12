using System;

namespace S01_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the first number:");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("write the second number:");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The sum is:");
            Console.WriteLine(Calculator.Add(x,y));
            Console.WriteLine("The biggest number is:");
            Console.WriteLine(Calculator.Maximum(x,y));
            
            Console.WriteLine("write the array lenght:");
            int z = Int32.Parse(Console.ReadLine());
            int[] array = new int[z];
            Console.WriteLine("write the numbers:");
            for (int i = 0; i < z; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is:");
            Console.WriteLine(Calculator.AddArray(array));
        }
    }
}